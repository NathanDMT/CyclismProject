namespace CyclismProject
{
    partial class Q5Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q5Form));
            this.q5_buttonNext = new System.Windows.Forms.Button();
            this.q5_buttonBack = new System.Windows.Forms.Button();
            this.q5_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q5_labelPseudo = new System.Windows.Forms.Label();
            this.q5_labelScore = new System.Windows.Forms.Label();
            this.q5_buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.q5_checkBoxDeadEnd = new System.Windows.Forms.CheckBox();
            this.q5_signEnter = new System.Windows.Forms.PictureBox();
            this.q5_labelQuestion = new System.Windows.Forms.Label();
            this.q5_checkBoxDeadEndWithoutIssue = new System.Windows.Forms.CheckBox();
            this.q5_checkBoxGreenTrack = new System.Windows.Forms.CheckBox();
            this.q5_checkBoxCyclableArea = new System.Windows.Forms.CheckBox();
            this.q5_labelAnswer = new System.Windows.Forms.Label();
            this.q5_groupBoxQuestionnaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q5_signEnter)).BeginInit();
            this.SuspendLayout();
            // 
            // q5_buttonNext
            // 
            this.q5_buttonNext.BackColor = System.Drawing.SystemColors.Info;
            this.q5_buttonNext.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5_buttonNext.ForeColor = System.Drawing.Color.OrangeRed;
            this.q5_buttonNext.Location = new System.Drawing.Point(1530, 892);
            this.q5_buttonNext.Name = "q5_buttonNext";
            this.q5_buttonNext.Size = new System.Drawing.Size(242, 39);
            this.q5_buttonNext.TabIndex = 6;
            this.q5_buttonNext.Text = "Suivant";
            this.q5_buttonNext.UseVisualStyleBackColor = false;
            this.q5_buttonNext.Visible = false;
            this.q5_buttonNext.Click += new System.EventHandler(this.q5_buttonNext_Click);
            // 
            // q5_buttonBack
            // 
            this.q5_buttonBack.BackColor = System.Drawing.SystemColors.Info;
            this.q5_buttonBack.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.q5_buttonBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.q5_buttonBack.Location = new System.Drawing.Point(12, 883);
            this.q5_buttonBack.Name = "q5_buttonBack";
            this.q5_buttonBack.Size = new System.Drawing.Size(242, 39);
            this.q5_buttonBack.TabIndex = 7;
            this.q5_buttonBack.Text = "Question précedente";
            this.q5_buttonBack.UseVisualStyleBackColor = false;
            this.q5_buttonBack.Click += new System.EventHandler(this.q5_buttonBack_Click);
            // 
            // q5_groupBoxQuestionnaire
            // 
            this.q5_groupBoxQuestionnaire.BackColor = System.Drawing.Color.MistyRose;
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_labelPseudo);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_labelScore);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_buttonConfirmAnswer);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_checkBoxDeadEnd);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_signEnter);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_labelQuestion);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_checkBoxDeadEndWithoutIssue);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_checkBoxGreenTrack);
            this.q5_groupBoxQuestionnaire.Controls.Add(this.q5_checkBoxCyclableArea);
            this.q5_groupBoxQuestionnaire.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5_groupBoxQuestionnaire.Location = new System.Drawing.Point(12, 16);
            this.q5_groupBoxQuestionnaire.Name = "q5_groupBoxQuestionnaire";
            this.q5_groupBoxQuestionnaire.Size = new System.Drawing.Size(841, 315);
            this.q5_groupBoxQuestionnaire.TabIndex = 17;
            this.q5_groupBoxQuestionnaire.TabStop = false;
            // 
            // q5_labelPseudo
            // 
            this.q5_labelPseudo.AutoSize = true;
            this.q5_labelPseudo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q5_labelPseudo.Location = new System.Drawing.Point(107, 284);
            this.q5_labelPseudo.Name = "q5_labelPseudo";
            this.q5_labelPseudo.Size = new System.Drawing.Size(65, 21);
            this.q5_labelPseudo.TabIndex = 30;
            this.q5_labelPseudo.Text = "pseudo";
            // 
            // q5_labelScore
            // 
            this.q5_labelScore.AutoSize = true;
            this.q5_labelScore.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q5_labelScore.Location = new System.Drawing.Point(401, 284);
            this.q5_labelScore.Name = "q5_labelScore";
            this.q5_labelScore.Size = new System.Drawing.Size(62, 21);
            this.q5_labelScore.TabIndex = 24;
            this.q5_labelScore.Text = "Score :";
            // 
            // q5_buttonConfirmAnswer
            // 
            this.q5_buttonConfirmAnswer.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q5_buttonConfirmAnswer.Location = new System.Drawing.Point(6, 279);
            this.q5_buttonConfirmAnswer.Name = "q5_buttonConfirmAnswer";
            this.q5_buttonConfirmAnswer.Size = new System.Drawing.Size(95, 31);
            this.q5_buttonConfirmAnswer.TabIndex = 15;
            this.q5_buttonConfirmAnswer.Text = "Confirmer";
            this.q5_buttonConfirmAnswer.UseVisualStyleBackColor = true;
            this.q5_buttonConfirmAnswer.Click += new System.EventHandler(this.q5_confirmAnswerButton_Click);
            // 
            // q5_checkBoxDeadEnd
            // 
            this.q5_checkBoxDeadEnd.Font = new System.Drawing.Font("Malgun Gothic", 16F);
            this.q5_checkBoxDeadEnd.Location = new System.Drawing.Point(7, 239);
            this.q5_checkBoxDeadEnd.Name = "q5_checkBoxDeadEnd";
            this.q5_checkBoxDeadEnd.Size = new System.Drawing.Size(597, 34);
            this.q5_checkBoxDeadEnd.TabIndex = 18;
            this.q5_checkBoxDeadEnd.Text = "Une impasse avec issue pour les piétons et les cyclistes";
            this.q5_checkBoxDeadEnd.UseVisualStyleBackColor = true;
            this.q5_checkBoxDeadEnd.CheckedChanged += new System.EventHandler(this.q5_checkBoxAutoRoad_CheckedChanged);
            // 
            // q5_signEnter
            // 
            this.q5_signEnter.BackColor = System.Drawing.Color.Transparent;
            this.q5_signEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q5_signEnter.BackgroundImage")));
            this.q5_signEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q5_signEnter.Location = new System.Drawing.Point(639, 0);
            this.q5_signEnter.Name = "q5_signEnter";
            this.q5_signEnter.Size = new System.Drawing.Size(202, 315);
            this.q5_signEnter.TabIndex = 8;
            this.q5_signEnter.TabStop = false;
            // 
            // q5_labelQuestion
            // 
            this.q5_labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.q5_labelQuestion.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q5_labelQuestion.ForeColor = System.Drawing.Color.Black;
            this.q5_labelQuestion.Location = new System.Drawing.Point(6, 11);
            this.q5_labelQuestion.Name = "q5_labelQuestion";
            this.q5_labelQuestion.Size = new System.Drawing.Size(645, 124);
            this.q5_labelQuestion.TabIndex = 9;
            this.q5_labelQuestion.Text = "Je veux rentrer plus vite je décide donc d\'emprunter cette ruelle cependant je ne" +
    " sais pas ce que signifie le panneau (1 seule réponse)";
            // 
            // q5_checkBoxDeadEndWithoutIssue
            // 
            this.q5_checkBoxDeadEndWithoutIssue.AutoSize = true;
            this.q5_checkBoxDeadEndWithoutIssue.BackColor = System.Drawing.Color.Transparent;
            this.q5_checkBoxDeadEndWithoutIssue.Font = new System.Drawing.Font("Malgun Gothic", 16F);
            this.q5_checkBoxDeadEndWithoutIssue.Location = new System.Drawing.Point(7, 203);
            this.q5_checkBoxDeadEndWithoutIssue.Name = "q5_checkBoxDeadEndWithoutIssue";
            this.q5_checkBoxDeadEndWithoutIssue.Size = new System.Drawing.Size(160, 34);
            this.q5_checkBoxDeadEndWithoutIssue.TabIndex = 17;
            this.q5_checkBoxDeadEndWithoutIssue.Text = "Une impasse";
            this.q5_checkBoxDeadEndWithoutIssue.UseVisualStyleBackColor = false;
            this.q5_checkBoxDeadEndWithoutIssue.CheckedChanged += new System.EventHandler(this.q5_checkBoxForrbidenRoad_CheckedChanged);
            // 
            // q5_checkBoxGreenTrack
            // 
            this.q5_checkBoxGreenTrack.AutoSize = true;
            this.q5_checkBoxGreenTrack.Font = new System.Drawing.Font("Malgun Gothic", 16F);
            this.q5_checkBoxGreenTrack.Location = new System.Drawing.Point(7, 169);
            this.q5_checkBoxGreenTrack.Name = "q5_checkBoxGreenTrack";
            this.q5_checkBoxGreenTrack.Size = new System.Drawing.Size(281, 34);
            this.q5_checkBoxGreenTrack.TabIndex = 16;
            this.q5_checkBoxGreenTrack.Text = "Début d\'une piste verte ";
            this.q5_checkBoxGreenTrack.UseVisualStyleBackColor = true;
            this.q5_checkBoxGreenTrack.CheckedChanged += new System.EventHandler(this.q5_checkBoxGreenTrack_CheckedChanged);
            // 
            // q5_checkBoxCyclableArea
            // 
            this.q5_checkBoxCyclableArea.AutoSize = true;
            this.q5_checkBoxCyclableArea.Font = new System.Drawing.Font("Malgun Gothic", 16F);
            this.q5_checkBoxCyclableArea.Location = new System.Drawing.Point(7, 135);
            this.q5_checkBoxCyclableArea.Name = "q5_checkBoxCyclableArea";
            this.q5_checkBoxCyclableArea.Size = new System.Drawing.Size(295, 34);
            this.q5_checkBoxCyclableArea.TabIndex = 15;
            this.q5_checkBoxCyclableArea.Text = "Zone réservé aux cyclistes";
            this.q5_checkBoxCyclableArea.UseVisualStyleBackColor = true;
            this.q5_checkBoxCyclableArea.CheckedChanged += new System.EventHandler(this.q5_checkBoxCyclablePiste_CheckedChanged);
            // 
            // q5_labelAnswer
            // 
            this.q5_labelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(133)))));
            this.q5_labelAnswer.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q5_labelAnswer.ForeColor = System.Drawing.Color.White;
            this.q5_labelAnswer.Location = new System.Drawing.Point(12, 328);
            this.q5_labelAnswer.Name = "q5_labelAnswer";
            this.q5_labelAnswer.Size = new System.Drawing.Size(841, 74);
            this.q5_labelAnswer.TabIndex = 15;
            this.q5_labelAnswer.Text = "Ce panneau signifie que la rue est une impasse, cependant les piétons et les cycl" +
    "istes y trouveront une issue\r\n\r\n";
            this.q5_labelAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q5_labelAnswer.Visible = false;
            // 
            // Q5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1784, 941);
            this.Controls.Add(this.q5_groupBoxQuestionnaire);
            this.Controls.Add(this.q5_labelAnswer);
            this.Controls.Add(this.q5_buttonBack);
            this.Controls.Add(this.q5_buttonNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Q5Form";
            this.Text = "Question n°5 : Un panneau";
            this.q5_groupBoxQuestionnaire.ResumeLayout(false);
            this.q5_groupBoxQuestionnaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q5_signEnter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button q5_buttonNext;
        private System.Windows.Forms.Button q5_buttonBack;
        private System.Windows.Forms.GroupBox q5_groupBoxQuestionnaire;
        private System.Windows.Forms.Label q5_labelScore;
        private System.Windows.Forms.Button q5_buttonConfirmAnswer;
        private System.Windows.Forms.CheckBox q5_checkBoxDeadEnd;
        private System.Windows.Forms.Label q5_labelQuestion;
        private System.Windows.Forms.CheckBox q5_checkBoxDeadEndWithoutIssue;
        private System.Windows.Forms.PictureBox q5_signEnter;
        private System.Windows.Forms.CheckBox q5_checkBoxGreenTrack;
        private System.Windows.Forms.CheckBox q5_checkBoxCyclableArea;
        private System.Windows.Forms.Label q5_labelAnswer;
        private System.Windows.Forms.Label q5_labelPseudo;
    }
}