using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_verifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il nome del contribuente: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci il cognome del contribuente: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserisci la data di nascita del contribuente (formato: YYYY-MM-DD): ");
            DateTime dataNascita = DateTime.Parse(Console.ReadLine());

            Console.Write("Inserisci il codice fiscale del contribuente: ");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Inserisci il sesso del contribuente (M/F): ");
            char sesso = char.Parse(Console.ReadLine());

            Console.Write("Inserisci il comune di residenza del contribuente: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Inserisci il reddito annuale del contribuente: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            Console.ReadLine();

            Contribuente Contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);
            Contribuente.CalcolaImposta();
            Contribuente.GetDettagli();

        }
    }
}
