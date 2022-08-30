using System;

class Program {
  public static void Main (string[] args) {
    double prev1=0;
    double prev2=1;
    string userString;
    int userInput;

    Console.WriteLine("Pick how many fibbonaci numbers");
    userString = Console.ReadLine();
    userInput = int.Parse(userString);

    for(int i =1; i<userInput; i++)
    {
      if(a==1)
        Console.Write(a+",");

      if (i>=1)
      {
        prev2=prev1;
        perv1=a;
        Console.Write(a+",");
        a = prev1+prev2;
      }
Console.ReadLine();



      

    }


    

    
    }
  }
}