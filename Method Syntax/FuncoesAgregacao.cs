using System.Net.NetworkInformation;

namespace estudoLINQ.MethodSyntax;

public class FuncoesAgregacao
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void funcoesAgregacao()
    {
        var quantidade = produtos.Count(p => p.Categoria == "Limpeza"); //? conta a quantidade de ocoorencias
        var maximo = produtos.Max(p => p.Preco); //? retorn o maior valor
        var minimo = produtos.Min(p => p.Preco); //? retorna o menor valor
        var soma = produtos.Sum(p => p.Preco); //? retorna a soma dos valores
        var media = produtos.Average(p => p.Preco); //? retorna a media dos valores

        Console.WriteLine("Count: " + quantidade);
        Console.WriteLine("Max: " + maximo);
        Console.WriteLine("Min: " + minimo);
        Console.WriteLine("Sun: " + soma);
        Console.WriteLine("Average: " + media);
    }
}