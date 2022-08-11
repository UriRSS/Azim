// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Globalization;

namespace programma
{
    class Program

    {
        static void Main()
        {
            Menu();
            Console.ReadLine();
            Console.WriteLine();
        }
 


    static void Menu()

    {
            int i;
            Console.Write("Меню:\n1) Посмотреть баланс \n2) Отправить средства \n3) Посмотреть номер лицевого счета \n\nВаш выбор: ");
            i = int.Parse(Console.ReadLine());
            switch (i)
        {
            case 1:
                User UserAvtorizovan;
                UserAvtorizovan.Firstname = "Alikeev";
                UserAvtorizovan.name = "Urmat";
                UserAvtorizovan.NomerScheta = 12345678;
                UserAvtorizovan.Balans = 1000;
                Console.WriteLine($"Фамилия: {UserAvtorizovan.Firstname}");
                Console.WriteLine($"Имя: {UserAvtorizovan.name}");
                Console.WriteLine($"Номер счета: {UserAvtorizovan.NomerScheta}");
                Console.WriteLine($"Баланс: {UserAvtorizovan.Balans}");
                break;
            case 2:                
                Tranzakciya tranzakciyaStuktura;// = new Tranzakciya();
                tranzakciyaStuktura.NomerSchetaPoluchatel = 12345678;
                tranzakciyaStuktura.dateTranzakcii = DateTime.Now;
                tranzakciyaStuktura.NomerTranzakcii = 0001;
                Console.WriteLine($"Введите номер счета:");
                tranzakciyaStuktura.NomerSchetaOtprovitel = Convert.ToInt32(Console.ReadLine());
                if (tranzakciyaStuktura.NomerSchetaPoluchatel == tranzakciyaStuktura.NomerSchetaOtprovitel)
                {
                    Console.WriteLine("Введите сумму пополнения");
                    NumberFormatInfo Rasdelitel = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    tranzakciyaStuktura.StrokaSumaPerevoda = Console.ReadLine();
                    tranzakciyaStuktura.SumaPerevoda = Convert.ToDouble(tranzakciyaStuktura.StrokaSumaPerevoda, Rasdelitel);
                    if (1000 <= tranzakciyaStuktura.SumaPerevoda)
                    {
                        tranzakciyaStuktura.SumaPerevoda = tranzakciyaStuktura.SumaPerevoda + 1000;
                        Console.WriteLine($"дата транзакции:  {tranzakciyaStuktura.dateTranzakcii}");
                        Console.WriteLine($"Счет отправителя: {tranzakciyaStuktura.NomerSchetaOtprovitel}");
                        Console.WriteLine($"Счет получателя: {tranzakciyaStuktura.NomerSchetaPoluchatel}");
                        Console.WriteLine($"Сумма: {tranzakciyaStuktura.SumaPerevoda}");
                        Console.WriteLine($"Номер транзакции: {tranzakciyaStuktura.NomerTranzakcii}");
                    }
                    else Console.WriteLine("Не достаточно средств для пополнения");
                }
                else
                {
                    Console.WriteLine("Номер счета веден не верно");
                }
                break;
            case 3:
                User UserAvtorizovanNomerScheta;
                UserAvtorizovanNomerScheta.NomerScheta = 12345678;
                Console.WriteLine($"Ваш номер счета: {UserAvtorizovanNomerScheta.NomerScheta}");
                break;
            default:
                Console.WriteLine("Вы нажали что-то другое...");
                break;
        }

            //Console.WriteLine();
            //Console.ReadLine();        
    }

    }

}

struct User
{
    public string name;
    public string Firstname;
    public int NomerScheta;
    public double Balans;
}

struct Tranzakciya
{
    public DateTime dateTranzakcii;
    public int NomerSchetaOtprovitel;
    public int NomerSchetaPoluchatel;
    public double SumaPerevoda;
    public String StrokaSumaPerevoda;
    public int NomerTranzakcii;
}