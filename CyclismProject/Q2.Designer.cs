namespace CyclismProject
{
    partial class Q2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q2Form));
            this.q2_nextButton = new System.Windows.Forms.Button();
            this.q2_backButton = new System.Windows.Forms.Button();
            this.q2_signEnter = new System.Windows.Forms.PictureBox();
            this.q2_question = new System.Windows.Forms.Label();
            this.q2_signLeave = new System.Windows.Forms.PictureBox();
            this.q2_answerLabel = new System.Windows.Forms.Label();
            this.q2_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q2_labelScore = new System.Windows.Forms.Label();
            this.q2_confirmAnswerButton = new System.Windows.Forms.Button();
            this.checkBoxAutoRoad = new System.Windows.Forms.CheckBox();
            this.checkBoxForrbidenRoad = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenTrack = new System.Windows.Forms.CheckBox();
            this.checkBoxCyclablePiste = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).BeginInit();
            this.q2_groupBoxQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // q2_nextButton
            // 
            this.q2_nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.q2_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q2_nextButton.Location = new System.Drawing.Point(972, 597);
            this.q2_nextButton.Name = "q2_nextButton";
            this.q2_nextButton.Size = new System.Drawing.Size(200, 32);
            this.q2_nextButton.TabIndex = 6;
            this.q2_nextButton.Text = "Suivant";
            this.q2_nextButton.UseVisualStyleBackColor = false;
            this.q2_nextButton.Click += new System.EventHandler(this.q2_nextButton_Click);
            // 
            // q2_backButton
            // 
            this.q2_backButton.BackColor = System.Drawing.SystemColors.Info;
            this.q2_backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q2_backButton.Location = new System.Drawing.Point(12, 597);
            this.q2_backButton.Name = "q2_backButton";
            this.q2_backButton.Size = new System.Drawing.Size(200, 32);
            this.q2_backButton.TabIndex = 7;
            this.q2_backButton.Text = "Question précedente";
            this.q2_backButton.UseVisualStyleBackColor = false;
            this.q2_backButton.Click += new System.EventHandler(this.q2_backButton_Click);
            // 
            // q2_signEnter
            // 
            this.q2_signEnter.BackColor = System.Drawing.Color.Transparent;
            this.q2_signEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2_signEnter.BackgroundImage")));
            this.q2_signEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2_signEnter.Location = new System.Drawing.Point(322, 0);
            this.q2_signEnter.Name = "q2_signEnter";
            this.q2_signEnter.Size = new System.Drawing.Size(111, 140);
            this.q2_signEnter.TabIndex = 8;
            this.q2_signEnter.TabStop = false;
            // 
            // q2_question
            // 
            this.q2_question.BackColor = System.Drawing.Color.Transparent;
            this.q2_question.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_question.Location = new System.Drawing.Point(6, 8);
            this.q2_question.Name = "q2_question";
            this.q2_question.Size = new System.Drawing.Size(310, 56);
            this.q2_question.TabIndex = 9;
            this.q2_question.Text = "J\'arrive proche de la ville, je croise ce panneau, a quoi correspond-t-il?";
            // 
            // q2_signLeave
            // 
            this.q2_signLeave.BackColor = System.Drawing.Color.Brown;
            this.q2_signLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2_signLeave.BackgroundImage")));
            this.q2_signLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2_signLeave.Location = new System.Drawing.Point(1061, 150);
            this.q2_signLeave.Name = "q2_signLeave";
            this.q2_signLeave.Size = new System.Drawing.Size(109, 106);
            this.q2_signLeave.TabIndex = 13;
            this.q2_signLeave.TabStop = false;
            this.q2_signLeave.Visible = false;
            // 
            // q2_answerLabel
            // 
            this.q2_answerLabel.BackColor = System.Drawing.Color.Brown;
            this.q2_answerLabel.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_answerLabel.ForeColor = System.Drawing.Color.White;
            this.q2_answerLabel.Location = new System.Drawing.Point(739, 152);
            this.q2_answerLabel.Name = "q2_answerLabel";
            this.q2_answerLabel.Size = new System.Drawing.Size(326, 104);
            this.q2_answerLabel.TabIndex = 11;
            this.q2_answerLabel.Text = "Ce panneau signifie que je peux emprunter un piste cyclable, à la fin je trouvera" +
    "is ce panneau";
            this.q2_answerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q2_answerLabel.Visible = false;
            // 
            // q2_groupBoxQuestionnaire
            // 
            this.q2_groupBoxQuestionnaire.BackColor = System.Drawing.Color.MistyRose;
            this.q2_groupBoxQuestionnaire.Controls.Add(this.q2_labelScore);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.q2_confirmAnswerButton);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.checkBoxAutoRoad);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.q2_question);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.checkBoxForrbidenRoad);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.q2_signEnter);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.checkBoxGreenTrack);
            this.q2_groupBoxQuestionnaire.Controls.Add(this.checkBoxCyclablePiste);
            this.q2_groupBoxQuestionnaire.Location = new System.Drawing.Point(739, 12);
            this.q2_groupBoxQuestionnaire.Name = "q2_groupBoxQuestionnaire";
            this.q2_groupBoxQuestionnaire.Size = new System.Drawing.Size(433, 140);
            this.q2_groupBoxQuestionnaire.TabIndex = 14;
            this.q2_groupBoxQuestionnaire.TabStop = false;
            // 
            // q2_labelScore
            // 
            this.q2_labelScore.AutoSize = true;
            this.q2_labelScore.Location = new System.Drawing.Point(260, 119);
            this.q2_labelScore.Name = "q2_labelScore";
            this.q2_labelScore.Size = new System.Drawing.Size(41, 13);
            this.q2_labelScore.TabIndex = 24;
            this.q2_labelScore.Text = "Score :";
            // 
            // q2_confirmAnswerButton
            // 
            this.q2_confirmAnswerButton.Location = new System.Drawing.Point(10, 111);
            this.q2_confirmAnswerButton.Name = "q2_confirmAnswerButton";
            this.q2_confirmAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.q2_confirmAnswerButton.TabIndex = 15;
            this.q2_confirmAnswerButton.Text = "Confirmer";
            this.q2_confirmAnswerButton.UseVisualStyleBackColor = true;
            this.q2_confirmAnswerButton.Click += new System.EventHandler(this.q2_confirmAnswerButton_Click);
            // 
            // checkBoxAutoRoad
            // 
            this.checkBoxAutoRoad.AutoSize = true;
            this.checkBoxAutoRoad.Location = new System.Drawing.Point(151, 92);
            this.checkBoxAutoRoad.Name = "checkBoxAutoRoad";
            this.checkBoxAutoRoad.Size = new System.Drawing.Size(165, 17);
            this.checkBoxAutoRoad.TabIndex = 18;
            this.checkBoxAutoRoad.Text = "Début d\'une route automobile";
            this.checkBoxAutoRoad.UseVisualStyleBackColor = true;
            this.checkBoxAutoRoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoRoad_CheckedChanged);
            // 
            // checkBoxForrbidenRoad
            // 
            this.checkBoxForrbidenRoad.AutoSize = true;
            this.checkBoxForrbidenRoad.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxForrbidenRoad.Location = new System.Drawing.Point(151, 67);
            this.checkBoxForrbidenRoad.Name = "checkBoxForrbidenRoad";
            this.checkBoxForrbidenRoad.Size = new System.Drawing.Size(141, 17);
            this.checkBoxForrbidenRoad.TabIndex = 17;
            this.checkBoxForrbidenRoad.Text = "Interdiction aux cyclistes";
            this.checkBoxForrbidenRoad.UseVisualStyleBackColor = false;
            this.checkBoxForrbidenRoad.CheckedChanged += new System.EventHandler(this.checkBoxForrbidenRoad_CheckedChanged);
            // 
            // checkBoxGreenTrack
            // 
            this.checkBoxGreenTrack.AutoSize = true;
            this.checkBoxGreenTrack.Location = new System.Drawing.Point(10, 90);
            this.checkBoxGreenTrack.Name = "checkBoxGreenTrack";
            this.checkBoxGreenTrack.Size = new System.Drawing.Size(139, 17);
            this.checkBoxGreenTrack.TabIndex = 16;
            this.checkBoxGreenTrack.Text = "Début d\'une piste verte ";
            this.checkBoxGreenTrack.UseVisualStyleBackColor = true;
            this.checkBoxGreenTrack.CheckedChanged += new System.EventHandler(this.checkBoxGreenTrack_CheckedChanged);
            // 
            // checkBoxCyclablePiste
            // 
            this.checkBoxCyclablePiste.AutoSize = true;
            this.checkBoxCyclablePiste.Location = new System.Drawing.Point(10, 67);
            this.checkBoxCyclablePiste.Name = "checkBoxCyclablePiste";
            this.checkBoxCyclablePiste.Size = new System.Drawing.Size(137, 17);
            this.checkBoxCyclablePiste.TabIndex = 15;
            this.checkBoxCyclablePiste.Text = "Début de piste cyclable";
            this.checkBoxCyclablePiste.UseVisualStyleBackColor = true;
            this.checkBoxCyclablePiste.CheckedChanged += new System.EventHandler(this.checkBoxCyclablePiste_CheckedChanged);
            // 
            // Q2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.q2_groupBoxQuestionnaire);
            this.Controls.Add(this.q2_signLeave);
            this.Controls.Add(this.q2_answerLabel);
            this.Controls.Add(this.q2_backButton);
            this.Controls.Add(this.q2_nextButton);
            this.Name = "Q2Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.q2_signEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).EndInit();
            this.q2_groupBoxQuestionnaire.ResumeLayout(false);
            this.q2_groupBoxQuestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button q2_nextButton;
        private System.Windows.Forms.Button q2_backButton;
        private System.Windows.Forms.PictureBox q2_signEnter;
        private System.Windows.Forms.Label q2_question;
        private System.Windows.Forms.PictureBox q2_signLeave;
        private System.Windows.Forms.Label q2_answerLabel;
        private System.Windows.Forms.GroupBox q2_groupBoxQuestionnaire;
        private System.Windows.Forms.CheckBox checkBoxAutoRoad;
        private System.Windows.Forms.CheckBox checkBoxForrbidenRoad;
        private System.Windows.Forms.CheckBox checkBoxGreenTrack;
        private System.Windows.Forms.CheckBox checkBoxCyclablePiste;
        private System.Windows.Forms.Button q2_confirmAnswerButton;
        private System.Windows.Forms.Label q2_labelScore;
    }
}