// See https://aka.ms/new-console-template for more information
using System;
using Trials;



Console.WriteLine("Hello, World!");
Console.WriteLine(Algos.sumOfN(5));


BaseClass obj1 = new ChildClass();
obj1.Greetings();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("my job is here");
}


int n = 0;
while(n < 10)
{
    n++;
    Console.WriteLine("yes");
}

public class BaseClass
{
    public virtual void Greetings()
    {
        Console.WriteLine("say hello");
    }

     
}



public class ChildClass: BaseClass
{
    public override void Greetings()
    {
        Console.WriteLine("hello word");    
    }


}

//public static class Algos
//{
//    public static int[] sumOfN(int n)
//    {
//        int magnitude = Math.Abs(n);
//        int factor = n < 0 ? -1 : 1;
//        int[] result = new int[magnitude + 1];
//        result[0] = 0;

//        // return Enumerable.Range(0, magnitude + 1).Select(num => num * (num + 1) / 2) * factor.ToArray();

//        for (int i = 1; i <= magnitude; i++)
//        {
//            result[i] = result[i - 1];
//            result[i] += i * factor;

//        }
//        return result;


//    }
//}





