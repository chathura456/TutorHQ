namespace TutorHQ.Views.Tutor_Data
{
    partial class AllTutorsData
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
            this.btnProf = new System.Windows.Forms.Button();
            this.addTutor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(391, 475);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "back to dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "All Tutors Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProf
            // 
            this.btnProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.Location = new System.Drawing.Point(391, 310);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(185, 40);
            this.btnProf.TabIndex = 16;
            this.btnProf.Text = "Tutor Profile";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // addTutor
            // 
            this.addTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTutor.Location = new System.Drawing.Point(391, 228);
            this.addTutor.Name = "addTutor";
            this.addTutor.Size = new System.Drawing.Size(185, 40);
            this.addTutor.TabIndex = 17;
            this.addTutor.Text = "Add Tutor";
            this.addTutor.UseVisualStyleBackColor = true;
            this.addTutor.Click += new System.EventHandler(this.addTutor_Click);
            // 
            // AllTutorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.addTutor);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "AllTutorsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllTutorsData";
            this.Load += new System.EventHandler(this.AllTutorsData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Button addTutor;
    }
}