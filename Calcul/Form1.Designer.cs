namespace Calcul
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
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonCalculAsync = new System.Windows.Forms.Button();
            this.btStopAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(311, 266);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(146, 23);
            this.buttonCalcul.TabIndex = 0;
            this.buttonCalcul.Text = "Calcul";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.buttonCalcul_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compteur";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(335, 242);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(50, 13);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Message";
            // 
            // buttonCalculAsync
            // 
            this.buttonCalculAsync.Location = new System.Drawing.Point(311, 330);
            this.buttonCalculAsync.Name = "buttonCalculAsync";
            this.buttonCalculAsync.Size = new System.Drawing.Size(146, 23);
            this.buttonCalculAsync.TabIndex = 4;
            this.buttonCalculAsync.Text = "Calcul Asynchrone";
            this.buttonCalculAsync.UseVisualStyleBackColor = true;
            this.buttonCalculAsync.Click += new System.EventHandler(this.buttonCalculAsync_Click);
            // 
            // btStopAsync
            // 
            this.btStopAsync.Location = new System.Drawing.Point(311, 399);
            this.btStopAsync.Name = "btStopAsync";
            this.btStopAsync.Size = new System.Drawing.Size(146, 23);
            this.btStopAsync.TabIndex = 5;
            this.btStopAsync.Text = "Stop Calcul";
            this.btStopAsync.UseVisualStyleBackColor = true;
            this.btStopAsync.Click += new System.EventHandler(this.btStopAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btStopAsync);
            this.Controls.Add(this.buttonCalculAsync);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCalcul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonCalculAsync;
        private System.Windows.Forms.Button btStopAsync;
    }
}

