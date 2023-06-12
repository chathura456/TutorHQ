namespace TutorHQ.Views.Schedules
{
    partial class Schedules
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
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSchedule.Location = new System.Drawing.Point(388, 229);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(185, 40);
            this.btnEditSchedule.TabIndex = 20;
            this.btnEditSchedule.Text = "Edit Schedule";
            this.btnEditSchedule.UseVisualStyleBackColor = true;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(388, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(185, 40);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "back to dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "View Schedule";
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnEditSchedule);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "Schedules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditSchedule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}