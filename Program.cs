using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", IMEI: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"7891011", modelo:"Modelo 2", IMEI: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whattsapp");