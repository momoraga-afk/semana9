        const int NUM_DIAS = 7; // Número de días a registrar
        double[] ventas = new double[NUM_DIAS];
        double totalVendido = 0;
        int diasSuperaron150 = 0;
        double ventaMasBaja = double.MaxValue;

        for (int i = 0; i < NUM_DIAS; i++)
        try
        {  
                        Console.Write($"Ingrese las ventas del día {i + 1}: ");
            ventas[i] = Convert.ToDouble(Console.ReadLine());

            totalVendido += ventas[i];

            if (ventas[i] > 150)
            {
                diasSuperaron150++;
            }

            if (ventas[i] < ventaMasBaja)
            {
                ventaMasBaja = ventas[i];
            } 
        }
        catch (FormatException)
        {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("Valor no válido. Por favor ingrese un número entero");
             Console.ResetColor();
             i--;
        }       

        Console.WriteLine($"\nTotal vendido: {totalVendido}");
        Console.WriteLine($"Número de días con ventas superiores a 150: {diasSuperaron150}");
        Console.WriteLine($"Venta más baja registrada: {ventaMasBaja}");
