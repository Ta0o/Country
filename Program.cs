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
        public static void Create(ref int Count, ref String[] number, ref String[] names,ref String[] sex, ref String[] snames,ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname,ref String[] mothers, ref String[] fathers,ref String[] bornCd, ref String[] alive, ref String[] income,ref int money,ref int taxRate)
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
                income[i] = Convert.ToString(rnd.Next(1500,4000));
                alive[i] = "A L I V E";
            }
        }
        public static void Answer(ref String command, ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers,ref String[] bornCd,ref int gS,ref String[] alive ,ref int dCount,ref int tdCount, ref String[] income,ref int money,ref int everyYearTax,ref int taxRate)
        {
            switch (command)
            {
                case "/begin":
                    Console.Clear();
                    if (gS != 1)
                    {
                        Console.WriteLine("Before you destroy the country in connection with the remains of money in the treasury, I will give you not much.Well, a couple of millions can.");
                        MoneyGaining(5000000, ref money);
                        Create(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref alive,ref income,ref money,ref taxRate);
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
                    Console.WriteLine("Number| Name   | Surname |Gender|Mother | Father |   Age   |BornCooldown| is Alive | Income");
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
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
                        bornCd[i] = Convert.ToString(bornCd[i]) + "      ";
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
                        Console.WriteLine(number[i] + " | " + names[i] + " | " + snames[i] + " | " + sex[i] + " | " + mothers[i] + " | " + fathers[i] + "  |  " + age[i]+"  |  " + bornCd[i] + "   | "+ alive[i]+ "| "+income[i]+ " $");
                    }
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/showStats":
                    Console.Clear();
                    Console.WriteLine("Total people : " + Count + "\n" + "Dead people : " + dCount + "\n" + "People alive : " + (Count - dCount) + "\n" + "Dead people today : " + tdCount + "\n" + "This year income : " + everyYearTax + "\n" + "Total money : " + money + "$ .");
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
                    tdCount = 0;
                    Born(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers,ref bornCd, ref alive, ref income, ref money,ref everyYearTax,ref taxRate);
                    NextTurn(ref Count, ref  number, ref  names, ref sex, ref snames, ref age, rnd, Mname,  Wname,  Sname, ref mothers, ref fathers, ref bornCd, ref dCount, ref alive,ref tdCount, ref income,ref money,ref everyYearTax,ref taxRate);
                    for (int i = 1; i != Count; i++)
                    {
                        if (alive[i] == "A L I V E")
                        { 
                        age[i] = Convert.ToString(Convert.ToInt32(age[i]) + 1);
                            if (Convert.ToInt32(bornCd[i]) != 0)
                            {
                                bornCd[i] = Convert.ToString(Convert.ToInt32(bornCd[i]) - 1);
                            }
                        }
                    }
                    IncomeGaining(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref  dCount, ref alive, ref  tdCount, ref income, ref money, ref everyYearTax, ref  taxRate);
                    MoneyGaining(everyYearTax,ref money);
                    Info(Count,dCount,tdCount,ref income,ref money,ref everyYearTax,ref taxRate);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error. Unknown command.");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
            }
            
        }
        public static void Info(int Count, int dCount, int tdCount, ref String[] income, ref int money, ref int everyYearTax,ref int taxRate)
        {
            Console.Clear();
            Console.WriteLine("Total people : " + Count + "\n" + "Dead people : " + dCount + "\n" + "People alive : " + (Count - dCount) + "\n" + "Dead people today : " + tdCount + "\n" + "This year income : " + everyYearTax +"$."+ "\n" + "Total money : " + money + "$ .");
            Console.WriteLine("Nice job.");
            Console.WriteLine("Write '/commands' if don’t know what to run the country.");
            Console.WriteLine("Write '/help' if don’t know what to run the country.");
        }
        public static void Born(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref String[] alive, ref String[] income,ref int money,ref int everyYearTax,ref int taxRate)
        {// метод отвественный за создание новых людей, выберается 2 случайных человека мужского и женского пола, вписываются определенные параметры, вызывается командой "/nextTurn"
            int f, m, d = 0,b = 0,a = rnd.Next(100);
            d = rnd.Next(0,2);
            if (d == 0)
            {
                Console.WriteLine("It seems nobody want to born little slaves.");
            }
            while (d == 1)
            {
                f = rnd.Next(1, Count);
                m = rnd.Next(1, Count);
                if (Convert.ToInt32(bornCd[m]) == 0 && Convert.ToInt32(age[f]) > 16 && Convert.ToInt32(age[m]) > 16 && alive[m] == "A L I V E" && alive[f] == "A L I V E" && sex[f] == "M" && sex[m] == "W")
                {
                    for (int i = Count; i < Count + d; i++)
                    {
                        number[i] = Convert.ToString(i);
                        if (a < 50)
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
                        age[i] = "0";
                        bornCd[m] = "2";
                        alive[i] = "A L I V E";
                        bornCd[i] = "0";
                        income[i] = "0";
                        Count += 1;
                        d -= 1;
                    }
                    b += 1;
                    if (b == 5)
                    {
                        d = 0;
                    }
                }
            }
        }
        public static void NextTurn(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount, ref String[] income, ref int money, ref int everyYearTax, ref int taxRate)
        {//метод отвечающий за возможность умереть каждого человека (0%-7%), применяется при команде "/nextTurn"
            int deadChance;
            deadChance = rnd.Next(2);
            for (int i = 1; i < Count; i++) { 

                if (alive[i] == "A L I V E")
                {
                    if (Convert.ToInt32(age[i]) < 10)
                    {
                        deadChance += rnd.Next(3);
                    }
                    if (Convert.ToInt32(age[i]) >= 10 && Convert.ToInt32(age[i]) < 35)
                    {
                        deadChance += rnd.Next(1);
                    }
                    if (Convert.ToInt32(age[i]) >= 35 && Convert.ToInt32(age[i]) < 60)
                    {
                        deadChance += rnd.Next(2);
                    }
                    if (Convert.ToInt32(age[i]) >= 60 && Convert.ToInt32(age[i]) < 100)
                    {
                        deadChance += rnd.Next(3);
                    }
                    if (Convert.ToInt32(age[i]) > 100)
                    {
                        deadChance += rnd.Next(5);
                    }
                    if (deadChance > rnd.Next(100)+1)
                    {
                        alive[i] = " D e a d ";
                        dCount += 1;
                        tdCount += 1;
                    }
                }
            }
        }
        public static void IncomeGaining(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount,ref String[] income,ref int money,ref int everyYearTax,ref int taxRate)
        {//метод отвечающий за обсчет налогов, вызывается командой "/nextTurn"
            everyYearTax = 0;
            for (int i = 1; i < Count; i++)
            {
                if (alive[i] != " D e a d ")
                {
                    everyYearTax = everyYearTax + (Convert.ToInt16(income[i]) / 100) * taxRate;// обсчет налога среди всех жителей
                }
            }
        }
        public static void MoneyGaining(int MoneyIncome,ref int money)
        { 
            money = money + MoneyIncome;
            Console.WriteLine("You gain : " + MoneyIncome + " $.");
            Console.WriteLine("Total money : "+ money + " $.");
        }
        public static void Main(string[] args)
        {
            int a = 1;// переменная отвечающая за бесконечный цикл запросов команды
            int gS = 0;// переменная отвечающая за начало игры(0 - игра не начата,могут возникать ошибки, пока не исправлено, 1 - игра начата, повторно игру не начать)
            int Count = 0;// общее количество людей
            int dCount = 0;// общее количество умерших людей
            int taxRate = 13;// ставка налога от доходов
            int tdCount = 0;//количество людей умершее в этот год(ход)
            int money = 0;//количество денег на счету
            int everyYearTax = 0;//переменная обозначает общее увечеличенее денег в этом году (ходу)
            Random rnd = new Random();//создание объекта для генерации случайных значений    
            String command;//переменная команды
            String[] number  = new String[99999];// массив порядкового номера каждого человека
            String[] names   = new String[99999];// массив имен
            String[] snames  = new String[99999];// массив фамилий
            String[] sex     = new String[99999];// массив отвечающий за пол
            String[] fathers = new String[99999];// массив отвечающий за порядковый номер отца (при рождении ребенка, при изначальном значении равен "-")
            String[] mothers = new String[99999];// массив отвечающий за порядковый номер матери (при рождении ребенка, при изначальном значении равен "-")
            String[] bornCd  = new String[99999];// время которое должно пройти с момента рождения ребенка женщиной, до следуйщего рождения
            String[] age     = new String[99999];// массив возрастов
            String[] alive   = new String[99999];// идикатор отвечающий за жизнь или смерть человека
            String[] income  = new String[99999];// доход человека(родившиеся дети не имеют дохода)

            String[] Mname = { "Vasja ", "Petya ", "Gorg  ","Alex  ", "Dima  ", "Arnold", "Kirill" };//возможные имена для людей мужского пола
            String[] Wname = { "Maria ", "Julia ", "Anna  ", "Nadya ", "Linda ", "Varia ", "Katya " };//возможные имена для людей женского пола
            String[] Sname = { "Black  ", "Grey   ", "Brown  ", "Duck   ", "Stevens", "Weigel " };// возможные фамилии
           
            
            
            Console.WriteLine("Hello, enjoy world of DEAD and anarchy");// что-то типо вступления
            Console.WriteLine("Write '/begin' to start the adventure in the rotten world of capitalism and dictatorship.");
            Console.WriteLine("Write '/help' to get help around the world of lies and power.");
            Console.WriteLine("Write '/commands' to get list of commands for controlled mortals.");
            while (a == 1)//бесконечный цикл
            {
                command = Console.ReadLine();//запрос команды
                Answer(ref command, ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers,ref bornCd,ref gS, ref alive,ref dCount,ref tdCount,ref income, ref money,ref everyYearTax,ref taxRate);//вызов метода который отвечает на команду,исходный код со строки 57.
            }
        }
    }
}
