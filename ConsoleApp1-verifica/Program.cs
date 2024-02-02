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
            // costruzione del tutto 

            Console.Write("MODULO CALCOLO IMPOSTA BASATO SUL REDDITO: " + "\n" + "\n");
            Console.Write("Inserisci il nome del contribuente: ");
            string nome = Console.ReadLine();

            Console.Write("Inserisci il cognome del contribuente: ");
            string cognome = Console.ReadLine();

            Console.Write("Inserisci la data di nascita del contribuente (formato: YYYY-MM-DD): ");
            DateTime dataNascita;
            while (true) // controllo della data di nascita affinchè funzioni solo con date superiori al 1900
            {
                if (DateTime.TryParse(Console.ReadLine(), out dataNascita) && dataNascita.Year >= 1900)
                {
                    break; // il break blocca il ciclo
                }
                else
                {
                    Console.WriteLine("Inserisci una data di nascita valida e successiva al 1900. Riprova:");
                }
            }

            Console.Write("Inserisci il codice fiscale del contribuente: ");
            string codiceFiscale = Console.ReadLine();
            while (codiceFiscale.Length != 16) // controllo sulla lunghezza del codice fiscale
            {
                Console.WriteLine("Il codice fiscale deve essere composto da 16 caratteri. Riprova.");
                Console.Write("Inserisci il codice fiscale del contribuente (16 caratteri): ");
                codiceFiscale = Console.ReadLine();
            }

            Console.Write("Inserisci il sesso del contribuente (M/F): ");
            char sesso;
            while (true) // controllo per la risposta al sesso unicamente con M o F
            {
                string input = Console.ReadLine();

                if (input.Length == 1 && (input[0] == 'M' || input[0] == 'm' || input[0] == 'F' || input[0] == 'f'))
                {
                    sesso = char.ToUpper(input[0]);
                    break; // il break blocca anche qui il ciclo
                }
                else
                {
                    Console.WriteLine("Inserisci un sesso valido (M o F). Riprova:");
                }
            }

            Console.Write("Inserisci il comune di residenza del contribuente: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Inserisci il reddito annuale del contribuente: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            Console.ReadLine();

            // costruttore:

            Contribuente Contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);
            Contribuente.CalcolaImposta(); // chiamata funzione
            Contribuente.GetDettagli(); // chiamata funzione

        }
    }
}
