namespace DAO.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public partial class Customer
	{
		public Customer()
		{
			this.Bookings = new HashSet<Booking>();
			this.CheckIns = new HashSet<CheckIn>();
		}

		[StringLength(10)]
		public string CustomerId { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(50)]
		public string Address { get; set; }

		[StringLength(50)]
		public string Phone { get; set; }

		[StringLength(50)]
		public string Fax { get; set; }

		[StringLength(50)]
		public string Telex { get; set; }

		public virtual ICollection<Booking> Bookings { get; set; }

		public virtual ICollection<CheckIn> CheckIns { get; set; }
	}
}
