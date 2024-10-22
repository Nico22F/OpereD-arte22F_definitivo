using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpereD_arte22F;

namespace OpereD_arte22F
{
    public partial class Form1 : Form
{
    Tabellona tabella_ = new Tabellona();
    public int n_artista = 0;

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        tabella_.Leggi();
        CaricaDataGrid();
        NascondiLabel();
    }

    private void CaricaDataGrid()
    {
        tabellarte.DataSource = tabella_.tabella.Select(a => new
        {
            a.Nome,
            a.Cognome,
            a.Nazionalità,
            a.Stile,
            a.Anno_nascita,
            a.Anno_morte,
            a.Image_link,
            a.Wiki,
        }).ToList();
    }

    private void NascondiLabel()
    {
        label_COGOME_VARIABILE.Visible = false;
        label_NOME_ARTISTA_VARIABILE.Visible = false;
        label_NAZIONALITA_VARIABILE.Visible = false;
        STILE_LABEL.Visible = false;
        label_VITA.Visible = false;
    }

    private void tabellarte_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
        {
            n_artista = e.RowIndex;
            Arte operaSelezionata = tabella_.tabella[n_artista];
            MostraDettagli(operaSelezionata);
        }
    }

    private void MostraDettagli(Arte operaSelezionata)
    {
        label_COGOME_VARIABILE.Visible = true;
        label_COGOME_VARIABILE.Text = operaSelezionata.Cognome;

        label_NOME_ARTISTA_VARIABILE.Visible = true;
        label_NOME_ARTISTA_VARIABILE.Text = operaSelezionata.Nome;

        label_NAZIONALITA_VARIABILE.Visible = true;
        label_NAZIONALITA_VARIABILE.Text = operaSelezionata.Nazionalità;

        STILE_LABEL.Visible = true;
        STILE_LABEL.Text = operaSelezionata.Stile;

        label_VITA.Visible = true;
        label_VITA.Text = $"{operaSelezionata.Anno_nascita} - {operaSelezionata.Anno_morte}";

        browser22F.Navigate(operaSelezionata.Wiki); // Naviga al link
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Random random = new Random();
        n_artista = random.Next(0, tabella_.tabella.Count);
        Arte operaSelezionata = tabella_.tabella[n_artista];
        MostraDettagli(operaSelezionata);
    }

    // WEB CHE MOSTRA LE IMMAGINI
    private void button2_Click(object sender, EventArgs e)
    {
        if (n_artista >= 0 && n_artista < tabella_.tabella.Count)
        {
            Arte operaSelezionata = tabella_.tabella[n_artista];
            string url = operaSelezionata.Image_link;
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }

    // ORDINA LA DATAGRID VIEW IN ORDINE DI NASCITA
    private void button_NASCITA_Click(object sender, EventArgs e)
    {
        tabella_.OrdinaPerAnnoNascita(); // Ordina direttamente la lista
        AggiornaDataGridView(); // Aggiorna il DataGridView
    }

    private void button_DECRESCENTE_Click(object sender, EventArgs e)
    {
        tabella_.OrdinaPerAnnoNascitaDECRESCENTE(); // Ordina direttamente la lista
        AggiornaDataGridView(); // Aggiorna il DataGridView
    }

    private void button_ALFABETICO_Click(object sender, EventArgs e)
    {
        tabella_.OrdinaAlfa(); // Ordina direttamente la lista
        AggiornaDataGridView(); // Aggiorna il DataGridView
    }

    private void button_ALFA_COGNO_Click(object sender, EventArgs e)
    {
        tabella_.OrdinaAlfaCOGNOME(); // Ordina direttamente la lista
        AggiornaDataGridView(); // Aggiorna il DataGridView
    }

    private void AggiornaDataGridView()
    {
        tabellarte.DataSource = null; // Pulisci il DataSource esistente
        tabellarte.DataSource = tabella_.tabella.Select(a => new
        {
            a.Nome,
            a.Cognome,
            a.Nazionalità,
            a.Stile,
            a.Anno_nascita,
            a.Anno_morte,
            a.Image_link,
            a.Wiki,
        }).ToList();
    }
}
}