using System;

public class Professor
{
    private string _lNumber;
    private string _firstName;
    private string _lastName;
    private string _department;

    public Professor(string lNumber, string firstName, string lastName, string department)
    {
        LNumber = lNumber;
        FirstName = firstName;
        LastName = lastName;
        Department = department;
    }

    public string LNumber
    {
        get { return _lNumber; }
        set
        {
            if (value.Length != 9 || !value.StartsWith("L00"))
            {
                throw new ArgumentException("Invalid LNumber format. LNumber should start with 'L00' and have 9 characters.");
            }
            _lNumber = value;
        }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }

    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }

    public override string ToString()
    {
        return $"LNumber: {LNumber}, Name: {FirstName} {LastName}, Department: {Department}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Testing the Professor class
        try
        {
            //Creating a Professor object
            Professor prof = new Professor("L00647764", "Daryl", "Dixon", "Computer Science");

            //Displaying professor information
            Console.WriteLine(prof);

            //Changing department
            prof.Department = "Mathematics";
            Console.WriteLine("After department change:");
            Console.WriteLine(prof);

            //Trying to set an invalid LNumber to test error handling
            prof.LNumber = "L12345678"; //This should throw an exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Testing incorrect Lnumber error handling: " + ex.Message);
        }
    }
}
