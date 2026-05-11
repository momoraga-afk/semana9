double [] temp1 = new double [7];
double [] tempPromedio = new double [7];

Console.WriteLine("Inserte las temperaturas de la semana");
for (int i = 0; i < temp1.Length; i++)
try
{
    Console.WriteLine($"Día {i + 1}:");
    temp1[i] = Convert.ToDouble(Console.ReadLine());  
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
    Console.ResetColor();
    i--;
}
double suma = 0;
for (int i = 0; i < temp1.Length; i++) 
{
    suma += temp1[i];
}
double promedio = suma / temp1.Length;
Console.WriteLine($"La temperatura promedio de la semana es: {promedio}");
Console.WriteLine("Las temperaturas más alta es: " + temp1.Max());
Console.WriteLine("Las temperaturas más baja es: " + temp1.Min());