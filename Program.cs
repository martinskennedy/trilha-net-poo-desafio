using DesafioPOO.Models;
using System.Diagnostics.CodeAnalysis;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 16);

Console.WriteLine("Smartphone Nokia:");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Iphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", 128);

Console.WriteLine("Smartphone iPhone:");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
