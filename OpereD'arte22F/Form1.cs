using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpereD_arte22F
{
    public partial class Form1 : Form
    {
        Tabellona tabella_ = new Tabellona();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabella_.Leggi();
            // Usa la DescrizioneTroncata per la colonna della descrizione
            tabellarte.DataSource = tabella_.tabella.Select(a => new
            {
                a.Nome,
                a.Cognome,
                a.Nazionalità,
                a.Stile,
                a.Anno_nascita,
                a.Anno_morte,
                a.Image_link,
                DescrizioneTroncata = a.DescrizioneTroncata // Troncata qui
            }).ToList();

            NascondiLabel();
        }

        private void NascondiLabel()
        {
            label_COGOME_VARIABILE.Visible = false;
            label_NOME_ARTISTA_VARIABILE.Visible = false;
            label_NAZIONALITA_VARIABILE.Visible = false;
            label_DESCRIZIONE.Visible = false;
            STILE_LABEL.Visible = false;
            label_VITA.Visible = false;
        }

        private void tabellarte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int indiceLista = e.RowIndex;
                Arte operaSelezionata = tabella_.tabella[indiceLista];

                // Mostra i dettagli nell'interfaccia
                label_COGOME_VARIABILE.Visible = true;
                label_COGOME_VARIABILE.Text = operaSelezionata.Cognome;

                label_NOME_ARTISTA_VARIABILE.Visible = true;
                label_NOME_ARTISTA_VARIABILE.Text = operaSelezionata.Nome;

                label_NAZIONALITA_VARIABILE.Visible = true;
                label_NAZIONALITA_VARIABILE.Text = operaSelezionata.Nazionalità;

                label_DESCRIZIONE.Visible = true;
                label_DESCRIZIONE.Text = operaSelezionata.Descrizione; // Descrizione completa

                STILE_LABEL.Visible = true;
                STILE_LABEL.Text = operaSelezionata.Stile;

                label_VITA.Visible = true;
                label_VITA.Text = $"{operaSelezionata.Anno_nascita} - {operaSelezionata.Anno_morte}";
            }
        }

        private void label_DESCRIZIONE_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label_DESCRIZIONE.Text, "Descrizione Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
