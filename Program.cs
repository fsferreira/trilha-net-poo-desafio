using DesafioPOO.Models;

// Implementado
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Nokia 1100", "111111111", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("654321", "Iphone 14", "222222222", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");