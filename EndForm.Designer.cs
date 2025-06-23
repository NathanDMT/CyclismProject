namespace CyclismProject
{
    partial class EndForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndForm));
            this.end_buttonRestart = new System.Windows.Forms.Button();
            this.end_labelScore = new System.Windows.Forms.Label();
            this.end_labelPseudo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.end_labelScoreMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // end_buttonRestart
            // 
            this.end_buttonRestart.BackColor = System.Drawing.Color.Transparent;
            this.end_buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_buttonRestart.ForeColor = System.Drawing.Color.White;
            this.end_buttonRestart.Location = new System.Drawing.Point(906, 654);
            this.end_buttonRestart.Name = "end_buttonRestart";
            this.end_buttonRestart.Size = new System.Drawing.Size(182, 32);
            this.end_buttonRestart.TabIndex = 10;
            this.end_buttonRestart.Text = "Recommencer";
            this.end_buttonRestart.UseVisualStyleBackColor = false;
            this.end_buttonRestart.Click += new System.EventHandler(this.end_buttonRestart_Click);
            // 
            // end_labelScore
            // 
            this.end_labelScore.BackColor = System.Drawing.Color.Transparent;
            this.end_labelScore.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_labelScore.ForeColor = System.Drawing.Color.White;
            this.end_labelScore.Location = new System.Drawing.Point(577, 385);
            this.end_labelScore.Name = "end_labelScore";
            this.end_labelScore.Size = new System.Drawing.Size(215, 38);
            this.end_labelScore.TabIndex = 13;
            this.end_labelScore.Text = "Score :";
            this.end_labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end_labelPseudo
            // 
            this.end_labelPseudo.BackColor = System.Drawing.Color.Transparent;
            this.end_labelPseudo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_labelPseudo.ForeColor = System.Drawing.Color.White;
            this.end_labelPseudo.Location = new System.Drawing.Point(312, 385);
            this.end_labelPseudo.Name = "end_labelPseudo";
            this.end_labelPseudo.Size = new System.Drawing.Size(212, 38);
            this.end_labelPseudo.TabIndex = 14;
            this.end_labelPseudo.Text = "Pseudo";
            this.end_labelPseudo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(100, 204);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(902, 95);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "Fin du mini-jeu !";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // end_labelScoreMessage
            // 
            this.end_labelScoreMessage.BackColor = System.Drawing.Color.Transparent;
            this.end_labelScoreMessage.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.end_labelScoreMessage.ForeColor = System.Drawing.Color.White;
            this.end_labelScoreMessage.Location = new System.Drawing.Point(309, 507);
            this.end_labelScoreMessage.Name = "end_labelScoreMessage";
            this.end_labelScoreMessage.Size = new System.Drawing.Size(483, 63);
            this.end_labelScoreMessage.TabIndex = 17;
            this.end_labelScoreMessage.Text = "end_labelScoreMessage";
            this.end_labelScoreMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 698);
            this.Controls.Add(this.end_labelScoreMessage);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.end_labelPseudo);
            this.Controls.Add(this.end_labelScore);
            this.Controls.Add(this.end_buttonRestart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EndForm";
            this.Text = "Menu de fin";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button end_buttonRestart;
        private System.Windows.Forms.Label end_labelScore;
        private System.Windows.Forms.Label end_labelPseudo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label end_labelScoreMessage;
    }
}