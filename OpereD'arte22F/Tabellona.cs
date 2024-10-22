using System;
using System.Collections.Generic;
using System.IO; // Per la gestione dei file
using System.Linq; // Per le operazioni di LINQ
using System.Text;
using System.Threading.Tasks;

namespace OpereD_arte22F
{
    internal class Tabellona
    {
        // Lista per memorizzare le opere d'arte
        public List<Arte> tabella = new List<Arte>();

        // Metodo per leggere i dati da un file CSV e popolare la lista
        public void Leggi()
        {
            try
            {
                // Apre il file artist.csv per la lettura
                using (StreamReader sr = new StreamReader(@"./artist.csv"))
                {
                    string letto;
                    // Legge il file riga per riga
                    while ((letto = sr.ReadLine()) != null)
                    {
                        // Divide la riga in base alla virgola
                        string[] riga = letto.Split(',');

                        // Verifica che la riga abbia abbastanza colonne
                        if (riga.Length >= 8)
                        {
                            // Crea un oggetto Arte e lo aggiunge alla lista
                            Arte arte = new Arte(riga[0], riga[1], riga[2], riga[3], riga[4], riga[5], riga[6], riga[7]);
                            tabella.Add(arte);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Stampa un messaggio di errore se la lettura fallisce
                Console.WriteLine($"Errore durante la lettura del file: {ex.Message}");
            }
        }

        // Metodo per ordinare la lista per anno di nascita in ordine crescente
        public void OrdinaPerAnnoNascita()
        {
            tabella = tabella.OrderBy(a => a.Anno_nascita).ToList();
        }

        // Metodo per ordinare la lista per anno di nascita in ordine decrescente
        public void OrdinaPerAnnoNascitaDECRESCENTE()
        {
            tabella = tabella.OrderByDescending(a => a.Anno_nascita).ToList();
        }

        // Metodo per ordinare la lista per nome in ordine alfabetico
        public void OrdinaAlfa()
        {
            tabella = tabella.OrderBy(a => a.Nome).ToList();
        }

        // Metodo per ordinare la lista per cognome in ordine alfabetico
        public void OrdinaAlfaCOGNOME()
        {
            tabella = tabella.OrderBy(a => a.Cognome).ToList();
        }
    }
}
