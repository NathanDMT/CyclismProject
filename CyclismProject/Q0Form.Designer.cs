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
            this.q0_backButton = new System.Windows.Forms.Button();
            this.q0_answer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
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
            this.q0_question.Location = new System.Drawing.Point(6, 4);
            this.q0_question.Name = "q0_question";
            this.q0_question.Size = new System.Drawing.Size(349, 51);
            this.q0_question.TabIndex = 5;
            this.q0_question.Text = "Mais avant de partir, peux-tu me dire ce dont j\'ai besoin d\'avoir obligatoirement" +
    "?";
            this.q0_question.Visible = false;
            // 
            // q0_nextButton
            // 
            this.q0_nextButton.BackColor = System.Drawing.SystemColors.Info;
            this.q0_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_nextButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q0_nextButton.Location = new System.Drawing.Point(869, 517);
            this.q0_nextButton.Name = "q0_nextButton";
            this.q0_nextButton.Size = new System.Drawing.Size(121, 32);
            this.q0_nextButton.TabIndex = 7;
            this.q0_nextButton.Text = "Suivant";
            this.q0_nextButton.UseVisualStyleBackColor = false;
            this.q0_nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // q0_backButton
            // 
            this.q0_backButton.BackColor = System.Drawing.SystemColors.Info;
            this.q0_backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_backButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.q0_backButton.Location = new System.Drawing.Point(12, 517);
            this.q0_backButton.Name = "q0_backButton";
            this.q0_backButton.Size = new System.Drawing.Size(132, 32);
            this.q0_backButton.TabIndex = 6;
            this.q0_backButton.Text = "Recommencer";
            this.q0_backButton.UseVisualStyleBackColor = false;
            // 
            // q0_answer
            // 
            this.q0_answer.BackColor = System.Drawing.Color.Brown;
            this.q0_answer.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q0_answer.ForeColor = System.Drawing.Color.White;
            this.q0_answer.Location = new System.Drawing.Point(629, 230);
            this.q0_answer.Name = "q0_answer";
            this.q0_answer.Size = new System.Drawing.Size(361, 89);
            this.q0_answer.TabIndex = 8;
            this.q0_answer.Text = "Il doit obligatoirement avoir une sonnette, de freins en état de marche, d\'un feu" +
    " avant blanc et d\'un feu arrière rouge, de réflecteur orange sur ses roues et se" +
    "s pédales";
            this.q0_answer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.q0_answer.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.q0_question);
            this.groupBox1.Location = new System.Drawing.Point(629, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(207, 132);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(97, 17);
            this.checkBox9.TabIndex = 17;
            this.checkBox9.Text = "Des réflécteurs";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(207, 155);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(98, 17);
            this.checkBox10.TabIndex = 16;
            this.checkBox10.Text = "De la nourriture";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(207, 109);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(65, 17);
            this.checkBox8.TabIndex = 13;
            this.checkBox8.Text = "De l\'eau";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(207, 86);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(85, 17);
            this.checkBox7.TabIndex = 12;
            this.checkBox7.Text = "Des lunettes";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(207, 63);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(76, 17);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Text = "Des freins ";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 155);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(139, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Une lampe arrière rouge";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 132);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(148, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Une lampe avant blanche";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Une sonnette";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Des gants";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Un casque";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Q0Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.q0_answer);
            this.Controls.Add(this.q0_nextButton);
            this.Controls.Add(this.q0_backButton);
            this.Controls.Add(this.q0_dialogue0);
            this.Name = "Q0Form";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label q0_dialogue0;
        private System.Windows.Forms.Label q0_question;
        private System.Windows.Forms.Button q0_nextButton;
        private System.Windows.Forms.Button q0_backButton;
        private System.Windows.Forms.Label q0_answer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Button button1;
    }
}

