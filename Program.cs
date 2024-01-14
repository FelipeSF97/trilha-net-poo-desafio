using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthpone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarthpone Iphone: ");
Smartphone iphone = new Iphone(numero: "6789", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");