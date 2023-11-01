using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("1399981122", "Nokia XYZ", "0123456789", 128);
Iphone iphone = new Iphone("2188835533", "I15", "9876543210", 256);

Console.WriteLine("Aparelho Nokia");
nokia.InstalarAplicativo("Telegram");
nokia.Ligar();

Console.WriteLine();

Console.WriteLine("Aparelho Iphone");
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();

