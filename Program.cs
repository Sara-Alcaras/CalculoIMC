namespace CalculoIMC;

public class Program
{
    #region Propriedade pública
    public static string Nome { get; set; }
    public static string Sexo { get; set; }
    public static int Idade { get; set; }
    public static float Altura { get; set; }
    public static float Peso { get; set; }
    public static float Imc { get; set; }
    public static string Categoria { get; set; }
    public static string ImcRisco { get; set; }
    public static string ImcRecomendacao { get; set; }
    #endregion
    static void Main(string[] args)
    {
        #region Chama os métodos
        //Método com entrada de dados
        Inicio();
        VerificaDados();
        Fim();
        #endregion

    }

    private static void VerificaDados()
    {
        CalculaIMC(Peso, Altura);
        VerificaCategoria(Idade);
        VerificaIMC(Imc);
    }

    #region Método que contém todos os atributos para entrada de dados
    public static void Inicio()
    {
        Console.WriteLine("Olá! Seja bem-vindo. Insira seus dados para calcular o DIAGNÓSTICO PRÉVIO IMC");
        Console.WriteLine("*****************************************************************************");

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
        bool eNumero = int.TryParse(nome, out int r); // Tenta converter a propriedade (nome) pra inteiro

        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome) || eNumero || nome.Length <= 2) // Verifica se o usuário está inserindo nulo, vazio ou numero 
        {
            Console.Write("\nNome Inválido! \r\nInforme seu nome novamente: ");
            ValidaNome(Console.ReadLine());
        }
        return nome;
    }

    public static string ValidaSexo(string strSexo) // Verifica se o sexo é válido
    {
        string sexo = string.Empty;
        int tipoSexo;
        int.TryParse(strSexo, out tipoSexo);

        switch (tipoSexo)
        {
            case 1:
                sexo = "Masculino";
                break;
            case  2 :
                sexo = "Feminino";
                break;
            case 3:
                sexo = "Outro";
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
            case > 1 and < 130:
                break;
            default:
                Console.Write("\nIdade Inválida! \r\nInforme sua idade novamente: ");
                ValidaIdade(Console.ReadLine());
                break;
        }
        return idade;
    }

    public static float ValidaAltura(string strAltura) // Verifica se a altura é válida
    {
        float altura;
        float.TryParse(strAltura, out altura);

        switch (altura)
        {
            case >= 100 and <= 200:
                break;
            default:
                Console.Write("\nAltura Inválida! \r\nInforme sua altura novamente: ");
                ValidaAltura(Console.ReadLine());
                break;
        }
        return altura;
    }

    public static float ValidaPeso(string strPeso) // Verifica se o peso é válido
    {
        float peso;
        float.TryParse(strPeso, out peso);

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
    public static void VerificaCategoria(int idade) // Define a categoria de idade
    {
        switch (idade)
        {
            case < 12:
               Categoria = "Infantil";
                break;
            case >= 12 and <= 20:
                Categoria = "Juvenil";
                break;
            case >= 21 and <= 65:
                Categoria = "Adulto";
                break;
            case > 65:
                Categoria = "Idoso";
                break;
                
        }
    }
    public static void CalculaIMC(float peso, float altura) // Método que faz o calculo do IMC
    {
        Imc = peso / (altura * altura);
        
    }

    public static void VerificaIMC(float imc) // Método que faz o calculo do IMC
    {
        switch (imc)
        {
            case < 20:
                ImcRecomendacao = "Inclua carboidratos simples em sua dieta, além de proteínas - indispensáveis para ganho de massa magra. Procure um profissional";
                ImcRisco = "Muitas complicações de saúde como doenças pulmonares e cardiovasculares podem estar associadas ao baixo peso.";
                break;
            case >= 20 and <= 24:
                ImcRecomendacao = "Mantenha uma dieta saudável e faça seus exames periódicos.";
                ImcRisco = "Seu peso está ideal para suas referências.";
                break;
            case >= 25 and <= 29:
                ImcRecomendacao  = "Adote um tratamento baseado em dieta balanceada, exercício físico e medicação. A ajuda de um profissional pode ser interessante";
                ImcRisco= "Aumento de peso apresenta risco moderado para outras doenças crônicas e cardiovasculares.";
                break;
            case >= 30 and <= 35:
                ImcRecomendacao = "Adote uma dieta alimentar rigorosa, com o acompanhamento de um nutricionista e um médico especialista(endócrino).";
                ImcRisco = "Quem tem obesidade vai estar mais exposto a doenças graves e ao risco de mortalidade.";
                break;
            case > 35:
                ImcRecomendacao = "Procure com urgência o acompanhamento de um nutricionista para realizar reeducação alimentar, um psicólogo e um médico especialista(endócrino).";
                ImcRisco = "O obeso mórbido vive menos, tem alto risco de mortalidade geral por diversas causas.";
                break;
        }
    }
    public static void Fim()
    {
        Console.WriteLine("Resultado DIAGNÓSTICO PRÉVIO IMC");
        Console.WriteLine("********************************");

        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Sexo: {Sexo}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Altura: {Altura}");
        Console.WriteLine($"Peso: {Peso}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"\n\nIMC Desejável: Entre 20 e 24");

        Console.WriteLine($"\n\rResultado IMC: {Imc.ToString("F2")}");
        Console.WriteLine($"\n\rRiscos: {ImcRisco}");
        Console.WriteLine($"\n\rRecomendações: {ImcRecomendacao}");
    }
}