using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW2D2.Models
{
    internal class Curriculum
    {
        internal class Informazioni_Personali
        {
            internal string Nome { get; set; } = "";
            internal string Cognome { get; set; } = "";
            internal string Telefono { get; set; } = "";
            internal string Email { get; set; } = "";
        }
        internal class Studi
        {
            internal string Qualifica { get; set; } = "";
            internal string Istituto { get; set; } = "";
            internal string Tipo { get; set; } = "";
            internal DateTime Dal;
            internal DateTime Al;
        }
        internal class Impiego
        {
            internal string Esperienza { get; set; } = "";
        }
        internal class Esperienza
        {
            internal string Azienda { get; set; } = "";
            internal string JobTitle { get; set; } = "";
            internal DateTime Dal;
            internal DateTime Al;
            internal string Descrizione { get; set; } = "";
            internal string Compiti { get; set; } = "";

        }
    }

    
}
