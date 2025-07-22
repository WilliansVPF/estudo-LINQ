namespace estudoLINQ.MethodSyntax;

public class OrdenarResultado
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void ordenaCrescente()
    {
        var resultado = produtos.OrderBy(p => p.Preco); //? ordena de forma crescente

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }

    public static void ordenaDecrescente()
    {
        var resultado = produtos.OrderByDescending(p => p.Preco); //? ordena de forma decrescente

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }
}