namespace estudoLINQ.MethodSyntax;

public class LimiteQuantidadeResultado
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void limiteQuantidadeResultado()
    {
        var resultado = produtos.Where(p => p.Preco > 3).Take(2); //? retorna a quantidade de registro informada

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }
}