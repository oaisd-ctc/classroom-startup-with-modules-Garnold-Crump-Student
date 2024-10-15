using System;

public class Program
{ 
    public static void Main(string[] args)
    {
        FindSeat();
        SignIn();
        DailyLogic();
        BoxBreathing();
        DailyHypothetical();

       
       
        // STEP 3.b - Uncomment the lines below after your functions have been defined
        // FindSeat();
        // SignIn();
        // DailyLogic();
    }

    public static void FindSeat()
    {
 Console.WriteLine("Walk in the room.");
        Console.WriteLine("Walk towards desk.");
        Console.WriteLine("Pull out chair.");
        Console.WriteLine("Take off backpack.");
        Console.WriteLine("Place backpack on the ground.");
        Console.WriteLine("Sit down in chair.");
        Console.WriteLine("Turn on computer.");
    }

    public static void SignIn()
    {
 Console.WriteLine("Sign in to computer.");
        Console.WriteLine("Open browser.");
      
    }

    public static void DailyLogic()
    {
  Console.WriteLine("Navigate to the Daily Logic Classroom.");
        Console.WriteLine("Complete the Daily Logic for the day.");
    }

    public static void BoxBreathing( )
    {
        int Time = 5;
        Console.WriteLine("Inhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Exhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Inhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Exhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Inhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Exhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Inhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Exhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Inhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
        Console.WriteLine("Exhale for " + ( Time ) + " seconds.");
        Console.WriteLine("Hold breath for " + ( Time ) + " seconds.");
    }

       public static void DailyHypothetical() 
       {

        Console.WriteLine("Open a new tab in the browser.");
        Console.WriteLine("Navigate to Google.");
        Console.WriteLine("Open Gmail.");
        Console.WriteLine("Read Daily Hypothetical.");
        Console.WriteLine("Talk to neighbors about Daily Hypothetical.");
        Console.WriteLine("Respond to Daily Hypothetical email.");

       }

    /**
    * Create functions for Box Breathing and Daily Hypotheticals below:
    */

}