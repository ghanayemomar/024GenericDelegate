class Proram
{
    //public delegate bool Filter<in T>(T n);
    static void Main(string[] args)
    {
        IEnumerable<int> list1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintNumber(list1, n => n < 6, () =>Console.WriteLine("hello"));
    }



    static void PrintNumber<T>(IEnumerable<T> numbers, Predicate<T> filter,Action action)
    {
        action();
        foreach (var n in numbers)
        {
            if (filter(n))
            {
                Console.WriteLine(n);
            }
        }
    }

    //static void PrintNumbersLessThanSix(IEnumerable<int> numbers)
    //{
    //    foreach (int number in numbers)
    //    {
    //        if (number < 6)
    //        {
    //            Console.WriteLine(number);
    //        }
    //    }
    //}

    //static void PrintNumbersLessThanSeven(IEnumerable<int> numbers)
    //{
    //    foreach (int number in numbers)
    //    {
    //        if (number < 7)
    //        {
    //            Console.WriteLine(number);
    //        }
    //    }
    //}

    //static void PrintNumbersLessThan(IEnumerable<int> numbers , int pivotNumber)
    //{
    //    foreach (int number in numbers)
    //    {
    //        if (number < pivotNumber)
    //        {
    //            Console.WriteLine(number);
    //        }
    //    }
    //}





}