namespace CalculoIMC;

public class Program
{
    #region Propriedade pública
    public static string Nome { get; set; }
    public static int Sexo { get; set; }
    public static int Idade { get; set; }
    public static float Altura { get; set; }
    public static float Peso { get; set; }
    public static string ImcDesejavel { get; set; }
    public static float ImcRisco { get; set; }
    public static string ImcRecomendacao { get; set; }
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

    #region Método que contém todos os atributos para entrada de dados
    public static void Inicio()
    {
        Console.WriteLine("Olá! Seja bem-vindo. Insira seus dados para calcular o DIAGNÓSTICO PRÉVIO IMC");
        Console.WriteLine("*************************************************************************");

        Console.Write("\nInforme seu nome: ");
        Nome = ValidaNome(Console.ReadLine());

        Console.WriteLine("\nDigite o número que corresponde ao seu sexo: \n1- Masculino\n2- Feminino\n3- Outro ");
        Sexo = ValidaSexo(Console.ReadLine());

        Console.Write("\nInforme sua idade: ");
        Idade = ValidaIdade(Console.ReadLine());

        Console.Write("\nInforme sua altura em centímetros(cm): ");
        Altura = ValidaAltura(Console.ReadLine());

        Console.Write("\nInforme seu peso(kg): ");
        Peso = ValidaPeso(Console.ReadLine());

        Console.Clear();
    }
    #endregion

    #region Métodos para validação de entrada de dados
    public static string ValidaNome(string nome) // Verifica se o nome é válido
    {
        bool eNumero = int.TryParse(nome,out int r); // Tenta converter a propriedade (nome) pra inteiro

        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || eNumero || nome.Length <= 2) // Verifica se o usuário está inserindo nulo, vazio ou numero 
        { 
            Console.Write("\nNome Inválido! \r\nInforme seu nome novamente: ");
            ValidaNome(Console.ReadLine());
        }
        return nome;
    }

    public static int ValidaSexo(string strSexo) // Verifica se o sexo é válido
    {
        int sexo;
        int.TryParse(strSexo, out sexo);

        switch (sexo)
        {
            case 1 or 2 or 3:
                break;
            default:
                Console.Write("\nSexo inválido! \r\nInforme uma opção válida:  ");
                ValidaSexo(Console.ReadLine());
                break;
        }
        return sexo;
    }

    public static int ValidaIdade(string strIdade) // Verifica se a idade é válida
    {
        int idade;
        int.TryParse(strIdade, out idade);

        switch (idade)
        {
            case  >1 and <130:
                break;
            default:
                Console.Write("\nIdade Inválida! \r\nInforme sua idade novamente: ");
                ValidaIdade(Console.ReadLine());
                break;
        }
        return idade;
    }

    public static int ValidaAltura(string strAltura) // Verifica se a altura é válida
    {
        int altura;
        int.TryParse(strAltura, out altura);

        switch (altura)
        {
            case >=100 and <=200:
                break;
            default:
                Console.Write("\nIdade Inválida! \r\nInforme sua altura novamente: ");
                ValidaAltura(Console.ReadLine());
                break;
        }
        return altura;
    }

    public static int ValidaPeso(string strPeso) // Verifica se a altura é válida
    {
        int peso;
        int.TryParse(strPeso, out peso);

        switch (peso)
        {
            case >= 20 and <= 200:
                break;
            default:
                Console.Write("\nPeso Inválido! \r\nInforme seu peso novamente: ");
                ValidaPeso(Console.ReadLine());
                break;
        }
        return peso;
    }
    #endregion
    //criar um metodo de FIM
    //DEVE retornar todos os atributos relacionados a saida de dados


    //criar Metodo calculaIMC
    //public static void calculaIMC()
    //{
    //    imc = Peso / (Altura * Altura);
    //    Console.WriteLine("Resultado IMC: " + imc.ToString());
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