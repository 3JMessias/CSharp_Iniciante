using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Iniciante
{
    internal class MetodoAsync
    {
        public void PrepararCafe()
        {
            Task taskPassarCafe = PassarCafeAsync();
            Task taskCortarPao = CortarPaoAsync();
            Task taskPassarManteigaNoPao = PassarManteigaNoPaoAsync();

            taskPassarCafe.Wait();

            Console.WriteLine($"\n****** Café na Mesa!");
            Console.ReadKey();
        }

        static async Task PassarCafeAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine($"Passando café: {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"##### Café Pronto!");

            });
        }

        static async Task PassarManteigaNoPaoAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 6; i > 0; i--)
                {
                    Console.WriteLine($"Passando Manteiga no Pão: {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"##### Pão Pronto!");
            });
        }

        static async Task CortarPaoAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine($"Cortando o Pão: {i}");
                    Thread.Sleep(1000);
                }
                Console.WriteLine($"##### Pão Cortado!");
            });
        }
    }
}
