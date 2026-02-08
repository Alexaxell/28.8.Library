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
            this.btnAddCliente.Location = new System.Drawing.Point(269, 114);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(263, 70);
            this.btnAddCliente.TabIndex = 1;
            this.btnAddCliente.Text = "AddCliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // btnAddVeicolo
            // 
            this.btnAddVeicolo.Location = new System.Drawing.Point(269, 190);
            this.btnAddVeicolo.Name = "btnAddVeicolo";
            this.btnAddVeicolo.Size = new System.Drawing.Size(263, 70);
            this.btnAddVeicolo.TabIndex = 2;
            this.btnAddVeicolo.Text = "AddVeicolo";
            this.btnAddVeicolo.UseVisualStyleBackColor = true;
            this.btnAddVeicolo.Click += new System.EventHandler(this.btnAddVeicolo_Click);
            // 
            // btnAddNoleggio
            // 
            this.btnAddNoleggio.Location = new System.Drawing.Point(269, 266);
            this.btnAddNoleggio.Name = "btnAddNoleggio";
            this.btnAddNoleggio.Size = new System.Drawing.Size(263, 70);
            this.btnAddNoleggio.TabIndex = 3;
            this.btnAddNoleggio.Text = "btnAddNoleggio";
            this.btnAddNoleggio.UseVisualStyleBackColor = true;
            this.btnAddNoleggio.Click += new System.EventHandler(this.btnAddNoleggio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

