using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        int tabuada;

        Console.WriteLine("Qual tabuada você quer? (1 a 9)");
        tabuada = int.Parse(Console.ReadLine());

        fazTabuada();

        void fazTabuada()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i + " x " + tabuada + " = " + (i * tabuada));

            }
        }


    }
}