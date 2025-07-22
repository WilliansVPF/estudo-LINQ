namespace estudoLINQ.MethodSyntax;

public class AlterandoRetorno
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        new Produto { Nome = "Feijão", Categoria = "Cereais", Preco = 8.19m },
        new Produto { Nome = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
        new Produto { Nome = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
    };

    public static void alterandoRetorno()
    {
        // var resultado = produtos.Select(p => p.Nome); //? retorna apenar uma propriedade
        // var resultado = produtos.Select(p => new {p.Nome, p.Preco}); //? para retornar mais de uma propriedade, retorna um objeto dinamico
        var resultado = produtos.Select(p => new {p.Nome, PrecoComAcrecimo = p.Preco * 1.1m}); //? é possivel retornar um campo personalizado

        foreach (var r in resultado)
        {
            Console.WriteLine(r);
        }
    }
}