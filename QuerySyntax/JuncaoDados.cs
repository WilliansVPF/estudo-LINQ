namespace estudoLINQ.QuerySyntax;

public class JuncaoDados
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

    public static void juncaoDados()
    {
        var resultado = from produto in produtos //produto = primeira variavel de interação, produtos = primeira fonte de dados
                        join promocao in promocoes //promocao = segunda variavel de interacao, promocoes = segunda fonte de dados
                        on produto.Categoria equals promocao.Categoria //criterio de junção
                        select new // retorna um objeto dinamico com propriedades vinda das duas fontes de dados
                        {
                            produto.Nome,
                            produto.Categoria,
                            PrecoComDesconto = produto.Preco * (1 - (promocao.Desconto / 100))
                        };

        foreach (var p in resultado)
        {
            Console.WriteLine($"{p.Nome} - {p.Categoria} - {p.PrecoComDesconto}");
        }
    }
}