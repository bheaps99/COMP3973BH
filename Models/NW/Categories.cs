using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspDb.Models.NW
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Display (Name = "ID")]
        public int CategoryId { get; set; }
            
        [Required (ErrorMessage="must enter a {0}")]
        [Display (Name = "CATEGORY")]
        [MaxLength (15)]

        public string CategoryName { get; set; }
        [Required]
        [Display (Name = "DESCRIPTION")]
        [MaxLength (30)]
        public string Description { get; set; }

        public byte[] Picture { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
