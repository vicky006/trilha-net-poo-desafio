namespace DesafioPOO.Models
{
    public abstract class Smartphone //abstract é uma classe abstrata que não pode ser instanciada, só pode ser herdada
    {
        public string Numero { get; set; } //atributo público
        private string _Modelo { get; set; } //atributo privado
        private string _IMEI { get; set; }
        private int _Memoria { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama - ok
        //implementado

        public Smartphone(string numero, string _modelo, string _imei, int _memoria) ///esse é o construtor
        {
            Numero = numero; 
            _Modelo = _Modelo;
            _IMEI = _imei;
            _Memoria = _memoria;

            // TODO: Passar os parâmetros do construtor para as propriedades - ok
            //implementado
        }

        public void Ligar(string nomePessoa)
        {
            Console.WriteLine($"Ligando para {nomePessoa}...");
        }

        public void ReceberLigacao(string nomePessoa) //método
        {
            Console.WriteLine($"Recebendo ligação de {nomePessoa}...");
        }

        public abstract void InstalarAplicativo(string nomeApp); //método abstrato, que não tem corpo, e deve ser implementado nas classes filhas
    }
}