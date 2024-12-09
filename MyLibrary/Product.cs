using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public class Product
	{
		private int Id_Field;
		public int Id
		{
			get { return Id_Field; }
			set { Id_Field = value; }
		}

		public string? Name;
		public decimal UnitPrice;
		public int UnitsInStock;

	}
}
