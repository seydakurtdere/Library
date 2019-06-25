namespace Library.WinUI.Borrows
{
    partial class ReturnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBorrows = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBorrowBooks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblLateDays = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "İade İşlemleri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBorrows
            // 
            this.lbBorrows.FormattingEnabled = true;
            this.lbBorrows.Location = new System.Drawing.Point(49, 105);
            this.lbBorrows.Name = "lbBorrows";
            this.lbBorrows.Size = new System.Drawing.Size(200, 238);
            this.lbBorrows.TabIndex = 31;
            this.lbBorrows.SelectedIndexChanged += new System.EventHandler(this.lbBorrows_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ödünç Listesi";
            // 
            // lbBorrowBooks
            // 
            this.lbBorrowBooks.FormattingEnabled = true;
            this.lbBorrowBooks.Location = new System.Drawing.Point(277, 105);
            this.lbBorrowBooks.Name = "lbBorrowBooks";
            this.lbBorrowBooks.Size = new System.Drawing.Size(200, 238);
            this.lbBorrowBooks.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Verilen Kitaplar";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(49, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "Teslim Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(536, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Bitiş Tarihi:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndDate.Location = new System.Drawing.Point(620, 106);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(0, 17);
            this.lblEndDate.TabIndex = 36;
            // 
            // lblLateDays
            // 
            this.lblLateDays.AutoSize = true;
            this.lblLateDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLateDays.Location = new System.Drawing.Point(620, 135);
            this.lblLateDays.Name = "lblLateDays";
            this.lblLateDays.Size = new System.Drawing.Size(0, 17);
            this.lblLateDays.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(547, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Gecikme:";
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPenalty.Location = new System.Drawing.Point(620, 163);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(0, 17);
            this.lblPenalty.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(507, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Gecikme Cezası:";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPenalty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblLateDays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbBorrowBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBorrows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBorrows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBorrowBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblLateDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label label7;
    }
}