using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[Display(Name = "Movie Or Event Name")]
		public string MovieName{ get; set; }

		[Display(Name = "Movie Image")]
		public string MovieImg{ get; set; }

		[Display(Name = "Movie Director")]
		public string MovieDic{ get; set; }

		[Display(Name = "Movie Description")]
		public string MovieDescription{ get; set; }


		[Display(Name= "Release Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd MMMM}", ApplyFormatInEditMode = true)]
		public DateTime?  Datesortie{ get; set; }

		[Display(Name = "Movie Genre")]
		public Genre Genre { get; set; }
		public int GenreId { get; set; }

		[Display(Name = "Movie Section")]
		public GenreSection GenreSection { get; set; }
		public int GenreSectionId { get; set; }

	}
}