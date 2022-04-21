using System;

namespace BozziRecuperoAprile6
{
    class Program
    {
        static void Main(string[] args)
        {
            // In un vettore è contenuta la classifica di una gara podistica
            // con i nomi dei concorrenti in ordine di arrivo.
            // Dato il nome di un concorrente, stampa la sua posizione in classifica.
            // Se il nome non compare tra quelli caricati nel vettore, visualizza una segnalazione di errore.

            const int dimensione = 5;
            string[] classifica = new string[dimensione];

            // caricamento del vettore
            Console.WriteLine("Inserisci i nomi dei concorrenti in ordine di arrivo: ");
            for(int i=0; i<dimensione; i++)
            {
                classifica[i] = Console.ReadLine();
            }

            Console.WriteLine("Inserisci il nome del concorrente per il quale vuoi scoprire la posizione: ");
            string nome = Console.ReadLine();

            int posizione = -1;

            for (int i = 0; i < dimensione; i++)
            {
                if (nome == classifica[i])
                {
                    posizione = i;
                }
            }

            if (posizione >= 0)
            {
                Console.WriteLine("La posizione è " + (posizione+1));
            }
            else
            {
                Console.WriteLine("Nome non trovato");
            }
        }
    }
}
