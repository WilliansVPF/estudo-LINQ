namespace estudoLINQ.MethodSyntax;

public class AvancarRegistro
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void avancarRegistro()
    {
        // var resultado = produtos.Skip(3); //? pula a quantidade de registro indicado
        var resultado = produtos.Skip(1).Take(1); //? pula um registro e rotarna dois proximos registro

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }
}