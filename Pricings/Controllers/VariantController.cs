using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace Variants.Controllers
{
    [ApiController]
    public class VariantController : ControllerBase
    {        
        public List<Variant> Variants { get; set; } = new List<Variant>() { 
            new Variant() { 
                ItemNumber = "G-0001",
                VariantName = "Small",
                RegularPrice = 399.00, 
                SalesPrice = 299.00 
            },
            new Variant() {
                ItemNumber = "G-0001",
                VariantName = "Medium",
                RegularPrice = 499.99,
                SalesPrice = 399.00
            },
            new Variant() {
                ItemNumber = "G-0001",
                VariantName = "Large",
                RegularPrice = 599.99,
                SalesPrice = 499.00
            }
        };
       

        [HttpGet]
        [Route("[controller]/{ItemNumber}")]
        public async Task<List<Variant>> GetVariant(string ItemNumber)
        {
            if(ItemNumber == "G-0001")            
                return Variants;
            
            throw new HttpRequestException();
        }
    }
}
