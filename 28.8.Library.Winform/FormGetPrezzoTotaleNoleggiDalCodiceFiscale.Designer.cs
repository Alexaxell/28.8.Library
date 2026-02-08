namespace _28._8.Library.Winform
{
    partial class FormGetPrezzoTotaleNoleggiDalCodiceFiscale
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.txtCodiceFiscale = new System.Windows.Forms.TextBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice fiscale";
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(60, 174);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(44, 16);
            this.lblRisultato.TabIndex = 1;
            this.lblRisultato.Text = "label2";
            // 
            // txtCodiceFiscale
            // 
            this.txtCodiceFiscale.Location = new System.Drawing.Point(260, 73);
            this.txtCodiceFiscale.Name = "txtCodiceFiscale";
            this.txtCodiceFiscale.Size = new System.Drawing.Size(234, 22);
            this.txtCodiceFiscale.TabIndex = 2;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(604, 73);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(125, 59);
            this.btnCalcola.TabIndex = 3;
            this.btnCalcola.Text = "Calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // FormGetPrezzoTotaleNoleggiDalCodiceFiscale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.txtCodiceFiscale);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.label1);
            this.Name = "FormGetPrezzoTotaleNoleggiDalCodiceFiscale";
            this.Text = "FormGetPrezzoTotaleNoleggiDalCodiceFiscale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRisultato;
        private System.Windows.Forms.TextBox txtCodiceFiscale;
        private System.Windows.Forms.Button btnCalcola;
    }
}