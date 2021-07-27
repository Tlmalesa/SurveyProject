namespace TestAssignment
{
    partial class Screen1
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
            this.btnViewSurvey = new System.Windows.Forms.Button();
            this.btnFillSurvey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewSurvey
            // 
            this.btnViewSurvey.BackColor = System.Drawing.Color.Gray;
            this.btnViewSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSurvey.ForeColor = System.Drawing.Color.Indigo;
            this.btnViewSurvey.Location = new System.Drawing.Point(572, 297);
            this.btnViewSurvey.Name = "btnViewSurvey";
            this.btnViewSurvey.Size = new System.Drawing.Size(155, 58);
            this.btnViewSurvey.TabIndex = 0;
            this.btnViewSurvey.Text = "View survey results";
            this.btnViewSurvey.UseVisualStyleBackColor = false;
            this.btnViewSurvey.Click += new System.EventHandler(this.btnViewSurvey_Click);
            // 
            // btnFillSurvey
            // 
            this.btnFillSurvey.BackColor = System.Drawing.Color.Gray;
            this.btnFillSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillSurvey.ForeColor = System.Drawing.Color.Indigo;
            this.btnFillSurvey.Location = new System.Drawing.Point(34, 297);
            this.btnFillSurvey.Name = "btnFillSurvey";
            this.btnFillSurvey.Size = new System.Drawing.Size(148, 58);
            this.btnFillSurvey.TabIndex = 1;
            this.btnFillSurvey.Text = "Fill out survey";
            this.btnFillSurvey.UseVisualStyleBackColor = false;
            this.btnFillSurvey.Click += new System.EventHandler(this.btnFillSurvey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(207, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 90);
            this.label1.TabIndex = 2;
            this.label1.Text = "        WELCOME \r\n              TO\r\nHUNADI\'S  RESTAURANT";
            // 
            // Screen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestAssignment.Properties.Resources.images__8__2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFillSurvey);
            this.Controls.Add(this.btnViewSurvey);
            this.Name = "Screen1";
            this.Text = "SCREEN 1";
            this.Load += new System.EventHandler(this.Screen1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewSurvey;
        private System.Windows.Forms.Button btnFillSurvey;
        private System.Windows.Forms.Label label1;
    }
}

