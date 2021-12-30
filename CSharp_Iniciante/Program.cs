// See https://aka.ms/new-console-template for more information
namespace CSharp_Iniciante
{
    class Program
    {
        enum Opcao { MetodoAsync = 1, SwitchComEnum}

        static void Main(string[] args)
        {
            MetodoAsync metodoAsync = new MetodoAsync();

            Console.WriteLine("Escolha o que deseja abrir.\n" +
                "\n1- Método Async\n2- Switch com Enum");

            Int32.TryParse(Console.ReadLine(), out int escolha);

            Console.WriteLine(string.Format("Item escolhido: {0}\n\n", ObterNomeItemEscolhido((Opcao)escolha)));

            switch (escolha)
            {
                case (int)Opcao.MetodoAsync:
                    {
                        metodoAsync.PrepararCafe();
                        break;
                    }
            }
            Console.ReadKey();

        }

        private static string ObterNomeItemEscolhido(Opcao escolha)
        {
            switch (escolha)
            {
                case Opcao.MetodoAsync:
                    return "Método Asyncrono";
                    break;
                case Opcao.SwitchComEnum:
                    return "Switch com Enum";
                    break;
                default:
                    return "Não foi possível obter o nome do item escolhido.";
                    break;
            }
        }
    }
}