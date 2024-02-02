using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("(11) 99999-9999", "G60", "Abc123Abc123", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Gympass");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone(numero: "(11) 98888-8888", modelo: "15 Pro Max", imei: "Qwe789Qwe789", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("LinkedIn");