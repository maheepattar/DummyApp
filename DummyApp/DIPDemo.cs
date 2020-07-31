using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyApp
{
    class DIPDemo
    {
        static void Main()
        {
            CustomerBusinessLogic customerBusinessLogic = new CustomerBusinessLogic();
            Console.WriteLine(customerBusinessLogic.GetCustomerName());

            Console.ReadKey();
        }
    }

    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    public class CustomerDataAcess : ICustomerDataAccess
    {
        public CustomerDataAcess()
        {

        }
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }

    // Returns Object of Data Access
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetDataAccessObject()
        {
            return new CustomerDataAcess();
        }
    }

    public class CustomerBusinessLogic
    {
        private ICustomerDataAccess customerDataAccess;
        public CustomerBusinessLogic()
        {
            customerDataAccess = DataAccessFactory.GetDataAccessObject();
        }

        public string GetCustomerName()
        {
            return customerDataAccess.GetCustomerName(1);
        }        
    }
}