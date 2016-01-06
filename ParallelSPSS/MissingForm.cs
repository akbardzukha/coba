using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelSPSS
{
    public partial class MissingForm : Form
    {
        public MissingForm()
        {
            InitializeComponent();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                Data.variableView[Data.indexRow].missing.Clear();
                Data.variableView[Data.indexRow].missingRange.Clear();
            }
            else if (radioButton2.Checked)
            {
                Data.variableView[Data.indexRow].missing.Clear();
                Data.variableView[Data.indexRow].missingRange.Clear();

                if (textBox1.Text != "" && textBox1.Text != null)
                    Data.variableView[Data.indexRow].missing.Add(textBox1.Text);
                if (textBox2.Text != "" && textBox2.Text != null)
                    Data.variableView[Data.indexRow].missing.Add(textBox2.Text);
                if (textBox3.Text != "" && textBox3.Text != null)
                    Data.variableView[Data.indexRow].missing.Add(textBox3.Text);
            }
            else if (radioButton3.Checked)
            {
                Data.variableView[Data.indexRow].missing.Clear();
                Data.variableView[Data.indexRow].missingRange.Clear();

                if (textBox4.Text != "" && textBox4.Text != null)
                    Data.variableView[Data.indexRow].missingRange.Add(textBox4.Text);
                if (textBox5.Text != "" && textBox5.Text != null)
                    Data.variableView[Data.indexRow].missingRange.Add(textBox5.Text);
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void MissingForm_Load(object sender, EventArgs e)
        {
            if (Data.variableView[Data.indexRow].missing.Count > 0)
            {
                for (int i = 0; i < Data.variableView[Data.indexRow].missing.Count;i++)
                    if(i==0)
                        textBox1.Text = Data.variableView[Data.indexRow].missing[0];
                    else if(i==1)
                        textBox2.Text = Data.variableView[Data.indexRow].missing[1];
                    else if(i==2)
                        textBox3.Text = Data.variableView[Data.indexRow].missing[2];

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                
                radioButton2.Checked = true;

            }
            else if (Data.variableView[Data.indexRow].missingRange.Count > 0)
            {
                for (int i = 0; i < Data.variableView[Data.indexRow].missingRange.Count; i++)
                    if (i == 0)
                        textBox4.Text = Data.variableView[Data.indexRow].missingRange[0];
                    else if (i == 1)
                        textBox5.Text = Data.variableView[Data.indexRow].missingRange[1];

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                radioButton3.Checked = true;

            }
            
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }


    }
}
