Console.Write("Yarıçap uzunluğu giriniz : ");
double radius = int.Parse(Console.ReadLine());
double thickness = 0.8;
double rin = radius - thickness, rOut = radius + thickness;

   

    for (double y = radius; y >= -radius;y--)
    {
        for (double x = -radius; x <= rOut; x += 0.6)
        {
            double value = x * x + y * y;
            if (value >= rin * rin && value <= rOut * rOut)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }

Console.Read();
