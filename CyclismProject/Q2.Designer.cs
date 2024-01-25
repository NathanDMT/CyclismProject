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
            this.q2_answer1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // 
            // q2_signEnter
            // 
            this.q2_signEnter.BackColor = System.Drawing.Color.Transparent;
            this.q2_signEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2_signEnter.BackgroundImage")));
            this.q2_signEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2_signEnter.Location = new System.Drawing.Point(280, 0);
            this.q2_signEnter.Name = "q2_signEnter";
            this.q2_signEnter.Size = new System.Drawing.Size(100, 127);
            this.q2_signEnter.TabIndex = 8;
            this.q2_signEnter.TabStop = false;
            // 
            // q2_question
            // 
            this.q2_question.BackColor = System.Drawing.Color.Transparent;
            this.q2_question.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_question.Location = new System.Drawing.Point(6, 8);
            this.q2_question.Name = "q2_question";
            this.q2_question.Size = new System.Drawing.Size(268, 74);
            this.q2_question.TabIndex = 9;
            this.q2_question.Text = "J\'arrive proche de la ville, je croise ce panneau, a quoi correspond-t-il?";
            // 
            // q2_signLeave
            // 
            this.q2_signLeave.BackColor = System.Drawing.Color.Brown;
            this.q2_signLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("q2_signLeave.BackgroundImage")));
            this.q2_signLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.q2_signLeave.Location = new System.Drawing.Point(1066, 168);
            this.q2_signLeave.Name = "q2_signLeave";
            this.q2_signLeave.Size = new System.Drawing.Size(104, 97);
            this.q2_signLeave.TabIndex = 13;
            this.q2_signLeave.TabStop = false;
            this.q2_signLeave.Visible = false;
            // 
            // q2_answer1
            // 
            this.q2_answer1.BackColor = System.Drawing.Color.Brown;
            this.q2_answer1.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2_answer1.ForeColor = System.Drawing.Color.White;
            this.q2_answer1.Location = new System.Drawing.Point(792, 170);
            this.q2_answer1.Name = "q2_answer1";
            this.q2_answer1.Size = new System.Drawing.Size(274, 95);
            this.q2_answer1.TabIndex = 11;
            this.q2_answer1.Text = "Ce panneau signifie que je peux emprunter un piste cyclable, à la fin je trouvera" +
    "is ce panneau";
            this.q2_answer1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q2_answer1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.q2_question);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.q2_signEnter);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(792, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 158);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(116, 110);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 18;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(116, 85);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 108);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Q2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.q2_signLeave);
            this.Controls.Add(this.q2_answer1);
            this.Controls.Add(this.q2_backButton);
            this.Controls.Add(this.q2_nextButton);
            this.Name = "Q2Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Q2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.q2_signEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2_signLeave)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button q2_nextButton;
        private System.Windows.Forms.Button q2_backButton;
        private System.Windows.Forms.PictureBox q2_signEnter;
        private System.Windows.Forms.Label q2_question;
        private System.Windows.Forms.PictureBox q2_signLeave;
        private System.Windows.Forms.Label q2_answer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}