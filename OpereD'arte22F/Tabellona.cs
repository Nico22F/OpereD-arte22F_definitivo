using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpereD_arte22F
{
    internal class Tabellona
    {
        public List<Arte> tabella = new List<Arte>();

        public void Leggi()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"./artist.csv"))
                {
                    string letto;
                    while ((letto = sr.ReadLine()) != null)
                    {
                        string[] riga = letto.Split(',');

                        if (riga.Length >= 8)
                        {
                            Arte arte = new Arte(riga[0], riga[1], riga[2], riga[3], riga[4], riga[5], riga[6], riga[7]);
                            tabella.Add(arte);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"File non trovato: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la lettura del file: {ex.Message}");
            }
        }

    }
}
