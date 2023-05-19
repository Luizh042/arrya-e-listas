namespace Arraya_e_Lista
{
    public class Calculadora
    {
        public static void Main(string[] args)
        {

        }
        public int Soma(List<int> numeros)
        {
             int soma = 0;
            foreach (int num in numeros)
            {
                soma += num;
            }
            return soma;

        }
    }
}
