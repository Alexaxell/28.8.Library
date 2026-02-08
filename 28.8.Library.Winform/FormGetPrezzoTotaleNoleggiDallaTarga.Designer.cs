namespace _28._8.Library.Winform
{
    partial class FormGetPrezzoTotaleNoleggiDallaTarga
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
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.btnCalcolo = new System.Windows.Forms.Button();
            this.lblRisultato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Targa";
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(216, 90);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(233, 22);
            this.txtTarga.TabIndex = 1;
            // 
            // btnCalcolo
            // 
            this.btnCalcolo.Location = new System.Drawing.Point(594, 90);
            this.btnCalcolo.Name = "btnCalcolo";
            this.btnCalcolo.Size = new System.Drawing.Size(102, 53);
            this.btnCalcolo.TabIndex = 2;
            this.btnCalcolo.Text = "Calcola";
            this.btnCalcolo.UseVisualStyleBackColor = true;
            this.btnCalcolo.Click += new System.EventHandler(this.btnCalcolo_Click);
            // 
            // lblRisultato
            // 
            this.lblRisultato.AutoSize = true;
            this.lblRisultato.Location = new System.Drawing.Point(68, 194);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(44, 16);
            this.lblRisultato.TabIndex = 3;
            this.lblRisultato.Text = "label2";
            // 
            // FormGetPrezzoTotaleNoleggiDallaTarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.btnCalcolo);
            this.Controls.Add(this.txtTarga);
            this.Controls.Add(this.label1);
            this.Name = "FormGetPrezzoTotaleNoleggiDallaTarga";
            this.Text = "FormGetPrezzoTotaleNoleggiDallaTarga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.Button btnCalcolo;
        private System.Windows.Forms.Label lblRisultato;
    }
}