using System.Diagnostics;
using System.Windows.Forms;
namespace ParallelSPSS
{
    partial class ResultForm
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
            this.resultTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTable
            // 
            this.resultTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTable.AutoScroll = true;
            this.resultTable.AutoSize = true;
            this.resultTable.BackColor = System.Drawing.SystemColors.Control;
            this.resultTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.resultTable.ColumnCount = 2;
            this.resultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74619F));
            this.resultTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.25381F));
            this.resultTable.Controls.Add(this.panel2, 1, 0);
            this.resultTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultTable.Location = new System.Drawing.Point(87, 107);
            this.resultTable.Name = "resultTable";
            this.resultTable.RowCount = 1;
            this.resultTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.resultTable.Size = new System.Drawing.Size(417, 235);
            this.resultTable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(210, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Results";
            //
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTable);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.resultTable.ResumeLayout(false);
            this.resultTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load+=ResultForm_Load;

        }

        void ResultForm_Load(object sender, System.EventArgs e)
        {
            //resultTable.ColumnCount = 2;
            //resultTable.RowCount = 1;
            //resultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //resultTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //resultTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //resultTable.Controls.Add(new Label() { Text = "nama" }, 1, 0);
            //resultTable.Controls.Add(new Label() { Text = "mean" }, 2, 0);
            for(int i=0;i< Form1.results.Count;i++)
            {
                //Debug.Write(Form1.columnChoosen[i]);
                resultTable.RowCount = resultTable.RowCount + 1;
                resultTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                resultTable.Controls.Add(new Label() { Text = Form1.columnChoosen[i], Anchor = AnchorStyles.Left, AutoSize = true },0,resultTable.RowCount-1);
                resultTable.Controls.Add(new Label() { Text = Form1.results[i].ToString(), Anchor = AnchorStyles.Left, AutoSize = true }, 1, resultTable.RowCount - 1);

            }
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel resultTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}