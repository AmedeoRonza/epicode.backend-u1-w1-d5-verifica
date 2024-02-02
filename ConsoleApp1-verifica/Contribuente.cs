using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_verifica
{
    // dichiarazione di classe
    internal class Contribuente 
    {
        private string _nome;
        private string _cognome;
        private DateTime _dataNascita;
        private string _codiceFiscale;
        private char _sesso;
        private string _comuneResidenza;
        private decimal _redditoAnnuale;
        private decimal _imposta;

        // get e set
        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public char Sesso
        {
            get { return _sesso; }
            set { _sesso = value; }
        }

        public string ComuneResidenza
        {
            get { return _comuneResidenza; }
            set { _comuneResidenza = value; }
        }

        public decimal RedditoAnnuale
        {
            get { return _redditoAnnuale; }
            set { _redditoAnnuale = value; }
        }

        // Costruttore della classe

        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        // Metodo per calcolare l'imposta in base al reddito annuale
        public decimal CalcolaImposta()
        {
            

            decimal imposta = 0;

            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }
            else if (RedditoAnnuale > 15000 && RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }
            else if (RedditoAnnuale > 28000 && RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }
            else if (RedditoAnnuale > 55000 && RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
            }

            Console.WriteLine("Imposta da pagare: $ " + imposta);
            return imposta;
            
        }

        // Metodo per ottenere e stampare i dettagli in console
        public void GetDettagli()
        {
            Console.WriteLine("\n---------------------------------------------" + "\n" + "\n");
            Console.WriteLine("I dettagli del contribuente sono: ");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cognome: " + Cognome);
            Console.WriteLine("Data di nascita: " + DataNascita);
            Console.WriteLine("Codice Fiscale: " + CodiceFiscale);
            Console.WriteLine("Sesso: " + Sesso);
            Console.WriteLine("Comune di residenza: " + ComuneResidenza);
            Console.WriteLine("Reddito annuale: $ " + RedditoAnnuale);
            decimal imposta = CalcolaImposta();         
            Console.ReadLine();
        }
        
    }
}

