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
            this.q1_answer1 = new System.Windows.Forms.Label();
            this.q1_nextButton = new System.Windows.Forms.Button();
            this.q1_signLeave = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.q1_labelScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.q0_answerResponse = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q1_signEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1_signLeave)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // q1_question
            // 
            this.q1_question.BackColor = System.Drawing.Color.Transparent;
            this.q1_question.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_question.Location = new System.Drawing.Point(6, 8);
            this.q1_question.Name = "q1_question";
            this.q1_question.Size = new System.Drawing.Size(288, 52);
            this.q1_question.TabIndex = 0;
            this.q1_question.Text = "J\'arrive proche d\'un bois, je croise ce panneau, a quoi correspond-t-il?";
            // 
            // q1_signEnter
            // 
            this.q1_signEnter.BackColor = System.Drawing.Color.Transparent;
            this.q1_signEnter.Image = ((System.Drawing.Image)(resources.GetObject("q1_signEnter.Image")));
            this.q1_signEnter.Location = new System.Drawing.Point(300, 0);
            this.q1_signEnter.Name = "q1_signEnter";
            this.q1_signEnter.Size = new System.Drawing.Size(97, 127);
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
            this.q1_backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // q1_answer1
            // 
            this.q1_answer1.BackColor = System.Drawing.Color.Brown;
            this.q1_answer1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1_answer1.ForeColor = System.Drawing.Color.White;
            this.q1_answer1.Location = new System.Drawing.Point(775, 146);
            this.q1_answer1.Name = "q1_answer1";
            this.q1_answer1.Size = new System.Drawing.Size(300, 98);
            this.q1_answer1.TabIndex = 5;
            this.q1_answer1.Text = "Ce panneau signifie que je peux emprunter une voie verte, a la fin j\'y trouverais" +
    " ce panneau";
            this.q1_answer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q1_answer1.Visible = false;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.q1_labelScore);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.q0_answerResponse);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.q1_question);
            this.groupBox1.Controls.Add(this.q1_signEnter);
            this.groupBox1.Location = new System.Drawing.Point(775, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // q1_labelScore
            // 
            this.q1_labelScore.AutoSize = true;
            this.q1_labelScore.Location = new System.Drawing.Point(214, 116);
            this.q1_labelScore.Name = "q1_labelScore";
            this.q1_labelScore.Size = new System.Drawing.Size(41, 13);
            this.q1_labelScore.TabIndex = 23;
            this.q1_labelScore.Text = "Score :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // q0_answerResponse
            // 
            this.q0_answerResponse.Location = new System.Drawing.Point(90, 114);
            this.q0_answerResponse.Name = "q0_answerResponse";
            this.q0_answerResponse.Size = new System.Drawing.Size(120, 17);
            this.q0_answerResponse.TabIndex = 22;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(136, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 17);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Une route automobile";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(136, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(98, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Une piste verte";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Une zone cyclable";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Une piste cyclable";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Q1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.q1_answer1);
            this.Controls.Add(this.q1_signLeave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.q1_nextButton);
            this.Controls.Add(this.q1_backButton);
            this.Name = "Q1Form";
            this.Text = "Q1";
            ((System.ComponentModel.ISupportInitialize)(this.q1_signEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1_signLeave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q1_question;
        private System.Windows.Forms.PictureBox q1_signEnter;
        private System.Windows.Forms.Button q1_backButton;
        private System.Windows.Forms.Label q1_answer1;
        private System.Windows.Forms.Button q1_nextButton;
        private System.Windows.Forms.PictureBox q1_signLeave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label q1_labelScore;
        private System.Windows.Forms.Label q0_answerResponse;
    }
}