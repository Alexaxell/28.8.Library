namespace _28._8.Library.Winform
{
    partial class FormAddNoleggio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNumeroDiGiorni = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cbxAddCliente = new System.Windows.Forms.ComboBox();
            this.cbxAddVeicolo = new System.Windows.Forms.ComboBox();
            this.dtpDataInizio = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data inizio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero di giorni";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Costo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Veicolo";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(224, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(168, 22);
            this.txtId.TabIndex = 6;
            // 
            // txtNumeroDiGiorni
            // 
            this.txtNumeroDiGiorni.Location = new System.Drawing.Point(224, 146);
            this.txtNumeroDiGiorni.Name = "txtNumeroDiGiorni";
            this.txtNumeroDiGiorni.Size = new System.Drawing.Size(168, 22);
            this.txtNumeroDiGiorni.TabIndex = 9;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(224, 204);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(168, 22);
            this.txtCosto.TabIndex = 10;
            // 
            // cbxAddCliente
            // 
            this.cbxAddCliente.FormattingEnabled = true;
            this.cbxAddCliente.Location = new System.Drawing.Point(224, 267);
            this.cbxAddCliente.Name = "cbxAddCliente";
            this.cbxAddCliente.Size = new System.Drawing.Size(200, 24);
            this.cbxAddCliente.TabIndex = 11;
            // 
            // cbxAddVeicolo
            // 
            this.cbxAddVeicolo.FormattingEnabled = true;
            this.cbxAddVeicolo.Location = new System.Drawing.Point(224, 329);
            this.cbxAddVeicolo.Name = "cbxAddVeicolo";
            this.cbxAddVeicolo.Size = new System.Drawing.Size(200, 24);
            this.cbxAddVeicolo.TabIndex = 12;
            // 
            // dtpDataInizio
            // 
            this.dtpDataInizio.Location = new System.Drawing.Point(224, 93);
            this.dtpDataInizio.Name = "dtpDataInizio";
            this.dtpDataInizio.Size = new System.Drawing.Size(200, 22);
            this.dtpDataInizio.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 210);
            this.button1.TabIndex = 14;
            this.button1.Text = "AddNoleggio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddNoleggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDataInizio);
            this.Controls.Add(this.cbxAddVeicolo);
            this.Controls.Add(this.cbxAddCliente);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtNumeroDiGiorni);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddNoleggio";
            this.Text = "FormAddNoleggio";
            this.Activated += new System.EventHandler(this.FormAddNoleggio_Activated);
            this.Load += new System.EventHandler(this.FormAddNoleggio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNumeroDiGiorni;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cbxAddCliente;
        private System.Windows.Forms.ComboBox cbxAddVeicolo;
        private System.Windows.Forms.DateTimePicker dtpDataInizio;
        private System.Windows.Forms.Button button1;
    }
}