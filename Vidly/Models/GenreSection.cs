using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
	public class GenreSection
	{
		public int id { get; set; }
		public string Name { get; set; }
		public virtual ICollection <Movie> Movies { get; set; }
	}
}