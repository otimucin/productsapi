using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen bir ürün adı giriniz")]
        public string Title { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ModifiedDate { get; set; }
        [RegularExpression(@"^\$?([1-9]{1}[0-9]{0,2}(\,[0-9]{3})*(\.[0-9]{0,2})?|[1-9]{1}[0-9]{0,}(\.[0-9]{0,2})?|0(\.[0-9]{0,2})?|(\.[0-9]{1,2})?)$", ErrorMessage = "Lütfen geçerli bir sayı giriniz")]
        public double? Price { get; set; }
    }
}
