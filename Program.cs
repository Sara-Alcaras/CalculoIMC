namespace CalculoIMC;

public class CalculadoraIMC : Usuario
{
    static void Main(string[] args)
    {
        UtilsConsole.Inicializacao();

        EntradaEValidacaoDados();
        VerificaDadosIMC();

        UtilsConsole.Fim();
    }

    public static void EntradaEValidacaoDados()
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
    } // entrada dos dados e chamada do metodo de validacao

    public static string RecebeDado(TipoDado tipoDado) // validacao dos dados recebidos
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