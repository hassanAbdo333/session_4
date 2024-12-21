using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment4;

class Program
{
    #region function
    #region p1
    public static void swap(int x, int y)//by value
    {
        int temp = x;
        x = y;
        y = temp;

    }
    public static void swap2(ref int x,ref int y)//by value
    {
        int temp = x;
        x = y;
        y = temp;

    }
    #endregion
    #region p2
    public static int sumarr(int[] arr)
    {
        int sum = 0;
        //arr[0] = 100;
        arr = new int[] { 4, 5, 6 };
        if (arr != null)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];//sum = sum + arr[i]

            }
        }
        return sum;

    }
    public static int sumarr2(ref int[] arr)
    {
        int sum = 0;
        //arr[0] = 100;
        arr = new int[] { 4, 5, 6 };
        if (arr != null)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];//sum = sum + arr[i]

            }
        }
        return sum;

    }
    #endregion
    #region p3
    static void sumMul(int x, int y, out int Sum, out int Sub)
    {
        Sum = x + y;
        Sub = x - y;
    }
    #endregion
    #region p4
    public static int sum(int number)
    {
        int x = number / 10;
        int y = number - (x * 10);
        int sum = x + y;
        return sum;
        
    }
    #endregion
    #region p5
    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2;i <Math.Sqrt(number);i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    #endregion
    #region p6
    static void MinMaxArray(ref int[] array, out int min, out int max)
    {
         max = array[0];
         min = array[0];

        for (int i = 1; i <array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

    }
    #endregion
    #region p7
    public static int factorial(int number)
    {
        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        return factorial;

    }
    #endregion
    #region p8
    public static void ChangeChar(ref string name, char letter, int pos)
    {
        char[] charArray = name.ToCharArray();

        charArray[pos] = letter;
        name = new string(charArray);
    }
    #endregion
    #endregion
    private static void Main(string[] args)
    {
        #region Array
        #region p01
        //double[] point1=new double[2];
        //double[] point2 = new double[2];
        //double[] point3 = new double[2];
        //Console.WriteLine("please enter point 1: ");
        //foreach(int i in point1)
        //    Console.ReadLine();
        //double x1=point1[0];
        //double y1=point1[1];
        //Console.WriteLine("please enter point 2: ");
        //foreach (int i in point2)
        //    Console.ReadLine();
        //double x2=point2[0];
        //double y2=point2[1];
        //Console.WriteLine("please enter point 3: ");
        //foreach (int i in point3)
        //    Console.ReadLine();
        //double x3 =point3[0];
        //double y3 =point3[1];

        //double area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

        //if (area == 0)
        //{
        //    Console.WriteLine("The points lie on a single straight line.");
        //}
        //else
        //{
        //    Console.WriteLine("The points do not lie on a single straight line.");
        //}

        #endregion
        #region p02
        //Console.Write("please Enter the time (in hours) : ");
        //double timeTaken = double.Parse(Console.ReadLine());

        //if (timeTaken >= 2 && timeTaken < 3)
        //{
        //    Console.WriteLine("The worker is highly efficient.");
        //}
        //else if (timeTaken >= 3 && timeTaken < 4)
        //{
        //    Console.WriteLine("The worker needs to increase their speed.");
        //}
        //else if (timeTaken >= 4 && timeTaken <= 5)
        //{
        //    Console.WriteLine("The worker is given training to enhance their speed.");
        //}
        //else if (timeTaken > 5)
        //{
        //    Console.WriteLine("The worker is required to leave the company.");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Time should be 2 hours or more.");
        //}
        #endregion
        #region p03
        //Console.Write("Enter the size of the identity matrix (n): ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter the Number: ");
        //int num = int.Parse(Console.ReadLine());
        //Console.WriteLine("Identity Matrix of size {0} x {0}:", n);

        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //            Console.Write($" {num}");

        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region p04

        //int[] numbers = {1,2,3,4,5}; ;
        //int Sum = 0;
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Sum += numbers[i];

        //}
        //Console.WriteLine($"The Sum of Array :{Sum}");
        #endregion
        #region p05
        //int[] arr1 = { 1, 2, 3, 4 };
        //int[] arr2 = { 5, 6, 7 ,8};
        //int[] arr3 = arr1.Concat(arr2).ToArray();
        //Array.Sort(arr3);
        //foreach (int i in arr3)
        //    Console.WriteLine(i);
        #endregion
        #region p06

        //int[] Arr = {2,2,3,3,4};
        //int[] frequency = new int[5];
        //int Count = 0;
        //for (int i = 0; i<5; i++)
        //{
        //    for (int j = 0; j <5; j++)
        //    {
        //        if (Arr[i] == Arr[j])
        //        {
        //            Count++;
        //        }   
        //    }
        //    frequency[i] = Count;
        //    Count = 0;

        //}
        //for (int z = 0; z < frequency.Length; z++)
        //    Console.WriteLine(frequency[z]);
        #endregion
        #region p07
        //Console.Write("Enter the size of the array: ");
        //int size = int.Parse(Console.ReadLine());

        //int[] array = new int[size];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write($"Element {i + 1}: ");
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        //int max = array[0];
        //int min = array[0];

        //for (int i = 1; i < size; i++)
        //{
        //    if (array[i] > max)
        //    {
        //        max = array[i];
        //    }

        //    if (array[i] < min)
        //    {
        //        min = array[i];
        //    }
        //}

        //Console.WriteLine($"Maximum element in the array: {max}");
        //Console.WriteLine($"Minimum element in the array: {min}");
        #endregion
        #region p08
        //int[] array = {1,7,9,5,3};

        //int max = array[0];
        //int max02 = array[0];

        //for (int i = 1; i < array.Length; i++)
        //{

        //    if (array[i] > max)
        //    {
        //        max02 = max;
        //        max = array[i];
        //    }
        //    else if (array[i] > max02 && array[i] != max)
        //    {
        //        max02 = array[i];
        //    }

        //}

        //    Console.WriteLine(max02);
        #endregion
        #region p09
        //int[] array = new int[10];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < 10; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
        //int maxDis = -1;
        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (firstOccurrence.ContainsKey(array[i]))
        //    { 
        //        int distance = i - firstOccurrence[array[i]] - 1;
        //        if (distance > maxDis)
        //        {
        //            maxDis = distance;
        //        }
        //    }
        //    else
        //    {
        //        firstOccurrence[array[i]] = i;
        //    }
        //}
        //Console.WriteLine($"the maxDistance : {maxDis}");
        #endregion
        #region p10
        //Console.WriteLine("Enter a space-separated list of words:");
        //string input = Console.ReadLine();
        //string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //Array.Reverse(words);
        //string ReverseWords= string.Join(" ", words);
        //Console.WriteLine(ReverseWords);
        #endregion
        #region p11
        //int[,] a = new int[3,3];
        //int[,] b = new int[3,3];
        //for (int i = 0; i < a.GetLength(0); i++)
        //{
        //    for (int j = 0; j < a.GetLength(1); j++)
        //    {
        //        Console.Write($"Enter value for element ({i + 1}, {j + 1}): ");
        //        a [i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        b[i, j] = a[i, j];
        //    }
        //}
        //for (int i = 0;i < b.GetLength(0); i++)
        //{
        //    for (int j = 0; j < b.GetLength(1); j++)
        //    {
        //        Console.Write(b[i,j]+" ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region p12
        //int[] array = new int[10];
        //Console.WriteLine("Enter the elements of the array:");
        //for (int i = 0; i < 10; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}
        //for (int i = 9;i >= 0; i--)
        //{
        //    Console.WriteLine(array[i]);
        //}
        #endregion
        #endregion
        #region function
        #region p1
        //int num1 = 9, num2 = 7;
        //Console.WriteLine(num1);//9
        //Console.WriteLine(num2);//7
        //swap(num1,num2);
        //Console.WriteLine(num1);//9
        //Console.WriteLine(num2);//7
        //swap2(ref num1,ref num2);
        //Console.WriteLine(num1);//7
        //Console.WriteLine(num2);//9
        #endregion
        #region p2
        //int[] number = { 1, 2, 3 };
        //int reslt = sumarr(number);//pasing by value
        //Console.WriteLine(reslt);
        //Console.WriteLine(number[0]);
        ////---------------------------
        //int[] numbers = { 1, 2, 3 };
        //int reslts = sumarr2(ref number);// passing by refernce
        //Console.WriteLine(reslt);
        //Console.WriteLine(number[0]);

        #endregion
        #region p3
        //int A = 10, B = 3, SumResult, SubResult;
        //sumMul(A, B, out SumResult, out SubResult);// passing by out [output parameter]
        //Console.WriteLine($"Sum={SumResult}");
        //Console.WriteLine($"Sub={SubResult}");
        #endregion
        #region p4
        //int num = 25;
        //int Sum = sum(num);
        //Console.WriteLine(Sum);
        #endregion
        #region p5
        //int number = 27;
        //bool result = IsPrime(number);

        //if (result)
        //{
        //    Console.WriteLine($"{number} is a prime number.");
        //}
        //else
        //{
        //    Console.WriteLine($"{number} is not a prime number.");
        //}
        #endregion
        #region p6
        //int[] number = { 1, 2, 3 };
        //int minreslt=0, maxreslt=0;
        // MinMaxArray(ref number,out minreslt,out maxreslt);
        //Console.WriteLine($"the Min :{minreslt} , the Max :{maxreslt}");
        #endregion
        #region p7
        //int x = 5;
        //int f = factorial(x);
        //Console.WriteLine(f);
        #endregion
        #region p8
        //string Name = "hassan";
        //char lter = 'Z';
        //int pos = 5;
        //Console.WriteLine(Name );
        //ChangeChar(ref Name,lter,pos);
        //Console.WriteLine(Name);


        #endregion
        #endregion

    }
}