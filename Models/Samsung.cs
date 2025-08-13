using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Samsung : Smartphone
    {
        public Samsung(string numero, string modelo, string imei, int memoria) // Construtor da classe Samsung
             : base(numero, modelo, imei, memoria) // Chama o construtor da classe pai Smartphone
        {

        }
    public override void InstalarAplicativo(string nomeApp) // Método override para instalar aplicativos 
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Samsung...");
        }
        
    }
}