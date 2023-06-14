﻿namespace TutorHQ.Views.Tutor_Data
{
    partial class Add_Tutor
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTutorName = new System.Windows.Forms.Label();
            this.lblTutorPhNo = new System.Windows.Forms.Label();
            this.lblSubName = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.txtTutorPhNo = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbSubName = new System.Windows.Forms.ComboBox();
            this.lblClassId = new System.Windows.Forms.Label();
            this.lblSubName2 = new System.Windows.Forms.Label();
            this.lblSubName3 = new System.Windows.Forms.Label();
            this.lblClassTyp = new System.Windows.Forms.Label();
            this.cmbClassTyp = new System.Windows.Forms.ComboBox();
            this.lblClassFees = new System.Windows.Forms.Label();
            this.txtClassFees = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTutorName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(631, 424);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(231, 40);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add Tutors";
            // 
            // lblTutorName
            // 
            this.lblTutorName.AutoSize = true;
            this.lblTutorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorName.Location = new System.Drawing.Point(126, 134);
            this.lblTutorName.Name = "lblTutorName";
            this.lblTutorName.Size = new System.Drawing.Size(151, 20);
            this.lblTutorName.TabIndex = 16;
            this.lblTutorName.Text = "Enter Tutor Name";
            this.lblTutorName.Click += new System.EventHandler(this.lblTutorName_Click);
            // 
            // lblTutorPhNo
            // 
            this.lblTutorPhNo.AutoSize = true;
            this.lblTutorPhNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorPhNo.Location = new System.Drawing.Point(126, 182);
            this.lblTutorPhNo.Name = "lblTutorPhNo";
            this.lblTutorPhNo.Size = new System.Drawing.Size(235, 20);
            this.lblTutorPhNo.TabIndex = 17;
            this.lblTutorPhNo.Text = "Enter Tutor Contact Number";
            // 
            // lblSubName
            // 
            this.lblSubName.AutoSize = true;
            this.lblSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubName.Location = new System.Drawing.Point(126, 227);
            this.lblSubName.Name = "lblSubName";
            this.lblSubName.Size = new System.Drawing.Size(177, 20);
            this.lblSubName.TabIndex = 18;
            this.lblSubName.Text = "Select Subject Name";
            // 
            // txtClassId
            // 
            this.txtClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassId.Location = new System.Drawing.Point(130, 312);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(122, 26);
            this.txtClassId.TabIndex = 20;
            this.txtClassId.TextChanged += new System.EventHandler(this.txtTutorName_TextChanged);
            // 
            // txtTutorPhNo
            // 
            this.txtTutorPhNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutorPhNo.Location = new System.Drawing.Point(410, 176);
            this.txtTutorPhNo.Name = "txtTutorPhNo";
            this.txtTutorPhNo.Size = new System.Drawing.Size(353, 26);
            this.txtTutorPhNo.TabIndex = 21;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(130, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(231, 40);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cmbSubName
            // 
            this.cmbSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubName.FormattingEnabled = true;
            this.cmbSubName.Items.AddRange(new object[] {
            "Geography",
            "History",
            "Logic and Scientific Method",
            "Communication & Media Studies",
            "Political Science",
            "Sinhala",
            "Agriculture",
            "Biology",
            "Bio System Technology",
            "Accounting",
            "Business",
            "Economics",
            "Information & Comunication Technology",
            "Combined Maths",
            "Chemistry",
            "Physics",
            "Science for Technology",
            "Engineering Technology"});
            this.cmbSubName.Location = new System.Drawing.Point(410, 225);
            this.cmbSubName.Name = "cmbSubName";
            this.cmbSubName.Size = new System.Drawing.Size(353, 28);
            this.cmbSubName.TabIndex = 24;
            // 
            // lblClassId
            // 
            this.lblClassId.AutoSize = true;
            this.lblClassId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassId.Location = new System.Drawing.Point(126, 269);
            this.lblClassId.Name = "lblClassId";
            this.lblClassId.Size = new System.Drawing.Size(126, 20);
            this.lblClassId.TabIndex = 25;
            this.lblClassId.Text = "Enter Class ID";
            // 
            // lblSubName2
            // 
            this.lblSubName2.AutoSize = true;
            this.lblSubName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubName2.Location = new System.Drawing.Point(294, 269);
            this.lblSubName2.Name = "lblSubName2";
            this.lblSubName2.Size = new System.Drawing.Size(121, 20);
            this.lblSubName2.TabIndex = 26;
            this.lblSubName2.Text = "Subject Name";
            // 
            // lblSubName3
            // 
            this.lblSubName3.AutoSize = true;
            this.lblSubName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubName3.Location = new System.Drawing.Point(310, 318);
            this.lblSubName3.Name = "lblSubName3";
            this.lblSubName3.Size = new System.Drawing.Size(0, 20);
            this.lblSubName3.TabIndex = 27;
            this.lblSubName3.Click += new System.EventHandler(this.lblSubName3_Click);
            // 
            // lblClassTyp
            // 
            this.lblClassTyp.AutoSize = true;
            this.lblClassTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassTyp.Location = new System.Drawing.Point(453, 269);
            this.lblClassTyp.Name = "lblClassTyp";
            this.lblClassTyp.Size = new System.Drawing.Size(96, 20);
            this.lblClassTyp.TabIndex = 28;
            this.lblClassTyp.Text = "Class Type";
            // 
            // cmbClassTyp
            // 
            this.cmbClassTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassTyp.FormattingEnabled = true;
            this.cmbClassTyp.Items.AddRange(new object[] {
            "Grade 12 ",
            "Grade 13",
            "Paper Class",
            "Revision Class"});
            this.cmbClassTyp.Location = new System.Drawing.Point(457, 310);
            this.cmbClassTyp.Name = "cmbClassTyp";
            this.cmbClassTyp.Size = new System.Drawing.Size(128, 28);
            this.cmbClassTyp.TabIndex = 29;
            // 
            // lblClassFees
            // 
            this.lblClassFees.AutoSize = true;
            this.lblClassFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassFees.Location = new System.Drawing.Point(627, 269);
            this.lblClassFees.Name = "lblClassFees";
            this.lblClassFees.Size = new System.Drawing.Size(98, 20);
            this.lblClassFees.TabIndex = 30;
            this.lblClassFees.Text = "Class Fees";
            // 
            // txtClassFees
            // 
            this.txtClassFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassFees.Location = new System.Drawing.Point(619, 310);
            this.txtClassFees.Name = "txtClassFees";
            this.txtClassFees.Size = new System.Drawing.Size(144, 26);
            this.txtClassFees.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(794, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 28);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtTutorName
            // 
            this.txtTutorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutorName.Location = new System.Drawing.Point(410, 128);
            this.txtTutorName.Name = "txtTutorName";
            this.txtTutorName.Size = new System.Drawing.Size(353, 26);
            this.txtTutorName.TabIndex = 33;
            // 
            // Add_Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.txtTutorName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtClassFees);
            this.Controls.Add(this.lblClassFees);
            this.Controls.Add(this.cmbClassTyp);
            this.Controls.Add(this.lblClassTyp);
            this.Controls.Add(this.lblSubName3);
            this.Controls.Add(this.lblSubName2);
            this.Controls.Add(this.lblClassId);
            this.Controls.Add(this.cmbSubName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTutorPhNo);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.lblSubName);
            this.Controls.Add(this.lblTutorPhNo);
            this.Controls.Add(this.lblTutorName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "Add_Tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Tutor";
            this.Load += new System.EventHandler(this.Add_Tutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTutorName;
        private System.Windows.Forms.Label lblTutorPhNo;
        private System.Windows.Forms.Label lblSubName;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.TextBox txtTutorPhNo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbSubName;
        private System.Windows.Forms.Label lblClassId;
        private System.Windows.Forms.Label lblSubName2;
        private System.Windows.Forms.Label lblSubName3;
        private System.Windows.Forms.Label lblClassTyp;
        private System.Windows.Forms.ComboBox cmbClassTyp;
        private System.Windows.Forms.Label lblClassFees;
        private System.Windows.Forms.TextBox txtClassFees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTutorName;
    }
}