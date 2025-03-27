namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - ok
    //implementado
    public class Iphone : Smartphone
    {
        //criando o construtor
        public Iphone(string numero, string _modelo, string _imei, int _memoria) : base(numero, _modelo, _imei, _memoria) //A classe Smartphone tem um construtor que exige parâmetros. Quando Iphone herda de Celular, o construtor de Iphone precisa garantir que os requisitos do construtor de Smartphone sejam atendidos, e isso é feito utilizando base. Esse é o construtor de Iphone.
        {
        
        }
        // TODO: Sobrescrever o método "InstalarAplicativo" - ok
        //implementado
       public override void InstalarAplicativo(String nomeApp) //override sobrescreve o método da classe pai - é uma forma de polimorfismo, onde o método da classe filha pode ter um comportamento diferente do pai.
       {
        Console.WriteLine($"Instalando aplicativo {nomeApp}...");
       }
        
    }
}