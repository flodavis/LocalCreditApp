using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;


namespace LocalCreditConsoleApp
{
     class BankResult
    {
        private string BankName { get; set; }
        private int AppFee { get; set; }
        private string LoanName { get; set; }
        private double APR { get; set; }
        private int Term { get; set; }
        private string _userName;

        public string Username
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

       // public static bool IsValidEmailAddress(this string address) => address != null && new EmailAddressAttribute().IsValid(address);

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool CanLogIn(string Username, string password) {
            bool output = false;
            if(Username.Length > 0 && password.Length > 0)
            {
                output = true;
            }
            return output;
        }

        //[Required(ErrorMessage = "You must provide a phone number")]
        //[Display(Name ="Phone")]
        //[DataType(DataType.PhoneNumber)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        // private string _phoneNumber;
        //  public string PhoneNumber;

        //public void SetPhoneNumber(string PhoneNumber) => _phoneNumber = PhoneNumber;
        //public string GetPhoneNumber()
        //{
        //  return _phoneNumber;
        //}

        private string _phonenumber;
        private Regex _regExPhone = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
        public void SetPhoneNumber(string phone)
        {
            Match m = _regExPhone.Match(phone);
            if (phone.Length > 0 && m.Success)
            {
                _phonenumber = phone;
            }

            else
            {
                Console.WriteLine($"{phone} is not a phone number, Please enter a valid phone number");
            }

        }
        public string PhoneNumber
        {
            get { return _phonenumber; }
        }

    }

}
