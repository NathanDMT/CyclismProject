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
            this.q2_answer2 = new System.Windows.Forms.Label();
            this.q2_answer1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q3_signOnPole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // q3_nextButton
            // 
            this.q3_nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.q3_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3_nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q3_nextButton.Location = new System.Drawing.Point(869, 517);
            this.q3_nextButton.Name = "q3_nextButton";
            this.q3_nextButton.Size = new System.Drawing.Size(121, 32);
            this.q3_nextButton.TabIndex = 6;
            this.q3_nextButton.Text = "Réponse";
            this.q3_nextButton.UseVisualStyleBackColor = false;
            this.q3_nextButton.Click += new System.EventHandler(this.q3_nextButton_Click);
            // 
            // q3_signOnPole
            // 
            this.q3_signOnPole.BackColor = System.Drawing.Color.Transparent;
            this.q3_signOnPole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q3_signOnPole.BackgroundImage")));
            this.q3_signOnPole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q3_signOnPole.InitialImage = null;
            this.q3_signOnPole.Location = new System.Drawing.Point(619, 230);
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
            this.q3_backButton.Location = new System.Drawing.Point(12, 517);
            this.q3_backButton.Name = "q3_backButton";
            this.q3_backButton.Size = new System.Drawing.Size(133, 32);
            this.q3_backButton.TabIndex = 8;
            this.q3_backButton.Text = "Recommencer";
            this.q3_backButton.UseVisualStyleBackColor = false;
            // 
            // q3_question
            // 
            this.q3_question.BackColor = System.Drawing.Color.Transparent;
            this.q3_question.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3_question.Location = new System.Drawing.Point(1, 0);
            this.q3_question.Name = "q3_question";
            this.q3_question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.q3_question.Size = new System.Drawing.Size(370, 54);
            this.q3_question.TabIndex = 9;
            this.q3_question.Text = "Lorsque je me trouve face au feu, je vois ce panneau, que signifie t-il?";
            this.q3_question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // q2_signLeave
            // 
            this.q2_signLeave.BackColor = System.Drawing.Color.Transparent;
            this.q2_signLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2_signLeave.BackgroundImage")));
            this.q2_signLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2_signLeave.Location = new System.Drawing.Point(12, 142);
            this.q2_signLeave.Name = "q2_signLeave";
            this.q2_signLeave.Size = new System.Drawing.Size(104, 100);
            this.q2_signLeave.TabIndex = 16;
            this.q2_signLeave.TabStop = false;
            this.q2_signLeave.Visible = false;
            // 
            // q2_answer2
            // 
            this.q2_answer2.BackColor = System.Drawing.Color.Transparent;
            this.q2_answer2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_answer2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.q2_answer2.Location = new System.Drawing.Point(-2, 74);
            this.q2_answer2.Name = "q2_answer2";
            this.q2_answer2.Size = new System.Drawing.Size(372, 65);
            this.q2_answer2.TabIndex = 15;
            this.q2_answer2.Text = "A la fin de la piste cyclable, je trouverais ce panneau";
            this.q2_answer2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q2_answer2.Visible = false;
            // 
            // q2_answer1
            // 
            this.q2_answer1.BackColor = System.Drawing.Color.Transparent;
            this.q2_answer1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_answer1.Location = new System.Drawing.Point(-2, 9);
            this.q2_answer1.Name = "q2_answer1";
            this.q2_answer1.Size = new System.Drawing.Size(372, 65);
            this.q2_answer1.TabIndex = 14;
            this.q2_answer1.Text = "Ce panneau signifie que je peux emprunter un piste cyclable";
            this.q2_answer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q2_answer1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(113, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.q3_question);
            this.groupBox1.Location = new System.Drawing.Point(619, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 172);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(2, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(2, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(2, 122);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Q3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.q2_signLeave);
            this.Controls.Add(this.q2_answer2);
            this.Controls.Add(this.q2_answer1);
            this.Controls.Add(this.q3_backButton);
            this.Controls.Add(this.q3_signOnPole);
            this.Controls.Add(this.q3_nextButton);
            this.Name = "Q3Form";
            this.Text = "Face à un feu";
            ((System.ComponentModel.ISupportInitialize)(this.q3_signOnPole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button q3_nextButton;
        private System.Windows.Forms.PictureBox q3_signOnPole;
        private System.Windows.Forms.Button q3_backButton;
        private System.Windows.Forms.Label q3_question;
        private System.Windows.Forms.PictureBox q2_signLeave;
        private System.Windows.Forms.Label q2_answer2;
        private System.Windows.Forms.Label q2_answer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}