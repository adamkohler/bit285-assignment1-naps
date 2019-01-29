﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bit285_assignment1_naps.Models
{
    public class User
    {
        [Required (ErrorMessage = "Please enter your first name.")]
        public string FirstName { get; set; }
        [Required (ErrorMessage = "Please ener your last name.")]
        public string LastName { get; set; }
        [Required (ErrorMessage = "Please enter valid email address.")]
        public string EmailAdd { get; set; }
        // This field is generated byt the PassWordSuggestionService //  public string Password { get; set; }
        public string Program { get; set; }
        public string Birthyr { get; set; }
        public string FavColor { get; set; }
    }
}
