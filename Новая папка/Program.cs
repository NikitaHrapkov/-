Console.WriteLine("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int max = a;

        if(b > max)
        {
            Console.WriteLine (b);
        }
        else if (b < max)
        {
            Console.WriteLine (a);
        }
