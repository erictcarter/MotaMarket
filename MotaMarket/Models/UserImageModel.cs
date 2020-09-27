using System;
using System.Collections.Generic;
using System.Text;

namespace MotaMarket.Models
{
   public class UserImageModel
    {
        public string imageUrl { get; set; }

        public string FullImagePath => $"https://motamarket.azurewebsites.net/{imageUrl}";
    }
}
