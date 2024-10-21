using SistemaCell.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("554869", "Nokia", "95801534", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("554869", "Iphone", "95801534", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");