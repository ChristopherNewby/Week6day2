using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1
{

    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {

    }
    public partial class CustomerMetaData
    {
        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "You must enter a customer name!")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 character or less")]
        public string CustomerName { get; set; }
        [DisplayName("Customer Phone Number")]
        [Required(ErrorMessage = "You must enter a movie name")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 character or less")]
        public string CustomerPhoneNumber { get; set; }                 
    }

    [MetadataType(typeof(GenreMetaData))]
    public partial class Genre
    {
    }
        public partial class GenreMetaData
        {
        [DisplayName("Genre Id")]
        
        public int GenreId { get; set; }

        [DisplayName("Genre Name")]
        [Required(ErrorMessage = "You must enter a genre name")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 character or less")]
        public string GenreName { get; set; }
    }

    [MetadataType(typeof(MovieMetaData))]
    public partial class Movie
    {
    }
    public partial class MovieMetaData
    {
        [DisplayName("Movie Id")]
        public int MovieId { get; set; }
        [DisplayName("Movie Name")]
        [Required(ErrorMessage = "You must enter a movie name!")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 characters or less")]
        public string MovieName { get; set; }
        [DisplayName("Movie Description")]
        [Required(ErrorMessage = "The description is required")]
        public string MovieDescription { get; set; }
        [DisplayName("Movie Genre")]
        [Required(ErrorMessage = "You must enter a genre name")]        
        public Nullable<int> MovieGenre { get; set; }
    }

    [MetadataType(typeof(RentalRecordMetaData))]
    public partial class RentalRecord
    {
    }
    public partial class RentalRecordMetaData
    {
        [DisplayName("Rental Id")]
        public int RentalId { get; set; }
        [DisplayName("Movie Id")]
        public int MovieId { get; set; }
        [DisplayName("Customer Name")]
        [Required(ErrorMessage = "You must enter a customer name")]
        [MaxLength(50, ErrorMessage = "Movie name must be 50 character or less")]
        public int CustomerId { get; set; }
        [DisplayName("Rental Date")]
        [Required(ErrorMessage = "You must enter a rental date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime RentalDate { get; set; }
        [Required(ErrorMessage = "You must enter a due date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Due Date")]
        public System.DateTime DueDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Return Date")]
        public Nullable<System.DateTime> ReturnDate { get; set; }
       
    }
}

       

