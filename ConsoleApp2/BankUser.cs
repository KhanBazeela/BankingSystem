﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace visualstudio_git
//{
//    public abstract class BankUser
//    {
//        protected string _firstName;
//        protected string _lastName;
//        protected int _age;
//        protected string _email;
//        protected string _address;
//        protected long _phoneNo;


//        public  BankUser(string fname,string lname, int age,string email,string address,long phoneNo)
//        {
//            this._firstName = fname;
//            this._lastName = lname; 
//            this._age = age;
//            this._email = email;
//            this._address = address;
//            this._phoneNo = phoneNo;


//        }


//        public abstract void DisplayInfo();



//    }

//    class Employee : BankUser
//    {


//        private int _empId;
//        private string _designation;

//        public Employee(string fname, string lname, int age, string email, string address, long phoneNo, int empid, string designation):base(fname,lname,age,email,address,phoneNo)
//        {
//            this._empId = empid;
//            this._designation = designation;

//        }

//        public override void DisplayInfo()
//        {
//            Console.WriteLine($"Employee Id : {_empId}");
//            Console.WriteLine($"Full Name : {_firstName} {_lastName}");
//            Console.WriteLine($"Age : {_age}");
//            Console.WriteLine($"Email : {_email}");
//            Console.WriteLine($"Mobile No : {_phoneNo}");
//            Console.WriteLine($"Address : {_address}");
//            Console.WriteLine($"Designation : {_designation}");
//        }



//    }


//    class Customer : BankUser
//    {


//        private int _customerId;
//        private string _designation;

//        public Customer(string fname, string lname, int age, string email, string address, long phoneNo, int custid) : base(fname, lname, age, email, address, phoneNo)
//        {
//            this._customerId = custid;


//        }

//        public int GetCustId()
//        {
//            return _customerId;
//        }


//        public override void DisplayInfo()
//        {

//            Console.WriteLine($"Customer id : {_customerId}");
//            Console.WriteLine($"Customer Full Name : {_firstName} {_lastName}");
//            Console.WriteLine($"Customer Age : {_age}");
//            Console.WriteLine($"Customer Email : {_email}");
//            Console.WriteLine($"Customer Mobile No : {_phoneNo}");
//            Console.WriteLine($"Customer Address : {_address} \n");


//        }


//    }
//}