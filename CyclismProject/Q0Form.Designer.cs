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
            this.q0_question = new System.Windows.Forms.Label();
            this.q0_nextButton = new System.Windows.Forms.Button();
            this.q0_answerLabel = new System.Windows.Forms.Label();
            this.q0_grpBoxQuestion = new System.Windows.Forms.GroupBox();
            this.q0_labelScore = new System.Windows.Forms.Label();
            this.q0_answerResponse = new System.Windows.Forms.Label();
            this.q0_confirmAnswerButton = new System.Windows.Forms.Button();
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
            this.q0_backButton = new System.Windows.Forms.Button();
            this.q0_grpBoxQuestion.SuspendLayout();
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
            this.q0_dialogue0.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // q0_question
            // 
            this.q0_question.BackColor = System.Drawing.Color.Transparent;
            this.q0_question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q0_question.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_question.Location = new System.Drawing.Point(6, 7);
            this.q0_question.Name = "q0_question";
            this.q0_question.Size = new System.Drawing.Size(349, 51);
            this.q0_question.TabIndex = 5;
            this.q0_question.Text = "Mais avant de partir, peux-tu me dire ce dont j\'ai besoin d\'avoir obligatoirement" +
    "?";
            // 
            // q0_nextButton
            // 
            this.q0_nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.q0_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q0_nextButton.Location = new System.Drawing.Point(972, 597);
            this.q0_nextButton.Name = "q0_nextButton";
            this.q0_nextButton.Size = new System.Drawing.Size(200, 32);
            this.q0_nextButton.TabIndex = 7;
            this.q0_nextButton.Text = "Suivant";
            this.q0_nextButton.UseVisualStyleBackColor = false;
            this.q0_nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // q0_answerLabel
            // 
            this.q0_answerLabel.BackColor = System.Drawing.Color.Brown;
            this.q0_answerLabel.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_answerLabel.ForeColor = System.Drawing.Color.White;
            this.q0_answerLabel.Location = new System.Drawing.Point(811, 215);
            this.q0_answerLabel.Name = "q0_answerLabel";
            this.q0_answerLabel.Size = new System.Drawing.Size(361, 112);
            this.q0_answerLabel.TabIndex = 8;
            this.q0_answerLabel.Text = resources.GetString("q0_answerLabel.Text");
            this.q0_answerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q0_answerLabel.Visible = false;
            // 
            // q0_grpBoxQuestion
            // 
            this.q0_grpBoxQuestion.BackColor = System.Drawing.Color.MistyRose;
            this.q0_grpBoxQuestion.Controls.Add(this.q0_labelScore);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_answerResponse);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_confirmAnswerButton);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxReflector);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxFood);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxWater);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxGlasses);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxBrakes);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxBackLight);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxFrontLight);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxRing);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxGloves);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_checkBoxHelmet);
            this.q0_grpBoxQuestion.Controls.Add(this.q0_question);
            this.q0_grpBoxQuestion.Location = new System.Drawing.Point(811, 12);
            this.q0_grpBoxQuestion.Name = "q0_grpBoxQuestion";
            this.q0_grpBoxQuestion.Size = new System.Drawing.Size(361, 203);
            this.q0_grpBoxQuestion.TabIndex = 9;
            this.q0_grpBoxQuestion.TabStop = false;
            this.q0_grpBoxQuestion.Visible = false;
            // 
            // q0_labelScore
            // 
            this.q0_labelScore.AutoSize = true;
            this.q0_labelScore.Location = new System.Drawing.Point(207, 184);
            this.q0_labelScore.Name = "q0_labelScore";
            this.q0_labelScore.Size = new System.Drawing.Size(41, 13);
            this.q0_labelScore.TabIndex = 21;
            this.q0_labelScore.Text = "Score :";
            // 
            // q0_answerResponse
            // 
            this.q0_answerResponse.Location = new System.Drawing.Point(83, 182);
            this.q0_answerResponse.Name = "q0_answerResponse";
            this.q0_answerResponse.Size = new System.Drawing.Size(120, 17);
            this.q0_answerResponse.TabIndex = 20;
            // 
            // q0_confirmAnswerButton
            // 
            this.q0_confirmAnswerButton.Location = new System.Drawing.Point(8, 178);
            this.q0_confirmAnswerButton.Name = "q0_confirmAnswerButton";
            this.q0_confirmAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.q0_confirmAnswerButton.TabIndex = 19;
            this.q0_confirmAnswerButton.Text = "Confirmer";
            this.q0_confirmAnswerButton.UseVisualStyleBackColor = true;
            this.q0_confirmAnswerButton.Click += new System.EventHandler(this.q0_confirmAnswer_Click);
            // 
            // q0_checkBoxReflector
            // 
            this.q0_checkBoxReflector.AutoSize = true;
            this.q0_checkBoxReflector.Location = new System.Drawing.Point(210, 130);
            this.q0_checkBoxReflector.Name = "q0_checkBoxReflector";
            this.q0_checkBoxReflector.Size = new System.Drawing.Size(97, 17);
            this.q0_checkBoxReflector.TabIndex = 17;
            this.q0_checkBoxReflector.Text = "Des réflécteurs";
            this.q0_checkBoxReflector.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxFood
            // 
            this.q0_checkBoxFood.AutoSize = true;
            this.q0_checkBoxFood.Location = new System.Drawing.Point(210, 153);
            this.q0_checkBoxFood.Name = "q0_checkBoxFood";
            this.q0_checkBoxFood.Size = new System.Drawing.Size(98, 17);
            this.q0_checkBoxFood.TabIndex = 16;
            this.q0_checkBoxFood.Text = "De la nourriture";
            this.q0_checkBoxFood.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxWater
            // 
            this.q0_checkBoxWater.AutoSize = true;
            this.q0_checkBoxWater.Location = new System.Drawing.Point(210, 107);
            this.q0_checkBoxWater.Name = "q0_checkBoxWater";
            this.q0_checkBoxWater.Size = new System.Drawing.Size(65, 17);
            this.q0_checkBoxWater.TabIndex = 13;
            this.q0_checkBoxWater.Text = "De l\'eau";
            this.q0_checkBoxWater.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxGlasses
            // 
            this.q0_checkBoxGlasses.AutoSize = true;
            this.q0_checkBoxGlasses.Location = new System.Drawing.Point(210, 84);
            this.q0_checkBoxGlasses.Name = "q0_checkBoxGlasses";
            this.q0_checkBoxGlasses.Size = new System.Drawing.Size(85, 17);
            this.q0_checkBoxGlasses.TabIndex = 12;
            this.q0_checkBoxGlasses.Text = "Des lunettes";
            this.q0_checkBoxGlasses.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxBrakes
            // 
            this.q0_checkBoxBrakes.AutoSize = true;
            this.q0_checkBoxBrakes.Location = new System.Drawing.Point(210, 61);
            this.q0_checkBoxBrakes.Name = "q0_checkBoxBrakes";
            this.q0_checkBoxBrakes.Size = new System.Drawing.Size(76, 17);
            this.q0_checkBoxBrakes.TabIndex = 11;
            this.q0_checkBoxBrakes.Text = "Des freins ";
            this.q0_checkBoxBrakes.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxBackLight
            // 
            this.q0_checkBoxBackLight.AutoSize = true;
            this.q0_checkBoxBackLight.Location = new System.Drawing.Point(9, 153);
            this.q0_checkBoxBackLight.Name = "q0_checkBoxBackLight";
            this.q0_checkBoxBackLight.Size = new System.Drawing.Size(139, 17);
            this.q0_checkBoxBackLight.TabIndex = 10;
            this.q0_checkBoxBackLight.Text = "Une lampe arrière rouge";
            this.q0_checkBoxBackLight.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxFrontLight
            // 
            this.q0_checkBoxFrontLight.AutoSize = true;
            this.q0_checkBoxFrontLight.Location = new System.Drawing.Point(10, 130);
            this.q0_checkBoxFrontLight.Name = "q0_checkBoxFrontLight";
            this.q0_checkBoxFrontLight.Size = new System.Drawing.Size(148, 17);
            this.q0_checkBoxFrontLight.TabIndex = 9;
            this.q0_checkBoxFrontLight.Text = "Une lampe avant blanche";
            this.q0_checkBoxFrontLight.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxRing
            // 
            this.q0_checkBoxRing.AutoSize = true;
            this.q0_checkBoxRing.Location = new System.Drawing.Point(10, 107);
            this.q0_checkBoxRing.Name = "q0_checkBoxRing";
            this.q0_checkBoxRing.Size = new System.Drawing.Size(90, 17);
            this.q0_checkBoxRing.TabIndex = 8;
            this.q0_checkBoxRing.Text = "Une sonnette";
            this.q0_checkBoxRing.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxGloves
            // 
            this.q0_checkBoxGloves.AutoSize = true;
            this.q0_checkBoxGloves.Location = new System.Drawing.Point(10, 84);
            this.q0_checkBoxGloves.Name = "q0_checkBoxGloves";
            this.q0_checkBoxGloves.Size = new System.Drawing.Size(74, 17);
            this.q0_checkBoxGloves.TabIndex = 7;
            this.q0_checkBoxGloves.Text = "Des gants";
            this.q0_checkBoxGloves.UseVisualStyleBackColor = true;
            // 
            // q0_checkBoxHelmet
            // 
            this.q0_checkBoxHelmet.AutoSize = true;
            this.q0_checkBoxHelmet.Location = new System.Drawing.Point(10, 61);
            this.q0_checkBoxHelmet.Name = "q0_checkBoxHelmet";
            this.q0_checkBoxHelmet.Size = new System.Drawing.Size(78, 17);
            this.q0_checkBoxHelmet.TabIndex = 6;
            this.q0_checkBoxHelmet.Text = "Un casque";
            this.q0_checkBoxHelmet.UseVisualStyleBackColor = true;
            // 
            // q0_backButton
            // 
            this.q0_backButton.BackColor = System.Drawing.SystemColors.Info;
            this.q0_backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q0_backButton.Location = new System.Drawing.Point(12, 597);
            this.q0_backButton.Name = "q0_backButton";
            this.q0_backButton.Size = new System.Drawing.Size(200, 32);
            this.q0_backButton.TabIndex = 6;
            this.q0_backButton.Text = "Retour au menu";
            this.q0_backButton.UseVisualStyleBackColor = false;
            this.q0_backButton.Click += new System.EventHandler(this.q0_backButton_Click);
            // 
            // Q0Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.q0_grpBoxQuestion);
            this.Controls.Add(this.q0_answerLabel);
            this.Controls.Add(this.q0_nextButton);
            this.Controls.Add(this.q0_backButton);
            this.Controls.Add(this.q0_dialogue0);
            this.Name = "Q0Form";
            this.Text = "Form1";
            this.q0_grpBoxQuestion.ResumeLayout(false);
            this.q0_grpBoxQuestion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q0_dialogue0;
        private System.Windows.Forms.Label q0_question;
        private System.Windows.Forms.Button q0_nextButton;
        private System.Windows.Forms.Label q0_answerLabel;
        private System.Windows.Forms.GroupBox q0_grpBoxQuestion;
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
        private System.Windows.Forms.Button q0_confirmAnswerButton;
        private System.Windows.Forms.Label q0_answerResponse;
        private System.Windows.Forms.Label q0_labelScore;
        private System.Windows.Forms.Button q0_backButton;
    }
}

