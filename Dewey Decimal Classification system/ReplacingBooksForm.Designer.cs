using System;

namespace Dewey_Decimal_Classification_system
{
    partial class ReplacingBooksForm
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
            this.TestLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listView3 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lpLbl = new System.Windows.Forms.Label();
            this.TryAgainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(12, 9);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(267, 13);
            this.TestLabel.TabIndex = 0;
            this.TestLabel.Text = "Re-order the generated Call Numbers in acending order";
            // 
            // listView1
            // 
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(161, 225);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(242, 45);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(161, 225);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(466, 45);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(161, 225);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = ": Library Points ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lpLbl
            // 
            this.lpLbl.AutoSize = true;
            this.lpLbl.Location = new System.Drawing.Point(690, 9);
            this.lpLbl.Name = "lpLbl";
            this.lpLbl.Size = new System.Drawing.Size(13, 13);
            this.lpLbl.TabIndex = 5;
            this.lpLbl.Text = "0";
            // 
            // TryAgainBtn
            // 
            this.TryAgainBtn.Location = new System.Drawing.Point(466, 338);
            this.TryAgainBtn.Name = "TryAgainBtn";
            this.TryAgainBtn.Size = new System.Drawing.Size(75, 23);
            this.TryAgainBtn.TabIndex = 6;
            this.TryAgainBtn.Text = "Try Again";
            this.TryAgainBtn.UseVisualStyleBackColor = true;
            this.TryAgainBtn.Click += new System.EventHandler(this.TryAgainBtn_Click);
            // 
            // ReplacingBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TryAgainBtn);
            this.Controls.Add(this.lpLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TestLabel);
            this.Name = "ReplacingBooksForm";
            this.Text = "ReplacingBooksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lpLbl;
        private System.Windows.Forms.Button TryAgainBtn;
    }
}