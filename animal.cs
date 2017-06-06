using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Animal
    {
        //declare properties to be applied on objects
        public string sex;
        public string type;
        public int age;
        public string name;


        //setter/mutator methods 
        public void setSex(String sex)
        {
        this.sex = sex;
        }
        public void setType(String type)
        {
        this.type = type;
        }
        public void setAge(int age)
        {
        this.age = age;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        //getter methods
        public string getName()
        {

            return name;

        }
        public string getSex()
        {

            return sex;

        }
        public string getType()
        {

            return type;

        }
        public int getAge()
        {

            return age;

        }
    }
}
