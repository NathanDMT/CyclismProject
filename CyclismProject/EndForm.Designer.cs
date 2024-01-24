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
            this.quitButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.Info;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.quitButton.Location = new System.Drawing.Point(308, 111);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(121, 32);
            this.quitButton.TabIndex = 12;
            this.quitButton.Text = "Quitter";
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // gameButton
            // 
            this.gameButton.BackColor = System.Drawing.SystemColors.Info;
            this.gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.gameButton.Location = new System.Drawing.Point(181, 111);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(121, 32);
            this.gameButton.TabIndex = 11;
            this.gameButton.Text = "Jeu";
            this.gameButton.UseVisualStyleBackColor = false;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.SystemColors.Info;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.restartButton.Location = new System.Drawing.Point(43, 111);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(132, 32);
            this.restartButton.TabIndex = 10;
            this.restartButton.Text = "Recommencer";
            this.restartButton.UseVisualStyleBackColor = false;
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.restartButton);
            this.Name = "EndForm";
            this.Text = "EndForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button restartButton;
    }
}