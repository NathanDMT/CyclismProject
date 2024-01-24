namespace CyclismProject
{
    partial class StartForm
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
            this.presentationButton = new System.Windows.Forms.Button();
            this.gameButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presentationButton
            // 
            this.presentationButton.BackColor = System.Drawing.SystemColors.Info;
            this.presentationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.presentationButton.Location = new System.Drawing.Point(40, 109);
            this.presentationButton.Name = "presentationButton";
            this.presentationButton.Size = new System.Drawing.Size(132, 32);
            this.presentationButton.TabIndex = 7;
            this.presentationButton.Text = "Présentation";
            this.presentationButton.UseVisualStyleBackColor = false;
            this.presentationButton.Click += new System.EventHandler(this.presentationButton_Click);
            // 
            // gameButton
            // 
            this.gameButton.BackColor = System.Drawing.SystemColors.Info;
            this.gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.gameButton.Location = new System.Drawing.Point(178, 109);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(121, 32);
            this.gameButton.TabIndex = 8;
            this.gameButton.Text = "Jeu";
            this.gameButton.UseVisualStyleBackColor = false;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.Info;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.quitButton.Location = new System.Drawing.Point(305, 109);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(121, 32);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quitter";
            this.quitButton.UseVisualStyleBackColor = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.gameButton);
            this.Controls.Add(this.presentationButton);
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button presentationButton;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Button quitButton;
    }
}