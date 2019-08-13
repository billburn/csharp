using System;

public class Example
{
   public static void Main()
   {
      int value = 2;
      for (int power = 0; power <= 128; power++)
         Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})", 
                           value, power, (long)Math.Pow(value, power));
   }
}