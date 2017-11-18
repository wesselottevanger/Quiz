using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    class Program
    { 
        int answerscorrect = 0;

        static void Main(string[] args)
        {
            IList<Vraag> stringList = new List<Vraag>() {
                new Vraag()
            {
                inhoud = "wat is 11 x 23",
                antwoord = "253",
                categorie = "wiskunde",
                moeilijkheidsgraad = 1
            },
                new Vraag()
            {
                inhoud = "welke kleur is een schaap?",
                antwoord = "Wit",
                categorie = "algemene kennis",
                moeilijkheidsgraad = 1
            },
                new Vraag()
            {
                inhoud = "Zijn alle insecten groen?" +
            "A: Ja" +
            "B: Nee",
                antwoord = "B",
                categorie = "algemene kennis",
                moeilijkheidsgraad = 1
            },
                new Vraag()
            {
                inhoud = "Kunnen alle vissen zwemmen?" +
            "A: Ja" +
            "B: Nee",
                antwoord = "A",
                categorie = "algemene kennis",
                moeilijkheidsgraad=2
            },
                new Vraag()
            {
                inhoud = "Welke kleur is een kameleon",
                antwoord = "elke",
                categorie = "striktvragen",
                moeilijkheidsgraad = 3
            },
                new Vraag()
            {
                inhoud = "Hoeveel minuten zitten er in een dag?",
                antwoord = "1440",
                categorie = "wiskunde",
                moeilijkheidsgraad = 2
            }
        };
        }
    }
}
