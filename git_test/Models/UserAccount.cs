﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace git_test.Models
{
    public class UserAccount
    {
        [Key] 
        public int UserId { get; set; }
        [Required(ErrorMessage = "Imię jest wymagane")]
        [Display(Name = "Imie")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email jest wymagany")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Wpisz poprawny email")]
        public string Email { get; set; }
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Podaj Nick")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Wpisz hasło")]
        [MinLength(8,ErrorMessage ="Hasło za krótkie")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Compare("Password",ErrorMessage = "Hasła nie pasują")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Potwierdź hasło")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        public string Describe { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        public string Location { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        public string Numer { get; set; }
        [Required(ErrorMessage = "to pole jest wymagane")]
        public string Hobby { get; set; }


    }
}