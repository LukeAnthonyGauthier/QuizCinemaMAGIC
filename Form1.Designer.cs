namespace ProjetPresentationOral
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonReponse4 = new System.Windows.Forms.Button();
            this.buttonReponse1 = new System.Windows.Forms.Button();
            this.buttonReponse2 = new System.Windows.Forms.Button();
            this.buttonReponse3 = new System.Windows.Forms.Button();
            this.buttonReponse5 = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(781, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 363);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageList1
            // 
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(12, 429);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(200, 40);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "--Question--";
            // 
            // buttonReponse4
            // 
            this.buttonReponse4.Location = new System.Drawing.Point(12, 12);
            this.buttonReponse4.Name = "buttonReponse4";
            this.buttonReponse4.Size = new System.Drawing.Size(752, 68);
            this.buttonReponse4.TabIndex = 4;
            this.buttonReponse4.Text = "4";
            this.buttonReponse4.UseVisualStyleBackColor = true;
            // 
            // buttonReponse1
            // 
            this.buttonReponse1.Location = new System.Drawing.Point(12, 159);
            this.buttonReponse1.Name = "buttonReponse1";
            this.buttonReponse1.Size = new System.Drawing.Size(752, 74);
            this.buttonReponse1.TabIndex = 5;
            this.buttonReponse1.Text = "1";
            this.buttonReponse1.UseVisualStyleBackColor = true;
            this.buttonReponse1.Click += new System.EventHandler(this.buttonReponse1_Click);
            // 
            // buttonReponse2
            // 
            this.buttonReponse2.Location = new System.Drawing.Point(12, 86);
            this.buttonReponse2.Name = "buttonReponse2";
            this.buttonReponse2.Size = new System.Drawing.Size(752, 67);
            this.buttonReponse2.TabIndex = 6;
            this.buttonReponse2.Text = "2";
            this.buttonReponse2.UseVisualStyleBackColor = true;
            // 
            // buttonReponse3
            // 
            this.buttonReponse3.Location = new System.Drawing.Point(12, 239);
            this.buttonReponse3.Name = "buttonReponse3";
            this.buttonReponse3.Size = new System.Drawing.Size(752, 70);
            this.buttonReponse3.TabIndex = 7;
            this.buttonReponse3.Text = "3";
            this.buttonReponse3.UseVisualStyleBackColor = true;
            // 
            // buttonReponse5
            // 
            this.buttonReponse5.Location = new System.Drawing.Point(12, 315);
            this.buttonReponse5.Name = "buttonReponse5";
            this.buttonReponse5.Size = new System.Drawing.Size(752, 60);
            this.buttonReponse5.TabIndex = 8;
            this.buttonReponse5.Text = "5";
            this.buttonReponse5.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(935, 381);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(177, 33);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Suivant";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 545);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonReponse5);
            this.Controls.Add(this.buttonReponse3);
            this.Controls.Add(this.buttonReponse2);
            this.Controls.Add(this.buttonReponse1);
            this.Controls.Add(this.buttonReponse4);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonReponse4;
        private System.Windows.Forms.Button buttonReponse1;
        private System.Windows.Forms.Button buttonReponse2;
        private System.Windows.Forms.Button buttonReponse3;
        private System.Windows.Forms.Button buttonReponse5;
        private System.Windows.Forms.Button buttonNext;
    }
}

