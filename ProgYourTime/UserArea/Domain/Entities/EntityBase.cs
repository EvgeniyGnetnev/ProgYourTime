using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgYourTime.UserArea.Entities
{
    public class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Display(Name = "ID пользователя")]
        public virtual string UserID { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Заполните поле Текущий вес")]
        [Display(Name = "Текущий вес")]
        public virtual float CurWeight { get; set; }
    }
}
