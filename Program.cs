using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Listen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 1
            //Erzeugen Sie ein Array mit 4 Zeilen und 4 Spalten.
            //Die Einträge sollen mit Zufallszahlen von 1-99
            //befüllt werden.
            //Geben Sie das Array in der Console aus.
            //Geben Sie nur die Diagonale des Arrays in der Console aus.

            int[,] Tabelle = new int[4,4];
            Random rnd = new Random();
            //Erzeugen
            for (int i = 0; i < Tabelle.GetLength(0); i++)
            {
                for (int j = 0; j < Tabelle.GetLength(1); j++)
                {
                    Tabelle[i, j] = rnd.Next(0, 100);
                }                
            }
            //Ausgabe in die Console
            for (int i = 0; i < Tabelle.GetLength(0); i++)
            {
                
                for (int j = 0; j < Tabelle.GetLength(1); j++)
                {
                    Console.Write(Tabelle[i, j] + "\t");
                }
                Console.Write("\n");
            }
            //Ausgabe der Diagonalelemente in einer Zeile
            Console.Write("\n");
            for (int i = 0; i < Tabelle.GetLength(0); i++)
            {
                Console.Write(Tabelle[i, i] + "\t");
            }

            //Aufgabe 2:
            //Erzeugen Sie ein eindimansionales Array mit sieben Enträgen
            //von Zahlen 1-99.
            //Geben Sie die Summe aller Einträge aus und die Größte Zahl des Array.
            
            Console.Write("\n");
            int[] array1D = new int[7];
            for (int i = 0; i < array1D.Length; i++)
            {
                array1D[i] = rnd.Next(1, 100);
            }
            Console.Write("\n");
            for (int i = 0; i < array1D.Length; i++)
            {
                Console.Write(array1D[i]+"\t");
            }
            Console.Write("\n");
            int summe = 0;
            for (int i = 0; i < array1D.Length; i++)
            {
                summe += array1D[i];
            }
            int max = 0;
            for (int i = 0; i < array1D.Length; i++)
            {
                if (array1D[i] > max) max = array1D[i];
            }
            Console.WriteLine("Summe aller Elemente = " + summe + "\n" +
                              "größtes Element = " + max);
            Console.WriteLine("Maximum=" + array1D.Max());
            Console.WriteLine("Summe=" + array1D.Sum());
            //Geben Sie das Array in umgekehrter Reihenfolge aus.
            Console.Write("\n");
            for (int i = array1D.Length-1; i >= 0; i--)
            {
                Console.Write(array1D[i]+"\t");
            }
            Console.Write("\n");
            //Geben Sie das Array von klein nach groß sortiert aus.
        }
    }
}
