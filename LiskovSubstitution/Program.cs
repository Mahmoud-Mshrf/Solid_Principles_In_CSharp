namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // Liskov Substitution Principle
    // Derived classes must be substitutable for their base classes.
    // In other words, a derived class should be able to replace its base class without affecting the behavior of the system.
    // This principle is important because it ensures that a class can be replaced with its subclass without affecting the functionality of the program.
    // This principle ensures that inheritance (one of the OOP principles) is used correctly.

    //If an override method does nothing or just throws an exception, then you're probably violating the LSP
    // It can apply to inheritance or interface
    /*
    * The four conditions for abiding by the Liskov Substitution principle are as follows:
    * Condition 1 Contravariance: Method signatures must match: Methods
      must take the same parameters; the parameters of the overriding methods
      should be the same or more generic than the types of the parent’s method
      parameters (it is not allowed in java but allowed in PHP to generalize the
      parameters for overloaded method). 
      Example:

      class Parent
      {
          public virtual void PrintDetails(object obj)
          {
              Console.WriteLine("Parent: " + obj);
          }
      }
      
      class Child : Parent
      {
          // Violates LSP: Child narrows parameter to String
          public override void PrintDetails(string str)
          {
              Console.WriteLine("Child: " + str);
          }
      }

      To comply with LSP:
      class Child : Parent
      {
          // Matches parent's parameter type
          public override void PrintDetails(object obj)
          {
              Console.WriteLine("Child: " + obj);
          }
      }


    * Condition 2: Preconditions cannot be strengthened in the subtype The
      preconditions for any method can’t be greater than that of its parent; Any
      inherited method should not have more conditionals that change the
      return of that method, such as throwing an Exception. For example, if the
      parent method in the parent class accepts an integer number while in an
      overridden method in the child class, you added a condition to accept the
      only positive integer number, that change in the child class violates LSP.
      Example:

      class Parent
      {
          public virtual void ProcessNumber(int number)
          {
              Console.WriteLine("Parent: " + number);
          }
      }
      
      class Child : Parent
      {
          // Violates LSP: Adds stricter precondition
          public override void ProcessNumber(int number)
          {
              if (number < 0)
              {
                  throw new ArgumentException("Only positive numbers allowed");
              }
              Console.WriteLine("Child: " + number);
          }
      }

      To comply with LSP:
      class Child : Parent
      {
          public override void ProcessNumber(int number)
          {
              Console.WriteLine("Child: " + number);
          }
      }

    * Condition 3: Postconditions cannot be weakened in the subtype
      Postconditions must be at least equal to that of its parent;
      Inherited methods should return the same type as that of their parent. For example,
      if the method in the parent class creates a connection to DB and at the end
      of the method, you close the connection, while in the child you keep the
      connection open, that changes in the child class violate LSP.
      Example:

      class Parent
      {
          public virtual string ConnectToDatabase()
          {
              // Establish connection and close it
              return "Connection closed";
          }
      }
      
      class Child : Parent
      {
          // Violates LSP: Weakens postcondition by leaving the connection open
          public override string ConnectToDatabase()
          {
              return "Connection left open";
          }
      }

      To comply with LSP:
      class Child : Parent
      {
          public override string ConnectToDatabase()
          {
              // Same postcondition as parent
              return "Connection closed";
          }
      }


    * Condition 4: Exception types must match; If a method is designed to
      return a FileNotFoundException in the event of an error, the same
      condition in the inherited method must return a FileNotFoundException too.
      Example:

      class Parent
      {
          public virtual void ReadFile()
          {
              // Read file logic
              throw new IOException("File not found");
          }
      }
      
      class Child : Parent
      {
          // Violates LSP: Throws unrelated exception
          public override void ReadFile()
          {
              throw new InvalidOperationException("Invalid operation while reading file");
          }
      }

      To comply with LSP:
      class Parent
      {
          public virtual void ReadFile()
          {
              // Read file logic
              throw new IOException("File not found");
          }
      }
      
      class Child : Parent
      {
          // Matches or throws a subclass of the parent exception
          public override void ReadFile()
          {
              throw new FileNotFoundException("File not found");
          }
      }

    */
}
