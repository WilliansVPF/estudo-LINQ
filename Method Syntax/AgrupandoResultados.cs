namespace estudoLINQ.MethodSyntax;

public class AgrupandoResultados
{
    private static List<Produto> produtos = new List<Produto>
    {
        new Produto { Nome = "Notebook", Preco = 8000, Categoria = "Informatica" },
        new Produto { Nome = "Monitor", Preco = 1000, Categoria = "Informatica" },
        new Produto { Nome = "Cama", Preco = 2000, Categoria = "Moveis" },
        new Produto { Nome = "Armario", Preco = 3000, Categoria = "Moveis" }
    };

    private static List<Promocao> promocoes = new List<Promocao>
    {
        new Promocao { Categoria = "Informatica", Desconto = 10 },
        new Promocao { Categoria = "Moveis", Desconto = 20 }
    };

    public static void agrupandoResultados()
    {
        var resultado = produtos.Join(promocoes,
                                      produto => produto.Categoria,
                                      promocao => promocao.Categoria,
                                      (produto, promocao) => new
                                      {
                                          produto.Nome,
                                          produto.Categoria,
                                          PrecoComDesconto = produto.Preco * (1 - (promocao.Desconto / 100))
                                      });

        foreach (var r in resultado)
        {
            Console.WriteLine($"{r.Nome} - {r.Categoria} - {r.PrecoComDesconto}");
        }
    }
}