using DesafioPOO.Models;

//Implementado
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "3310", imei: "111111111111", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "15 PRO", imei: "000000000000", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
