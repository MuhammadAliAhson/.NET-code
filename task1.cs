using System;

public class HelloWorld
{
      public int Prime(int n)  
        {  
         int  i, m=0, flag=0;    
          Console.Write("Enter the Number to check Prime: ");    
          n = int.Parse(Console.ReadLine());  
          m=n/2;    
          for(i = 2; i <= m; i++)    
          {    
           if(n % i == 0)    
            {    
             Console.Write("Number is not Prime.");    
             flag=1;    
             break;    
            }    
          }    
          if (flag==0)    
           Console.Write("Number is Prime.");       
           return n;
           }  
           //=================================================//
     public int Resursion(int n)  
        {
            if(n == 0){
                return 1;
            }
            return n* Resursion(n-1);
           }  
    //==========================================================//
    public void Palindrome(){
        
          int n,r,sum=0,temp;    
          Console.Write("Enter the Number: ");   
          n = int.Parse(Console.ReadLine());  
          temp=n;      
          while(n>0)      
          {      
           r=n%10;      
           sum=(sum*10)+r;      
           n=n/10;      
          }      
          if(temp==sum)      
           Console.WriteLine("Number is Palindrome.");      
          else      
           Console.WriteLine("Number is not Palindrome");     
    }  
  //=======================================================================//
     public void StringReverse(){
        string a;
          Console.Write("Enter the String: ");   
          a = Convert.ToString(Console.ReadLine()); 
          string []b= a.Split(' ');
        for(int i=(b.Length-1);i>=0;i--){
              Console.Write(b[i] + " ");    
        }
    }  
    
    
    
    public static void Main(string[] args)
    {
        int choice=0;
        int a;
        int b;
        Console.WriteLine("Welcome to the Fat Calculator System");
       Console.WriteLine("Press 1 for Addition ");
       Console.WriteLine("Press 2 for Subtraction");
       Console.WriteLine("Press 3 for Multiplication");
       Console.WriteLine("Press 4 for Modular division");
       Console.WriteLine("Press 5 for Prime number");
       Console.WriteLine("Press 6 for Factorial using recursion");
       Console.WriteLine("Press 7 for Square root of a number");
        Console.WriteLine("Press 8 for Palindrome Checking");
        Console.WriteLine("Press 9 for String reverse");
      
        choice =Convert.ToInt32(Console.ReadLine());
       if( choice == 1){
            Console.WriteLine("Enter First Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Second Digit ");
           b =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine(a+b);
           
       }
       else if( choice == 2){
             Console.WriteLine("Enter First Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Second Digit ");
           b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a-b);
           
       }
       else if( choice == 3){
             Console.WriteLine("Enter First Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Second Digit ");
           b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a*b);
           
       }else if( choice == 4){
             Console.WriteLine("Enter First Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter Second Digit ");
           b =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a%b);
           
       }else if( choice == 5){
             Console.WriteLine("Enter First Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           HelloWorld good=new HelloWorld();
          b= good.Prime(a);
           
       }else if( choice == 6){
             Console.WriteLine("Enter First Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           HelloWorld good=new HelloWorld();
          b= good.Resursion(a);
           Console.WriteLine(b);
          
       }else if( choice == 7){
           Console.WriteLine("Enter Digit ");
           a =Convert.ToInt32(Console.ReadLine());
           double result = Math.Sqrt(a);
            Console.WriteLine(result);
       }
       else if(choice == 8){
           HelloWorld good=new HelloWorld();
          good.Palindrome();
       }
       else if(choice == 9){
            HelloWorld good=new HelloWorld();
          good.StringReverse();
       }
    }
}