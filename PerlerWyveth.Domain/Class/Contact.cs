using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WV.EntityFrameWorkCore.Abstract;

namespace PerlerWyveth.Domain.Class
{
    public class Contact : Entity
    {
        #region Public Methods
        [Required]
        public string Key { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        #endregion
    }
}
