using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgYourTime.Domain.Entities
{
    public class ActivitiesBase 
    {

        [Required]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "Заполните поле Вид деятельности")]
        public string Activity { get; set; }
    }
}
