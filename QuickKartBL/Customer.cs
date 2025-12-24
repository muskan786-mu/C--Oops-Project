using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartBL
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string address;
        private long phoneNumber;
        private string emailId;
        private string customerType;
        private DateTime dateOfBirth;
        private Gender gender;
        private string password;

        private static int counter;

        static Customer()
        {
            counter = 1000;
        }
        public Customer()
        { 
            
            customerId = ++counter;
        }

        public int CustomerId
        {
            get { return customerId; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if(Validator.IsName(value))
                    customerName = value;
                else
                    customerName = null;
            }
        }
        public string Address
        {
            get
            { return address; }
            set
            {
                if (Validator.IsName(value))
                    address = value;
                else
                    address = null;
                
            }
        }
        public long PhoneNumber { get; set; }
        public string EmailId { get
            {

             return emailId   ;
            }
            set
            {

             if(Validator.IsEmailId(value))
                    emailId = value;
             else 
                    emailId = null;
            } 
        }
        public string CustomerType { get
            {
                return customerType ;
            } set
            {
              customerType = value;
            } }
        public DateTime DateOfBirth { get
            {return dateOfBirth

                ; }
            set
            {
                if(Validator.ValidateAge(value,18))
                    dateOfBirth = value;
            } }
        public Gender Gender { get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
            }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if(Validator.HasLength(value,5,20) && Validator.HasCapitalLetter(value) && Validator.HasSmallLetter(value) && Validator.HasSpecialCharacter(value))
                    password = value;
                else
                    password = null;
            }
        }
        public Customer(int customerId, string customerName, string address,long phoneNumber,string emailId,string customerType,DateTime dateOfBirth,Gender gender,string password)
        {
            this.customerId = customerId;
            CustomerName = customerName;
            Address = address;
            PhoneNumber = phoneNumber;
            EmailId = emailId;
            CustomerType = customerType; 
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Password = password;
        }


        public string DisplayCustomerDetails()
        {
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Customer ID={0}", customerId);
            //Console.WriteLine("Customer Name ={0}", customerName);
            //Console.WriteLine("Customer Address ={0}", address);
            //Console.WriteLine("Customer Phone Number ={0}", phoneNumber);
            //Console.WriteLine("Email ID ={0}", emailId);
            string details = string.Empty;
            details += string.Format("Customer ID = {0}", this.customerId);
            details += string.Format("\n Customer Name = {0}", this.customerName);
            details += string.Format("\n Address = {0}", this.address);
            details += string.Format("\n Phone Number = {0}", this.phoneNumber);
            details += string.Format("\n Email ID = {0}", this.emailId);
            // Format = replacess{0} with values
           

            return details;
        }
        public double GetDiscount()
        {
            
            return 0.0;
        }
        public static int GetNumberOfCustomers()
        {
            int numberOfCustomers = counter - 1000;
            return numberOfCustomers;
        }
        //Params
        public string[] DeliveryAddress { get; set; }

        public string AddDeliveryAddress(params string[] deliveryAddress)
        {
            this.DeliveryAddress = deliveryAddress;
            return "Delivery address added successfully!";
        }


        


    }
}
