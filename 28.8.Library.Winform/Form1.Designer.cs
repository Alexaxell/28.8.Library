namespace _28._8.Library.Winform
{
    partial class Form1
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
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.btnAddVeicolo = new System.Windows.Forms.Button();
            this.btnAddNoleggio = new System.Windows.Forms.Button();
            this.btnGetPrezzoTotaleNoleggiDallaTarga = new System.Windows.Forms.Button();
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale = new System.Windows.Forms.Button();
            this.btnGetPrezzoTotaleNoleggiPerAuto = new System.Windows.Forms.Button();
            this.btnSalvaSuCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTORE NOLEGGI";
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(82, 119);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(263, 70);
            this.btnAddCliente.TabIndex = 1;
            this.btnAddCliente.Text = "AddCliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnAddVeicolo
            // 
            this.btnAddVeicolo.Location = new System.Drawing.Point(82, 195);
            this.btnAddVeicolo.Name = "btnAddVeicolo";
            this.btnAddVeicolo.Size = new System.Drawing.Size(263, 70);
            this.btnAddVeicolo.TabIndex = 2;
            this.btnAddVeicolo.Text = "AddVeicolo";
            this.btnAddVeicolo.UseVisualStyleBackColor = true;
            this.btnAddVeicolo.Click += new System.EventHandler(this.btnAddVeicolo_Click);
            // 
            // btnAddNoleggio
            // 
            this.btnAddNoleggio.Location = new System.Drawing.Point(82, 271);
            this.btnAddNoleggio.Name = "btnAddNoleggio";
            this.btnAddNoleggio.Size = new System.Drawing.Size(263, 70);
            this.btnAddNoleggio.TabIndex = 3;
            this.btnAddNoleggio.Text = "btnAddNoleggio";
            this.btnAddNoleggio.UseVisualStyleBackColor = true;
            this.btnAddNoleggio.Click += new System.EventHandler(this.btnAddNoleggio_Click);
            // 
            // btnGetPrezzoTotaleNoleggiDallaTarga
            // 
            this.btnGetPrezzoTotaleNoleggiDallaTarga.Location = new System.Drawing.Point(462, 119);
            this.btnGetPrezzoTotaleNoleggiDallaTarga.Name = "btnGetPrezzoTotaleNoleggiDallaTarga";
            this.btnGetPrezzoTotaleNoleggiDallaTarga.Size = new System.Drawing.Size(280, 46);
            this.btnGetPrezzoTotaleNoleggiDallaTarga.TabIndex = 4;
            this.btnGetPrezzoTotaleNoleggiDallaTarga.Text = "GetPrezzoTotaleNoleggiDallaTarga";
            this.btnGetPrezzoTotaleNoleggiDallaTarga.UseVisualStyleBackColor = true;
            this.btnGetPrezzoTotaleNoleggiDallaTarga.Click += new System.EventHandler(this.btnGetPrezzoTotaleNoleggiDallaTarga_Click_1);
            // 
            // btnGetPrezzoTotaleNoleggiDalCodiceFiscale
            // 
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.Location = new System.Drawing.Point(462, 171);
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.Name = "btnGetPrezzoTotaleNoleggiDalCodiceFiscale";
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.Size = new System.Drawing.Size(280, 46);
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.TabIndex = 5;
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.Text = "GetPrezzoTotaleNoleggiDalCodiceFiscale";
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.UseVisualStyleBackColor = true;
            this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale.Click += new System.EventHandler(this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale_Click);
            // 
            // btnGetPrezzoTotaleNoleggiPerAuto
            // 
            this.btnGetPrezzoTotaleNoleggiPerAuto.Location = new System.Drawing.Point(462, 223);
            this.btnGetPrezzoTotaleNoleggiPerAuto.Name = "btnGetPrezzoTotaleNoleggiPerAuto";
            this.btnGetPrezzoTotaleNoleggiPerAuto.Size = new System.Drawing.Size(280, 46);
            this.btnGetPrezzoTotaleNoleggiPerAuto.TabIndex = 6;
            this.btnGetPrezzoTotaleNoleggiPerAuto.Text = "GetPrezzoTotaleNoleggiPerAuto";
            this.btnGetPrezzoTotaleNoleggiPerAuto.UseVisualStyleBackColor = true;
            this.btnGetPrezzoTotaleNoleggiPerAuto.Click += new System.EventHandler(this.btnGetPrezzoTotaleNoleggiPerAuto_Click);
            // 
            // btnSalvaSuCSV
            // 
            this.btnSalvaSuCSV.Location = new System.Drawing.Point(462, 275);
            this.btnSalvaSuCSV.Name = "btnSalvaSuCSV";
            this.btnSalvaSuCSV.Size = new System.Drawing.Size(280, 46);
            this.btnSalvaSuCSV.TabIndex = 7;
            this.btnSalvaSuCSV.Text = "SalvaSuCsv";
            this.btnSalvaSuCSV.UseVisualStyleBackColor = true;
            this.btnSalvaSuCSV.Click += new System.EventHandler(this.btnSalvaSuCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvaSuCSV);
            this.Controls.Add(this.btnGetPrezzoTotaleNoleggiPerAuto);
            this.Controls.Add(this.btnGetPrezzoTotaleNoleggiDalCodiceFiscale);
            this.Controls.Add(this.btnGetPrezzoTotaleNoleggiDallaTarga);
            this.Controls.Add(this.btnAddNoleggio);
            this.Controls.Add(this.btnAddVeicolo);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Button btnAddVeicolo;
        private System.Windows.Forms.Button btnAddNoleggio;
        private System.Windows.Forms.Button btnGetPrezzoTotaleNoleggiDallaTarga;
        private System.Windows.Forms.Button btnGetPrezzoTotaleNoleggiDalCodiceFiscale;
        private System.Windows.Forms.Button btnGetPrezzoTotaleNoleggiPerAuto;
        private System.Windows.Forms.Button btnSalvaSuCSV;
    }
}

