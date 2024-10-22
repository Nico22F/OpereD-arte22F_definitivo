﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpereD_arte22F
{
    internal class Arte
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nazionalità { get; set; }
        public string Stile { get; set; }
        public string Anno_nascita { get; set; }
        public string Anno_morte { get; set; }
        public string Image_link { get; set; }
        public string Wiki { get; set; }

        // Proprietà per la descrizione troncata
        

        public Arte(string nome, string cognome, string nazionalità, string stile, string anno_nascita, string anno_morte, string image_link, string wiki)
        {
            Nome = nome;
            Cognome = cognome;
            Nazionalità = nazionalità;
            Stile = stile;
            Anno_nascita = anno_nascita;
            Anno_morte = anno_morte;
            Image_link = image_link;
            Wiki = wiki;


        }
        public Arte() { }

        
    }

}