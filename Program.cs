int NumeroDigitado; 

Console.Write("Digite um número: ");
NumeroDigitado = Convert.ToInt32(Console.ReadLine());

bool NumeroEhPar = (NumeroDigitado % 2) ==0;

if (NumeroEhPar)

 {
       Console.ForegroundColor = ConsoleColor.DarkYellow;
       Console.WriteLine($"{NumeroDigitado} é par");
 }

else 
{
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine($"{NumeroDigitado} é inpar");
}

Console.ResetColor();