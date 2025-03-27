namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - ok
    //implementado
    public class Nokia : Smartphone //herdando
    {
      public Nokia(string numero, string _modelo, string _imei, int _memoria) : base(numero, _modelo, _imei, _memoria) //A classe Smartphone tem um construtor que exige parâmetros. Quando Nokia herda de Celular, o construtor de Nokia precisa garantir que os requisitos do construtor de Smartphone sejam atendidos, e isso é feito utilizando base.
      {
  
        
      } 

        // TODO: Sobrescrever o método "InstalarAplicativo" - ok
        //implementado
        public override void InstalarAplicativo(string nomeApp) //sobrescrevendo o método da classe pai.
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp}...");
        }
    }
    
}