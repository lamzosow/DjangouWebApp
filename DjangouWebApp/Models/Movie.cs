using System;
namespace DjangouWebApp.Models
{
    public class Movie
    {
        public Movie()
        { }
            

            public int Id { get; set; }


            //[StringLength(50)]
            public string Title { get; set; }

            public string Genre { get; set; }

            //[DataType(DataType.Date)]
            public DateTime ReleaseDate { get; set; }

            public decimal Price { get; set; }

        
          }
   }
