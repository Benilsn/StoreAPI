using System;
using Store.entities.Enum;

namespace Store.entities
{
    public class Staff
    {

        private long id;
        private string name;
        private int age;
        private string role;
        private DateTime entry_date;
        private Department department;

        public Staff() { }

        public Staff(string name, int age, string role, DateTime entry_date, Department dp) 
        {
            this.name = name;
            this.age = age;
            this.role = role;
            this.entry_date = entry_date;
            this.department = dp;

        }

        public long Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public DateTime Entry_Date
        {
            get { return entry_date; }
            set { entry_date = value; }
        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        public string toString()
        {
            return "Name = " + this.name +
                "\nAge = " + this.age +
                "\nRole = " + this.role +
                "\nEntryDate = " + this.entry_date +
                "\nDepartment = " + this.department;
        }


    }
}
