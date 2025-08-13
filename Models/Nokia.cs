namespace DesafioPOO.Models
{
    public class Nokia : Smartphone // Classe Nokia herda de Smartphone
    {
    public Nokia(string numero, string modelo, string imei, int memoria) // Construtor da classe Nokia
             : base(numero, modelo, imei, memoria) // Chama o construtor da classe pai Smartphone
        {

        }
    public override void InstalarAplicativo(string nomeApp) // Método override serve para sobrescrever o método da classe pai
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no Nokia...");
        }
    }
}