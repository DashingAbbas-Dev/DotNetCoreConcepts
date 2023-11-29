using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCoreConcepts
{
    #region Extension Method
    // Here Geek class contains three methods 
    // Now we want to add two more new methods in it  
    // Without re-compiling this class 
    class ExtensionMethod
    {

        // Method 1 
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2 
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3 
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }

    }

    // This class contains M4 and M5 method 
    // Which we want to add in Geek class. 
    // NewMethodClass is a static class 
    static class NewMethodClass
    {

        // Method 4 
        //Binding parameters are those parameters which are used to bind the new method with the existing class or structure.
        //It does not take any value when you are calling the extension method because they are used only for binding not for any other use.
        //always present at the first place, any other place rather than first place then the compiler will give an error.
        //The binding parameter is created using this keyword followed by the name of the class in which you want to add a new method and the parameter name.

        public static void M4(this ExtensionMethod g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5 
        public static void M5(this ExtensionMethod g, string str)
        {
            Console.WriteLine(str);
        }
    }
    #endregion

    #region ReadOnly vs Const
    #region Constant
    //constant fields are created using const keyword.
    //Const  is a compile time constant.
    //The value of the const field can not be changed.
    //It can be declared inside the method.
    //In const fields, we can only assign values in declaration part.
    //It cannot be used with static modifiers.
    class Const
    {
        // Constant fields
        public const int myvar = 10;
        public const string str = "GeeksforGeeks";
    }
    #endregion

    #region ReadOnly
    //Readonly fields can be created using readonly keyword
    //ReadOnly is a runtime constant. It cannot be declared inside the method.
    //The value of readonly field can be changed.
    //It can be used with static modifiers.
    class ReadOnly
    {
        // readonly variables
        public readonly int myvar1;
        public readonly int myvar2;

        // variables are assigned Using constructor
        public ReadOnly(int b, int c)
        {
            myvar1 = b;
            myvar2 = c;
            Console.WriteLine("Display value of myvar1 {0}, " +
                            "and myvar2 {1}", myvar1, myvar2);
        }
    }
    #endregion
    #endregion

    #region Ref and Out
    class OutKeyword
    {
        //The out is a keyword in C# which is used for the passing the arguments to methods as a reference type.
        //It is generally used when a method returns multiple values.

        // Method that calculates the square of a number and returns it through the out parameter
        public void CalculateSumAndProduct(int x, int y, out int sumResult, out int productResult)
        {
            sumResult = x + y;
            productResult = x * y;
        }
    }
    class RefKeyword
    {
        //The ref is a keyword in C# which is used for the passing the arguments by a reference.
        // if any changes made in this argument in the method will reflect in that variable when the control return to the calling method.
        public void SetValue(ref string str1)
        {
            // Check parameter value 
            if (str1 == "Geek")
            {
                Console.WriteLine("Hello!!Geek");
            }
            // Assign the new value 
            // of the parameter 
            str1 = "GeeksforGeeks";
        }
    }
    #endregion

    #region Access Modifiers
    // Define a class with different access modifiers
    class AccessModifiers
    {
        #region Public Members

        // Public field - accessible from any class
        public int publicField = 10;

        // Public method - accessible from any class
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        #endregion

        #region Private Members

        // Private field - accessible only within this class
        private int privateField = 20;

        // Private method - accessible only within this class
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        #endregion

        #region Protected Members

        // Protected field - accessible within this class and by derived classes
        protected int protectedField = 30;

        // Protected method - accessible within this class and by derived classes
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        #endregion

        #region Internal Members

        // Internal field - accessible only within the same assembly
        internal int internalField = 40;

        // Internal method - accessible only within the same assembly
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }

        #endregion
    }

    // Derived class
    class DerivedClass : AccessModifiers
    {
        #region Derived Class Members

        public void AccessProtectedField()
        {
            // Accessing protected field from the base class
            Console.WriteLine($"Derived Class accessing protected field: {protectedField}");
        }

        #endregion
    }


    #endregion
}

