using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WV.EntityFrameWorkCore.Abstract;

namespace PerlerWyveth.Domain.Class
{
    public class User : Entity
    {
        #region Fields
        [Required]
        public string Key { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public bool Admin { get; set; }
        public bool Disabled { get; set; } 

        public Picture PictureDisplay { get; set; }
        #endregion
    }
}
