using System;
using AulaPOOCelular.Celular;
namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)

        {
            //    Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
            //    Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
            //    Só será possível executar tais métodos se o celular estiver ligado.

            int escolha;
           do
           {
                Console.WriteLine("Escolha uma opção!");
                Console.WriteLine(" [1] - ligar o celular");
                Console.WriteLine(" [2] - fazer ligação");
                Console.WriteLine(" [3] - enviar mensagem");
                Console.WriteLine(" [0] - desligar o celular");

           } while (escolha != 0);
            
            switch (escolha)
            {
                case 1:
                Console.WriteLine($"O celular está ligando");
                    break;

                case 2:
                Console.WriteLine($"Efetuando ligação");
                    break;
                case 3:
                Console.WriteLine($"Mensagem enviada com sucesso");
                    break;
                case 0:
                Console.WriteLine("Desligando o celular");
                    break;       
                default:
                Console.WriteLine("Opção inválida");
                    break;
            }
            
        
        
        }
    }
}
        

