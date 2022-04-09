using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WV.EntityFrameWorkCore.Abstract;

namespace PerlerWyveth.Domain.Class
{
    public class Tag : Entity
    {
        #region Public Methods
        [Required]
        public string Key { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Libelle { get; set; }
        [Required]
        public Picture Picture { get; set; }
        #endregion
    }
}
