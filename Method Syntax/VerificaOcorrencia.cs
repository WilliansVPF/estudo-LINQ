namespace estudoLINQ.MethodSyntax;

public class VerificaOcorrencia
{
    private static List<int> notas = new List<int> { 500, 600, 700, 800, 900 };

    public static void verificaOcorrencia()
    {
        var any = notas.Any(n => n > 900); //? verifica se pelo menos um item atende ao criterio
        var all = notas.All(n => n > 400); //? verifica se todos os itens atende ao criterio
        var contain = notas.Contains(1000); //? verifica se a fonte de dados contem o valor passado

        Console.WriteLine("Any: " + any);
        Console.WriteLine("All: " + all);
        Console.WriteLine("Contains: " + contain);

    }
}