using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgYourTime.UserArea.Domain.Entities
{
    public class User
    {
        [Required]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "Заполните поле Логин")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Заполните поле Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Заполните поле Пароль")]
        public string Password { get; set; }
    }
}
