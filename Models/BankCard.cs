using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSystemsProject.Models
{
	public class BankCard
	{
		public long ID { get; set; } 
		public long StudentID { get; set; }
		public short ExpirationYear { get; set; }
		public byte ExpirationMonth { get; set; } 
		public string NameOnCard { get; set; } 
		public string Type { get; set; } 
		public string CVV { get; set; } 
	}

}
