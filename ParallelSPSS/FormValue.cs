using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelSPSS
{
    public partial class FormValue : Form
    {
        public FormValue()
        {
            InitializeComponent();
            removeButton.Enabled = false;
            changeButton.Enabled = false;

        }
        
        private void FormValue_Load(object sender, EventArgs e)
        {
            if (Data.indexRow < Data.variableView.Count())
                if (Data.variableView!=null && Data.variableView[Data.indexRow].valueCoding!=null)
                   for(int i=0;i<Data.variableView[Data.indexRow].valueCoding.Count();i++)
                     {
                        listBox1.Items.Add(Data.variableView[Data.indexRow].valueCoding[i].value + " = '" + Data.variableView[Data.indexRow].valueCoding[i].label + "' ");
                     }
        
        }
        private void TextBoxLabel_KeyDown1(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                changeButton.Enabled = true;
        }

        void textBoxValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedIndex != -1 && textBoxValue.Text=="" && textBoxLabel.Text=="")
                addButton.Enabled = true;
        }

        int selectedIndex;
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = false;
            if (listBox1.SelectedIndex != -1)
            {
                removeButton.Enabled = true;

                textBoxValue.Text = Data.variableView[Data.indexRow].valueCoding[listBox1.SelectedIndex].value.ToString();
                textBoxLabel.Text = Data.variableView[Data.indexRow].valueCoding[listBox1.SelectedIndex].label;
                selectedIndex = listBox1.SelectedIndex;
            }
            else
            {
                removeButton.Enabled = false;
                changeButton.Enabled = false;
            }
        }


        //private void ListBox1_SelectedIndexChanged1(object sender, System.EventArgs e)
        //{
        //    removeButton.Enabled = true;
        //    textBoxLabel.Text = tempData.variableView[listBox1.SelectedIndex].valueCoding.label;
        //    textBoxValue.Text = tempData.variableView[listBox1.SelectedIndex].valueCoding.value.ToString();
        //}

        private void removeButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            Data.variableView[Data.indexRow].valueCoding.Remove(Data.variableView[Data.indexRow].valueCoding[selectedIndex]);
        }

        private void TextBoxLabel_TextChanged(object sender, EventArgs e)
        {
            // changeButton.Enabled = true;
            if (textBoxLabel.Text == "" && textBoxValue.Text == "")
            {
                addButton.Enabled = true;
                changeButton.Enabled = false;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = false;
            Data.variableView[Data.indexRow].valueCoding[listBox1.SelectedIndex].label = textBoxLabel.Text;
            listBox1.Items[listBox1.SelectedIndex] = Data.variableView[Data.indexRow].valueCoding[listBox1.SelectedIndex].value +
                " = '" + Data.variableView[Data.indexRow].valueCoding[listBox1.SelectedIndex].label+"'";
        //    textBoxLabel.Text; 
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text != "" || textBoxValue.Text != null && textBoxLabel.Text != "" || textBoxLabel.Text != null)
            {
                int value;
                int.TryParse(textBoxValue.Text, out value);
                List<ValueCoding> tempValueCoding = new List<ValueCoding>();
            //    Debug.Write(tempData.variableView.Count());
                if(Data.variableView[Data.indexRow].valueCoding != null)
                 tempValueCoding = Data.variableView[Data.indexRow].valueCoding;
                double valueResult;
                double.TryParse(textBoxValue.Text, out valueResult);
                tempValueCoding.Add(new ValueCoding { label = textBoxLabel.Text, value = valueResult });
                // tempData.variableView.Add(new VariableView { valueCoding = tempValueCoding});
                Data.variableView[Data.indexRow].valueCoding = tempValueCoding;
              //  Debug.Write(tempData.variableView[tempData.indexRow].F);

                textBoxValue.Text = "";
                textBoxLabel.Text = "";
                //listBox1.Items.Add(tempData.variableView[tempData.variableView.Count - 1].valueCoding[tempData.variableView[tempData.variableView.Count()-1].valueCoding.Count()].value + " = '" +
                //    tempData.variableView[tempData.variableView.Count - 1].valueCoding[tempData.variableView[tempData.variableView.Count() - 1].valueCoding.Count()].label + "' ");
                listBox1.Items.Add(Data.variableView[Data.indexRow].valueCoding[Data.variableView[Data.indexRow].valueCoding.Count() - 1].value + " = '" +
                    Data.variableView[Data.indexRow].valueCoding[Data.variableView[Data.indexRow].valueCoding.Count()-1].label + "' ");
                addButton.Enabled = true;
                changeButton.Enabled = false;
                //   Debug.Write(tempData.variableView[tempData.variableView.Count - 1].valueCoding);
                //  Debug.Write(tempData.variableView[tempData.variableView.Count - 1].valueCoding[tempData.variableView[tempData.variableView.Count() - 1].valueCoding.Count()].value);

            }

        }
    }
}
