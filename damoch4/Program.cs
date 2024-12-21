using System.Text;
using System.Threading.Tasks;

namespace damoch4;

   class Employee
  {
    public string firstName { get; set; } = "";
    public string? lastName { get; set; } = null;

  }
 class Program
 {
    // contain
    // function
    // data
    #region passing by out
    static void sumMul(int x, int y,out int Sum,out int Mul)
    {
         Sum = x + y;
         Mul = x * y;
        //return sum;
        //return Mul;
        //return new int[] {Sum, Mul }

    
    }
    #endregion
    #region function_params
    public static int sumarr3(int x, int y=5,params int[] arr)
    {
        int sum = 0;
        if (arr != null)
        {
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

        }

        return sum;
    }
    #endregion
    #region function
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
    public static void swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;

    }
    public static void print(string pattern, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(pattern);
        }
    }

    public static void printpattern(string pattern = "#", int count = 10)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(pattern);
        }
    }
    #endregion
    #region Excertion Handling and protective code
    public static void DoSomeCode() { 
    //
    //    try
    //    {
    //        int x, y, z;
    //        Console.WriteLine("please inter x:");
    //        x = int.Parse(Console.ReadLine());
    //        Console.WriteLine("please inter y:");
    //        y = int.Parse(Console.ReadLine());
    //        z = x / y;
    //        int[] arr = { 1, 2, 3 };
    //        arr[100] = 22;
    //    }
    //    catch (FormatException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    catch (DivideByZeroException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    catch (IndexOutOfRangeException ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);
    //    }
        // Execptions
        //1-- system Execption
        //1- formet Execption
        //2-indexout of range Execption
        //3-Nullreference Execption
        //4- invalid opertation Execption
        //5- arithmetic Execption
        //5.1- divided by zero Execption
        //2--Application Execption
    }
    public static void DoSomeProtective()
    {
        int x, y, z;
        //bool flag;
        do
        {
            Console.WriteLine("please inter x:");
            //flag =int.TryParse(Console.ReadLine(), out x);
        }while (!int.TryParse(Console.ReadLine(), out x));
        //x = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("please inter y:");
            //flag =int.TryParse(Console.ReadLine(), out x);
        } while (!int.TryParse(Console.ReadLine(), out y) || y==0);
         //y = int.Parse(Console.ReadLine());
        z = x / y;
        int[] arr = { 1, 2, 3 };
        if(arr?.Length>100)
        {
            arr[100] = 22;
        }
        
    }
    #endregion
    static void Main()
    {
        #region string Vs stringBuilder
        //string name01;

        //name01 = new string("Hassan");
        //string name02 = "Abdo";
        //name02 = name01;
        //name01 = "omar";
        //Console.WriteLine($"Name 01 is {name01}");
        //Console.WriteLine($"Name 02 is {name02}");
        // string is an imutable type cannot change itis value
        //--------------------------
        //string message = "Hello";
        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());
        //message += "hassan";//create new object with different new identity
        //Console.WriteLine(message);
        //Console.WriteLine(message.GetHashCode());

        //-------------------------
        //StringBuilder SB=new StringBuilder();
        //SB.Append("Hello");
        //Console.WriteLine(SB);
        //Console.WriteLine(SB.GetHashCode());
        //SB.Append("Hassan");
        //Console.WriteLine(SB);
        //Console.WriteLine(SB.GetHashCode());
        ////stringBuilder => Reference type work , work as Reference type
        //string name ;
        //name = "Hassan";//12 Bytes
        //name = "Abdo";//8 Bytes


        #endregion
        #region Array
        #region one D Array
        //int[] Number;
        //Number = new int[3];
        //Console.WriteLine(Number[0]);
        //Number[0] = 1;
        //Number[1] = 2;
        //Number[2] = 3;
        //Console.WriteLine(Number[0]);
        //int[] Number2 = new int[3] { 1, 2, 3 };
        //Console.WriteLine(Number2[0]);
        //int[] Number3 = new int[] { 1, 2};
        //int[] Number4 ={ 1, 2, 3 ,4 ,5 };
        //Console.WriteLine($"size of Array ={Number4.Length } Number of dimenision ={Number4.Rank}");
        //for (int i=0; i<Number.Length;i++)
        //{
        //    Console.WriteLine(Number[i]);
        //}




        #endregion
        #region 2D Array
        //int[,] mark = new int[3, 5] { { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99}, { 55, 66, 77, 88, 99} };
        //Console.WriteLine($"size of Array ={mark.Length} ,dimention ={mark.Rank} ");
        // to get input 
        //int[,] mark = new int[2, 4];
        //Console.WriteLine(mark.GetLength(0));//rows
        //Console.WriteLine(mark.GetLength(1));//colums
        //for (int i = 0; i < mark.GetLength(0); i++)
        //{
        //    Console.WriteLine($"enter mark of students number {i+1}");
        //    for (int j = 0; j < mark.GetLength(1); j++)
        //    {
        //        Console.WriteLine($"sub number {j + 1}");
        //        mark[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}
        ////to print inputs
        //for (int i = 0; i < mark.GetLength(0); i++)
        //{
        //    Console.WriteLine($"grades of student number {i+1}");
        //    for (int j = 0; j < mark.GetLength(1); j++)
        //    {
        //        Console.WriteLine($"sub number {j + 1}= {mark[i,j]}");
        //    }
        //}
        #endregion
        #region judged Array
        // judged Array=> one d array of array with differnet sizes
        //int[][] number = new int[3][];
        //number[0]=new int[] {1,2,3};
        //number[1] = new int[] { 4, 5 };
        //number[2] = new int[] { 6 };
        ////print
        //for (int i = 0; i < number.Length; i++)
        //{
        //    for (int j = 0; j < number[i].Length; j++)
        //    {
        //        Console.WriteLine(number[i][j]);
        //    }

        //}
        #endregion

        #endregion
        #region Array methods
        //int[] number = { 5, 1, 5, 3, 4,10 };
        //int[] arr1 = { 1, 2, 3 };
        //int[] arr2 = new int[5];
        #region class member methods [static methods]
        //Array.Sort(number);// sort array in Asc order
        //Array.Copy(arr1,arr2,2);
        //foreach(int num in arr2)
        //{
        //    Console.WriteLine(num);//1  2  0  0  0
        //}
        //Array.Clear(number);//return value to default value

        // Array.ConstrainedCopy(arr1, 1, arr2, 1, 2);
        //------------------------------------------
        //int [] arr3=(int[]) Array.CreateInstance(typeof(int), 10);
        //int[,,] arr4 = (int[,,])Array.CreateInstance(typeof(int), 2, 4, 3);

        #endregion
        #region object member methods
        //arr1.CopyTo(arr2, 1);
        //foreach (int i in arr2)
        //{
        //    Console.WriteLine(i);//{0,1,2,3,0}
        //}
        //arr1.SetValue(100, 1);
        //Console.WriteLine(arr1[1]);

        #endregion

        #endregion
        #region function 
        //function has tow components
        //1- prototype
        //1- signature
        //2- return type
        //3- name
        //4- paremeters
        // body
        //2- calling of function 
        //print("kkkkk",5);
        //printpattern();// passing parameters by order
        // passing parameters by name
        //printpattern( pattern :"@");// Basing by name
        #region pasing value type
        //int a = 3, b = 5;
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //swap(ref a,ref b);
        //Console.WriteLine(a);
        //Console.WriteLine(b);


        #endregion
        #region passing refernce type
        //int[] number = {1,2,3};
        //int reslt = sumarr( number);//pasing by value
        //Console.WriteLine(reslt);
        //Console.WriteLine( number[0]);
        //---------------------------
        //int[] number = { 1, 2, 3 };
        //int reslt = sumarr2(ref number);// passing by refernce
        //Console.WriteLine(reslt);
        //Console.WriteLine(number[0]);

        #endregion
        #region passing by out
        //int A = 10, B = 5, SumResult, MulResult;
        //sumMul(A, B, out SumResult, out MulResult);// passing by out [output parameter]
        //Console.WriteLine($"Sum={SumResult}");
        //Console.WriteLine($"Mul={MulResult}");
        //int age;
        //int.TryParse( Console.ReadLine(), out age );

        #endregion
        #region function_params
        //int[] Number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //int total=sumarr3 (1, 2, 3, 4, 5, 6, 7, 8, 9);
        //Console.WriteLine(total);
        #endregion


        #endregion
        #region Boxing Vs unBoxing
        //Boxing : casting from datatype [value type] to datatype [refernce type]
        //unBoxing : casting from datatype [refernce type] to datatype [value type]
        #region example01
        //object obj;
        //declare for refernce of type "object",refering to null
        // this refernce obj can refer to an instance from type object or any another datatype
        //obj = new object();
        //obj = new string("hassan");
        //obj = 'A';//casting from char [value type to object [refernce type]]// implicitly
        //obj = 3;//casting from int [value type to object [refernce type]]// implicitly//boxing
        //obj = true;////casting from bool [value type to object [refernce type]]// implicitly//boxing
        //bool flag = (bool)obj;
        //Console.WriteLine(flag);//unboxing / explicit casting // unsafe casting
        //#endregion
        //#region example02
        //int x = 5;
        //object 01 = x;

        #endregion
        #region example02
        // boxing
        //int x = 5;
        //object a = x;
        //casting from int [value type to object [refernce type]]// implicitly//boxing
        // 5  ---------> new object (5)//boxing
        // parent=child xxxx
        // animal = dog xxxx
        // boxing [safe casting]// implicit casting
        //Console.WriteLine(a);
        //unboxing
        //object b = 10;
        //b = "hassan";
        //int y = (int)b;
        //casting from datatype [refernce type] to datatype [value type]//explicit
        //unboxing unsafe casting :my be there exceptions[invalid casting explicit]
        // new object (10)-----------> 10
        // chiled = parent

        #endregion
        #endregion
        #region Nullable value type
        // Null=> is valid value for datetype refernce type only
        //---------------------------------

        //int? age;// Nullable integer : allow null for int (int value + null)//Nullable<int>age; this code is syntax sugar for int? age;
        //age = 10;
        //age = null;
        //-----------------------------------
        //nullable double : (double values + null)
        //Nullable<double>salary;
        //double? salary;//syntax sugar
        //salary = 22.5;
        //salary = null;


        #endregion
        #region how to work with nullable value type
        //int x = 5;
        //int? y ;
        //y = x;// safe
        ////-----------------
        //int? k = 10;
        //k = null;
        //int l = 20;

        //l =(int) k;// unsafe
        //----------

        //if (k != null)
        //{
        //    l = (int)k;
        //}
        //else
        //{
        //    l =0;       
        //}
        //l=k.HasValue ? k.Value : l;
        //c oleasing operater
        //l = k ?? 0;// syntax sugar

        #endregion
        #region Nullable Refernce type
        //string message = "hhi";
        //message = null;
        //string? message02= null;
        //Console.WriteLine(message);
        //Console.WriteLine(message02);
        //-------------------
        //string nonull = "hello";
        //string? Nullable = default;
        //nonull = Nullable!;//null forgivness 

        #endregion
        #region Null propagation operater
        //double x = default;
        //int[]? number = {1,2,3,4};
        //for (int i = 0;(number!=null)&&(i<number.Length);i++)//dereferenceing
        //{
        //    Console.WriteLine(number[i]);
        //}
        //if (number != null)
        //{
        //    for (int i = 0;i < number?.Length; i++)//dereferenceing
        //    {
        //        Console.WriteLine(number[i]);
        //    }

        //}
        //====================
        //int? length = number?.Length;
        //number != null ? number.Length : null;//Null propagation operater
        //int length = number?.Length ?? 0;//coleasing operater
        #endregion
        #region Excertion Handling and protective code
        DoSomeProtective();
        #endregion

    }
}
