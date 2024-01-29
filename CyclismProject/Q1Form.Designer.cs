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
            this.q1_question = new System.Windows.Forms.Label();
            this.q1_signEnter = new System.Windows.Forms.PictureBox();
            this.q1_backButton = new System.Windows.Forms.Button();
            this.q1_answerLabel = new System.Windows.Forms.Label();
            this.q1_nextButton = new System.Windows.Forms.Button();
            this.q1_signLeave = new System.Windows.Forms.PictureBox();
            this.q1_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q1_confirmAnswerButton = new System.Windows.Forms.Button();
            this.q1_labelScore = new System.Windows.Forms.Label();
            this.q0_answerResponse = new System.Windows.Forms.Label();
            this.checkBoxAutoRoad = new System.Windows.Forms.CheckBox();
            this.checkBoxGreenTrack = new System.Windows.Forms.CheckBox();
            this.checkBoxCycleArea = new System.Windows.Forms.CheckBox();
            this.checkBoxCycleTrack = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q1_signEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1_signLeave)).BeginInit();
            this.q1_groupBoxQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // q1_question
            // 
            this.q1_question.BackColor = System.Drawing.Color.Transparent;
            this.q1_question.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_question.Location = new System.Drawing.Point(6, 8);
            this.q1_question.Name = "q1_question";
            this.q1_question.Size = new System.Drawing.Size(396, 52);
            this.q1_question.TabIndex = 0;
            this.q1_question.Text = "J\'arrive proche d\'un bois, je croise ce panneau, a quoi correspond-t-il?";
            // 
            // q1_signEnter
            // 
            this.q1_signEnter.BackColor = System.Drawing.Color.Transparent;
            this.q1_signEnter.Image = ((System.Drawing.Image)(resources.GetObject("q1_signEnter.Image")));
            this.q1_signEnter.Location = new System.Drawing.Point(419, 0);
            this.q1_signEnter.Name = "q1_signEnter";
            this.q1_signEnter.Size = new System.Drawing.Size(97, 135);
            this.q1_signEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.q1_signEnter.TabIndex = 2;
            this.q1_signEnter.TabStop = false;
            // 
            // q1_backButton
            // 
            this.q1_backButton.BackColor = System.Drawing.SystemColors.Info;
            this.q1_backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q1_backButton.Location = new System.Drawing.Point(12, 597);
            this.q1_backButton.Name = "q1_backButton";
            this.q1_backButton.Size = new System.Drawing.Size(200, 32);
            this.q1_backButton.TabIndex = 3;
            this.q1_backButton.Text = "Question précedente";
            this.q1_backButton.UseVisualStyleBackColor = false;
            this.q1_backButton.Click += new System.EventHandler(this.q1_backButton_Click);
            // 
            // q1_answerLabel
            // 
            this.q1_answerLabel.BackColor = System.Drawing.Color.Brown;
            this.q1_answerLabel.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_answerLabel.ForeColor = System.Drawing.Color.White;
            this.q1_answerLabel.Location = new System.Drawing.Point(656, 146);
            this.q1_answerLabel.Name = "q1_answerLabel";
            this.q1_answerLabel.Size = new System.Drawing.Size(419, 98);
            this.q1_answerLabel.TabIndex = 5;
            this.q1_answerLabel.Text = "Ce panneau signifie que je peux emprunter une voie verte, a la fin j\'y trouverais" +
    " ce panneau";
            this.q1_answerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q1_answerLabel.Visible = false;
            // 
            // q1_nextButton
            // 
            this.q1_nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.q1_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q1_nextButton.Location = new System.Drawing.Point(972, 597);
            this.q1_nextButton.Name = "q1_nextButton";
            this.q1_nextButton.Size = new System.Drawing.Size(200, 32);
            this.q1_nextButton.TabIndex = 8;
            this.q1_nextButton.Text = "Suivant";
            this.q1_nextButton.UseVisualStyleBackColor = false;
            this.q1_nextButton.Click += new System.EventHandler(this.q1_nextButton_Click);
            // 
            // q1_signLeave
            // 
            this.q1_signLeave.BackColor = System.Drawing.Color.Brown;
            this.q1_signLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q1_signLeave.BackgroundImage")));
            this.q1_signLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q1_signLeave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.q1_signLeave.Location = new System.Drawing.Point(1075, 146);
            this.q1_signLeave.Name = "q1_signLeave";
            this.q1_signLeave.Size = new System.Drawing.Size(97, 98);
            this.q1_signLeave.TabIndex = 10;
            this.q1_signLeave.TabStop = false;
            this.q1_signLeave.Visible = false;
            // 
            // q1_groupBoxQuestionnaire
            // 
            this.q1_groupBoxQuestionnaire.BackColor = System.Drawing.Color.MistyRose;
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_confirmAnswerButton);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_labelScore);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q0_answerResponse);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.checkBoxAutoRoad);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.checkBoxGreenTrack);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.checkBoxCycleArea);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.checkBoxCycleTrack);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_question);
            this.q1_groupBoxQuestionnaire.Controls.Add(this.q1_signEnter);
            this.q1_groupBoxQuestionnaire.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_groupBoxQuestionnaire.Location = new System.Drawing.Point(656, 12);
            this.q1_groupBoxQuestionnaire.Name = "q1_groupBoxQuestionnaire";
            this.q1_groupBoxQuestionnaire.Size = new System.Drawing.Size(516, 135);
            this.q1_groupBoxQuestionnaire.TabIndex = 11;
            this.q1_groupBoxQuestionnaire.TabStop = false;
            // 
            // q1_confirmAnswerButton
            // 
            this.q1_confirmAnswerButton.Location = new System.Drawing.Point(10, 106);
            this.q1_confirmAnswerButton.Name = "q1_confirmAnswerButton";
            this.q1_confirmAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.q1_confirmAnswerButton.TabIndex = 24;
            this.q1_confirmAnswerButton.Text = "Confirmer";
            this.q1_confirmAnswerButton.UseVisualStyleBackColor = true;
            this.q1_confirmAnswerButton.Click += new System.EventHandler(this.q1_confirmAnswerButton_Click);
            // 
            // q1_labelScore
            // 
            this.q1_labelScore.AutoSize = true;
            this.q1_labelScore.Location = new System.Drawing.Point(361, 114);
            this.q1_labelScore.Name = "q1_labelScore";
            this.q1_labelScore.Size = new System.Drawing.Size(41, 13);
            this.q1_labelScore.TabIndex = 23;
            this.q1_labelScore.Text = "Score :";
            // 
            // q0_answerResponse
            // 
            this.q0_answerResponse.Location = new System.Drawing.Point(90, 114);
            this.q0_answerResponse.Name = "q0_answerResponse";
            this.q0_answerResponse.Size = new System.Drawing.Size(120, 17);
            this.q0_answerResponse.TabIndex = 22;
            // 
            // checkBoxAutoRoad
            // 
            this.checkBoxAutoRoad.AutoSize = true;
            this.checkBoxAutoRoad.Location = new System.Drawing.Point(227, 86);
            this.checkBoxAutoRoad.Name = "checkBoxAutoRoad";
            this.checkBoxAutoRoad.Size = new System.Drawing.Size(183, 17);
            this.checkBoxAutoRoad.TabIndex = 6;
            this.checkBoxAutoRoad.Text = "Début d\'une route automobile";
            this.checkBoxAutoRoad.UseVisualStyleBackColor = true;
            this.checkBoxAutoRoad.CheckedChanged += new System.EventHandler(this.checkBoxAutoRoad_CheckedChanged);
            // 
            // checkBoxGreenTrack
            // 
            this.checkBoxGreenTrack.AutoSize = true;
            this.checkBoxGreenTrack.Location = new System.Drawing.Point(227, 63);
            this.checkBoxGreenTrack.Name = "checkBoxGreenTrack";
            this.checkBoxGreenTrack.Size = new System.Drawing.Size(132, 17);
            this.checkBoxGreenTrack.TabIndex = 5;
            this.checkBoxGreenTrack.Text = "Début de piste verte";
            this.checkBoxGreenTrack.UseVisualStyleBackColor = true;
            this.checkBoxGreenTrack.CheckedChanged += new System.EventHandler(this.checkBoxGreenTrack_CheckedChanged);
            // 
            // checkBoxCycleArea
            // 
            this.checkBoxCycleArea.AutoSize = true;
            this.checkBoxCycleArea.Location = new System.Drawing.Point(10, 86);
            this.checkBoxCycleArea.Name = "checkBoxCycleArea";
            this.checkBoxCycleArea.Size = new System.Drawing.Size(214, 17);
            this.checkBoxCycleArea.TabIndex = 4;
            this.checkBoxCycleArea.Text = "Début de zone réservée aux cyclistes";
            this.checkBoxCycleArea.UseVisualStyleBackColor = true;
            this.checkBoxCycleArea.CheckedChanged += new System.EventHandler(this.checkBoxCycleArea_CheckedChanged);
            // 
            // checkBoxCycleTrack
            // 
            this.checkBoxCycleTrack.AutoSize = true;
            this.checkBoxCycleTrack.Location = new System.Drawing.Point(10, 63);
            this.checkBoxCycleTrack.Name = "checkBoxCycleTrack";
            this.checkBoxCycleTrack.Size = new System.Drawing.Size(130, 17);
            this.checkBoxCycleTrack.TabIndex = 3;
            this.checkBoxCycleTrack.Text = "Début piste cyclable";
            this.checkBoxCycleTrack.UseVisualStyleBackColor = true;
            this.checkBoxCycleTrack.CheckedChanged += new System.EventHandler(this.checkBoxCycleTrack_CheckedChanged);
            // 
            // Q1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.q1_answerLabel);
            this.Controls.Add(this.q1_signLeave);
            this.Controls.Add(this.q1_groupBoxQuestionnaire);
            this.Controls.Add(this.q1_nextButton);
            this.Controls.Add(this.q1_backButton);
            this.Name = "Q1Form";
            this.Text = "Q1";
            ((System.ComponentModel.ISupportInitialize)(this.q1_signEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1_signLeave)).EndInit();
            this.q1_groupBoxQuestionnaire.ResumeLayout(false);
            this.q1_groupBoxQuestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q1_question;
        private System.Windows.Forms.PictureBox q1_signEnter;
        private System.Windows.Forms.Button q1_backButton;
        private System.Windows.Forms.Label q1_answerLabel;
        private System.Windows.Forms.Button q1_nextButton;
        private System.Windows.Forms.PictureBox q1_signLeave;
        private System.Windows.Forms.GroupBox q1_groupBoxQuestionnaire;
        private System.Windows.Forms.CheckBox checkBoxAutoRoad;
        private System.Windows.Forms.CheckBox checkBoxGreenTrack;
        private System.Windows.Forms.CheckBox checkBoxCycleArea;
        private System.Windows.Forms.CheckBox checkBoxCycleTrack;
        private System.Windows.Forms.Label q1_labelScore;
        private System.Windows.Forms.Label q0_answerResponse;
        private System.Windows.Forms.Button q1_confirmAnswerButton;
    }
}