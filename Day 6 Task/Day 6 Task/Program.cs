using System;

namespace Day_6_Task
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Problem 1
            //Point P1;
            //P1 = new Point();
            //Console.WriteLine(P1.ToString());

            //Point P2 = new Point(2, 4);
            //Console.WriteLine(P2.ToString());

            ///* Question: Why can't a struct inherit from another struct or class in C#? 
            //   In C#, structs are value types and do not support inheritance because they 
            //   are designed to be lightweight and efficient. Allowing inheritance would add 
            //   complexity and overhead, which goes against the purpose of structs.
            // */ 
            #endregion

            #region Problem 2
            //TypeA obj = new TypeA(1, 2, 3);

            //Console.WriteLine($"Public H: {obj.H}");

            //Console.WriteLine($"Internal G: {obj.G}");

            //Console.WriteLine($"Private F: {obj.GetF()}");

            ///*  Question: How do access modifiers impact the scope and visibility of a class member?  
            //    private: Accessible only within the same class.
            //    internal: Accessible within the same assembly.
            //    public: Accessible anywhere the class is visible.
            // */ 
            #endregion

            #region Problem 3
            //Employee emp = new Employee();
            //emp.EmployeeId = 1;
            //emp.SetName("Nour");
            //emp.EmployeeSalary = 1000000.0M;

            //Console.WriteLine(emp.ToString());

            ///* Question: Why is encapsulation critical in software design? 
            //   Encapsulation helps protect the internal state of an object and only exposes a controlled interface.
            //   This improves maintainability, reduces complexity, and enhances security.
            // */ 
            #endregion

            #region Problem 4

            //Point p1 = new Point(6);
            //Point p2 = new Point(2, 4);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            ///* Question: what is constructors in structs?  
            //   Struct constructors are methods that initialize struct fields. 
            //   In C#, structs cannot have parameterless constructors (except for default),
            //   and all fields must be fully assigned within a constructor.
            // */ 
            #endregion

            #region Problem 5
            //Point point1 = new Point(1, 2);
            //Point point2 = new Point(3, 4);

            //Console.WriteLine(point1.ToCustomString());
            //Console.WriteLine(point2.ToCustomString());

            ///* Question: How does overriding methods like ToString() improve code readability? 
            //    Overriding methods like ToString() improves code readability by providing a meaningful 
            //    string representation of the object, which makes it easier to understand and debug the code.
            // */ 
            #endregion

        }
    }
}
