namespace Questão5_H1.Controllers
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public double Altura { get; set; }

        public double CalcularIMC()
        {
            return Peso / (Altura * Altura);
        }
    }
}
