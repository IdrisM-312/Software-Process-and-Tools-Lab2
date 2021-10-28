using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Person
    {
        private string name;
        private int age;
        private double weight;
        private double height;

        public Person(string name, int age, double weight, double height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
    }
}
