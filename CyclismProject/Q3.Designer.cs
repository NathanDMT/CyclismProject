namespace CyclismProject
{
    partial class Q3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Q3Form));
            this.q3_nextButton = new System.Windows.Forms.Button();
            this.q3_signOnPole = new System.Windows.Forms.PictureBox();
            this.q3_backButton = new System.Windows.Forms.Button();
            this.q3_question = new System.Windows.Forms.Label();
            this.q2_signLeave = new System.Windows.Forms.PictureBox();
            this.q2_answer1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.q3_groupBoxQuestionnaire = new System.Windows.Forms.GroupBox();
            this.q3_labelScore = new System.Windows.Forms.Label();
            this.q3_buttonConfirmAnswer = new System.Windows.Forms.Button();
            this.checkBoxFakeConditions = new System.Windows.Forms.CheckBox();
            this.checkBoxConditionValide = new System.Windows.Forms.CheckBox();
            this.checkBoxGoEverywhere = new System.Windows.Forms.CheckBox();
            this.checkBoxGoRight = new System.Windows.Forms.CheckBox();
            this.checkBoxGoLeft = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q3_signOnPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.q3_groupBoxQuestionnaire.SuspendLayout();
            this.SuspendLayout();
            // 
            // q3_nextButton
            // 
            this.q3_nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.q3_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3_nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q3_nextButton.Location = new System.Drawing.Point(972, 597);
            this.q3_nextButton.Name = "q3_nextButton";
            this.q3_nextButton.Size = new System.Drawing.Size(200, 32);
            this.q3_nextButton.TabIndex = 6;
            this.q3_nextButton.Text = "Suivant";
            this.q3_nextButton.UseVisualStyleBackColor = false;
            this.q3_nextButton.Click += new System.EventHandler(this.q3_nextButton_Click);
            // 
            // q3_signOnPole
            // 
            this.q3_signOnPole.BackColor = System.Drawing.Color.Transparent;
            this.q3_signOnPole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q3_signOnPole.BackgroundImage")));
            this.q3_signOnPole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q3_signOnPole.InitialImage = null;
            this.q3_signOnPole.Location = new System.Drawing.Point(739, 260);
            this.q3_signOnPole.Name = "q3_signOnPole";
            this.q3_signOnPole.Size = new System.Drawing.Size(100, 100);
            this.q3_signOnPole.TabIndex = 7;
            this.q3_signOnPole.TabStop = false;
            // 
            // q3_backButton
            // 
            this.q3_backButton.BackColor = System.Drawing.SystemColors.Info;
            this.q3_backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3_backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q3_backButton.Location = new System.Drawing.Point(12, 597);
            this.q3_backButton.Name = "q3_backButton";
            this.q3_backButton.Size = new System.Drawing.Size(200, 32);
            this.q3_backButton.TabIndex = 8;
            this.q3_backButton.Text = "Question précedente";
            this.q3_backButton.UseVisualStyleBackColor = false;
            this.q3_backButton.Click += new System.EventHandler(this.q3_backButton_Click);
            // 
            // q3_question
            // 
            this.q3_question.BackColor = System.Drawing.Color.Transparent;
            this.q3_question.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3_question.Location = new System.Drawing.Point(6, 8);
            this.q3_question.Name = "q3_question";
            this.q3_question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.q3_question.Size = new System.Drawing.Size(374, 65);
            this.q3_question.TabIndex = 9;
            this.q3_question.Text = "Lorsque je me trouve face au feu, je vois ce panneau, quel droit me donne-t-il et" +
    " sous quelles conditions\r\n?\r\n";
            // 
            // q2_signLeave
            // 
            this.q2_signLeave.BackColor = System.Drawing.Color.Brown;
            this.q2_signLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2_signLeave.BackgroundImage")));
            this.q2_signLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2_signLeave.Location = new System.Drawing.Point(302, 218);
            this.q2_signLeave.Name = "q2_signLeave";
            this.q2_signLeave.Size = new System.Drawing.Size(104, 100);
            this.q2_signLeave.TabIndex = 16;
            this.q2_signLeave.TabStop = false;
            this.q2_signLeave.Visible = false;
            // 
            // q2_answer1
            // 
            this.q2_answer1.BackColor = System.Drawing.Color.Brown;
            this.q2_answer1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_answer1.ForeColor = System.Drawing.Color.White;
            this.q2_answer1.Location = new System.Drawing.Point(12, 218);
            this.q2_answer1.Name = "q2_answer1";
            this.q2_answer1.Size = new System.Drawing.Size(289, 204);
            this.q2_answer1.TabIndex = 14;
            this.q2_answer1.Text = resources.GetString("q2_answer1.Text");
            this.q2_answer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q2_answer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Brown;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(302, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 108);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // q3_groupBoxQuestionnaire
            // 
            this.q3_groupBoxQuestionnaire.BackColor = System.Drawing.Color.LightCoral;
            this.q3_groupBoxQuestionnaire.Controls.Add(this.q3_labelScore);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.q3_buttonConfirmAnswer);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.checkBoxFakeConditions);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.checkBoxConditionValide);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.checkBoxGoEverywhere);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.checkBoxGoRight);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.checkBoxGoLeft);
            this.q3_groupBoxQuestionnaire.Controls.Add(this.q3_question);
            this.q3_groupBoxQuestionnaire.Location = new System.Drawing.Point(12, 12);
            this.q3_groupBoxQuestionnaire.Name = "q3_groupBoxQuestionnaire";
            this.q3_groupBoxQuestionnaire.Size = new System.Drawing.Size(395, 206);
            this.q3_groupBoxQuestionnaire.TabIndex = 18;
            this.q3_groupBoxQuestionnaire.TabStop = false;
            // 
            // q3_labelScore
            // 
            this.q3_labelScore.AutoSize = true;
            this.q3_labelScore.Location = new System.Drawing.Point(318, 187);
            this.q3_labelScore.Name = "q3_labelScore";
            this.q3_labelScore.Size = new System.Drawing.Size(41, 13);
            this.q3_labelScore.TabIndex = 26;
            this.q3_labelScore.Text = "Score :";
            // 
            // q3_buttonConfirmAnswer
            // 
            this.q3_buttonConfirmAnswer.Location = new System.Drawing.Point(8, 177);
            this.q3_buttonConfirmAnswer.Name = "q3_buttonConfirmAnswer";
            this.q3_buttonConfirmAnswer.Size = new System.Drawing.Size(75, 23);
            this.q3_buttonConfirmAnswer.TabIndex = 19;
            this.q3_buttonConfirmAnswer.Text = "Confirmer";
            this.q3_buttonConfirmAnswer.UseVisualStyleBackColor = true;
            this.q3_buttonConfirmAnswer.Click += new System.EventHandler(this.q3_buttonConfirmAnswer_Click);
            // 
            // checkBoxFakeConditions
            // 
            this.checkBoxFakeConditions.AutoSize = true;
            this.checkBoxFakeConditions.Location = new System.Drawing.Point(168, 129);
            this.checkBoxFakeConditions.Name = "checkBoxFakeConditions";
            this.checkBoxFakeConditions.Size = new System.Drawing.Size(181, 17);
            this.checkBoxFakeConditions.TabIndex = 14;
            this.checkBoxFakeConditions.Text = "Je passe vu que je suis prioritaire";
            this.checkBoxFakeConditions.UseVisualStyleBackColor = true;
            // 
            // checkBoxConditionValide
            // 
            this.checkBoxConditionValide.Location = new System.Drawing.Point(168, 83);
            this.checkBoxConditionValide.Name = "checkBoxConditionValide";
            this.checkBoxConditionValide.Size = new System.Drawing.Size(217, 38);
            this.checkBoxConditionValide.TabIndex = 13;
            this.checkBoxConditionValide.Text = "Je dois céder le passage aux piétons et aux véhicules ayant un feu vert";
            this.checkBoxConditionValide.UseVisualStyleBackColor = true;
            // 
            // checkBoxGoEverywhere
            // 
            this.checkBoxGoEverywhere.Location = new System.Drawing.Point(10, 129);
            this.checkBoxGoEverywhere.Name = "checkBoxGoEverywhere";
            this.checkBoxGoEverywhere.Size = new System.Drawing.Size(152, 32);
            this.checkBoxGoEverywhere.TabIndex = 12;
            this.checkBoxGoEverywhere.Text = "Je peux aller à gauche, à droite, en face";
            this.checkBoxGoEverywhere.UseVisualStyleBackColor = true;
            // 
            // checkBoxGoRight
            // 
            this.checkBoxGoRight.AutoSize = true;
            this.checkBoxGoRight.Location = new System.Drawing.Point(10, 106);
            this.checkBoxGoRight.Name = "checkBoxGoRight";
            this.checkBoxGoRight.Size = new System.Drawing.Size(125, 17);
            this.checkBoxGoRight.TabIndex = 11;
            this.checkBoxGoRight.Text = "Je peux allez à droite";
            this.checkBoxGoRight.UseVisualStyleBackColor = true;
            // 
            // checkBoxGoLeft
            // 
            this.checkBoxGoLeft.AutoSize = true;
            this.checkBoxGoLeft.Location = new System.Drawing.Point(10, 83);
            this.checkBoxGoLeft.Name = "checkBoxGoLeft";
            this.checkBoxGoLeft.Size = new System.Drawing.Size(133, 17);
            this.checkBoxGoLeft.TabIndex = 10;
            this.checkBoxGoLeft.Text = "Je peux aller à gauche";
            this.checkBoxGoLeft.UseVisualStyleBackColor = true;
            // 
            // Q3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.q3_groupBoxQuestionnaire);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.q2_signLeave);
            this.Controls.Add(this.q2_answer1);
            this.Controls.Add(this.q3_backButton);
            this.Controls.Add(this.q3_signOnPole);
            this.Controls.Add(this.q3_nextButton);
            this.Name = "Q3Form";
            this.Text = "Face à un feu";
            ((System.ComponentModel.ISupportInitialize)(this.q3_signOnPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.q3_groupBoxQuestionnaire.ResumeLayout(false);
            this.q3_groupBoxQuestionnaire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button q3_nextButton;
        private System.Windows.Forms.PictureBox q3_signOnPole;
        private System.Windows.Forms.Button q3_backButton;
        private System.Windows.Forms.Label q3_question;
        private System.Windows.Forms.PictureBox q2_signLeave;
        private System.Windows.Forms.Label q2_answer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox q3_groupBoxQuestionnaire;
        private System.Windows.Forms.CheckBox checkBoxGoRight;
        private System.Windows.Forms.CheckBox checkBoxGoLeft;
        private System.Windows.Forms.CheckBox checkBoxFakeConditions;
        private System.Windows.Forms.CheckBox checkBoxConditionValide;
        private System.Windows.Forms.CheckBox checkBoxGoEverywhere;
        private System.Windows.Forms.Button q3_buttonConfirmAnswer;
        private System.Windows.Forms.Label q3_labelScore;
    }
}