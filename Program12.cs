﻿//**Shallow Copy vs. Deep Copy**

//Create a `Department` class with a reference-type property `Manager`. Implement both **Shallow Copy**
//and **Deep Copy** to show how references are handled.

using System;

namespace c__Assignment
{
    class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }

        public Manager(Manager manager)
        {
            Name = manager.Name;
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string departmentName, Manager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        public Department DeepCopy()
        {
            Department deepCopyDepartment = (Department)this.MemberwiseClone();
            deepCopyDepartment.Manager = new Manager(this.Manager);
            return deepCopyDepartment;
        }

        public override string ToString()
        {
            return $"Department: {DepartmentName}, Manager: {Manager.Name}";
        }
    }

    //public class Program12
    //{
    //    static void Main()
    //    {
    //        Manager manager = new Manager("Alice");
    //        Department originalDepartment = new Department("HR", manager);

    //        Department shallowCopyDepartment = originalDepartment.ShallowCopy();
          
    //        Department deepCopyDepartment = originalDepartment.DeepCopy();

    //        originalDepartment.Manager.Name = "Bob";

    //        Console.WriteLine("Original Department: " + originalDepartment);
    //        Console.WriteLine("Shallow Copy Department: " + shallowCopyDepartment);
    //        Console.WriteLine("Deep Copy Department: " + deepCopyDepartment);
    //    }
    //}
}

