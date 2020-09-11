using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Person
    {
        public string FirstName { get; set; }

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}
		public DateTime DateOfBirth { get; set; }
		public Vehicle Transport { get; set; }

		public Person() { }
		public Person(string firstName, string lastName, DateTime dob,Vehicle transport)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dob;
			Transport = transport;
		}




	}
}
