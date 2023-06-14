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
            this.btnBackD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(521, 585);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(247, 49);
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
            this.label1.Location = new System.Drawing.Point(513, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "All Tutors Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnProf
            // 
            this.btnProf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.Location = new System.Drawing.Point(554, 478);
            this.btnProf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(247, 49);
            this.btnProf.TabIndex = 16;
            this.btnProf.Text = "Tutor Profile";
            this.btnProf.UseVisualStyleBackColor = true;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // addTutor
            // 
            this.addTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTutor.Location = new System.Drawing.Point(180, 478);
            this.addTutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTutor.Name = "addTutor";
            this.addTutor.Size = new System.Drawing.Size(247, 49);
            this.addTutor.TabIndex = 17;
            this.addTutor.Text = "Add Tutor";
            this.addTutor.UseVisualStyleBackColor = true;
            this.addTutor.Click += new System.EventHandler(this.addTutor_Click);
            // 
            // btnBackD
            // 
            this.btnBackD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackD.Location = new System.Drawing.Point(926, 478);
            this.btnBackD.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackD.Name = "btnBackD";
            this.btnBackD.Size = new System.Drawing.Size(247, 49);
            this.btnBackD.TabIndex = 18;
            this.btnBackD.Text = "Back to Dashboard";
            this.btnBackD.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 285);
            this.dataGridView1.TabIndex = 19;
            // 
            // AllTutorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 814);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackD);
            this.Controls.Add(this.addTutor);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AllTutorsData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllTutorsData";
            this.Load += new System.EventHandler(this.AllTutorsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Button addTutor;
        private System.Windows.Forms.Button btnBackD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}