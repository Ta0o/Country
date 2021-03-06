﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Create(ref int Count, ref String[] number, ref String[] names,ref String[] sex, ref String[] snames,ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname,ref String[] mothers, ref String[] fathers,ref String[] bornCd, ref String[] alive, ref String[] income,ref int money,ref int taxRate,ref int hospital,ref int supermarket,ref int police,ref int firestation,ref int maternity)
        {// метод начала игры вызывается командой "/begin", создает x случайных людей
            for (int i = Count; i < 100; i++)
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
                    names[i] = Wname[rnd.Next(Wname.Length)];
                    sex[i] = "W";
                }
                snames[i] = Sname[rnd.Next(Sname.Length)];
                mothers[i] = " -   ";
                fathers[i] = " -   ";
                age[i] = Convert.ToString(rnd.Next(10, 20));
                bornCd[i] = Convert.ToString(0);
                income[i] = Convert.ToString(rnd.Next(1000,7000));
                alive[i] = "A L I V E";
            }
        }
        public static void Answer(ref String command, ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers,ref String[] bornCd,ref int gS,ref String[] alive ,ref int dCount,ref int tdCount, ref String[] income,ref int money,ref int everyYearTax,ref int taxRate,ref int hospital,ref int supermarket,ref int police,ref int firestation,ref int maternity)
        {//метод обработки запроса
            switch (command)
            {
                case "/begin"://начало игры
                    Console.Clear();
                    if (gS != 1)
                    {
                        Console.WriteLine("Before you destroy the country in connection with the remains of money in the treasury, I will give you not much.Well, a couple of millions can.");
                        MoneyGaining(5000000, ref money);
                        Create(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref alive,ref income,ref money,ref taxRate,ref hospital,ref supermarket,ref police,ref firestation,ref maternity);
                        gS = 1;
                        Console.WriteLine("First people arrived.");
                    }
                    else
                    {
                        Console.WriteLine("You already started game.");
                    }
                    break;
                case "/showAllPersons":// информация о всех людях
                    if (gS != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Rulling didnt started yet.");
                        break;
                    }
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
                case "/showStats"://глобальная статистика на текущий ход
                    if (gS != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Rulling didnt started yet.");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Total people : " + Count + "\n" + "Dead people : " + dCount + "\n" + "People alive : " + (Count - dCount) + "\n" + "Dead people today : " + tdCount + "\n" + "This year income : " + everyYearTax + "\n" + "Total money : " + money + "$ .");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/commands":// список команд
                    Console.Clear();
                    Console.WriteLine("Write '/begin' to start the adventure in the rotten world of capitalism and dictatorship.");
                    Console.WriteLine("Write '/showStats' if you want to see how well you rule(bad).");
                    Console.WriteLine("Write '/showAllPersons' if you want to looking for the stupid little people.");
                    Console.WriteLine("Write '/nextTurn' if you are tired of listening to the current generation.");
                    Console.WriteLine("Write '/build' to spend money of your country.");
                    Console.WriteLine("WWrite '/personManipulating'if you want to play with your slaves.");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    Console.WriteLine("write '/info' if u forget about your evils");
                    break;
                case "/info":
                    if (gS != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Rulling didnt started yet.");
                        break;
                    }
                    Console.Clear();
                    Info(Count, dCount,  tdCount, ref  income, ref  money, ref everyYearTax, ref  taxRate, ref hospital, ref supermarket, ref police, ref firestation, ref maternity);
                    break;
                case "/help"://общие слова по поводу игры
                    Console.Clear();
                    Console.WriteLine("Hello, my lord."+"\n"+"If you came here, it means that you have never sowed tyranny in a small, inconspicuous country and did not follow silly little dogs."+"\n"+"In short, you need to make your country great, but some people do not speak much about cardinal politics, so it would not be bad to punish them."+"\n"+ "Write '/commands' to find possible commands.You are certainly omnipotent, but unfortunately you do not break some laws, such as physics, but common sense can be ignored.");
                    break;
                case "/build":
                    if (gS != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Rulling didnt started yet.");
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Here you can buy buildings for mobey from Country budget. I enjoy spending money, espesially if they are not mine.");
                    Console.WriteLine("Hospital - reduce chances of death for nearly 1%. Cost "+1000000*(hospital+1)+" $. Write /hospital");
                    Console.WriteLine("Supermarket - increase income for 3% per person. Cost "+ 1500000*(supermarket+1)+"$. Write /supermarket");
                    Console.WriteLine("Police - reduce chances of death for nearly 1%. Cost "+ 2000000*(police+1)+" $. Write /police");
                    Console.WriteLine("Firestation - reduce chances of death for nearly 1%. Cost "+2500000*(firestation+1) +" $. Write /firestation");
                    Console.WriteLine("Maternity - reduce BCD for all womens for 1 year and make them born much more. Cost 3000000 $.Write /matermity.");
                    Console.WriteLine("if you want get back write anything or '/back'.");
                    command = Console.ReadLine();
                    Console.Clear();
                    switch (command)
                    {
                        case "/hospital":
                            if (money > 1000000 * (hospital + 1))
                            {
                                money = money - 1000000 * (hospital + 1);
                                Console.WriteLine("You build a hospital. Now little slaves dont dead like little bugs.");
                                hospital += 1;
                            }
                            else
                            {
                                Console.WriteLine("Not enight money");
                            }
                            break;
                        case "/supermarket":
                            if (money > 1500000 * (supermarket + 1))
                            {
                                money = money - 1500000 * (supermarket + 1);
                                Console.WriteLine("You build a supermarket. Your budget will increase faster because fat people like to eat a lot.");
                                supermarket += 1;
                                taxRate += 3;
                            }
                            else
                            {
                                Console.WriteLine("Not enight money");
                            }
                            break;
                        case "/police":
                            if (money > 2000000 * (police + 1))
                            { 
                               money = money - 2000000 * (police + 1);
                               Console.WriteLine("You build a police station. Now less bad people on streets.");
                               police += 1;
                            }
                            else
                            {
                                Console.WriteLine("Not enight money");
                            }
                           break;
                            case "/firestation":
                            if (money > 2500000 * (firestation + 1))
                            {
                                money = money - 2500000 * (firestation + 1);
                                Console.WriteLine("You build a fire station. You become angry much less.");
                                firestation += 1;
                            }
                            else
                            {
                                Console.WriteLine("Not enight money");
                            }
                                break;
                            case "/maternity":
                            if (money > 3000000)
                            {
                                if (maternity == 1)
                                {
                                    Console.WriteLine("You can build more then 1 maternity.");
                                    break;
                                }
                                else
                                {
                                    maternity += 1;
                                    money = money - 3000000;
                                    Console.WriteLine("You build a maternity. Little slaves born really fast.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not enight money");
                            }
                            break;

                            case "/back":
                                break;

                            default:
                               break;
                        }
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/personManipulating":
                    Console.Clear();
                    PersonManupalates(ref command, ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref gS, ref alive, ref dCount, ref tdCount, ref income, ref money, ref everyYearTax, ref taxRate, ref hospital, ref supermarket, ref police, ref firestation, ref maternity);
                    break;
                case "/nextTurn"://следуйщий ход(год), увеличивается возраст всех людей на год, рождаются новые, обсчитываются налоги, умирают люди
                    if (gS != 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Rulling didnt started yet.");
                        break;
                    }
                    tdCount = 0;
                    Born(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers,ref bornCd, ref alive, ref income, ref money,ref everyYearTax,ref taxRate,ref hospital,ref supermarket,ref police,ref firestation,ref maternity);
                    NextTurn(ref Count, ref  number, ref  names, ref sex, ref snames, ref age, rnd, Mname,  Wname,  Sname, ref mothers, ref fathers, ref bornCd, ref dCount, ref alive,ref tdCount, ref income,ref money,ref everyYearTax,ref taxRate, ref hospital, ref supermarket, ref police, ref firestation, ref maternity);
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
                    IncomeCreating(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref dCount, ref alive, ref tdCount, ref income, ref money, ref everyYearTax, ref taxRate);
                    IncomeGaining(ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers, ref bornCd, ref  dCount, ref alive, ref  tdCount, ref income, ref money, ref everyYearTax, ref  taxRate, ref hospital, ref supermarket, ref police, ref firestation, ref maternity);
                    MoneyGaining(everyYearTax,ref money);
                    Info(Count, dCount, tdCount, ref income, ref money, ref everyYearTax, ref taxRate, ref hospital, ref supermarket, ref police, ref firestation, ref maternity);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error. Unknown command.");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
            }
            
        }
        public static void Info(int Count, int dCount, int tdCount, ref String[] income, ref int money, ref int everyYearTax,ref int taxRate, ref int hospital, ref int supermarket, ref int police, ref int firestation, ref int maternity)
        {//ежегодная статистика, вызывается в конце метода "/nextTurn", от "/showStats" тем , что этот вызывается каждый ход, а другой только при команде
            
            Console.WriteLine("Total people : " + Count + "\n" + "Dead people : " + dCount + "\n" + "People alive : " + (Count - dCount) + "\n" + "Dead people today : " + tdCount + "\n" + "This year income : " + everyYearTax +"$."+ "\n" + "Total money : " + money + "$ .");
            Console.WriteLine("You have built "+ hospital +" Hospitals.");
            Console.WriteLine("You have built " + supermarket + " Supermarkets.");
            Console.WriteLine("You have built " + police  + " police stations.");
            Console.WriteLine("You have built " + firestation + " fire stations.");
            Console.WriteLine("You have built " + maternity + " Maternities.");
            Console.WriteLine("Nice job.");
            Console.WriteLine("Write '/commands' if don’t know what to run the country.");
            Console.WriteLine("Write '/help' if don’t know what to run the country.");
        }
        public static void Born(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref String[] alive, ref String[] income,ref int money,ref int everyYearTax,ref int taxRate,ref int hospital,ref int supermarket,ref int police,ref int firestation,ref int maternity)
        {// метод отвественный за создание новых людей, выберается 2 случайных человека мужского и женского пола, вписываются определенные параметры, вызывается командой "/nextTurn"
            Console.Clear();
            int f, m, d = 0, b = 0, a = rnd.Next(100), z = Count;
            d = rnd.Next(1,6) - 2 + maternity * 2;
            while (d > 0)
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
                            names[i] = Wname[rnd.Next(Wname.Length)];
                            sex[i] = "W";
                        }
                        snames[i] = snames[f];
                        mothers[i] = Convert.ToString(m);
                        fathers[i] = Convert.ToString(f);
                        age[i] = "0";
                        bornCd[m] = Convert.ToString(2 - maternity);
                        alive[i] = "A L I V E";
                        bornCd[i] = "0";
                        income[i] = "0";
                        Count += 1;
                        d -= 1;
                    }
                   
                }
            }
            b += 1;
            if (b == 30)
            {
            d = 0;
            }
            if (z == Count)
            {
                Console.WriteLine("It seems nobody want to born little slaves.");
            }
        }
        public static void NextTurn(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount, ref String[] income, ref int money, ref int everyYearTax, ref int taxRate,ref int hospital,ref int supermarket,ref int police,ref int firestation,ref int maternity)
        {//метод отвечающий за возможность умереть каждого человека (0%-), применяется при команде "/nextTurn"
            int deadChance;
            deadChance = rnd.Next(6)-hospital-police-firestation;
            for (int i = 1; i < Count; i++) { 
                if (alive[i] == "A L I V E")
                {
                    if (Convert.ToInt32(age[i]) < 10)
                    {
                        if (maternity == 1)
                        {
                            deadChance-=1;
                        }
                        deadChance += rnd.Next(2);
                        if (deadChance < 0 && hospital == 1)
                        {
                            deadChance = 0;
                        }
                    }
                    if (Convert.ToInt32(age[i]) >= 10 && Convert.ToInt32(age[i]) < 35)
                    {
                        deadChance += rnd.Next(1);
                        if (deadChance < 0 && hospital == 1)
                        {
                            deadChance = 0;
                        }
                    }
                    if (Convert.ToInt32(age[i]) >= 35 && Convert.ToInt32(age[i]) < 60)
                    {
                        deadChance += rnd.Next(1);
                        if (deadChance < 0)
                        {
                            deadChance = 2;
                        }
                    }
                    if (Convert.ToInt32(age[i]) >= 60 && Convert.ToInt32(age[i]) < 100)
                    {
                        deadChance += rnd.Next(1);
                        if (deadChance < 0)
                        {
                            deadChance = 3;
                        }
                    }
                    if (Convert.ToInt32(age[i]) > 100)
                    {
                        deadChance += rnd.Next(2);
                        if (deadChance < 0)
                        {
                            deadChance = 5;
                        }
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
        public static void IncomeGaining(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount,ref String[] income,ref int money,ref int everyYearTax,ref int taxRate,ref int hospital,ref int supermarket,ref int police,ref int firestation,ref int maternity)
        {//метод отвечающий за обсчет налогов, вызывается командой "/nextTurn"
            everyYearTax = 0;
            for (int i = 1; i < Count; i++)
            {
                if (alive[i] != " D e a d ")
                {
                    everyYearTax = everyYearTax + 12 * (Convert.ToInt16(income[i]) / 100) * taxRate;// обсчет налога среди всех жителей
                }
            }
        }
        public static void IncomeCreating(ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int dCount, ref String[] alive, ref int tdCount, ref String[] income, ref int money, ref int everyYearTax, ref int taxRate)
        {
            for (int i = 1; i < Count; i++)
            {
                if (alive[i] != " D e a d ")
                {
                    if (Convert.ToInt16(age[i]) > 16 && Convert.ToInt16(income[i]) == 0)
                    {
                        income[i] = Convert.ToString(rnd.Next(1000, 5000));
                    }
                }
            }
        }
        public static void MoneyGaining(int MoneyIncome,ref int money)
        { // окончательная прибавка денег, либо в виде MoneyGaining("число", money)при случайных событиях, либо прибавка налогов MoneyGaining(everyYearTax,money)
            money = money + MoneyIncome;
            //Console.WriteLine("You gain : " + MoneyIncome + " $.");
            //Console.WriteLine("Total money : "+ money + " $.");
        }
        public static void PersonManupalates(ref String command, ref int Count, ref String[] number, ref String[] names, ref String[] sex, ref String[] snames, ref String[] age, Random rnd, String[] Mname, String[] Wname, String[] Sname, ref String[] mothers, ref String[] fathers, ref String[] bornCd, ref int gS, ref String[] alive, ref int dCount, ref int tdCount, ref String[] income, ref int money, ref int everyYearTax, ref int taxRate, ref int hospital, ref int supermarket, ref int police, ref int firestation, ref int maternity)
        { 
            Console.WriteLine("Write '/kill_'+'number' to kill somebody.");
            Console.WriteLine("Write '/increaseIncome_'+'number' if you want gift someone.");
            command = Console.ReadLine();
            String[] q = command.Split(new char[] { ' ' });
            Console.Clear();
            switch (q[0]) {
                case "/kill":
                    if (alive[Convert.ToInt16(q[1])] == " D e a d ")
                    {
                        Console.WriteLine("Person already dead.");
                    }
                    else
                    {
                        alive[Convert.ToInt16(q[1])] = " D e a d ";
                        Console.WriteLine("You murdered little pig.");
                        dCount += 1;
                        tdCount += 1;
                    }
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                case "/increaseIncome":
                    if (alive[Convert.ToInt16(q[1])] == " D e a d ")
                    {
                        Console.WriteLine("Person already dead.He cant get more.");
                    }
                    else
                    { 
                        income[Convert.ToInt16(q[1])] = Convert.ToString(Convert.ToInt16(Convert.ToInt16(Convert.ToInt16(income[Convert.ToInt16(q[1])])) + Convert.ToInt16(Convert.ToInt16(income[Convert.ToInt16(q[1])])) * 0.15));
                        money = money - Convert.ToInt16(income[Convert.ToInt16(q[1])]);
                        Console.WriteLine("You regret about little pig.");
                        dCount += 1;
                        tdCount += 1;
                    }
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error. Unknown command.");
                    Console.WriteLine("Write '/commands' if don’t know what to run the country.");
                    Console.WriteLine("Write '/help' if don’t know what to run the country.");
                    break;
            }

    
        }
        public static void Main(string[] args)
        {
            int a = 1;// переменная отвечающая за бесконечный цикл запросов команды
            int gS = 0;// переменная отвечающая за начало игры(0 - игра не начата, 1 - игра начата, повторно игру не начать)
            int Count = 0;// общее количество людей
            int dCount = 0;// общее количество умерших людей
            int taxRate = 13;// ставка налога от доходов
            int tdCount = 0;//количество людей умершее в этот год(ход)
            int money = 0;//количество денег на счету
            int everyYearTax = 0;//переменная обозначает общее увечеличенее денег в этом году (ходу)
            int police = 0;
            int supermarket = 0;
            int hospital = 0;
            int firestation = 0;
            int maternity = 0;

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

            String[] Mname = { "Vasja ", "Petya ", "Gorg  ","Alex  ", "Dima  ", "Arnold", "Kirill","Anton ","Boris ","Alex  ","Pavel ","Artyom","Andrew","Peter " };//возможные имена для людей мужского пола
            String[] Wname = { "Maria ", "Julia ", "Anna  ", "Nadya ", "Linda ", "Varya ", "Katya ","Nastya","Lidia ","Alina ","Helen " };//возможные имена для людей женского пола
            String[] Sname = { "Black  ", "Grey   ", "Brown  ", "Duck   ", "Stevens", "Weigel ","Kekers ","Orange "};// возможные фамилии
            
            Console.WriteLine("Hello, enjoy world of DEAD and anarchy");// что-то типо вступления
            Console.WriteLine("Write '/begin' to start the adventure in the rotten world of capitalism and dictatorship.");
            Console.WriteLine("Write '/help' to get help around the world of lies and power.");
            Console.WriteLine("Write '/commands' to get list of commands for controlled mortals.");// что-то типо вступления
            
            while (a == 1)//бесконечный цикл
            {
                command = Console.ReadLine();//запрос команды
                Answer(ref command, ref Count, ref number, ref names, ref sex, ref snames, ref age, rnd, Mname, Wname, Sname, ref mothers, ref fathers,ref bornCd,ref gS, ref alive,ref dCount,ref tdCount,ref income, ref money,ref everyYearTax,ref taxRate,ref hospital, ref supermarket,ref police,ref firestation,ref maternity);//вызов метода который отвечает на команду,исходный код со строки 57.
            }
        }
    }
}
