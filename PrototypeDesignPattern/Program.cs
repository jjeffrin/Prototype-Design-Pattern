using System;

namespace PrototypeDesignPattern
{
    public interface IEmployee
    {
        IEmployee Clone();
        void GetDetails();
    }

    public class Developer : IEmployee
    {
        public string Name;
        public string Role;
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public void GetDetails()
        {
            Console.WriteLine(this.Name + " " + this.Role);
        }
    }

    public class Designer : IEmployee
    {
        public string Name;
        public string Role;
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        public void GetDetails()
        {
            Console.WriteLine(this.Name + " " + this.Role);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Design Pattern");
            Developer dev = new Developer();
            dev.Name = "Jeffrin J";
            dev.Role = "Web Developer";
            dev.GetDetails();
            Developer devCopy = (Developer)dev.Clone();
            devCopy.Role = "Web Dev";
            devCopy.GetDetails();

            Designer designer = new Designer();
            designer.Name = "Pranav S";
            designer.Role = "Web Designer";
            designer.GetDetails();
            Designer designerCopy = (Designer)designer.Clone();
            designerCopy.Role = "Software Designer";
            designerCopy.GetDetails();
        }
    }
}
