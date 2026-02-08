namespace _28._8.Library.Winform
{
    partial class FormSalvaSuCsv
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
            this.btnVeicoli = new System.Windows.Forms.Button();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnNoleggi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVeicoli
            // 
            this.btnVeicoli.Location = new System.Drawing.Point(49, 164);
            this.btnVeicoli.Name = "btnVeicoli";
            this.btnVeicoli.Size = new System.Drawing.Size(146, 59);
            this.btnVeicoli.TabIndex = 0;
            this.btnVeicoli.Text = "Veicoli";
            this.btnVeicoli.UseVisualStyleBackColor = true;
            this.btnVeicoli.Click += new System.EventHandler(this.btnVeicoli_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(320, 164);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(146, 59);
            this.btnClienti.TabIndex = 1;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.btnClienti_Click);
            // 
            // btnNoleggi
            // 
            this.btnNoleggi.Location = new System.Drawing.Point(593, 164);
            this.btnNoleggi.Name = "btnNoleggi";
            this.btnNoleggi.Size = new System.Drawing.Size(146, 59);
            this.btnNoleggi.TabIndex = 2;
            this.btnNoleggi.Text = "Noleggi";
            this.btnNoleggi.UseVisualStyleBackColor = true;
            this.btnNoleggi.Click += new System.EventHandler(this.btnNoleggi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salva su csv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "File path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(206, 375);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(377, 22);
            this.txtFilePath.TabIndex = 5;
            // 
            // FormSalvaSuCsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoleggi);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.btnVeicoli);
            this.Name = "FormSalvaSuCsv";
            this.Text = "FormSalvaSuCsv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVeicoli;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnNoleggi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilePath;
    }
}