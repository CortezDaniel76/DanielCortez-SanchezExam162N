using System;

class Eliza
{
    //generate Eliza's response based on the user's statement
    public static string CreateElizaResponse(string statement)
    {
        //If the statement contains "my"
        if (statement.Contains("my"))
        {
            //Find the index of "my" and the index of the next space/blank
            int myIndex = statement.IndexOf("my");
            int spaceIndex = statement.IndexOf(" ", myIndex);

            //If there's a space after "my", extract the noun
            if (spaceIndex != -1)
            {
                string noun = statement.Substring(spaceIndex + 1);
                return "Tell me more about your " + noun + ".";
            }
            //this is mostly for error handling and to keep program running
            else
            {
                return "Tell me more about your.";
            }
        }
        //if statement contains "love" or "hate"
        else if (statement.Contains("love") || statement.Contains("hate"))
        {
            return "You have strong feelings about that!";
        }
        //default response 
        else
        {
            string[] defaultResponses = { "Please go on.", "Tell me more.", "Continue." };
            Random rand = new Random();
            return defaultResponses[rand.Next(0, defaultResponses.Length)];
        }
    }

    static void Main(string[] args)
    {
        //Continuously prompt the user for input
        while (true)
        {
            Console.Write("Enter your statement: ");
            string statement = Console.ReadLine();
            string response = CreateElizaResponse(statement);
            Console.WriteLine("Eliza: " + response + "\n");
        }
    }
}
