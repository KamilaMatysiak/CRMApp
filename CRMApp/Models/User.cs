using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRMApp.Models
{
    public class User
    {
        //id, name, surname, dateOfBirth, login, passwordMd5, idroli, idDeleted
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string Login { get; set; }
        public bool IdDeleted { get; set; }
    }
}
