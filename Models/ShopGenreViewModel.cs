using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class ShopGenreViewModel
    {
        public List<Shop>? Shops { get; set; }
        public SelectList? Genres { get; set; }
        public string? ShopGenre { get; set; }
        public string? SearchString { get; set; }

    }
}
