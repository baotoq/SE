﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Domain;

namespace BUS.Tests
{
	[TestClass()]
	public class CustomerBUSTests
	{
		private Customer expected = new Customer()
		{
			CustomerId = "C0001"
		};

		[TestMethod()]
		public void GetCustomerByIdTest()
		{
			var actual = CustomerBUS.GetCustomerById("C0001");
			Assert.AreEqual(expected.CustomerId, actual.CustomerId);
		}

		[TestMethod()]
		public void AddCustomerTest()
		{
			var id = CustomerBUS.NextId();
			var newCustomer = new Customer()
			{
				CustomerId = id
			};
			CustomerBUS.Add(newCustomer);
			Assert.IsTrue(true);
		}

		[TestMethod()]
		public void RemoveCustomerTest()
		{
			var removeCustomerId = "C0002";
			CustomerBUS.Remove(removeCustomerId);
			Assert.IsTrue(true);
		}

		[TestMethod()]
		public void NextCustomerIdTest_TC1()
		{
			var actual = CustomerBUS.NextId();
			var expected = "C0001";
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void NextCustomerIdTest_TC2()
		{
			var actual = CustomerBUS.NextId();
			var expected = "C0002";
			Assert.AreEqual(expected, actual);
		}
	}
}