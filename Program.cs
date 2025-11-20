using DesafioPOO.Models;

Smartphone iphone = new Iphone("11988887777", "iPhone 14", "123456789000111", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Smartphone nokia = new Nokia("11999996666", "Nokia 3310", "987654321000222", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
