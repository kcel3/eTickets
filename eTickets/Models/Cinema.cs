using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo of Cinema")]
        public string Logo { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }

        //Relations

        public List<Movie> Movies{ get; set; }

    }
}
