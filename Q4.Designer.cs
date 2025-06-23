namespace CyclismProject
{
    partial class Q4Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q4Form));
            this.q4_buttonNext = new System.Windows.Forms.Button();
            this.q4_buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxSign = new System.Windows.Forms.PictureBox();
            this.q4_labelQuestion = new System.Windows.Forms.Label();
            this.q4_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q4_labelPseudo = new System.Windows.Forms.Label();
            this.q4_labelScore = new System.Windows.Forms.Label();
            this.q4_buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.q4_checkBoxCyclesLane = new System.Windows.Forms.CheckBox();
            this.q4_checkBoxDeadEnd = new System.Windows.Forms.CheckBox();
            this.q4_checkBoxOneWay = new System.Windows.Forms.CheckBox();
            this.q4_checkBoxCyclesBan = new System.Windows.Forms.CheckBox();
            this.q4_labelAnswer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).BeginInit();
            this.q4_groupBoxQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // q4_buttonNext
            // 
            this.q4_buttonNext.BackColor = System.Drawing.SystemColors.Info;
            this.q4_buttonNext.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4_buttonNext.ForeColor = System.Drawing.Color.OrangeRed;
            this.q4_buttonNext.Location = new System.Drawing.Point(1551, 888);
            this.q4_buttonNext.Name = "q4_buttonNext";
            this.q4_buttonNext.Size = new System.Drawing.Size(215, 41);
            this.q4_buttonNext.TabIndex = 6;
            this.q4_buttonNext.Text = "Suivant";
            this.q4_buttonNext.UseVisualStyleBackColor = false;
            this.q4_buttonNext.Visible = false;
            this.q4_buttonNext.Click += new System.EventHandler(this.q4_buttonNext_Click);
            // 
            // q4_buttonBack
            // 
            this.q4_buttonBack.BackColor = System.Drawing.SystemColors.Info;
            this.q4_buttonBack.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4_buttonBack.ForeColor = System.Drawing.Color.OrangeRed;
            this.q4_buttonBack.Location = new System.Drawing.Point(12, 886);
            this.q4_buttonBack.Name = "q4_buttonBack";
            this.q4_buttonBack.Size = new System.Drawing.Size(243, 41);
            this.q4_buttonBack.TabIndex = 7;
            this.q4_buttonBack.Text = "Question précedente";
            this.q4_buttonBack.UseVisualStyleBackColor = false;
            this.q4_buttonBack.Click += new System.EventHandler(this.q4_buttonBack_Click);
            // 
            // pictureBoxSign
            // 
            this.pictureBoxSign.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSign.BackgroundImage")));
            this.pictureBoxSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSign.Location = new System.Drawing.Point(381, 74);
            this.pictureBoxSign.Name = "pictureBoxSign";
            this.pictureBoxSign.Size = new System.Drawing.Size(283, 275);
            this.pictureBoxSign.TabIndex = 8;
            this.pictureBoxSign.TabStop = false;
            // 
            // q4_labelQuestion
            // 
            this.q4_labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.q4_labelQuestion.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.q4_labelQuestion.ForeColor = System.Drawing.Color.Black;
            this.q4_labelQuestion.Location = new System.Drawing.Point(12, 18);
            this.q4_labelQuestion.Name = "q4_labelQuestion";
            this.q4_labelQuestion.Size = new System.Drawing.Size(460, 89);
            this.q4_labelQuestion.TabIndex = 10;
            this.q4_labelQuestion.Text = "Je me trouve face à ce panneau, que signifie-t-il? (1 seule réponse)";
            // 
            // q4_groupBoxQuestionnaire
            // 
            this.q4_groupBoxQuestionnaire.BackColor = System.Drawing.Color.MistyRose;
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_labelPseudo);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_labelScore);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_buttonConfirmAnswer);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_checkBoxCyclesLane);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_checkBoxDeadEnd);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_checkBoxOneWay);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_checkBoxCyclesBan);
            this.q4_groupBoxQuestionnaire.Controls.Add(this.q4_labelQuestion);
            this.q4_groupBoxQuestionnaire.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4_groupBoxQuestionnaire.Location = new System.Drawing.Point(1288, 12);
            this.q4_groupBoxQuestionnaire.Name = "q4_groupBoxQuestionnaire";
            this.q4_groupBoxQuestionnaire.Size = new System.Drawing.Size(478, 275);
            this.q4_groupBoxQuestionnaire.TabIndex = 12;
            this.q4_groupBoxQuestionnaire.TabStop = false;
            // 
            // q4_labelPseudo
            // 
            this.q4_labelPseudo.AutoSize = true;
            this.q4_labelPseudo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q4_labelPseudo.Location = new System.Drawing.Point(110, 243);
            this.q4_labelPseudo.Name = "q4_labelPseudo";
            this.q4_labelPseudo.Size = new System.Drawing.Size(65, 21);
            this.q4_labelPseudo.TabIndex = 29;
            this.q4_labelPseudo.Text = "pseudo";
            // 
            // q4_labelScore
            // 
            this.q4_labelScore.AutoSize = true;
            this.q4_labelScore.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q4_labelScore.Location = new System.Drawing.Point(364, 243);
            this.q4_labelScore.Name = "q4_labelScore";
            this.q4_labelScore.Size = new System.Drawing.Size(62, 21);
            this.q4_labelScore.TabIndex = 27;
            this.q4_labelScore.Text = "Score :";
            // 
            // q4_buttonConfirmAnswer
            // 
            this.q4_buttonConfirmAnswer.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.q4_buttonConfirmAnswer.Location = new System.Drawing.Point(7, 239);
            this.q4_buttonConfirmAnswer.Name = "q4_buttonConfirmAnswer";
            this.q4_buttonConfirmAnswer.Size = new System.Drawing.Size(97, 29);
            this.q4_buttonConfirmAnswer.TabIndex = 20;
            this.q4_buttonConfirmAnswer.Text = "Confirmer";
            this.q4_buttonConfirmAnswer.UseVisualStyleBackColor = true;
            this.q4_buttonConfirmAnswer.Click += new System.EventHandler(this.q4_buttonConfirmAnswer_Click);
            // 
            // q4_checkBoxCyclesLane
            // 
            this.q4_checkBoxCyclesLane.AutoSize = true;
            this.q4_checkBoxCyclesLane.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q4_checkBoxCyclesLane.Location = new System.Drawing.Point(12, 193);
            this.q4_checkBoxCyclesLane.Name = "q4_checkBoxCyclesLane";
            this.q4_checkBoxCyclesLane.Size = new System.Drawing.Size(355, 36);
            this.q4_checkBoxCyclesLane.TabIndex = 14;
            this.q4_checkBoxCyclesLane.Text = "Une voie réservé aux cyclistes";
            this.q4_checkBoxCyclesLane.UseVisualStyleBackColor = true;
            this.q4_checkBoxCyclesLane.CheckedChanged += new System.EventHandler(this.checkBoxCyclesLane_CheckedChanged);
            // 
            // q4_checkBoxDeadEnd
            // 
            this.q4_checkBoxDeadEnd.AutoSize = true;
            this.q4_checkBoxDeadEnd.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q4_checkBoxDeadEnd.Location = new System.Drawing.Point(12, 162);
            this.q4_checkBoxDeadEnd.Name = "q4_checkBoxDeadEnd";
            this.q4_checkBoxDeadEnd.Size = new System.Drawing.Size(296, 36);
            this.q4_checkBoxDeadEnd.TabIndex = 13;
            this.q4_checkBoxDeadEnd.Text = "Une impasse sans issues";
            this.q4_checkBoxDeadEnd.UseVisualStyleBackColor = true;
            this.q4_checkBoxDeadEnd.CheckedChanged += new System.EventHandler(this.checkBoxDeadEnd_CheckedChanged);
            // 
            // q4_checkBoxOneWay
            // 
            this.q4_checkBoxOneWay.AutoSize = true;
            this.q4_checkBoxOneWay.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q4_checkBoxOneWay.Location = new System.Drawing.Point(12, 131);
            this.q4_checkBoxOneWay.Name = "q4_checkBoxOneWay";
            this.q4_checkBoxOneWay.Size = new System.Drawing.Size(202, 36);
            this.q4_checkBoxOneWay.TabIndex = 12;
            this.q4_checkBoxOneWay.Text = "Un sens unique";
            this.q4_checkBoxOneWay.UseVisualStyleBackColor = true;
            this.q4_checkBoxOneWay.CheckedChanged += new System.EventHandler(this.checkBoxOneWay_CheckedChanged);
            // 
            // q4_checkBoxCyclesBan
            // 
            this.q4_checkBoxCyclesBan.AutoSize = true;
            this.q4_checkBoxCyclesBan.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.q4_checkBoxCyclesBan.Location = new System.Drawing.Point(12, 101);
            this.q4_checkBoxCyclesBan.Name = "q4_checkBoxCyclesBan";
            this.q4_checkBoxCyclesBan.Size = new System.Drawing.Size(347, 36);
            this.q4_checkBoxCyclesBan.TabIndex = 11;
            this.q4_checkBoxCyclesBan.Text = "Une interdiction aux cyclistes";
            this.q4_checkBoxCyclesBan.UseVisualStyleBackColor = true;
            this.q4_checkBoxCyclesBan.CheckedChanged += new System.EventHandler(this.checkBoxCyclesBan_CheckedChanged);
            // 
            // q4_labelAnswer
            // 
            this.q4_labelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(133)))));
            this.q4_labelAnswer.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.q4_labelAnswer.ForeColor = System.Drawing.Color.White;
            this.q4_labelAnswer.Location = new System.Drawing.Point(1287, 287);
            this.q4_labelAnswer.Name = "q4_labelAnswer";
            this.q4_labelAnswer.Size = new System.Drawing.Size(479, 133);
            this.q4_labelAnswer.TabIndex = 28;
            this.q4_labelAnswer.Text = "Ce panneau indique que je n\'ai pas le droit d\'entrer dans la rue, je dois donc ch" +
    "anger de chemin et prendre une autre route pour rentrer chez moi\r\n";
            this.q4_labelAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q4_labelAnswer.Visible = false;
            // 
            // Q4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1784, 941);
            this.Controls.Add(this.q4_labelAnswer);
            this.Controls.Add(this.q4_groupBoxQuestionnaire);
            this.Controls.Add(this.pictureBoxSign);
            this.Controls.Add(this.q4_buttonBack);
            this.Controls.Add(this.q4_buttonNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Q4Form";
            this.Text = "Question n°5 : Un panneau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSign)).EndInit();
            this.q4_groupBoxQuestionnaire.ResumeLayout(false);
            this.q4_groupBoxQuestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button q4_buttonNext;
        private System.Windows.Forms.Button q4_buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxSign;
        private System.Windows.Forms.Label q4_labelQuestion;
        private System.Windows.Forms.GroupBox q4_groupBoxQuestionnaire;
        private System.Windows.Forms.CheckBox q4_checkBoxCyclesLane;
        private System.Windows.Forms.CheckBox q4_checkBoxDeadEnd;
        private System.Windows.Forms.CheckBox q4_checkBoxOneWay;
        private System.Windows.Forms.CheckBox q4_checkBoxCyclesBan;
        private System.Windows.Forms.Button q4_buttonConfirmAnswer;
        private System.Windows.Forms.Label q4_labelScore;
        private System.Windows.Forms.Label q4_labelAnswer;
        private System.Windows.Forms.Label q4_labelPseudo;
    }
}