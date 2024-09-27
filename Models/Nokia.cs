namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria): base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (string.IsNullOrWhiteSpace(nomeApp))
            {
                Console.WriteLine("Nome do aplicativo inválido.");
                return;
            }

            Console.WriteLine($"Instalando o aplicativo {nomeApp}.");
        }
    }
}
