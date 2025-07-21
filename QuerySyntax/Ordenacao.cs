namespace estudoLINQ.QuerySyntax;

public class Ordenacao
{
    private static List<Despesa> despesas = new List<Despesa>
    {
        new Despesa { Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2021, 10, 1) },
        new Despesa { Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2021, 10, 8) },
        new Despesa { Descricao = "Aluguel", Valor = 1200, Vencimento = new DateTime(2021, 10, 18) },
        new Despesa { Descricao = "Contabilidade", Valor = 400, Vencimento = new DateTime(2021, 10, 20) }
    };

    public static void ordenação()
    {
        var despesasVencidas = from d in despesas //d = variavel de interação despesas = fonte de dados
                               where d.Valor < 500 // filtro
                               orderby d.Vencimento descending, d.Valor ascending //ordenação descending = decrecente e ascending = crescente
                               select d; // retorno


        foreach (var d in despesasVencidas)
        {
            Console.WriteLine(d);
        }
    }
}