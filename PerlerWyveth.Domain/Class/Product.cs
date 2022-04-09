using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WV.EntityFrameWorkCore.Abstract;

namespace PerlerWyveth.Domain.Class
{
    public class Product : Entity
    {
        #region Public Methods
        [Required]
        public string Key { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string TitleContent { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public List<Tag> Tags { get; set; }
        [Required]
        public Picture picture { get; set; }
        #endregion
    }
}
