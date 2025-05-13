using System;
using System.ComponentModel;

class URI {

    static void Main(string[] args) {
        // Pergunta inicial do usuário
        Console.WriteLine("Qual operação deseja?");
        Console.WriteLine("Soma (Tecle 1)");
        Console.WriteLine("Subtração (Tecle 2)");
        Console.WriteLine("Multiplicação (Tecle 3)");
        Console.WriteLine("Divisão (Tecle 4)");

        double op = double.Parse(Console.ReadLine());

        // Condição de acordo com o que o usuário escolher
        // Operação de SOMA
        if (op == 1) {
            Console.WriteLine("Você entrou na SOMA");
            Console.WriteLine("Digite o número que deseja: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());
            double SR = numero1 + numero2;
            Console.WriteLine("O resultado da Soma é: " + SR);
        // Operação de SUBTRAÇÃO
        } else if (op == 2) {
            Console.WriteLine("Você entrou na SUBTRAÇÃO");
            Console.WriteLine("Digite o número que deseja: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());
            double MR = numero1 - numero2;
            Console.WriteLine("O resultado da Subtração é: " + MR);
        // Operação de MULTIPLICAÇÃO
            } else if (op == 3) {
            Console.WriteLine("Você entrou na MULTIPLICAÇÃO");
            Console.WriteLine("Digite o número que deseja: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());
            double XR = numero1 * numero2;
            Console.WriteLine("O resultado da Multiplicação é: " + XR);
        // Operação de DIVISÃO
        } else if (op == 4) {
            Console.WriteLine("Você entrou na DIVISÃO");
            Console.WriteLine("Digite o número que deseja: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());
            double DR = numero1 / numero2;
            Console.WriteLine("O resultado da Divisão é: " + DR);
        // Caso o usuário digite errado
        } else {
            Console.WriteLine("Opção inválida");
        }
    }

}