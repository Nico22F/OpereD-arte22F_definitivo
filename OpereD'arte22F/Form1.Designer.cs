namespace OpereD_arte22F
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabellarte = new System.Windows.Forms.DataGridView();
            this.label_NOME_ARTISTA = new System.Windows.Forms.Label();
            this.label_NOME_ARTISTA_VARIABILE = new System.Windows.Forms.Label();
            this.label_COGOME_VARIABILE = new System.Windows.Forms.Label();
            this.label_COGNOME = new System.Windows.Forms.Label();
            this.label_NAZIONALITA_VARIABILE = new System.Windows.Forms.Label();
            this.label_NAZIONALITA = new System.Windows.Forms.Label();
            this.STILE_LABEL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_DESCRIZIONE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_VITA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabellarte)).BeginInit();
            this.SuspendLayout();
            // 
            // tabellarte
            // 
            this.tabellarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabellarte.Location = new System.Drawing.Point(12, 12);
            this.tabellarte.Name = "tabellarte";
            this.tabellarte.Size = new System.Drawing.Size(933, 643);
            this.tabellarte.TabIndex = 0;
            this.tabellarte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabellarte_CellContentClick);
            // 
            // label_NOME_ARTISTA
            // 
            this.label_NOME_ARTISTA.AutoSize = true;
            this.label_NOME_ARTISTA.Location = new System.Drawing.Point(951, 12);
            this.label_NOME_ARTISTA.Name = "label_NOME_ARTISTA";
            this.label_NOME_ARTISTA.Size = new System.Drawing.Size(117, 13);
            this.label_NOME_ARTISTA.TabIndex = 1;
            this.label_NOME_ARTISTA.Text = "NOME DELL\'ARTISTA";
            // 
            // label_NOME_ARTISTA_VARIABILE
            // 
            this.label_NOME_ARTISTA_VARIABILE.AutoSize = true;
            this.label_NOME_ARTISTA_VARIABILE.Location = new System.Drawing.Point(951, 43);
            this.label_NOME_ARTISTA_VARIABILE.Name = "label_NOME_ARTISTA_VARIABILE";
            this.label_NOME_ARTISTA_VARIABILE.Size = new System.Drawing.Size(35, 13);
            this.label_NOME_ARTISTA_VARIABILE.TabIndex = 2;
            this.label_NOME_ARTISTA_VARIABILE.Text = "label1";
            // 
            // label_COGOME_VARIABILE
            // 
            this.label_COGOME_VARIABILE.AutoSize = true;
            this.label_COGOME_VARIABILE.Location = new System.Drawing.Point(951, 107);
            this.label_COGOME_VARIABILE.Name = "label_COGOME_VARIABILE";
            this.label_COGOME_VARIABILE.Size = new System.Drawing.Size(35, 13);
            this.label_COGOME_VARIABILE.TabIndex = 4;
            this.label_COGOME_VARIABILE.Text = "label1";
            // 
            // label_COGNOME
            // 
            this.label_COGNOME.AutoSize = true;
            this.label_COGNOME.Location = new System.Drawing.Point(951, 75);
            this.label_COGNOME.Name = "label_COGNOME";
            this.label_COGNOME.Size = new System.Drawing.Size(140, 13);
            this.label_COGNOME.TabIndex = 3;
            this.label_COGNOME.Text = "COGNOME DELL\'ARTISTA";
            // 
            // label_NAZIONALITA_VARIABILE
            // 
            this.label_NAZIONALITA_VARIABILE.AutoSize = true;
            this.label_NAZIONALITA_VARIABILE.Location = new System.Drawing.Point(951, 176);
            this.label_NAZIONALITA_VARIABILE.Name = "label_NAZIONALITA_VARIABILE";
            this.label_NAZIONALITA_VARIABILE.Size = new System.Drawing.Size(35, 13);
            this.label_NAZIONALITA_VARIABILE.TabIndex = 6;
            this.label_NAZIONALITA_VARIABILE.Text = "label1";
            // 
            // label_NAZIONALITA
            // 
            this.label_NAZIONALITA.AutoSize = true;
            this.label_NAZIONALITA.Location = new System.Drawing.Point(951, 146);
            this.label_NAZIONALITA.Name = "label_NAZIONALITA";
            this.label_NAZIONALITA.Size = new System.Drawing.Size(158, 13);
            this.label_NAZIONALITA.TabIndex = 5;
            this.label_NAZIONALITA.Text = "NAZIONALITA\' DELL\'ARTISTA";
            // 
            // STILE_LABEL
            // 
            this.STILE_LABEL.AutoSize = true;
            this.STILE_LABEL.Location = new System.Drawing.Point(951, 236);
            this.STILE_LABEL.Name = "STILE_LABEL";
            this.STILE_LABEL.Size = new System.Drawing.Size(35, 13);
            this.STILE_LABEL.TabIndex = 8;
            this.STILE_LABEL.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "STILE DELL\'ARTISTA";
            // 
            // label_DESCRIZIONE
            // 
            this.label_DESCRIZIONE.AutoSize = true;
            this.label_DESCRIZIONE.Location = new System.Drawing.Point(949, 299);
            this.label_DESCRIZIONE.Name = "label_DESCRIZIONE";
            this.label_DESCRIZIONE.Size = new System.Drawing.Size(35, 13);
            this.label_DESCRIZIONE.TabIndex = 10;
            this.label_DESCRIZIONE.Text = "label1";
            this.label_DESCRIZIONE.Click += new System.EventHandler(this.label_DESCRIZIONE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "DESCRIZIONE DELLO STILE  DELL\'ARTISTA";
            // 
            // label_VITA
            // 
            this.label_VITA.AutoSize = true;
            this.label_VITA.Location = new System.Drawing.Point(951, 365);
            this.label_VITA.Name = "label_VITA";
            this.label_VITA.Size = new System.Drawing.Size(35, 13);
            this.label_VITA.TabIndex = 12;
            this.label_VITA.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(951, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "VITA DELL\'ARTISTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 667);
            this.Controls.Add(this.label_VITA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_DESCRIZIONE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.STILE_LABEL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_NAZIONALITA_VARIABILE);
            this.Controls.Add(this.label_NAZIONALITA);
            this.Controls.Add(this.label_COGOME_VARIABILE);
            this.Controls.Add(this.label_COGNOME);
            this.Controls.Add(this.label_NOME_ARTISTA_VARIABILE);
            this.Controls.Add(this.label_NOME_ARTISTA);
            this.Controls.Add(this.tabellarte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabellarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabellarte;
        private System.Windows.Forms.Label label_NOME_ARTISTA;
        private System.Windows.Forms.Label label_NOME_ARTISTA_VARIABILE;
        private System.Windows.Forms.Label label_COGOME_VARIABILE;
        private System.Windows.Forms.Label label_COGNOME;
        private System.Windows.Forms.Label label_NAZIONALITA_VARIABILE;
        private System.Windows.Forms.Label label_NAZIONALITA;
        private System.Windows.Forms.Label STILE_LABEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_DESCRIZIONE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_VITA;
        private System.Windows.Forms.Label label4;
    }
}

