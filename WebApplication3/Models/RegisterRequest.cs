using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "������� �����")]
        [RegularExpression(@"^[\s�-��-���a-zA-Z$&+,:;=?@#|""��'<>.-^*()%!_-]+$", ErrorMessage = "������� ������������ �������")]
        [Remote(action: "CheckUsername", controller: "Account", ErrorMessage = "����� ��� ������������")]
        public string Username { get; set; }

        [Required(ErrorMessage = "������� �����")]
        [RegularExpression(@"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*$", ErrorMessage = "����� ������� �������")]
        [Remote(action: "CheckEmail", controller: "Account", ErrorMessage = "����� ��� ������������")]
        public string Email{ get; set; }

        [UIHint("password")]
        [Required(ErrorMessage = "������� ������")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}