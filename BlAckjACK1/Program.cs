﻿using System;

namespace BlackJack_1

{
    class program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Välkommen till 21!");
            Console.WriteLine("1. Spela 21:an");
            Console.WriteLine("2. Visa senaste vinnaren");
            Console.WriteLine("3. Spelets regler");
            Console.WriteLine("4. Avsluta Programmet");
            int val = int.Parse(Console.ReadLine());
            Random slump = new Random();

            switch (val)

            {

                case 1:
                    int spelareSum = 0;
                    int datorsum = 0;
                    int Spelare = slump.Next(1, 11);
                    int Spelare2 = slump.Next(1, 11);
                    datorsum += slump.Next(1, 11);
                    datorsum += slump.Next(1, 11);
                    while (spelareSum <= 21)
                    {


                        Console.WriteLine("Nu kommer två kort att dras");
                        Console.WriteLine("Din poäng:" + (Spelare + Spelare2));
                        Console.WriteLine("Datorns poäng:" + (datorsum));
                        Console.WriteLine("Vill du dra ett till kort? (j/n)");

                        string val2 = Console.ReadLine();

                        switch (val2[0])
                        {
                            case 'j':


                                spelareSum += Spelare + Spelare2;

                                int nyPoäng = slump.Next(1, 11);
                                spelareSum += nyPoäng;
                                Console.WriteLine($"Ditt kortdrag är värt: {nyPoäng}");
                                Console.WriteLine($"Din nya poäng är: {spelareSum}");
                                if (spelareSum > 21)
                                {
                                    Console.WriteLine("Du har förlorat");
                                }



                                break;

                            case 'n':
                                if (datorsum > 21)
                                {

                                }
                                int nyPoäng2 = slump.Next(1, 11);
                                datorsum += nyPoäng2;
                                Console.WriteLine("Datorn kommer att dra ett till kort...");
                                Console.WriteLine($"Ditt kortdrag är värt: {nyPoäng2}");
                                Console.WriteLine($"Din nya poäng är: {datorsum}");
                                break;
                        }
                    }
                    break;


                case 2:
                    Console.WriteLine();
                    break;

                case 3:
                    string text = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(20);
                    }

                    Console.WriteLine("");

                    string text2 = "Du får poäng genom att dra kort, varje kort har 1-10 poäng.";
                    foreach (char e in text2)
                    {
                        Console.Write(e);
                        Thread.Sleep(20);
                    }

                    Console.WriteLine("");

                    string text3 = "Om du får mer än 21 poäng har du förlorat.";
                    foreach (char f in text3)
                    {
                        Console.Write(f);
                        Thread.Sleep(20);
                    }

                    Console.WriteLine("");

                    string text4 = "Både du och datorn får två kort i början. Du ska dra kort till du är nöjd eller får över 21.";
                    foreach (char g in text4)
                    {
                        Console.Write(g);
                        Thread.Sleep(20);
                    }

                    Console.WriteLine("");

                    string text5 = "När du är färdig drar datorn kort till den har mer poäng än dig eller över 21 poäng.";
                    foreach (char h in text5)
                    {
                        Console.Write(h);
                        Thread.Sleep(20);
                    }

                    Console.WriteLine("");
                    string text6 = "Ditt mål är att tvinga datorn att få mer än 21 poäng.";
                    foreach (char i in text6)
                    {
                        Console.Write(i);
                        Thread.Sleep(20);
                    }
                    break;

                case 4:
                    Console.WriteLine("Programmet har avslutats.....");
                    break;

                default:
                    Console.WriteLine("Du valde inte ett giltig alternativ");
                    break;

            }


        }
    }
}
