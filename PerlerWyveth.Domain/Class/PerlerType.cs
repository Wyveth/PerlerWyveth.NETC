using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerlerWyveth.Domain.Class
{
    public class PerlerType
    {
        #region Public Methods
        [Required]
        public string Key { get; set; }
        [Required]
        public string Reference { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Required]
        public string Color { get; set; }
        #endregion
    }
}
