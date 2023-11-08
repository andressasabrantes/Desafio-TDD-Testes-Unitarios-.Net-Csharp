using Calculadora.Services;

CalculadoraImp c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"A soma entre {num1} + {num2} é de: {c.Somar(num1, num2)}");
