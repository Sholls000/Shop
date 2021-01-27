using Shop.Domain.Infrastructure;
using Shop.Domain.Models;

namespace Shop.Application.Cart
{
    [Service]
    public class AddCustomerInformation
    {
        private ISessionManager _sessionManager;

        public AddCustomerInformation(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public class Request
        {
            
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phonenumber { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }
        }


        public void Do(Request request)
        {
            //Adding new customer information using _sessionManager 
            _sessionManager.AddCustomerInformation(new CustomerInformation
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phonenumber = request.Phonenumber,
                Address1 = request.Address1,
                Address2 = request.Address2,
                City = request.City,
                PostCode = request.PostCode,
            });
        }
    }
}

    

