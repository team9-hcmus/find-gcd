// C# program to find GCD of two
// numbers
using System;
 
class GFG {
     
    // Recursive function to return
    // gcd of a and b
    static int gcd(int a, int b)
    {
         
        // Everything divides 0 
        if (a == 0)
          return b;
        if (b == 0)
          return a;
     
        // base case
        if (a == b)
            return a;
     
        // a is greater
        if (a > b)
            return gcd(a - b, b);
             
        return gcd(a, b - a);
    }
     
    // Driver method
    public static void Main() 
    {
        int a = 98, b = 56;
        Console.WriteLine("GCD of "
          + a +" and " + b + " is "
                      + gcd(a, b));
    }
}
