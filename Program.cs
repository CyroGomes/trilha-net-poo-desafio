using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "123456789012345", memoria: 256); // Os dados dos atributos ficam encapsuladas.
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("------------------------------------------------");

Console.WriteLine("Smartphone Samsung");
Smartphone samsung = new Samsung(numero: "987654321", modelo: "Galaxy S20", imei: "987654321098765", memoria: 512);      
samsung.Ligar();
samsung.InstalarAplicativo("Facebook");
Console.WriteLine("------------------------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "555555555", modelo: "Iphone 12", imei: "555555555555555", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");