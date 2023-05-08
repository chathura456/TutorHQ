namespace TutorHQ.Views.Attendence
{
    partial class CheckAttendence
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
            this.btnBack = new System.Windows.Forms.Button();
            this.addAtten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Check/View Attendence";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(400, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "back to dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // addAtten
            // 
            this.addAtten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAtten.Location = new System.Drawing.Point(400, 219);
            this.addAtten.Name = "addAtten";
            this.addAtten.Size = new System.Drawing.Size(185, 40);
            this.addAtten.TabIndex = 17;
            this.addAtten.Text = "Add Attendence";
            this.addAtten.UseVisualStyleBackColor = true;
            this.addAtten.Click += new System.EventHandler(this.addAtten_Click);
            // 
            // CheckAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.addAtten);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "CheckAttendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckAttendence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button addAtten;
    }
}