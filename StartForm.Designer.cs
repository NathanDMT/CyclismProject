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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.gameButton = new System.Windows.Forms.Button();
            this.start_textBoxPseudo = new System.Windows.Forms.TextBox();
            this.start_labelError = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameButton
            // 
            this.gameButton.BackColor = System.Drawing.Color.Transparent;
            this.gameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameButton.ForeColor = System.Drawing.Color.White;
            this.gameButton.Location = new System.Drawing.Point(826, 604);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(218, 35);
            this.gameButton.TabIndex = 8;
            this.gameButton.Text = "Commencer";
            this.gameButton.UseVisualStyleBackColor = false;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // start_textBoxPseudo
            // 
            this.start_textBoxPseudo.BackColor = System.Drawing.Color.White;
            this.start_textBoxPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_textBoxPseudo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.start_textBoxPseudo.Location = new System.Drawing.Point(140, 612);
            this.start_textBoxPseudo.Name = "start_textBoxPseudo";
            this.start_textBoxPseudo.Size = new System.Drawing.Size(279, 22);
            this.start_textBoxPseudo.TabIndex = 10;
            this.start_textBoxPseudo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_labelError
            // 
            this.start_labelError.BackColor = System.Drawing.Color.Transparent;
            this.start_labelError.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_labelError.ForeColor = System.Drawing.Color.White;
            this.start_labelError.Location = new System.Drawing.Point(419, 604);
            this.start_labelError.Name = "start_labelError";
            this.start_labelError.Size = new System.Drawing.Size(345, 34);
            this.start_labelError.TabIndex = 13;
            this.start_labelError.Text = "Error message";
            this.start_labelError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(35, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1009, 141);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Mini-jeu - les cyclistes et la route";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 50);
            this.label3.TabIndex = 15;
            this.label3.Text = "Règles du jeu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(723, 140);
            this.label4.TabIndex = 16;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(52, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Pseudo :";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.start_labelError);
            this.Controls.Add(this.start_textBoxPseudo);
            this.Controls.Add(this.gameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "StartForm";
            this.Text = "Code de la route cycliste - Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.TextBox start_textBoxPseudo;
        private System.Windows.Forms.Label start_labelError;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}