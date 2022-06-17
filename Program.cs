namespace CalculoIMC;

public class CalculadoraIMC : Usuario
{
    static void Main(string[] args)
    {
        #region Inicializa os métodos
        UtilsConsole.Inicializacao();

        EntradaEValidacaoDados();
        VerificaDadosIMC();

        UtilsConsole.Fim();
        #endregion
    }

    public static void EntradaEValidacaoDados() // Método que chama as entrada dos dados conforme o tipo do dado e chama o método de validação
    {
        UtilsConsole.ExibeMensagemEntradaDado(TipoDado.Nome);
        Nome = RecebeDado(TipoDado.Nome);

        UtilsConsole.ExibeMensagemEntradaDado(TipoDado.Sexo);
        Sexo = RecebeDado(TipoDado.Sexo);

        UtilsConsole.ExibeMensagemEntradaDado(TipoDado.Idade);
        Idade = int.Parse(RecebeDado(TipoDado.Idade));

        UtilsConsole.ExibeMensagemEntradaDado(TipoDado.Altura);
        Altura = float.Parse(RecebeDado(TipoDado.Altura));

        UtilsConsole.ExibeMensagemEntradaDado(TipoDado.Peso);
        Peso = float.Parse(RecebeDado(TipoDado.Peso));

        UtilsConsole.LimparTela();
    }

    public static string RecebeDado(TipoDado tipoDado) // Método que recebe todos os dados digitados pelo usuário
    {
        string dado = Console.ReadLine();
        string dadoValido = String.Empty;

        switch (tipoDado)
        {
            case TipoDado.Nome:
                dadoValido = Validador.Nome(dado);
                break;
            case TipoDado.Sexo:
                dadoValido = Validador.Sexo(dado);
                break;
            case TipoDado.Idade:
                dadoValido = Validador.Idade(dado);
                break;
            case TipoDado.Altura:
                dadoValido = Validador.Altura(dado);
                break;
            case TipoDado.Peso:
                dadoValido = Validador.Peso(dado);
                break;
            default:
                break;
        }
        return dadoValido;
    }
}