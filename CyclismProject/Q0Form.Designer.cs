namespace CyclismProject
{
    partial class Q0Form
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q0Form));
            this.q0_dialogue0 = new System.Windows.Forms.Label();
            this.q0_dialogue1 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // q0_dialogue0
            // 
            this.q0_dialogue0.BackColor = System.Drawing.Color.Transparent;
            this.q0_dialogue0.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_dialogue0.Location = new System.Drawing.Point(12, 9);
            this.q0_dialogue0.Name = "q0_dialogue0";
            this.q0_dialogue0.Size = new System.Drawing.Size(574, 40);
            this.q0_dialogue0.TabIndex = 4;
            this.q0_dialogue0.Text = "En cette belle journée, pourquoi ne pas aller se balader!";
            this.q0_dialogue0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // q0_dialogue1
            // 
            this.q0_dialogue1.BackColor = System.Drawing.Color.Transparent;
            this.q0_dialogue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q0_dialogue1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_dialogue1.Location = new System.Drawing.Point(354, 289);
            this.q0_dialogue1.Name = "q0_dialogue1";
            this.q0_dialogue1.Size = new System.Drawing.Size(232, 49);
            this.q0_dialogue1.TabIndex = 5;
            this.q0_dialogue1.Text = "Mais avant de partir, peut-tu me dire ce dont j\'ai besoin?";
            this.q0_dialogue1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.nextButton.Location = new System.Drawing.Point(869, 517);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(121, 32);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Suivant";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Info;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.backButton.Location = new System.Drawing.Point(12, 517);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 32);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Recommencer";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // Q0Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.q0_dialogue1);
            this.Controls.Add(this.q0_dialogue0);
            this.Name = "Q0Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q0_dialogue0;
        private System.Windows.Forms.Label q0_dialogue1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
    }
}

