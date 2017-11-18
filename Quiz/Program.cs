using System;

namespace Quiz
{
    class Program
    { 
        int answerscorrect = 0;

        static void Main(string[] args)
        {
            Vraag vraag1 = new Vraag()
            {
                inhoud = "wat is 11 x 23",
                antwoord = "253"
            };
            Vraag vraag2 = new Vraag()
            {
                inhoud = "welke kleur is een schaap?",
                antwoord = "Wit" 
            };
            Vraag vraag3 = new Vraag()
            {
                inhoud = "Zijn alle insecten groen?" +
            "A: Ja" +
            "B: Nee",
                antwoord = "B"
            };
            Vraag vraag4 = new Vraag()
            {
                inhoud = "Kunnen alle vissen zwemmen?" +
            "A: Ja" +
            "B: Nee",
                antwoord = "A"
            };
            Vraag vraag5 = new Vraag()
            {
                inhoud = "Hoeveel minuten zitten er in een dag?",
                antwoord = "1440"
            };
            Vraag vraag6 = new Vraag()
            {
                inhoud = "Welke kleur is een kameleon",
                antwoord = "elke"
            };
        }
    }
}
