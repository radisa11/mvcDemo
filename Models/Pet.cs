using System;
using System.ComponentModel.DataAnnotations;

namespace mvcDemo.Models
{
    public class Pet 
    {
        [Required(ErrorMessage ="Pet has to have a name!")]
        public string petName {get;set;}
        [Required(ErrorMessage ="Pet must have a Type!")]
        [MinLength(2,ErrorMessage ="Pet must contain at least two characters!")]
        public string petType {get;set;}
        [Required(ErrorMessage ="Pet must have a name!")]
        public int petAge {get;set;}
    }
}