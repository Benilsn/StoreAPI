using System;

namespace Store.entities
{
    public class Client
    {

        private long id;
        private string name;
        private int age;
        private DateTime memberSince;
        private string phone;

        public Client() { }


        public Client(string name, int age, DateTime memberSince, string phone)
        {
            this.name = name;
            this.age = age;
            this.memberSince = memberSince;
            this.phone = phone;
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
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
        
        public DateTime Date
        {
            get { return memberSince; }
            set { memberSince = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
           
        public string toString()
        {
            return "Name = " + this.name +
                "\nAge = " + this.age +
                "\nMemberSince = " + this.memberSince +
                "\nPhone = " + this.phone;
        }

    }
}
