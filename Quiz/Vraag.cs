using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Vraag
    {
        public string inhoud { get; set; }
        public string antwoord { get; set; }
        public string categorie { get; set; }
        public int moeilijkheidsgraad { get; set; }
    }
}
