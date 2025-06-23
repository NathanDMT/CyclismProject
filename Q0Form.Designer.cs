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
            this.q0_labelDialogue = new System.Windows.Forms.Label();
            this.q0_labelQuestion = new System.Windows.Forms.Label();
            this.q0_buttonNext = new System.Windows.Forms.Button();
            this.q0_labelAnswer = new System.Windows.Forms.Label();
            this.q0_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q0_labelAnswerRemaining = new System.Windows.Forms.Label();
            this.q0_labelPseudo = new System.Windows.Forms.Label();
            this.q0_labelScore = new System.Windows.Forms.Label();
            this.q0_buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.q0_checkBoxReflector = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxFood = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxWater = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxGlasses = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxBrakes = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxBackLight = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxFrontLight = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxRing = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxGloves = new System.Windows.Forms.CheckBox();
            this.q0_checkBoxHelmet = new System.Windows.Forms.CheckBox();
            this.q0_buttonBack = new System.Windows.Forms.Button();
            this.q0_groupBoxQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // q0_labelDialogue
            // 
            this.q0_labelDialogue.BackColor = System.Drawing.Color.Transparent;
            this.q0_labelDialogue.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_labelDialogue.Location = new System.Drawing.Point(12, 9);
            this.q0_labelDialogue.Name = "q0_labelDialogue";
            this.q0_labelDialogue.Size = new System.Drawing.Size(749, 40);
            this.q0_labelDialogue.TabIndex = 4;
            this.q0_labelDialogue.Text = "En cette belle journée, pourquoi ne pas aller se balader!";
            this.q0_labelDialogue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // q0_labelQuestion
            // 
            this.q0_labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.q0_labelQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q0_labelQuestion.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q0_labelQuestion.ForeColor = System.Drawing.Color.Black;
            this.q0_labelQuestion.Location = new System.Drawing.Point(6, 14);
            this.q0_labelQuestion.Name = "q0_labelQuestion";
            this.q0_labelQuestion.Size = new System.Drawing.Size(639, 78);
            this.q0_labelQuestion.TabIndex = 5;
            this.q0_labelQuestion.Text = "Mais avant de partir, peux-tu me dire de quoi j\'ai besoin d\'avoir obligatoirement" +
    " ?";
            // 
            // q0_buttonNext
            // 
            this.q0_buttonNext.BackColor = System.Drawing.SystemColors.Info;
            this.q0_buttonNext.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_buttonNext.ForeColor = System.Drawing.Color.OrangeRed;
            this.q0_buttonNext.Location = new System.Drawing.Point(1563, 879);
            this.q0_buttonNext.Name = "q0_buttonNext";
            this.q0_buttonNext.Size = new System.Drawing.Size(200, 42);
            this.q0_buttonNext.TabIndex = 7;
            this.q0_buttonNext.Text = "Suivant";
            this.q0_buttonNext.UseVisualStyleBackColor = false;
            this.q0_buttonNext.Click += new System.EventHandler(this.q0_buttonNext_Click);
            // 
            // q0_labelAnswer
            // 
            this.q0_labelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(133)))));
            this.q0_labelAnswer.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q0_labelAnswer.ForeColor = System.Drawing.Color.White;
            this.q0_labelAnswer.Location = new System.Drawing.Point(1121, 326);
            this.q0_labelAnswer.Name = "q0_labelAnswer";
            this.q0_labelAnswer.Size = new System.Drawing.Size(650, 197);
            this.q0_labelAnswer.TabIndex = 8;
            this.q0_labelAnswer.Text = resources.GetString("q0_labelAnswer.Text");
            this.q0_labelAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q0_labelAnswer.Visible = false;
            // 
            // q0_groupBoxQuestionnaire
            // 
            this.q0_groupBoxQuestionnaire.BackColor = System.Drawing.Color.MistyRose;
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_labelAnswerRemaining);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_labelPseudo);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_labelScore);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_buttonConfirmAnswer);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxReflector);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxFood);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxWater);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxGlasses);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxBrakes);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxBackLight);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxFrontLight);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxRing);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxGloves);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_checkBoxHelmet);
            this.q0_groupBoxQuestionnaire.Controls.Add(this.q0_labelQuestion);
            this.q0_groupBoxQuestionnaire.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_groupBoxQuestionnaire.Location = new System.Drawing.Point(1121, 12);
            this.q0_groupBoxQuestionnaire.Name = "q0_groupBoxQuestionnaire";
            this.q0_groupBoxQuestionnaire.Size = new System.Drawing.Size(651, 316);
            this.q0_groupBoxQuestionnaire.TabIndex = 9;
            this.q0_groupBoxQuestionnaire.TabStop = false;
            this.q0_groupBoxQuestionnaire.Visible = false;
            // 
            // q0_labelAnswerRemaining
            // 
            this.q0_labelAnswerRemaining.AutoSize = true;
            this.q0_labelAnswerRemaining.Font = new System.Drawing.Font("Malgun Gothic", 14F);
            this.q0_labelAnswerRemaining.ForeColor = System.Drawing.Color.Black;
            this.q0_labelAnswerRemaining.Location = new System.Drawing.Point(479, 60);
            this.q0_labelAnswerRemaining.Name = "q0_labelAnswerRemaining";
            this.q0_labelAnswerRemaining.Size = new System.Drawing.Size(166, 25);
            this.q0_labelAnswerRemaining.TabIndex = 23;
            this.q0_labelAnswerRemaining.Text = "answer remaining";
            // 
            // q0_labelPseudo
            // 
            this.q0_labelPseudo.AutoSize = true;
            this.q0_labelPseudo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q0_labelPseudo.Location = new System.Drawing.Point(117, 283);
            this.q0_labelPseudo.Name = "q0_labelPseudo";
            this.q0_labelPseudo.Size = new System.Drawing.Size(65, 21);
            this.q0_labelPseudo.TabIndex = 22;
            this.q0_labelPseudo.Text = "pseudo";
            // 
            // q0_labelScore
            // 
            this.q0_labelScore.AutoSize = true;
            this.q0_labelScore.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q0_labelScore.Location = new System.Drawing.Point(410, 283);
            this.q0_labelScore.Name = "q0_labelScore";
            this.q0_labelScore.Size = new System.Drawing.Size(62, 21);
            this.q0_labelScore.TabIndex = 21;
            this.q0_labelScore.Text = "Score :";
            // 
            // q0_buttonConfirmAnswer
            // 
            this.q0_buttonConfirmAnswer.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q0_buttonConfirmAnswer.Location = new System.Drawing.Point(9, 279);
            this.q0_buttonConfirmAnswer.Name = "q0_buttonConfirmAnswer";
            this.q0_buttonConfirmAnswer.Size = new System.Drawing.Size(102, 29);
            this.q0_buttonConfirmAnswer.TabIndex = 19;
            this.q0_buttonConfirmAnswer.Text = "Confirmer";
            this.q0_buttonConfirmAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q0_buttonConfirmAnswer.UseVisualStyleBackColor = true;
            this.q0_buttonConfirmAnswer.Click += new System.EventHandler(this.q0_confirmAnswer_Click);
            // 
            // q0_checkBoxReflector
            // 
            this.q0_checkBoxReflector.AutoSize = true;
            this.q0_checkBoxReflector.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxReflector.Location = new System.Drawing.Point(351, 202);
            this.q0_checkBoxReflector.Name = "q0_checkBoxReflector";
            this.q0_checkBoxReflector.Size = new System.Drawing.Size(193, 36);
            this.q0_checkBoxReflector.TabIndex = 17;
            this.q0_checkBoxReflector.Text = "Des réflécteurs";
            this.q0_checkBoxReflector.UseVisualStyleBackColor = true;
            this.q0_checkBoxReflector.CheckedChanged += new System.EventHandler(this.q0_checkBoxReflector_CheckedChanged);
            // 
            // q0_checkBoxFood
            // 
            this.q0_checkBoxFood.AutoSize = true;
            this.q0_checkBoxFood.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxFood.Location = new System.Drawing.Point(351, 238);
            this.q0_checkBoxFood.Name = "q0_checkBoxFood";
            this.q0_checkBoxFood.Size = new System.Drawing.Size(204, 36);
            this.q0_checkBoxFood.TabIndex = 16;
            this.q0_checkBoxFood.Text = "De la nourriture";
            this.q0_checkBoxFood.UseVisualStyleBackColor = true;
            this.q0_checkBoxFood.CheckedChanged += new System.EventHandler(this.q0_checkBoxFood_CheckedChanged);
            // 
            // q0_checkBoxWater
            // 
            this.q0_checkBoxWater.AutoSize = true;
            this.q0_checkBoxWater.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxWater.Location = new System.Drawing.Point(351, 167);
            this.q0_checkBoxWater.Name = "q0_checkBoxWater";
            this.q0_checkBoxWater.Size = new System.Drawing.Size(122, 36);
            this.q0_checkBoxWater.TabIndex = 13;
            this.q0_checkBoxWater.Text = "De l\'eau";
            this.q0_checkBoxWater.UseVisualStyleBackColor = true;
            this.q0_checkBoxWater.CheckedChanged += new System.EventHandler(this.q0_checkBoxWater_CheckedChanged);
            // 
            // q0_checkBoxGlasses
            // 
            this.q0_checkBoxGlasses.AutoSize = true;
            this.q0_checkBoxGlasses.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxGlasses.Location = new System.Drawing.Point(351, 131);
            this.q0_checkBoxGlasses.Name = "q0_checkBoxGlasses";
            this.q0_checkBoxGlasses.Size = new System.Drawing.Size(167, 36);
            this.q0_checkBoxGlasses.TabIndex = 12;
            this.q0_checkBoxGlasses.Text = "Des lunettes";
            this.q0_checkBoxGlasses.UseVisualStyleBackColor = true;
            this.q0_checkBoxGlasses.CheckedChanged += new System.EventHandler(this.q0_checkBoxGlasses_CheckedChanged);
            // 
            // q0_checkBoxBrakes
            // 
            this.q0_checkBoxBrakes.AutoSize = true;
            this.q0_checkBoxBrakes.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxBrakes.Location = new System.Drawing.Point(351, 95);
            this.q0_checkBoxBrakes.Name = "q0_checkBoxBrakes";
            this.q0_checkBoxBrakes.Size = new System.Drawing.Size(148, 36);
            this.q0_checkBoxBrakes.TabIndex = 11;
            this.q0_checkBoxBrakes.Text = "Des freins ";
            this.q0_checkBoxBrakes.UseVisualStyleBackColor = true;
            this.q0_checkBoxBrakes.CheckedChanged += new System.EventHandler(this.q0_checkBoxBrakes_CheckedChanged);
            // 
            // q0_checkBoxBackLight
            // 
            this.q0_checkBoxBackLight.AutoSize = true;
            this.q0_checkBoxBackLight.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxBackLight.Location = new System.Drawing.Point(9, 238);
            this.q0_checkBoxBackLight.Name = "q0_checkBoxBackLight";
            this.q0_checkBoxBackLight.Size = new System.Drawing.Size(298, 36);
            this.q0_checkBoxBackLight.TabIndex = 10;
            this.q0_checkBoxBackLight.Text = "Une lampe arrière rouge";
            this.q0_checkBoxBackLight.UseVisualStyleBackColor = true;
            this.q0_checkBoxBackLight.CheckedChanged += new System.EventHandler(this.q0_checkBoxBackLight_CheckedChanged);
            // 
            // q0_checkBoxFrontLight
            // 
            this.q0_checkBoxFrontLight.AutoSize = true;
            this.q0_checkBoxFrontLight.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxFrontLight.Location = new System.Drawing.Point(9, 202);
            this.q0_checkBoxFrontLight.Name = "q0_checkBoxFrontLight";
            this.q0_checkBoxFrontLight.Size = new System.Drawing.Size(309, 36);
            this.q0_checkBoxFrontLight.TabIndex = 9;
            this.q0_checkBoxFrontLight.Text = "Une lampe avant blanche";
            this.q0_checkBoxFrontLight.UseVisualStyleBackColor = true;
            this.q0_checkBoxFrontLight.CheckedChanged += new System.EventHandler(this.q0_checkBoxFrontLight_CheckedChanged);
            // 
            // q0_checkBoxRing
            // 
            this.q0_checkBoxRing.AutoSize = true;
            this.q0_checkBoxRing.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxRing.Location = new System.Drawing.Point(9, 167);
            this.q0_checkBoxRing.Name = "q0_checkBoxRing";
            this.q0_checkBoxRing.Size = new System.Drawing.Size(179, 36);
            this.q0_checkBoxRing.TabIndex = 8;
            this.q0_checkBoxRing.Text = "Une sonnette";
            this.q0_checkBoxRing.UseVisualStyleBackColor = true;
            this.q0_checkBoxRing.CheckedChanged += new System.EventHandler(this.q0_checkBoxRing_CheckedChanged);
            // 
            // q0_checkBoxGloves
            // 
            this.q0_checkBoxGloves.AutoSize = true;
            this.q0_checkBoxGloves.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxGloves.Location = new System.Drawing.Point(9, 131);
            this.q0_checkBoxGloves.Name = "q0_checkBoxGloves";
            this.q0_checkBoxGloves.Size = new System.Drawing.Size(139, 36);
            this.q0_checkBoxGloves.TabIndex = 7;
            this.q0_checkBoxGloves.Text = "Des gants";
            this.q0_checkBoxGloves.UseVisualStyleBackColor = true;
            this.q0_checkBoxGloves.CheckedChanged += new System.EventHandler(this.q0_checkBoxGloves_CheckedChanged);
            // 
            // q0_checkBoxHelmet
            // 
            this.q0_checkBoxHelmet.AutoSize = true;
            this.q0_checkBoxHelmet.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q0_checkBoxHelmet.Location = new System.Drawing.Point(9, 95);
            this.q0_checkBoxHelmet.Name = "q0_checkBoxHelmet";
            this.q0_checkBoxHelmet.Size = new System.Drawing.Size(146, 36);
            this.q0_checkBoxHelmet.TabIndex = 6;
            this.q0_checkBoxHelmet.Text = "Un casque";
            this.q0_checkBoxHelmet.UseVisualStyleBackColor = true;
            this.q0_checkBoxHelmet.CheckedChanged += new System.EventHandler(this.q0_checkBoxHelmet_CheckedChanged);
            // 
            // q0_buttonBack
            // 
            this.q0_buttonBack.BackColor = System.Drawing.SystemColors.Info;
            this.q0_buttonBack.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_buttonBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.q0_buttonBack.Location = new System.Drawing.Point(22, 879);
            this.q0_buttonBack.Name = "q0_buttonBack";
            this.q0_buttonBack.Size = new System.Drawing.Size(200, 42);
            this.q0_buttonBack.TabIndex = 6;
            this.q0_buttonBack.Text = "Retour au menu";
            this.q0_buttonBack.UseVisualStyleBackColor = false;
            this.q0_buttonBack.Click += new System.EventHandler(this.q0_backButton_Click);
            // 
            // Q0Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1784, 941);
            this.Controls.Add(this.q0_groupBoxQuestionnaire);
            this.Controls.Add(this.q0_labelAnswer);
            this.Controls.Add(this.q0_buttonNext);
            this.Controls.Add(this.q0_buttonBack);
            this.Controls.Add(this.q0_labelDialogue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Q0Form";
            this.Text = "Question n°1 : L\'équipement";
            this.q0_groupBoxQuestionnaire.ResumeLayout(false);
            this.q0_groupBoxQuestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q0_labelDialogue;
        private System.Windows.Forms.Label q0_labelQuestion;
        private System.Windows.Forms.Button q0_buttonNext;
        private System.Windows.Forms.Label q0_labelAnswer;
        private System.Windows.Forms.GroupBox q0_groupBoxQuestionnaire;
        private System.Windows.Forms.CheckBox q0_checkBoxWater;
        private System.Windows.Forms.CheckBox q0_checkBoxGlasses;
        private System.Windows.Forms.CheckBox q0_checkBoxBrakes;
        private System.Windows.Forms.CheckBox q0_checkBoxBackLight;
        private System.Windows.Forms.CheckBox q0_checkBoxFrontLight;
        private System.Windows.Forms.CheckBox q0_checkBoxRing;
        private System.Windows.Forms.CheckBox q0_checkBoxGloves;
        private System.Windows.Forms.CheckBox q0_checkBoxHelmet;
        private System.Windows.Forms.CheckBox q0_checkBoxReflector;
        private System.Windows.Forms.CheckBox q0_checkBoxFood;
        private System.Windows.Forms.Button q0_buttonConfirmAnswer;
        private System.Windows.Forms.Label q0_labelScore;
        private System.Windows.Forms.Button q0_buttonBack;
        private System.Windows.Forms.Label q0_labelPseudo;
        private System.Windows.Forms.Label q0_labelAnswerRemaining;
    }
}

