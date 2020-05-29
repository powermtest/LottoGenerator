using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LottoGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var sciezkaPliku = @"C:\Users\Public\TestFolder\WriteLines.txt";
            //if (File.Exists(sciezkaPliku)) File.Delete(sciezkaPliku);

            void siedem()
            {
                var sciezkaPliku = @"C:\Users\Public\TestFolder\WriteLines.txt";
                //if (File.Exists(sciezkaPliku)) File.Delete(sciezkaPliku);
                var pierwszaLiczba = 1;
                var drugaliczba = 1;
                var trzeciaLiczba = 1;
                var czwartaLiczba = 1;
                var piataLiczba = 1;
                var szostaLiczba = 1;
                var siodmaLiczba = 1;
                var i = 49;
                var ii = 47;
                var iii = 0;
                var iv = 0;
                var v = 0;
                var vi = 0;
                var vii = 0;
                var calosc = new List<string>();
                var unikalne = new List<string>();
                var licznik = 0;
                var grupaSiedem = new int[7];
                var siodemki = string.Empty;
                ;

                Console.WriteLine("Zaczynamy! Będę pokazywać tylko progress drugich liczb");

                for (var j = 0; j < 51; j++)
                {
                    if (vii != vi &&
                        v != iv && v != iii && v != ii && v != i &&
                        iv != iii && iv != ii && iv != i && iv != v &&
                        iii != ii && iii != i && iii != v && iii != iv &&
                        ii != i && ii != v && ii != iv && ii != iii &&
                        i != v && i != iv && i != iii && i != ii)
                    {
                        //posortowac 'siodemki' grupami 5/2
                        int[] grupaPiec =
                        {
                            pierwszaLiczba + i, drugaliczba + ii, trzeciaLiczba + iii, czwartaLiczba + iv,
                            piataLiczba + v
                        };
                        Array.Sort(grupaPiec);
                        int[] grupaDwa = {szostaLiczba + vi, siodmaLiczba + vii};
                        Array.Sort(grupaDwa);
                        Array.Copy(grupaPiec, 0, grupaSiedem, 0, 5);
                        Array.Copy(grupaDwa, 0, grupaSiedem, 5, 2);
                        
                        siodemki = string.Join(" ", grupaSiedem.ToArray());
                        calosc.Add(siodemki);
                    }


                    vii++;

                    if (vii == 10)
                    {
                        vii = 0;
                        j = 0;
                        vi++;
                    }

                    if (vi == 10)
                    {
                        vii = 0;
                        vi = 0;
                        j = 0;
                        v++;
                        //Console.WriteLine("szóste liczby" + v);
                    }

                    if (v == 50)
                    {
                        vii = 0;
                        vi = 0;
                        v = 0;
                        j = 0;
                        iv++;
                        //Console.WriteLine("piąte liczby " + iv);
                    }

                    if (iv == 50)
                    {
                        vii = 0;
                        vi = 0;
                        v = 0;
                        iv = 0;
                        j = 0;
                        iii++;
                        //Console.WriteLine("czwarte liczby " + iii);
                    }

                    if (iii == 50)
                    {
                        vii = 0;
                        vi = 0;
                        v = 0;
                        iv = 0;
                        iii = 0;
                        j = 0;
                        ii++;
                        Console.WriteLine("trzecie liczby " + ii);
                        Console.WriteLine("Zaczynam sortowanie");
                        unikalne = calosc.Distinct().ToList();
                        File.AppendAllLines(sciezkaPliku, unikalne);
                        unikalne.Clear();
                        calosc.Clear();
                    }

                    if (ii == 50)
                    {
                        vii = 0;
                        vi = 0;
                        v = 0;
                        iv = 0;
                        iii = 0;
                        ii = 0;
                        j = 0;
                        i++;
                        Console.WriteLine("drugie liczby " + i);

                        //Console.WriteLine("Zaczynam sortowanie");
                        //unikalne = calosc.Distinct().ToList();
                        //File.AppendAllLines(sciezkaPliku, unikalne);
                        //unikalne.Clear();
                        //calosc.Clear();

                        //calosc.Sort();
                        //Console.WriteLine("Szukam duplikatów");
                        //for (int k = 0; k < calosc.Count - 1; k++)
                        //{
                        //    if (calosc.ElementAt(k) == calosc.ElementAt(k + 1))
                        //    {
                        //        calosc.RemoveAt(k + 1);
                        //        k--;
                        //        //Console.WriteLine("Znalazłem duplikat!");
                        //    }
                        //}
                        //Console.WriteLine("Zapisuję do pliku");
                        //File.AppendAllLines(sciezkaPliku, calosc);

                        //calosc.Clear();
                    }

                    if (i == 50)
                    {
                        vii = 0;
                        vi = 0;
                        v = 0;
                        iv = 0;
                        iii = 0;
                        ii = 0;
                        j = 51;
                    }
                }

                Console.WriteLine("Zapisuję dane do pliku!");
                //File.AppendAllLines(sciezkaPliku, calosc);
            }

            void sortujPlik() //metoda wydaje sie dzialac - potrzebna lepsza optymalizacja procesu wytwarzania danych w 'siedem'
            {
                var sciezkaPliku = @"C:\Users\Public\TestFolder\WriteLines.txt";
                var plikJakoString = string.Empty;

                //String[] calyPlik = File.ReadAllLines(sciezkaPliku);
                //calyPlik.Distinct();
                string[] calyPlikLista = File.ReadAllLines(sciezkaPliku);
                //plikJakoString = string.Join(" ", calyPlikLista.ToArray());

                

                //Array.Sort(calyPlikLista);
                var unikalne = calyPlikLista.Distinct().ToList();
                


                var sciezkaNowegoPliku = @"C:\Users\Public\TestFolder\NowyPlik.txt";
                //File.Create(sciezkaNowegoPliku);
                File.WriteAllLines(sciezkaNowegoPliku,unikalne);
            }

            //siedem();
            sortujPlik();
            Console.WriteLine("Koniec");
            Console.ReadKey();
        }
    }
}