using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Producer Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Biography { get; set; }

        //Relations

        public List<Movie> Movies { get; set; }
    }
}
