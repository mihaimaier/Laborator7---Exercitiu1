using System;

namespace Laborator7___Exercitiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator 7 - Exerictiu 1 - Poker

            // Scrieți un program care va modela o mână de poker. 
            // Mâna e poker conține 5 cărți. Cărțile vor avea valori de la 1 la 14 și vor putea fi de mai multe tipuri:

            // Inimă roșie 
            // Inimă neagră
            // Romb
            // Trifoi

            // Creați o metoda prin intermediul căreia mâna de poker va putea fi tipărită pe ecran.
            // Creați o metodă care va determina tipul mâinii de poker. 
            // Dacă toate cărțile sunt inimă neagră, vom avea un royal flush, dacă toate cărțile sunt inimă roșie, mâna va fi de tipul
            // straight flush, iar dacă va conține 4 carți cu aceiași valoare vom mâna va fi four of a kind. In orice altă situație, mâna va fi comună.
            // Hint: folosiți enumerații
            // În metoda main creeați mai multe mâini de poker, tipăriți - le, determinați - le tipul și afișați - l pe ecra

            // Exemplu Royal Flush

            Cartea Cartea1 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.AS);
            Cartea Cartea2 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.AS);
            Cartea Cartea3 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.AS);
            Cartea Cartea4 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.AS);
            Cartea Cartea5 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.DOI);

            Mana mana = new Mana(Cartea1,Cartea2,Cartea3,Cartea4,Cartea5);
            mana.Tipareste();
            mana.GetMana();

            Console.WriteLine();

            // Exemplu Straight Flush
            
            Cartea Cartea6 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.PATRU);
            Cartea Cartea7 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.PATRU);
            Cartea Cartea8 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.PATRU);
            Cartea Cartea9 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.PATRU);
            Cartea Cartea10 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.AS);

            Mana mana2 = new Mana(Cartea6, Cartea7, Cartea8, Cartea9, Cartea10);
            mana2.Tipareste();
            mana2.GetMana();

            Console.WriteLine();

            // Exemplu Four of a Kind

            Cartea Cartea11 = new Cartea(Cartea.Culori.Trifoi, Cartea.Valori.PATRU);
            Cartea Cartea12 = new Cartea(Cartea.Culori.Trifoi, Cartea.Valori.PATRU);
            Cartea Cartea13 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.PATRU);
            Cartea Cartea14 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.PATRU);
            Cartea Cartea15 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.AS);

            Mana mana3 = new Mana(Cartea11, Cartea12, Cartea13, Cartea14, Cartea15);
            mana3.Tipareste();
            mana3.GetMana();

            Console.WriteLine();

            // Exemplu Comun

            Cartea Cartea16 = new Cartea(Cartea.Culori.Trifoi, Cartea.Valori.DOI);
            Cartea Cartea17 = new Cartea(Cartea.Culori.InimaNeagra, Cartea.Valori.TREI);
            Cartea Cartea18 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.AS);
            Cartea Cartea19 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.AS);
            Cartea Cartea20 = new Cartea(Cartea.Culori.InimaRosie, Cartea.Valori.AS);

            Mana mana4 = new Mana(Cartea16, Cartea17, Cartea18, Cartea19, Cartea20);
            mana4.Tipareste();
            mana4.GetMana();
        }
    }
}
