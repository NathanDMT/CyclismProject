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
            this.q1_labelQuestion = new System.Windows.Forms.Label();
            this.q1_pictureBoxSignEnter = new System.Windows.Forms.PictureBox();
            this.q1_buttonBack = new System.Windows.Forms.Button();
            this.q1_labelAnswer = new System.Windows.Forms.Label();
            this.q1_buttonNext = new System.Windows.Forms.Button();
            this.q1_pictureBoxSignLeave = new System.Windows.Forms.PictureBox();
            this.q1_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q1_labelPseudo = new System.Windows.Forms.Label();
            this.q1_buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.q1_labelScore = new System.Windows.Forms.Label();
            this.q1_checkBoxAutoRoad = new System.Windows.Forms.CheckBox();
            this.q1_checkBoxGreenTrack = new System.Windows.Forms.CheckBox();
            this.q1_checkBoxCycleArea = new System.Windows.Forms.CheckBox();
            this.q1_checkBoxCycleTrack = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q1_pictureBoxSignEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1_pictureBoxSignLeave)).BeginInit();
            this.q1_groupBoxQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // q1_labelQuestion
            // 
            this.q1_labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.q1_labelQuestion.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q1_labelQuestion.ForeColor = System.Drawing.Color.Black;
            this.q1_labelQuestion.Location = new System.Drawing.Point(6, 11);
            this.q1_labelQuestion.Name = "q1_labelQuestion";
            this.q1_labelQuestion.Size = new System.Drawing.Size(520, 112);
            this.q1_labelQuestion.TabIndex = 0;
            this.q1_labelQuestion.Text = "J\'arrive proche d\'un bois, je croise ce panneau, à quoi correspond-t-il? (1 seule" +
    " réponse)";
            // 
            // q1_pictureBoxSignEnter
            // 
            this.q1_pictureBoxSignEnter.BackColor = System.Drawing.Color.Transparent;
            this.q1_pictureBoxSignEnter.Image = ((System.Drawing.Image)(resources.GetObject("q1_pictureBoxSignEnter.Image")));
            this.q1_pictureBoxSignEnter.Location = new System.Drawing.Point(533, 0);
            this.q1_pictureBoxSignEnter.Name = "q1_pictureBoxSignEnter";
            this.q1_pictureBoxSignEnter.Size = new System.Drawing.Size(193, 290);
            this.q1_pictureBoxSignEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.q1_pictureBoxSignEnter.TabIndex = 2;
            this.q1_pictureBoxSignEnter.TabStop = false;
            // 
            // q1_buttonBack
            // 
            this.q1_buttonBack.BackColor = System.Drawing.SystemColors.Info;
            this.q1_buttonBack.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_buttonBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.q1_buttonBack.Location = new System.Drawing.Point(23, 879);
            this.q1_buttonBack.Name = "q1_buttonBack";
            this.q1_buttonBack.Size = new System.Drawing.Size(232, 43);
            this.q1_buttonBack.TabIndex = 3;
            this.q1_buttonBack.Text = "Question précedente";
            this.q1_buttonBack.UseVisualStyleBackColor = false;
            this.q1_buttonBack.Click += new System.EventHandler(this.q1_backButton_Click);
            // 
            // q1_labelAnswer
            // 
            this.q1_labelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(133)))));
            this.q1_labelAnswer.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q1_labelAnswer.ForeColor = System.Drawing.Color.White;
            this.q1_labelAnswer.Location = new System.Drawing.Point(1047, 301);
            this.q1_labelAnswer.Name = "q1_labelAnswer";
            this.q1_labelAnswer.Size = new System.Drawing.Size(532, 195);
            this.q1_labelAnswer.TabIndex = 5;
            this.q1_labelAnswer.Text = "Ce panneau signifie que je peux emprunter une voie verte, à la fin j\'y trouverai " +
    "ce panneau\r\nUne voie verte est une voie réservé aux véhicules non-motorisé";
            this.q1_labelAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q1_labelAnswer.Visible = false;
            // 
            // q1_buttonNext
            // 
            this.q1_buttonNext.BackColor = System.Drawing.SystemColors.Info;
            this.q1_buttonNext.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_buttonNext.ForeColor = System.Drawing.Color.OrangeRed;
            this.q1_buttonNext.Location = new System.Drawing.Point(1559, 877);
            this.q1_buttonNext.Name = "q1_buttonNext";
            this.q1_buttonNext.Size = new System.Drawing.Size(200, 43);
            this.q1_buttonNext.TabIndex = 8;
            this.q1_buttonNext.Text = "Suivant";
            this.q1_buttonNext.UseVisualStyleBackColor = false;
            this.q1_buttonNext.Visible = false;
            this.q1_buttonNext.Click += new System.EventHandler(this.q1_nextButton_Click);
            // 
            // q1_pictureBoxSignLeave
            // 
            this.q1_pictureBoxSignLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(133)))));
            this.q1_pictureBoxSignLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q1_pictureBoxSignLeave.BackgroundImage")));
            this.q1_pictureBoxSignLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q1_pictureBoxSignLeave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.q1_pictureBoxSignLeave.Location = new System.Drawing.Point(1579, 301);
            this.q1_pictureBoxSignLeave.Name = "q1_pictureBoxSignLeave";
            this.q1_pictureBoxSignLeave.Size = new System.Drawing.Size(193, 195);
            this.q1_pictureBoxSignLeave.TabIndex = 10;
            this.q1_pictureBoxSignLeave.TabStop = false;
            this.q1_pictureBoxSignLeave.Visible = false;
            // 
            // q1_groupBoxQuestionnaire
            // 
            this.q1_groupBoxQuestionnaire.BackColor = System.Drawing.Color.MistyRose;
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_labelPseudo);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_buttonConfirmAnswer);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_labelScore);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_checkBoxAutoRoad);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_checkBoxGreenTrack);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_checkBoxCycleArea);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_checkBoxCycleTrack);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_labelQuestion);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_pictureBoxSignEnter);
            this.q1_groupBoxQuestionnaire.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_groupBoxQuestionnaire.Location = new System.Drawing.Point(1046, 12);
            this.q1_groupBoxQuestionnaire.Name = "q1_groupBoxQuestionnaire";
            this.q1_groupBoxQuestionnaire.Size = new System.Drawing.Size(726, 290);
            this.q1_groupBoxQuestionnaire.TabIndex = 11;
            this.q1_groupBoxQuestionnaire.TabStop = false;
            // 
            // q1_labelPseudo
            // 
            this.q1_labelPseudo.AutoSize = true;
            this.q1_labelPseudo.BackColor = System.Drawing.Color.Transparent;
            this.q1_labelPseudo.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_labelPseudo.Location = new System.Drawing.Point(116, 261);
            this.q1_labelPseudo.Name = "q1_labelPseudo";
            this.q1_labelPseudo.Size = new System.Drawing.Size(65, 21);
            this.q1_labelPseudo.TabIndex = 12;
            this.q1_labelPseudo.Text = "pseudo";
            // 
            // q1_buttonConfirmAnswer
            // 
            this.q1_buttonConfirmAnswer.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_buttonConfirmAnswer.Location = new System.Drawing.Point(11, 257);
            this.q1_buttonConfirmAnswer.Name = "q1_buttonConfirmAnswer";
            this.q1_buttonConfirmAnswer.Size = new System.Drawing.Size(99, 28);
            this.q1_buttonConfirmAnswer.TabIndex = 24;
            this.q1_buttonConfirmAnswer.Text = "Confirmer";
            this.q1_buttonConfirmAnswer.UseVisualStyleBackColor = true;
            this.q1_buttonConfirmAnswer.Click += new System.EventHandler(this.q1_confirmAnswerButton_Click);
            // 
            // q1_labelScore
            // 
            this.q1_labelScore.AutoSize = true;
            this.q1_labelScore.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_labelScore.Location = new System.Drawing.Point(428, 264);
            this.q1_labelScore.Name = "q1_labelScore";
            this.q1_labelScore.Size = new System.Drawing.Size(62, 21);
            this.q1_labelScore.TabIndex = 23;
            this.q1_labelScore.Text = "Score :";
            // 
            // q1_checkBoxAutoRoad
            // 
            this.q1_checkBoxAutoRoad.AutoSize = true;
            this.q1_checkBoxAutoRoad.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q1_checkBoxAutoRoad.Location = new System.Drawing.Point(20, 219);
            this.q1_checkBoxAutoRoad.Name = "q1_checkBoxAutoRoad";
            this.q1_checkBoxAutoRoad.Size = new System.Drawing.Size(393, 36);
            this.q1_checkBoxAutoRoad.TabIndex = 6;
            this.q1_checkBoxAutoRoad.Text = "Le début d\'une route automobile";
            this.q1_checkBoxAutoRoad.UseVisualStyleBackColor = true;
            this.q1_checkBoxAutoRoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoRoad_CheckedChanged);
            // 
            // q1_checkBoxGreenTrack
            // 
            this.q1_checkBoxGreenTrack.AutoSize = true;
            this.q1_checkBoxGreenTrack.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q1_checkBoxGreenTrack.Location = new System.Drawing.Point(20, 187);
            this.q1_checkBoxGreenTrack.Name = "q1_checkBoxGreenTrack";
            this.q1_checkBoxGreenTrack.Size = new System.Drawing.Size(319, 36);
            this.q1_checkBoxGreenTrack.TabIndex = 5;
            this.q1_checkBoxGreenTrack.Text = "Le début d\'une piste verte";
            this.q1_checkBoxGreenTrack.UseVisualStyleBackColor = true;
            this.q1_checkBoxGreenTrack.CheckedChanged += new System.EventHandler(this.checkBoxGreenTrack_CheckedChanged);
            // 
            // q1_checkBoxCycleArea
            // 
            this.q1_checkBoxCycleArea.AutoSize = true;
            this.q1_checkBoxCycleArea.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q1_checkBoxCycleArea.Location = new System.Drawing.Point(20, 156);
            this.q1_checkBoxCycleArea.Name = "q1_checkBoxCycleArea";
            this.q1_checkBoxCycleArea.Size = new System.Drawing.Size(496, 36);
            this.q1_checkBoxCycleArea.TabIndex = 4;
            this.q1_checkBoxCycleArea.Text = "Le début d\'une zone réservée aux cyclistes";
            this.q1_checkBoxCycleArea.UseVisualStyleBackColor = true;
            this.q1_checkBoxCycleArea.CheckedChanged += new System.EventHandler(this.checkBoxCycleArea_CheckedChanged);
            // 
            // q1_checkBoxCycleTrack
            // 
            this.q1_checkBoxCycleTrack.AutoSize = true;
            this.q1_checkBoxCycleTrack.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q1_checkBoxCycleTrack.Location = new System.Drawing.Point(20, 125);
            this.q1_checkBoxCycleTrack.Name = "q1_checkBoxCycleTrack";
            this.q1_checkBoxCycleTrack.Size = new System.Drawing.Size(350, 36);
            this.q1_checkBoxCycleTrack.TabIndex = 3;
            this.q1_checkBoxCycleTrack.Text = "Le début d\'une piste cyclable";
            this.q1_checkBoxCycleTrack.UseVisualStyleBackColor = true;
            this.q1_checkBoxCycleTrack.CheckedChanged += new System.EventHandler(this.checkBoxCycleTrack_CheckedChanged);
            // 
            // Q1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1784, 941);
            this.Controls.Add(this.q1_labelAnswer);
            this.Controls.Add(this.q1_pictureBoxSignLeave);
            this.Controls.Add(this.q1_groupBoxQuestionnaire);
            this.Controls.Add(this.q1_buttonNext);
            this.Controls.Add(this.q1_buttonBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Q1Form";
            this.Text = "Question n°2 : Un panneau";
            ((System.ComponentModel.ISupportInitialize)(this.q1_pictureBoxSignEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1_pictureBoxSignLeave)).EndInit();
            this.q1_groupBoxQuestionnaire.ResumeLayout(false);
            this.q1_groupBoxQuestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q1_labelQuestion;
        private System.Windows.Forms.PictureBox q1_pictureBoxSignEnter;
        private System.Windows.Forms.Button q1_buttonBack;
        private System.Windows.Forms.Label q1_labelAnswer;
        private System.Windows.Forms.Button q1_buttonNext;
        private System.Windows.Forms.PictureBox q1_pictureBoxSignLeave;
        private System.Windows.Forms.GroupBox q1_groupBoxQuestionnaire;
        private System.Windows.Forms.CheckBox q1_checkBoxAutoRoad;
        private System.Windows.Forms.CheckBox q1_checkBoxGreenTrack;
        private System.Windows.Forms.CheckBox q1_checkBoxCycleArea;
        private System.Windows.Forms.CheckBox q1_checkBoxCycleTrack;
        private System.Windows.Forms.Label q1_labelScore;
        private System.Windows.Forms.Button q1_buttonConfirmAnswer;
        private System.Windows.Forms.Label q1_labelPseudo;
    }
}