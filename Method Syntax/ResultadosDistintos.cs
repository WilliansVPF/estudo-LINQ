namespace estudoLINQ.MethodSyntax;

public class ResultadosDistintos
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void resultadosDistintos()
    {
        var categoria = produtos.Select(p => p.Categoria).Distinct(); //? mesmo que o item se repita, com o Distinct, só uma ocorrencia sera retornada

        foreach (var c in categoria)
        {
            Console.WriteLine(c);
        }
    }
}