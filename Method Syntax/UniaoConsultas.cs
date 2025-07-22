namespace estudoLINQ.MethodSyntax;

public class UniaoConsultas
{
    private static List<Conta> despesas = new List<Conta>
        {
            new Conta { Descricao = "Aluguel", Valor = 500, Vencimento = new DateTime(2021, 10, 01)},
            new Conta { Descricao = "Transporte", Valor = 300, Vencimento = new DateTime(2021, 10, 02)},
            new Conta { Descricao = "Alimentação", Valor = 200, Vencimento = new DateTime(2021, 10, 03)}
        };

    private static List<Conta> receitas = new List<Conta>
        {
            new Conta { Descricao = "Salário", Valor = 1500, Vencimento = new DateTime(2021, 10, 01)},
            new Conta { Descricao = "Investimentos", Valor = 100, Vencimento = new DateTime(2021, 10, 02)}
        };

    public static void uniaoConsultas()
    {
        var contas = despesas.Union(receitas); //? une as duas coleções em uma unica coleção. As duas coleções devem ser do mesmo tipo

        foreach (var c in contas)
        {
            Console.WriteLine(c);
        }
    }
}