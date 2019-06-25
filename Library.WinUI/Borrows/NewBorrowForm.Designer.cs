namespace Library.WinUI.Borrows
{
    partial class NewBorrowForm
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
            this.cbStudents = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.lbSelectedBooks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(757, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kitap Teslimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStudents
            // 
            this.cbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudents.FormattingEnabled = true;
            this.cbStudents.Location = new System.Drawing.Point(102, 70);
            this.cbStudents.Name = "cbStudents";
            this.cbStudents.Size = new System.Drawing.Size(200, 21);
            this.cbStudents.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Öğrenci:";
            // 
            // cbGenres
            // 
            this.cbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(102, 97);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(200, 21);
            this.cbGenres.TabIndex = 23;
            this.cbGenres.SelectedIndexChanged += new System.EventHandler(this.cbGenres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tür:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Kitaplar:";
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.Location = new System.Drawing.Point(102, 128);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(200, 160);
            this.lbBooks.TabIndex = 25;
            // 
            // lbSelectedBooks
            // 
            this.lbSelectedBooks.FormattingEnabled = true;
            this.lbSelectedBooks.Location = new System.Drawing.Point(443, 128);
            this.lbSelectedBooks.Name = "lbSelectedBooks";
            this.lbSelectedBooks.Size = new System.Drawing.Size(200, 160);
            this.lbSelectedBooks.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = ">>>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(336, 200);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 30);
            this.btnRemove.TabIndex = 28;
            this.btnRemove.Text = "<<<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaveStatus.Location = new System.Drawing.Point(440, 362);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 17);
            this.lblSaveStatus.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(443, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 35);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 477);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbSelectedBooks);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGenres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStudents);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewBorrowForm";
            this.Text = "Ödünç İşlemleri";
            this.Load += new System.EventHandler(this.NewBorrowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.ListBox lbSelectedBooks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Button btnSave;
    }
}