namespace DTO.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity.Spatial;

	public partial class Service
	{
		public Service()
		{
			ServiceDetails = new HashSet<ServiceDetail>();
		}

		[StringLength(10)]
		public string ServiceId { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		public decimal Price { get; set; }

		public virtual ICollection<ServiceDetail> ServiceDetails { get; set; }
	}
}
