using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        //Nokia
        var meuNokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
        meuNokia.Ligar();
        meuNokia.InstalarAplicativo("Snake");
        meuNokia.ReceberLigacao();

        Console.WriteLine();

        //Iphone
        var meuIphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128);
        meuIphone.Ligar();
        meuIphone.InstalarAplicativo("WhatsApp");
        meuIphone.ReceberLigacao();
    }
}

