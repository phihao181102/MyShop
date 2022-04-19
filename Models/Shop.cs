using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class Shop
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display (Name ="Tên Sản Phẩm")]
        public string Title { get; set; }
        [Display(Name = "Loại Sản Phẩm")]
        public string Genre { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Display(Name = "Giá")]

        public decimal Price { get; set; }

    }
}
