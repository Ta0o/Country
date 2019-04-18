using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        public static void Create(ref int Count, ref String[] number, ref String[] names,ref String[] sex, ref String[] snames,ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname,ref String[] mothers, ref String[] fathers,ref String[] bornCd, ref String[] alive, ref String[] income,ref int money)
        {
            for (int i = Count; i != 20; i++)
            {
                Count += 1;
                if (i >= 10000)
                {
                    number[i] = Convert.ToString(i);
                }
                else if (i >= 1000)
                {
                    number[i] = Convert.ToString(i) + " ";
                }
                else if (i >= 100)
                {
                    number[i] = Convert.ToString(i) + "  ";
                }
                else if (i >= 10)
                {
                    number[i] = Convert.ToString(i) + "   ";
                }
                else
                {
                    number[i] = Convert.ToString(i) + "    ";
                }
                if (rnd.Next(1, 100) > 50)
                {
                    names[i] = Mname[rnd.Next(Mname.Length)];
                    sex[i] = "M";
                }
                else
                {
                    names[i] = Wname[rnd.Next(Mname.Length)];
                    sex[i] = "W";
                }
                snames[i] = Sname[rnd.Next(Sname.Length)];
                mothers[i] = " -   ";
                fathers[i] = " -   ";
                age[i] = Convert.ToString(rnd.Next(15, 30));
                bornCd[i] = Convert.ToString(0);
                alive[i] = "A L I V E";
            }
        }
        public static void Answer(ref String command, ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers,ref String[] bornCd,ref int gS,ref String[] alive ,ref int dCount,ref int tdCount, ref String[] income,ref int money,ref int everyYearTax)
        {
            switch (command)
            {
                case "/begin":
                    Console.Clear();
                    if (gS != 1)
                    {
                        Console.WriteLine("Before you destroy the country in connection with the remains of money in the treasury, I will give you not much.Well, a couple of millions can.");
                        MoneyGaining(5000000, ref money);
                        Create(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref alive,ref income,ref money);
                        gS = 1;
                        Console.WriteLine("First people arrived.");
                    }
                    else
                    {
                        Console.WriteLine("You already started game.");
                    }
                    break;
                case "/showAllPersons":
                    Console.Clear();
                    Console.WriteLine("Number| Name   | Surname |Gender|Mother | Father |   Age   | BornCooldown| is Alive | Income");
                    Console.WriteLine("-------------------------------------------------------------------------");
                    for (int i = 1; i != Count; i++)
                    {
                        if (i >= 10000)
                            {
                                number[i] = Convert.ToString(i);
                            }
                        else if (i >= 1000)
                            {
                                number[i] = Convert.ToString(i) + " ";
                            }
                        else if (i >= 100)
                            {
                                number[i] = Convert.ToString(i) + "  ";
                            }
                        else if (i >= 10)
                            {
                                number[i] = Convert.ToString(i) + "   ";
                            }
                        else
                            {
                                number[i] = Convert.ToString(i) + "    ";
                            }
                        sex[i] = sex[i] + "   ";
                        if (mothers[i] != " -   ")
                        {
                            if (Convert.ToInt16(mothers[i]) >= 10000)
                            {
                                mothers[i] = Convert.ToString(mothers[i]);
                            }
                            else if (Convert.ToInt16(mothers[i]) >= 1000)
                            {
                                mothers[i] = Convert.ToString(mothers[i]) + " ";
                            }
                            else if (Convert.ToInt16(mothers[i]) >= 100)
                            {
                                mothers[i] = Convert.ToString(mothers[i]) + "  ";
                            }
                            else if (Convert.ToInt16(mothers[i]) >= 10)
                            {
                                mothers[i] = Convert.ToString(mothers[i]) + "   ";
                            }
                            else
                            {
                                mothers[i] = Convert.ToString(mothers[i]) + "    ";
                            }
                        }
                        if (fathers[i] != " -   ")
                        {
                            if (Convert.ToInt16(fathers[i]) >= 10000)
                            {
                                fathers[i] = Convert.ToString(fathers[i]);
                            }
                            else if (Convert.ToInt16(fathers[i]) >= 1000)
                            {
                                fathers[i] = Convert.ToString(fathers[i]) + " ";
                            }
                            else if (Convert.ToInt16(fathers[i]) >= 100)
                            {
                                fathers[i] = Convert.ToString(fathers[i]) + "  ";
                            }
                            else if (Convert.ToInt16(fathers[i]) >= 10)
                            {
                                fathers[i] = Convert.ToString(fathers[i]) + "   ";
                            }
                            else
                            {
                                fathers[i] = Convert.ToString(fathers[i]) + "    ";
                            }
                        }
                        bornCd[i] = Convert.ToString(bornCd[i]) + "       ";
                        if (Convert.ToInt16(age[i]) >= 10000)
                        {
                           age[i] = Convert.ToString(age[i]);
                        }
                        else if (Convert.ToInt16(age[i]) >= 1000)
                        {
                            age[i] = Convert.ToString(age[i]) + " ";
                        }
                        else if (Convert.ToInt16(age[i]) >= 100)
                        {
                            age[i] = Convert.ToString(age[i]) + "  ";
                        }
                        else if (Convert.ToInt16(age[i]) >= 10)
                        {
                            age[i] = Convert.ToString(age[i]) + "   ";
                        }
                        else
                        {
                            age[i] = Convert.ToString(age[i]) + "    ";
                        }
                        Console.WriteLine(number[i] + " | " + names[i] + " | " + snames[i] + " | " + sex[i] + " | " + mothers[i] + " | " + fathers[i] + "  |  " + age[i]+"  |  " + bornCd[i] + " | "+ alive[i]);
                    }
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/showStats":
                    Console.Clear();
                    Console.WriteLine("Total people : " + Count +"\n"+ "Dead people : "+ dCount + "\n" + "People alive : ");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/commands":
                    Console.Clear();
                    Console.WriteLine("Write '/showStats' if you want to see how well you rule(bad).");
                    Console.WriteLine("Write '/showAllPersons' if you want to looking for the stupid little people.");
                    Console.WriteLine("Write '/nextTurn' if you are tired of listening to the current generation.");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/help":
                    Console.Clear();
                    Console.WriteLine("Hello, my lord."+"\n"+"If you came here, it means that you have never sowed tyranny in a small, inconspicuous country and did not follow silly little dogs."+"\n"+"In short, you need to make your country great, but some people do not speak much about cardinal politics, so it would not be bad to punish them."+"\n"+ "Write '/commands' to find possible commands.You are certainly omnipotent, but unfortunately you do not break some laws, such as physics, but common sense can be ignored.");
                    break;
                case "/nextTurn":
                    Console.Clear();
                    Born(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers,ref bornCd, ref alive, ref income, ref money,ref everyYearTax);
                    NextTurn(ref Count, ref  number, ref  names, ref sex, ref snames, ref age, rnd, Mname,  Wname,  Sname, ref mothers, ref fathers, ref bornCd, ref dCount, ref alive,ref tdCount, ref income,ref money,ref everyYearTax);
                    for (int i = 1; i != Count; i++)
                    {
                        if (alive[i] == "A L I V E")
                        { 
                        age[i] = Convert.ToString(Convert.ToInt32(age[i]) + 1);
                            if (Convert.ToInt32(bornCd[i]) != 0)
                            {
                                bornCd[i] = Convert.ToString(Convert.ToInt32(bornCd[i]) + 1);
                            }
                        }
                    }
                    MoneyGaining(everyYearTax,ref money);
                    Info(Count,dCount,tdCount,ref income,ref money,ref everyYearTax);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error. Unknown command.");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
            }
            
        }

        public static void Info(int Count, int dCount, int tdCount, ref String[] income, ref int money, ref int everyYearTax)
        {
            Console.Clear();
            Console.WriteLine("Total people : " + Count + "\n" + "Dead people : " + dCount + "\n" + "People alive : " + (Count - dCount) + "\n" + "Dead people today : " + tdCount + "\n" + "This year income : " + everyYearTax + "\n" + "Total money : " + money + "$ .");
            Console.WriteLine("Nice job.");
            Console.WriteLine("Write '/commands' if don’t know what to run the country.");
            Console.WriteLine("Write '/help' if don’t know what to run the country.");
        }
        public static void Born(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref String[] alive, ref String[] income,ref int money,ref int everyYearTax)
        {
            int f, m, a, d = 0, p = 0;
            a = 1;
            d = rnd.Next(0, 1)+1;
            while (a == 1)
            {
                f = rnd.Next(1, Count);
                m = rnd.Next(1, Count);
                if (Convert.ToInt32(bornCd[m]) == 0 && Convert.ToInt32(age[f]) > 16 && Convert.ToInt32(age[m]) > 16 && alive[m] == "Yes  " && alive[f] == "Yes  ")
                {
                    if (sex[f] == "M" && sex[m] == "W")
                    {
                        for (int i = Count; i < Count + d; i++)
                        {
                            number[i] = Convert.ToString(i);
                            if (rnd.Next(1, 100) > 50)
                            {
                                names[i] = Mname[rnd.Next(Mname.Length)];
                                sex[i] = "M";
                            }
                            else
                            {
                                names[i] = Wname[rnd.Next(Mname.Length)];
                                sex[i] = "W";
                            }
                            snames[i] = snames[f];
                            mothers[i] = Convert.ToString(m);
                            fathers[i] = Convert.ToString(f);
                            age[i] = Convert.ToString(0) + "  ";
                            bornCd[m] = Convert.ToString(2);
                            alive[i] = "Yes  ";
                            bornCd[i] = Convert.ToString(0);
                            p = p + 1;
                            if (p == 5) {
                                Console.WriteLine("It seems today no one gave birth");
                                i = Count + d;
                                a = 0;
                                break;
                            }
                        }
                        a = 0;
                        Count += d;

                    }
                }
            }
        }

        public static void NextTurn(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount, ref String[] income,ref int money,ref int everyYearTax)
        {
            int deadChance;
            deadChance = rnd.Next(2);
            for (int i = 1; i != Count; i++)
            {
                if (Convert.ToInt32(age[i]) < 10)
                {
                    deadChance += rnd.Next(5);
                }
                if (Convert.ToInt32(age[i]) >= 10 && Convert.ToInt32(age[i]) < 35)
                {
                    deadChance += rnd.Next(2);
                }
                if (Convert.ToInt32(age[i]) >= 35 && Convert.ToInt32(age[i]) < 60)
                {
                    deadChance += rnd.Next(3);
                }
                if (Convert.ToInt32(age[i]) >= 60 && Convert.ToInt32(age[i]) < 100)
                {
                    deadChance += rnd.Next(5);
                }
                if (Convert.ToInt32(age[i]) > 100)
                {
                    deadChance += rnd.Next(7);
                }
                if (deadChance > 95)
                {
                    alive[i] = " D e a d ";
                    dCount += 1;
                    tdCount += 1;
                }
            }
        }
        public static void IncomeGaining(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount,ref String[] income,ref int money,ref int everyYearTax)
        {
            for (int i = 1; i < Count; i++)
            {

            }
        }
        public static void MoneyGaining(int MoneyIncome,ref int money)
        { 
            money = money + MoneyIncome;
            Console.WriteLine("You gain : " + MoneyIncome + " $.");
            Console.WriteLine("Total money : "+ money + " $.");
        }

            static void Main(string[] args)
        {
            int a = 1,gS = 0;
            int Count = 0, dCount = 0;
            int tdCount = 0,money = 0, everyYearTax = 0;
            Random rnd = new Random();        
            String command;
            String[] number  = new String[99999];
            String[] names   = new String[99999];
            String[] snames  = new String[99999];
            String[] sex     = new String[99999];
            String[] fathers = new String[99999];
            String[] mothers = new String[99999];
            String[] bornCd  = new String[99999];
            String[] age     = new String[99999];
            String[] alive   = new String[99999];
            String[] income = new String[99999]; 

            String[] Mname = { "Vasja ", "Petya ", "Gorg  ","Alex  ", "Dima  ", "Arnold", "Kirill" };
            String[] Wname = { "Maria ", "Julia ", "Anna  ", "Nadya ", "Linda ", "Varia ", "Katya " };
            String[] Sname = { "Black  ", "Grey   ", "Brown  ", "Duck   ", "Stevens", "Weigel " };
            Console.WriteLine("Hello, enjoy world of DEAD and anarchy");
            Console.WriteLine("Write '/begin' to start the adventure in the rotten world of capitalism and dictatorship.");
            Console.WriteLine("Write '/help' to get help around the world of lies and power.");
            Console.WriteLine("Write '/commands' to get list of commands for controlled mortals.");
            while (a == 1)
            {
                command = Console.ReadLine();
                Answer(ref command, ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers,ref bornCd,ref gS, ref alive,ref dCount,ref tdCount,ref income, ref money,ref everyYearTax);
            }
        }
    }
}
