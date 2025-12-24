using QuickKartBL;
namespace QuickKartTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //obj1.customerId = 1001;
            //obj1.customerName = "Alfred";
            //obj1.address = "12th Block,Gandhi Square";
            //obj1.phoneNumber = 919771741974;
            //obj1.emailId = "alfred@gmail.com";

            //Console.WriteLine("Customer ID :");
            //int customerId = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Customer Name :");
            //string customerName = Console.ReadLine();
            //Console.WriteLine("Customer Address :");
            //string address = Console.ReadLine();
            //Console.WriteLine("Customer Phone Number :");
            //long phoneNumber = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Customer EmailID :");
            //string emailId = Console.ReadLine();
            //Customer obj1 = new Customer(customerId, customerName, address, phoneNumber, emailId, customerType, dateOfBirth, gender, password);
            //Console.WriteLine("--------------------------------------------------");
            //Customer obj2 = new Customer(8119,"Muskan", "s2uigdyeyfgefvfe", 9347249794, "mheguyqyy3.com","regular",null,"o9r893ro2");
            //Console.WriteLine("Customer ID ={0}",customerId);
            //Console.WriteLine("Customer Name ={0}", customerName);
            //Console.WriteLine("Customer Address ={0}", address);
            //Console.WriteLine("Customer Phone Number ={0}", phoneNumber);
            //Console.WriteLine("Email ID ={0}", emailId);


            //obj2.customerId = 1002;
            //obj2.customerName = "Juliet";
            //obj2.address = "14h Block,Nehru Square";
            //obj2.phoneNumber = 982479238429;
            //obj2.emailId = "juliet@gmail.com";


            //Console.WriteLine("Customer ID={0}",obj2.customerId);
            //Console.WriteLine("Customer Name ={0}", obj2.customerName);
            //Console.WriteLine("Customer Address ={0}", obj2.address);
            //Console.WriteLine("Customer Phone Number ={0}", obj2.phoneNumber);
            //Console.WriteLine("Email ID ={0}", obj2.emailId);

            //string customerOne = obj1.DisplayCustomerDetails();
            //Console.WriteLine(customerOne);
            //Console.WriteLine("--------------------------------------------------");
            //string customerTwo = obj2.DisplayCustomerDetails();
            //Console.WriteLine(customerTwo);

            // CustomerDateOfBirth dob1;
            // dob1.dobDay = 07;
            // dob1.dobMonth = "March";
            // dob1.dobYear = 2009;
            //CustomerDateOfBirth dobOne = new CustomerDateOfBirth(06,"November",2002);
            //Console.WriteLine("Date of Birth = {0}-{1}-{2}",dobOne.dobDay,
            //dobOne.dobMonth.Substring(0,3),dobOne.dobYear);

            // Console.WriteLine("Date of Birth = {0}-{1}-{2}", dob1.dobDay,
            //dob1.dobMonth.Substring(0, 3), dob1.dobYear);

            // PrivilagedCustomer privilagedCustomer = new PrivilagedCustomer(1001, "Emily", "maswuiuwdhuwd.com", 92828942428, "10th Floor,Social Apartment",MembershipCardType.Gold);
            // Console.WriteLine("-----------------------------------------");
            // Console.WriteLine("Privileged Customer Details");
            // Console.WriteLine("-----------------------------------------");
            // Console.WriteLine("Membership Card Type={0}",privilagedCustomer.membershipCardType);

            // //Boxing - boxing a specific data type of value into one common object
            // int purchaseId = 198891;
            // object purchaseIdObj = purchaseId;
            // string productName = "Smart Watch";
            // object productNameObj = productName;
            // double totalPrice = 5699.99;
            // object totalPriceObj = totalPrice;
            // Console.WriteLine("PurchaseId={0}", purchaseIdObj);
            // Console.WriteLine("ProductName={0}", productName);
            // Console.WriteLine("TotalPrice = {0}", totalPriceObj);

            // //Unboxing - This process of converting the object into specific data type is called as Unboxing
            // Console.WriteLine("-------------------------------------------------------------------------");
            // int nextPurchaseId = Convert.ToInt32(purchaseIdObj)+1;
            // Console.WriteLine("Next PurchaseId ={0}", nextPurchaseId);
            // string productVersion = Convert.ToString(purchaseIdObj) + "v1.0";
            // Console.WriteLine("ProductVersion={0}",productVersion);
            // double totalPriceWithGST = Convert.ToDouble(purchaseIdObj) + 189.99;
            // Console.WriteLine("TotalPriceWithGST ={0}",totalPriceWithGST);

            // //Category sportsCategory = new Category(1, "Sports");
            // //Console.WriteLine("CategoryId = {0}",sportsCategory.categoryId);
            // //Console.WriteLine("CategoryName={0}", sportsCategory.categoryName);

            // Cart shoppingCart = new Cart();
            // shoppingCart.DisplayItems();


            //     Console.WriteLine("----------------------------------------------");
            // Category cs = new Category(0,null);
            // Console.WriteLine("CategoryName ={0}",cs.CategoryId);
            // Console.WriteLine("CtegoryId ={0}",cs.CategoryName);
            // cs.CategoryId = 1;
            // cs.CategoryName = "Sports";
            // Console.WriteLine("---------------------------------------------");
            // Console.WriteLine(" After Update");
            // Console.WriteLine("CategoryName ={0}", cs.CategoryName);
            // Console.WriteLine("CtegoryId ={0}", cs.CategoryId);

            // //USING AUTO - IMPLEMENTED PROPERTIES
            // Console.WriteLine("Enter Category=");
            // byte categoryId = Convert.ToByte(Console.ReadLine());
            // Console.WriteLine("Enter CategoryName = ");
            // string categoryName = Console.ReadLine();

            // if (categoryId <= 0 || categoryName.Equals(string.Empty))
            // {
            //     Console.WriteLine("Invalid data entered! Please re-execute program and try again");
            // }
            // else
            // {
            //     cs = new Category(categoryId,categoryName);
            //     Console.WriteLine("CategoryId ={0}",cs.CategoryId);
            //     Console.WriteLine("CategoryName ={0}",cs.CategoryName);
            // }
            Category sp = new Category(1, "Sports");
            sp[0] = 2;
            sp[1] = "Water Sports";
            Console.WriteLine("CategoryId ={0}", sp[0]);
            Console.WriteLine("CategoryName ={0}", sp[1]);

            Console.WriteLine("Number of registered customers = {0}",Customer.GetNumberOfCustomers);
            Console.WriteLine("*************************************************************8");
            Product pro = new Product("P131", "Marble chess board", 1099.99, "Made up of Wood", 10);
            int discount = 0;
            double minPrice;
            double maxPrice;
            string result = pro.CalculateDiscount(ref discount,out minPrice,out maxPrice);
            Console.WriteLine(result);
            Console.WriteLine("Dicount for the product ={0}",discount);
            Console.WriteLine("Minimun Price ={0}",minPrice);
            Console.WriteLine("Maximum Price ={0}",maxPrice);
            Console.WriteLine("Thank you");

            //Customer customerOne = new Customer(1001, "Taylor", "774,Banglore", 9887765764, "taylor@gmail.com", "Regular",2005 - 08 - 25, Gender.Male, "Tay@123");
            //Customer customerTwo = new Customer(1002, "Taylor", "774,Banglore", 9887765764, "taylor@gmail.com", "Regular", 2005 - 08 - 25, Gender.Male, "Tay@123");
            //Customer customerThree = new Customer(1003, "Taylor", "774,Banglore", 9887765764, "taylor@gmail.com", "Regular", 2005 - 08 - 25, Gender.Male, "Tay@123");

            //string result1 = customerOne.AddDeliveryAddress("5th block Mysore");
            //Console.WriteLine(result1);
            //result1 = customerTwo.AddDeliveryAddress("2nd block Banglore");
            //Console.WriteLine(result1);
            //result1 = customerThree.AddDeliveryAddress("10th Main,Windham Gardens", "995,Wilson Garden", "17th Square Block,New York");
            //Console.WriteLine(result1);

            //Console.WriteLine("****************************************************************************");
            //foreach(string address in customerThree.DeliveryAddress)
            //{
            //    Console.WriteLine(address);
            //}









        }
    }
}
