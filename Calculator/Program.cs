//calculadora
int option = 0;
double x, y;
Console.WriteLine("Calculadora\n");
Console.WriteLine("Digite o primeiro número: ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nDigite o Segundo número: ");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Selecione uma das operações que deseja executar(Apenas o número da opção): \n");
Console.WriteLine("1.Soma");
Console.WriteLine("2.Subtração");
Console.WriteLine("3.Multiplicação");
Console.WriteLine("4.Divisão");
option = Convert.ToInt32(Console.ReadLine());


switch (option)
{
    case 1:
        Console.WriteLine($"O resultado da soma é {x + y:0.00}");
        break;
    case 2:
        Console.WriteLine($"O resultado da subtração é {x - y:0.00}");
        break;
    case 3:
        Console.WriteLine($"O resultado da multiplicação é {x * y:0.00}");
        break;
    case 4:
        Console.WriteLine($"O resultado da divisão é {x / y:0.00}");
        break;
}