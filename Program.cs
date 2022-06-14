namespace CalculoIMC;

public class Program
{
    static void Main(string[] args)
    {
        float imc, altura, peso;

        Console.WriteLine("Calculo IMC");

        Console.WriteLine("Insira o peso(kg): ");
        peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Insira a altura: ");
        altura = float.Parse(Console.ReadLine());

        imc = peso / (altura * altura);
        Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

        if (imc < 18.5)
            Console.WriteLine("Magreza");
        else if (imc >= 18.5 && imc < 24.9)
            Console.WriteLine("Normal");
        else if (imc >= 24.9 && imc < 30)
            Console.WriteLine("Sobrepeso");
        else if (imc >= 30 && imc < 35)
            Console.WriteLine("Obesidade grau 1");
        else if (imc >= 35 && imc < 40)
            Console.WriteLine("Obesidade grau 2");
        else
            Console.WriteLine("Obesidade grau 3");
    }
}


