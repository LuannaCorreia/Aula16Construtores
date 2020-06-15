using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância sem argumentos
           Produto perfume = new Produto();
           perfume.Nome = "Coffe";


           // Instância com 1 argumento
           Produto videogame = new Produto(54);
           System.Console.WriteLine(videogame.Codigo);


           // Instância com todos os atributos como argumentos
           Produto bone = new Produto( 47, "Overcome", "Preto", 395);
           System.Console.WriteLine(bone.Codigo);
           System.Console.WriteLine(bone.Nome);
           System.Console.WriteLine(bone.Descrição);
           System.Console.WriteLine(bone.Estoque);
        }
    }
}