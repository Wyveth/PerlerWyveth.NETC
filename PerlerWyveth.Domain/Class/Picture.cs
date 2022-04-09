using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WV.EntityFrameWorkCore.Abstract;

namespace PerlerWyveth.Domain.Class
{
    public class Picture : Entity
    {
        #region Public Methods
        [Required]
        public string Key { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public byte[] ByteArray { get; set; }
        #endregion
    }
}
