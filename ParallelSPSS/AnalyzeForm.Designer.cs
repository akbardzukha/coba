using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
namespace ParallelSPSS
{
    partial class AnalyzeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.arrowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged+=listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(271, 36);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(174, 212);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged+=listBox2_SelectedIndexChanged;
            this.GotFocus+=listBox2_GotFocus;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Variable (s) :";
            this.GotFocus += listBox1_GotFocus;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(144, 272);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(226, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // arrowButton
            // 
            this.arrowButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;
            this.arrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.arrowButton.Location = new System.Drawing.Point(208, 110);
            this.arrowButton.Name = "arrowButton";
            this.arrowButton.Size = new System.Drawing.Size(50, 44);
            this.arrowButton.TabIndex = 2;
            this.arrowButton.UseVisualStyleBackColor = true;
            this.arrowButton.Click+=arrowButton_Click;
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 307);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrowButton);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "AnalyzeForm";
            this.Text = "AnalyzeForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += AnalyzeForm_Load;

        }


        
        void listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                arrow = false;
                arrowButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.leftArrow;

            }
        }

        void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                arrow = true;
                arrowButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;

            }
        }
        bool arrow=true;

        void listBox2_GotFocus(object sender, System.EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                arrowButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.leftArrow;
                arrow = false;
            }
        }

        void arrowButton_Click(object sender, System.EventArgs e)
        {
            if (arrow && listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else if(!arrow && listBox2.SelectedIndex !=-1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }

            int counter=0;
           //Data.variableView[Data.indexRow].nama
         
           for(int i=0;i<listBox2.Items.Count;i++)
               for(int j=0;j<Data.variableView.Count;j++)
                   if(Data.variableView[j].label == listBox2.Items[i])
                   {
                       Data.columnChoosen[counter]=j;

                       counter++;

                   }

        }


        void listBox1_GotFocus(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                arrowButton.BackgroundImage = global::ParallelSPSS.Properties.Resources.rightArrow1;
                arrow = true;
            }
        }

     
        void AnalyzeForm_Load(object sender, System.EventArgs e)
        {
            int y;
            for (int i = 0; i < Data.variableView.Count; i++)
            {
                y = i + 1;
                if (Data.variableView[i].nama != null && Data.variableView[i].nama != "VAR00"+y)
                    listBox1.Items.Add(Data.variableView[i].label);
            }

            for (int j = 0; j < Data.columnChoosen.Length; j++)
                Data.columnChoosen[j] = -1;

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button arrowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}