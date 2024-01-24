namespace CyclismProject
{
    partial class Q1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q1Form));
            this.q1_dialogue0 = new System.Windows.Forms.Label();
            this.voieVerteEntree = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.voieVerteEntree)).BeginInit();
            this.SuspendLayout();
            // 
            // q1_dialogue0
            // 
            this.q1_dialogue0.BackColor = System.Drawing.Color.Transparent;
            this.q1_dialogue0.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_dialogue0.Location = new System.Drawing.Point(12, 9);
            this.q1_dialogue0.Name = "q1_dialogue0";
            this.q1_dialogue0.Size = new System.Drawing.Size(373, 79);
            this.q1_dialogue0.TabIndex = 0;
            this.q1_dialogue0.Text = "J\'arrive proche d\'un bois, je croise ce panneau, a quoi correspond-t-il?";
            // 
            // voieVerteEntree
            // 
            this.voieVerteEntree.BackColor = System.Drawing.Color.Transparent;
            this.voieVerteEntree.Image = ((System.Drawing.Image)(resources.GetObject("voieVerteEntree.Image")));
            this.voieVerteEntree.Location = new System.Drawing.Point(391, 9);
            this.voieVerteEntree.Name = "voieVerteEntree";
            this.voieVerteEntree.Size = new System.Drawing.Size(100, 100);
            this.voieVerteEntree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.voieVerteEntree.TabIndex = 2;
            this.voieVerteEntree.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Info;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.backButton.Location = new System.Drawing.Point(12, 517);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(133, 32);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Recommencer";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.nextButton.Location = new System.Drawing.Point(869, 517);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(121, 32);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Suivant";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // Q1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.voieVerteEntree);
            this.Controls.Add(this.q1_dialogue0);
            this.Name = "Q1Form";
            this.Text = "Q1";
            ((System.ComponentModel.ISupportInitialize)(this.voieVerteEntree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q1_dialogue0;
        private System.Windows.Forms.PictureBox voieVerteEntree;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
    }
}