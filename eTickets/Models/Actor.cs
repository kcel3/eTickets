﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Actor Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="FullName")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Biography { get; set; }

        //Relations
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}