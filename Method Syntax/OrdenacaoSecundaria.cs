namespace estudoLINQ.MethodSyntax;

public class OrdenacaoSecundaria
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m }
    };

    public static void ordenacaoSecundariaCrescente()
    {
        var resultado = produtos.OrderBy(p => p.Categoria).ThenBy(p => p.Preco); //? ordenação secundaria crescente

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }

    public static void ordenacaoSecundariaDecrescente()
    {
        var resultado = produtos.OrderBy(p => p.Categoria).ThenByDescending(p => p.Preco); //? ordenação secundaria decrescente

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }
}