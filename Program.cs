using System;

namespace ddzz6
{
    class Program
    {
         static int[] Reverse(int[] arr) 
        { 
            int[] t=new int[arr.Length]; 
            for(int i=0; i<arr.Length; i++) 
            {
                t[i]=arr[i]; 
            }
            for(int i=0;i<t.Length;i++) 
            {
                arr[i]=t[arr.Length-i-1]; 
            }
            return arr; 
        } 
 
        static int[] ArrPart(int[] arr, int index, int count) 
        { 
            int[] t=new int[count]; 
            for(int i=0; i<count; i++) 
                if(i+index<arr.Length) 
                    t[i]=arr[i+index]; 
                else t[i]=1; 
            return t; 
        }
 
        static void Main(string[] args) 
        { 
            Console.WriteLine("ZADANIE#2"); 
            int s=Convert.ToInt16(Console.ReadLine()); 
            int[] x=new int[s]; 
 
            for(int i=0; i<x.Length; i++) 
                {
                    x[i] = i;
                    Console.WriteLine($"x[{i}] = {i}");
                } 

            double m1=x[0], m2=x[0], c=0, a; 
            for(int i=0; i<x.Length; i++) 
            { 
                if(m1<x[i])
                { 
                    m1=x[i]; 
                }

                if(m2>x[i])
                { 
                    m2=x[i]; 
                }

                c+=x[i]; 
            } 
            a=c/x.Length; 
            Console.WriteLine($"min = {m2}\nmax = {m1}\nСумма = {c}\nСреднее арефметическое = {a}"); 
            Console.WriteLine("Все нечётные элементы: ");
            for(int i=0; i<x.Length; i++) 
            {
                if(x[i]%2==1) 
                {
                    Console.WriteLine(x[i]); 
                }
            }
            Console.WriteLine("ZADANIE#3"); 
            x=Reverse(x); 
            Console.WriteLine("Перевёрнутый массив: ");
            for(int i=0; i<x.Length; i++) 
                Console.WriteLine(x[i]);  
 
            Console.WriteLine("ZADANIE#4"); 
            int n=Convert.ToInt32(Console.ReadLine()); 
            int[] y=new int[n]; 
            Console.WriteLine("Массив: ");
            for(int i=0; i<n; i++) 
            { 
                y[i]=i; 
                Console.WriteLine(y[i]); 
            } 
            Console.Write("Index = "); 
            int index=Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Count = "); 
            int count=Convert.ToInt32(Console.ReadLine()); 
 
            y=ArrPart(y,index,count); 
            Console.WriteLine($"Часть массива начиная с индекса {index}, {count} значений");
            for(int i=0; i<y.Length; i++) 
            { 
                Console.WriteLine(y[i]); 
            } 
 
        } 
    }
}