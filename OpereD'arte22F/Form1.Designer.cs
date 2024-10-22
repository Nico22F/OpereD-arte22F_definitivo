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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabellarte = new System.Windows.Forms.DataGridView();
            this.label_NOME_ARTISTA = new System.Windows.Forms.Label();
            this.label_NOME_ARTISTA_VARIABILE = new System.Windows.Forms.Label();
            this.label_COGOME_VARIABILE = new System.Windows.Forms.Label();
            this.label_COGNOME = new System.Windows.Forms.Label();
            this.label_NAZIONALITA_VARIABILE = new System.Windows.Forms.Label();
            this.label_NAZIONALITA = new System.Windows.Forms.Label();
            this.STILE_LABEL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_VITA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browser22F = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button_NASCITA = new System.Windows.Forms.Button();
            this.button_ALFABETICO = new System.Windows.Forms.Button();
            this.button_DECRESCENTE = new System.Windows.Forms.Button();
            this.button_ALFA_COGNO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabellarte)).BeginInit();
            this.SuspendLayout();
            // 
            // tabellarte
            // 
            this.tabellarte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabellarte.Location = new System.Drawing.Point(42, 58);
            this.tabellarte.Name = "tabellarte";
            this.tabellarte.Size = new System.Drawing.Size(901, 612);
            this.tabellarte.TabIndex = 0;
            this.tabellarte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabellarte_CellContentClick);
            // 
            // label_NOME_ARTISTA
            // 
            this.label_NOME_ARTISTA.AutoSize = true;
            this.label_NOME_ARTISTA.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NOME_ARTISTA.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_NOME_ARTISTA.Location = new System.Drawing.Point(976, 58);
            this.label_NOME_ARTISTA.Name = "label_NOME_ARTISTA";
            this.label_NOME_ARTISTA.Size = new System.Drawing.Size(117, 14);
            this.label_NOME_ARTISTA.TabIndex = 1;
            this.label_NOME_ARTISTA.Text = "NOME DELL\'ARTISTA";
            // 
            // label_NOME_ARTISTA_VARIABILE
            // 
            this.label_NOME_ARTISTA_VARIABILE.AutoSize = true;
            this.label_NOME_ARTISTA_VARIABILE.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NOME_ARTISTA_VARIABILE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_NOME_ARTISTA_VARIABILE.Location = new System.Drawing.Point(1012, 71);
            this.label_NOME_ARTISTA_VARIABILE.Name = "label_NOME_ARTISTA_VARIABILE";
            this.label_NOME_ARTISTA_VARIABILE.Size = new System.Drawing.Size(42, 14);
            this.label_NOME_ARTISTA_VARIABILE.TabIndex = 2;
            this.label_NOME_ARTISTA_VARIABILE.Text = "label1";
            // 
            // label_COGOME_VARIABILE
            // 
            this.label_COGOME_VARIABILE.AutoSize = true;
            this.label_COGOME_VARIABILE.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COGOME_VARIABILE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_COGOME_VARIABILE.Location = new System.Drawing.Point(1012, 139);
            this.label_COGOME_VARIABILE.Name = "label_COGOME_VARIABILE";
            this.label_COGOME_VARIABILE.Size = new System.Drawing.Size(42, 14);
            this.label_COGOME_VARIABILE.TabIndex = 4;
            this.label_COGOME_VARIABILE.Text = "label1";
            // 
            // label_COGNOME
            // 
            this.label_COGNOME.AutoSize = true;
            this.label_COGNOME.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_COGNOME.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_COGNOME.Location = new System.Drawing.Point(968, 116);
            this.label_COGNOME.Name = "label_COGNOME";
            this.label_COGNOME.Size = new System.Drawing.Size(142, 14);
            this.label_COGNOME.TabIndex = 3;
            this.label_COGNOME.Text = "COGNOME DELL\'ARTISTA";
            // 
            // label_NAZIONALITA_VARIABILE
            // 
            this.label_NAZIONALITA_VARIABILE.AutoSize = true;
            this.label_NAZIONALITA_VARIABILE.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NAZIONALITA_VARIABILE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_NAZIONALITA_VARIABILE.Location = new System.Drawing.Point(1012, 212);
            this.label_NAZIONALITA_VARIABILE.Name = "label_NAZIONALITA_VARIABILE";
            this.label_NAZIONALITA_VARIABILE.Size = new System.Drawing.Size(42, 14);
            this.label_NAZIONALITA_VARIABILE.TabIndex = 6;
            this.label_NAZIONALITA_VARIABILE.Text = "label1";
            // 
            // label_NAZIONALITA
            // 
            this.label_NAZIONALITA.AutoSize = true;
            this.label_NAZIONALITA.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NAZIONALITA.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_NAZIONALITA.Location = new System.Drawing.Point(959, 188);
            this.label_NAZIONALITA.Name = "label_NAZIONALITA";
            this.label_NAZIONALITA.Size = new System.Drawing.Size(164, 14);
            this.label_NAZIONALITA.TabIndex = 5;
            this.label_NAZIONALITA.Text = "NAZIONALITA\' DELL\'ARTISTA";
            // 
            // STILE_LABEL
            // 
            this.STILE_LABEL.AutoSize = true;
            this.STILE_LABEL.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STILE_LABEL.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.STILE_LABEL.Location = new System.Drawing.Point(1012, 290);
            this.STILE_LABEL.Name = "STILE_LABEL";
            this.STILE_LABEL.Size = new System.Drawing.Size(42, 14);
            this.STILE_LABEL.TabIndex = 8;
            this.STILE_LABEL.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(976, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "STILE DELL\'ARTISTA";
            // 
            // label_VITA
            // 
            this.label_VITA.AutoSize = true;
            this.label_VITA.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VITA.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_VITA.Location = new System.Drawing.Point(1012, 382);
            this.label_VITA.Name = "label_VITA";
            this.label_VITA.Size = new System.Drawing.Size(42, 14);
            this.label_VITA.TabIndex = 12;
            this.label_VITA.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(976, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "VITA DELL\'ARTISTA";
            // 
            // browser22F
            // 
            this.browser22F.Location = new System.Drawing.Point(1130, 58);
            this.browser22F.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser22F.Name = "browser22F";
            this.browser22F.Size = new System.Drawing.Size(545, 612);
            this.browser22F.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1341, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "OPERE DELL\'ARTISTA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Location = new System.Drawing.Point(962, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 87);
            this.button1.TabIndex = 15;
            this.button1.Text = "VISUALIZZA UN ARTISTA A  CASO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "CLICCA PER VISUALIZZARE AL MEGLIO LE INFORMAZIONI DI UN ARTISTA";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button2.Location = new System.Drawing.Point(967, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 91);
            this.button2.TabIndex = 17;
            this.button2.Text = "VISUALIZZA PAGINA WIKIART";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_NASCITA
            // 
            this.button_NASCITA.BackColor = System.Drawing.Color.Honeydew;
            this.button_NASCITA.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NASCITA.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_NASCITA.Location = new System.Drawing.Point(12, 673);
            this.button_NASCITA.Name = "button_NASCITA";
            this.button_NASCITA.Size = new System.Drawing.Size(306, 24);
            this.button_NASCITA.TabIndex = 18;
            this.button_NASCITA.Text = "ORDINA PER ANNO DI NASCITA (crescente)";
            this.button_NASCITA.UseVisualStyleBackColor = false;
            this.button_NASCITA.Click += new System.EventHandler(this.button_NASCITA_Click);
            // 
            // button_ALFABETICO
            // 
            this.button_ALFABETICO.BackColor = System.Drawing.Color.Honeydew;
            this.button_ALFABETICO.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ALFABETICO.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_ALFABETICO.Location = new System.Drawing.Point(637, 673);
            this.button_ALFABETICO.Name = "button_ALFABETICO";
            this.button_ALFABETICO.Size = new System.Drawing.Size(306, 24);
            this.button_ALFABETICO.TabIndex = 19;
            this.button_ALFABETICO.Text = "ORDINA PER ORDINE ALFABETCO (NOME)";
            this.button_ALFABETICO.UseVisualStyleBackColor = false;
            this.button_ALFABETICO.Click += new System.EventHandler(this.button_ALFABETICO_Click);
            // 
            // button_DECRESCENTE
            // 
            this.button_DECRESCENTE.BackColor = System.Drawing.Color.Honeydew;
            this.button_DECRESCENTE.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DECRESCENTE.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_DECRESCENTE.Location = new System.Drawing.Point(324, 673);
            this.button_DECRESCENTE.Name = "button_DECRESCENTE";
            this.button_DECRESCENTE.Size = new System.Drawing.Size(306, 24);
            this.button_DECRESCENTE.TabIndex = 20;
            this.button_DECRESCENTE.Text = "ORDINA PER ANNO DI NASCITA (decrescente)";
            this.button_DECRESCENTE.UseVisualStyleBackColor = false;
            this.button_DECRESCENTE.Click += new System.EventHandler(this.button_DECRESCENTE_Click);
            // 
            // button_ALFA_COGNO
            // 
            this.button_ALFA_COGNO.BackColor = System.Drawing.Color.Honeydew;
            this.button_ALFA_COGNO.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ALFA_COGNO.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_ALFA_COGNO.Location = new System.Drawing.Point(949, 673);
            this.button_ALFA_COGNO.Name = "button_ALFA_COGNO";
            this.button_ALFA_COGNO.Size = new System.Drawing.Size(306, 24);
            this.button_ALFA_COGNO.TabIndex = 21;
            this.button_ALFA_COGNO.Text = "ORDINA PER ORDINE ALFABETCO (COGNOME)";
            this.button_ALFA_COGNO.UseVisualStyleBackColor = false;
            this.button_ALFA_COGNO.Click += new System.EventHandler(this.button_ALFA_COGNO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1687, 709);
            this.Controls.Add(this.button_ALFA_COGNO);
            this.Controls.Add(this.button_DECRESCENTE);
            this.Controls.Add(this.button_ALFABETICO);
            this.Controls.Add(this.button_NASCITA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browser22F);
            this.Controls.Add(this.label_VITA);
            this.Controls.Add(this.label4);
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
            this.Text = "OPERE D\'ARTE 22F";
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
        private System.Windows.Forms.Label label_VITA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser browser22F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_NASCITA;
        private System.Windows.Forms.Button button_ALFABETICO;
        private System.Windows.Forms.Button button_DECRESCENTE;
        private System.Windows.Forms.Button button_ALFA_COGNO;
    }
}

