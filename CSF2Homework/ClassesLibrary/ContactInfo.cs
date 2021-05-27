﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
   public class ContactInfo
    {
        private string _stretAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        public string StreetAddress
        {
            get { return _stretAddress; }
            set { _stretAddress = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }
        public ContactInfo()
        { }
        public override string ToString()
        {
            //return base.ToString();
            return string.Format("ContactInfo:{0}\n" +
                "Street Address: {1}\n" +
                "City: {2}\n" +
                "State: {3}\n" +
                "Zip: {4}\n" +
                "Phone: {5}\n" +
                "Email: {6}\n",
                StreetAddress, City, State, Zip, Phone, Email);
        }
    }//class
}//namespace