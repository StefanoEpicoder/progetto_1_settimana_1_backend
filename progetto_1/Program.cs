using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autovetture auto1 = new Autovetture();// istanzio la classe

            auto1.Marca = "BMW";// qui faccio il set

            Autovetture auto2 = new Autovetture();

            auto2.Marca = "Ford";// faccio il set di un'altra auto

            Console.WriteLine("Auto1: " + auto1.Marca);// qui faccio il get
            Console.WriteLine("\n");//nuova linea

            Console.WriteLine("Auto2: " + auto2.Marca);// qui faccio il get
            Console.WriteLine("\n");//nuova linea
            auto1.Marca = "Ferrari";

            Console.WriteLine("Auto1 Aggiornata: " + auto1.Marca);
            Console.WriteLine("\n");

            string Messaggio = auto1.kmTagliando(500); // richiamo un metodo passando un valore
            Console.WriteLine(Messaggio);
            Console.WriteLine("\n");

            string altroMessaggio = auto2.kmTagliando(15000);
            Console.WriteLine(altroMessaggio);
            Console.WriteLine("\n");


            //QUI PROCEDO CON L'ESERCIZIO ODIERNO

            Atleta giocatore1 = new Atleta();

            giocatore1.Nome = "Messi";

            Atleta giocatore2 = new Atleta();

            giocatore2.Nome = "Ronaldo";

            Console.WriteLine("giocatore1: " + giocatore1.Nome);
            Console.WriteLine("\n");

            Console.WriteLine("giocatore2: " + giocatore2.Nome);
            Console.WriteLine("\n");

            giocatore1.Nome = "Maradona";
            Console.WriteLine("Giocatore1 Aggiornato: " + giocatore1.Nome);
            Console.WriteLine("\n");

            string Messaggio1 = giocatore1.etaAnagrafica(36);
            Console.WriteLine(giocatore1.Nome + " è" + Messaggio1);
            Console.WriteLine("\n");

            string Messaggio2 = giocatore2.etaAnagrafica(25);
            Console.WriteLine(giocatore2.Nome + Messaggio2);
            Console.WriteLine("\n");

            Animali animale1 = new Animali();

            animale1.Specie = "Lofiforme";

            Animali animale2 = new Animali();

            animale2.Specie = "Barracuda";

            Console.WriteLine("Animale1: " + animale1.Specie);
            Console.WriteLine("\n");

            Console.WriteLine("Animale2: " + animale2.Specie);
            Console.WriteLine("\n");


            string Testo = animale1.profondità(4000);
            Console.WriteLine("Il " + animale1.Specie + Testo);
            Console.WriteLine("\n");

            string Testo2 = animale2.profondità(100);
            Console.WriteLine("Il " + animale2.Specie + Testo2);
            Console.WriteLine("\n");



            Console.ReadLine();// attendo un input (tips per non fermare l'esecuzione)

        }
    }
}
