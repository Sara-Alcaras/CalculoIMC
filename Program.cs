namespace CalculoIMC;

public class Program
{
    #region Propriedade pública
    public static string Nome { get; set; }
    public static string Sexo { get; set; }
    public static float Idade { get; set; }
    public static float Altura { get; set; }
    public static float Peso { get; set; }
    public static float ImcDesejavel { get; set; }
    public static float ImcRisco { get; set; }
    public static float ImcRecomendacao { get; set; }
    #endregion
    static void Main(string[] args)
    {
        #region Chama os métodos
        //Método com entrada de dados
        Inicio();

        //Método que faz o calculo do IMC
        //calculaIMC();
        #endregion

    }

    public static void Inicio()
    {
        //deve conter todos atributos relacionados a entrada de dados
        //criar metodo de iniciliazação - output de mensagens
        Console.WriteLine("Olá! Seja bem-vindo. Insira seus dados para calcular o DIAGNÓSTICO PRÉVIO");
        Console.WriteLine("*************************************************************************");

        Console.Write("\rInforme seu nome: ");
        Nome = ValidaNome(Console.ReadLine());

        Console.Write("Informe seu sexo: ");
        Sexo = Console.ReadLine();

        Console.Write("Informe sua idade: ");
        Idade = float.Parse(Console.ReadLine());

        Console.Write("Insira a altura: ");
        Altura = float.Parse(Console.ReadLine());

        Console.Write("Insira o peso(kg): ");
        Peso = float.Parse(Console.ReadLine());


    }

    //criar um metodo de FIM
    //DEVE retornar todos os atributos relacionados a saida de dados


    //criar Metodo calculaIMC
    //public static void calculaIMC()
    //{
    //    imc = Peso / (Altura * Altura);
    //    Console.WriteLine("Seu IMC é: " + imc.ToString());
    //}


    //criar um metodo verifica categoria  


    //criar Metodo Verifica imc baseado na propriedade imc publica
    // o metodo deve utilizar o
    // switch (imc) {
    //      case < 20:
    //          ImcRisco = escrever mensagem do risco;
    //ImcDesejavel = escrever mensagem do imc desejavel;
    //ImcRecomendacao = escrever mensagem da recomendacaoinicial
    //      break;
    // default: break;
    // }


    public static string ValidaNome(string nome) // Verifica se o nome é valido
    {
        if (nome == null || nome == " " || nome.Length <= 1)
        {
            Console.Write("Nome Inválido! \r\nInforme seu nome novamente: ");
            ValidaNome(Console.ReadLine());
        }
        return nome;
    }


    //     if (imc< 20)
    //            Console.WriteLine("Abaixo do peso ideal: Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.");

    //        else if (imc >= 20 && imc< 24)
    //            Console.WriteLine("Peso normal: Seu peso está ideal para suas referências.");

    //        else if (imc >= 24 && imc< 30)
    //            Console.WriteLine("Excesso de peso: Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.");

    //        else if (imc >= 30 && imc< 35)
    //            Console.WriteLine("Obesidade: Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.");

    //        else if (imc >= 35)
    //            Console.WriteLine("Super obesidade: obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas. ");
    //
}
