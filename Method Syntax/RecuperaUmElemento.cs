namespace estudoLINQ.MethodSyntax;

public class RecuperaUmElemento
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void recuperaUmElemento()
    {
        var primeiro = produtos.First(p => p.Nome.Contains("De")); //? retorna o primeiro elemento que atende a condição
        var ultimo = produtos.Last(p => p.Nome.Contains("De")); //? retorna o ultimo elemento que atende a condição
        var arroz = produtos.Single(p => p.Nome == "Arroz"); //? retorna um elemento especifico que atende a condição (a condição precisa retornar apenas um elemento, caso haja outro elemento na coleção que tambem atenda as condições, ocorrera um erro)

        Console.WriteLine(arroz);
    } 
}