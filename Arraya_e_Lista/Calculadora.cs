namespace Arraya_e_Lista
{
    public class Calculadora
    {
        
        public static void Main(string[] args)
        {
             List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            Console.WriteLine("Soma: " + Soma(numeros));
            Console.WriteLine("Média: " + Media(numeros));
        }
        public static int Soma(List<int> numeros)
        {
             int soma = 0;
            foreach (int num in numeros)
            {
                soma += num;
            }
            return soma;

        }
        public static double Media(List<int> numeros)
        {
            int soma = Soma(numeros);
            double media = (double)soma / numeros.Count;
            return media;
          
        }
    }
}
