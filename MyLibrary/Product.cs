using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary;
public class Product(int id, string name, decimal unitPrice, int unitsInStock)
{
	//propiedades
	public int Id => id;
	public string Name => name;
	public decimal UnitPrice => unitPrice;
	public int UnitsInStock => unitsInStock;
}

public class Product2(int id, string name, decimal unitPrice, int unitsInStock,
	bool discontinued)
	: Product(id, name, default, default)
{
	public bool Disconinued { get; set; } = discontinued;
}