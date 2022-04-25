int NumeroDigitado; 

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite um número: ");
 Console.ResetColor();
NumeroDigitado = Convert.ToInt32(Console.ReadLine());


bool NumeroEhPar = (NumeroDigitado % 2) ==0;

if (NumeroEhPar)

 {
       Console.ForegroundColor = ConsoleColor.DarkYellow;
       Console.WriteLine($"{NumeroDigitado} É PAR");
 }

else 
{
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine($"{NumeroDigitado} É IMPAR");
}

Console.ResetColor();