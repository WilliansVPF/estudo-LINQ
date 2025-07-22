namespace estudoLINQ.MethodSyntax;

public class FiltroMethod
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void filtro()
    {
        // var resultado = produtos.Where(p => p.Preco < 5); //? retorna uma lista com todos os produtos onde o preço é menor que 5
        // var resultado = produtos.Where(p => p.Categoria == "Cereais"); //? retorna uma lista com todos os produtos que a categoria é igua a Cereais
        // var resultado = produtos.Where(p => p.Nome.Contains("De")); //? retorna uma lista com todos os produtos onde o nome contenha "De". OBS: case sensitive ("De" <> "de")
        var resultado = produtos.Where(p => p.Categoria == "Limpeza" && p.Preco < 3); //? aplica multiplos filtros

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }


}