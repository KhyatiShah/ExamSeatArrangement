namespace WindowsFormsApplication1
{
    partial class DataEntry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbclassno = new System.Windows.Forms.TextBox();
            this.tbBlockno = new System.Windows.Forms.TextBox();
            this.tbSeatno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbEnrlno = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbExamdate = new System.Windows.Forms.TextBox();
            this.cbExamtype = new System.Windows.Forms.ComboBox();
            this.cbSubcode = new System.Windows.Forms.ComboBox();
            this.cbClassno = new System.Windows.Forms.ComboBox();
            this.cbSeatno = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exam Name/Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class Nmber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Block Number:";
            // 
            // tbclassno
            // 
            this.tbclassno.Location = new System.Drawing.Point(172, 130);
            this.tbclassno.Name = "tbclassno";
            this.tbclassno.Size = new System.Drawing.Size(75, 20);
            this.tbclassno.TabIndex = 5;
            // 
            // tbBlockno
            // 
            this.tbBlockno.Location = new System.Drawing.Point(134, 173);
            this.tbBlockno.Name = "tbBlockno";
            this.tbBlockno.Size = new System.Drawing.Size(63, 20);
            this.tbBlockno.TabIndex = 6;
            // 
            // tbSeatno
            // 
            this.tbSeatno.Location = new System.Drawing.Point(175, 226);
            this.tbSeatno.Name = "tbSeatno";
            this.tbSeatno.Size = new System.Drawing.Size(100, 20);
            this.tbSeatno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exam Seat Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enrollment No. :";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(175, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(268, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbEnrlno
            // 
            this.tbEnrlno.Location = new System.Drawing.Point(133, 280);
            this.tbEnrlno.Name = "tbEnrlno";
            this.tbEnrlno.Size = new System.Drawing.Size(100, 20);
            this.tbEnrlno.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(361, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subject Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subject Exam Date:";
            // 
            // tbExamdate
            // 
            this.tbExamdate.Location = new System.Drawing.Point(349, 87);
            this.tbExamdate.Name = "tbExamdate";
            this.tbExamdate.Size = new System.Drawing.Size(100, 20);
            this.tbExamdate.TabIndex = 3;
            this.tbExamdate.Visible = false;
            // 
            // cbExamtype
            // 
            this.cbExamtype.FormattingEnabled = true;
            this.cbExamtype.Items.AddRange(new object[] {
            "Please Choose Any One From This Exam:",
            "Degree (Sem.)-Summer Exam(Year)",
            "Degree(Sem.)-Winter Exam(Year)",
            "Diploma(Sem.)-Summer Exam(Year)",
            "Diplome(Sem.)-Winter Exam(Year)"});
            this.cbExamtype.Location = new System.Drawing.Point(134, 33);
            this.cbExamtype.Name = "cbExamtype";
            this.cbExamtype.Size = new System.Drawing.Size(209, 21);
            this.cbExamtype.TabIndex = 1;
            // 
            // cbSubcode
            // 
            this.cbSubcode.FormattingEnabled = true;
            this.cbSubcode.Items.AddRange(new object[] {
            "140001",
            "140210",
            "140215",
            "140232",
            "102542",
            "140254",
            "140701",
            "140712",
            "140245",
            "168585",
            "160248",
            "246464",
            "458758"});
            this.cbSubcode.Location = new System.Drawing.Point(133, 82);
            this.cbSubcode.Name = "cbSubcode";
            this.cbSubcode.Size = new System.Drawing.Size(96, 21);
            this.cbSubcode.TabIndex = 2;
            this.cbSubcode.SelectedIndexChanged += new System.EventHandler(this.cbSubcode_SelectedIndexChanged);
            // 
            // cbClassno
            // 
            this.cbClassno.FormattingEnabled = true;
            this.cbClassno.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbClassno.Location = new System.Drawing.Point(133, 129);
            this.cbClassno.Name = "cbClassno";
            this.cbClassno.Size = new System.Drawing.Size(33, 21);
            this.cbClassno.TabIndex = 4;
            // 
            // cbSeatno
            // 
            this.cbSeatno.FormattingEnabled = true;
            this.cbSeatno.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbSeatno.Location = new System.Drawing.Point(133, 226);
            this.cbSeatno.Name = "cbSeatno";
            this.cbSeatno.Size = new System.Drawing.Size(37, 21);
            this.cbSeatno.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "DD/MM/YYYY";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2012, 6, 15, 0, 0, 0, 0);
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(464, 406);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbSeatno);
            this.Controls.Add(this.cbClassno);
            this.Controls.Add(this.cbSubcode);
            this.Controls.Add(this.cbExamtype);
            this.Controls.Add(this.tbExamdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbEnrlno);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSeatno);
            this.Controls.Add(this.tbBlockno);
            this.Controls.Add(this.tbclassno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataEntry";
            this.Text = "Data Entry Form";
            this.Load += new System.EventHandler(this.DataEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbclassno;
        private System.Windows.Forms.TextBox tbBlockno;
        private System.Windows.Forms.TextBox tbSeatno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbEnrlno;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbExamdate;
        private System.Windows.Forms.ComboBox cbExamtype;
        private System.Windows.Forms.ComboBox cbSubcode;
        private System.Windows.Forms.ComboBox cbClassno;
        private System.Windows.Forms.ComboBox cbSeatno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

