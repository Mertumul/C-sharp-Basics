using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     class Identity
    {
        string name;
        string surname;
        int age;
        string hometown;
        char gender;


         public string NAME
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
         public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }
       public  int AGE
        {
            get { return age;}
            set { Math.Abs(value); }
        }
        public string HOMETOWN
        {
            get { return hometown; }
            set { hometown = value; }
            
        }
      public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }
         public Identity()
        {
            name = " ";
            surname = "";
            age = 18;
            hometown = "Mugla";
            gender = 'f';
        }
    }
}
