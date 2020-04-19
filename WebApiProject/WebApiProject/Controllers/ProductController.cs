using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id) => Products.Single(x => x.Id == id);


        [HttpPost]
        public ActionResult Create(Product model)
        {
            
            model.Id = Products.Count() + 1;
            Products.Add(model);
            return CreatedAtAction(
                "Get",
                new {id = model.Id},
                model
                );
        }

        [HttpPut("{productId}")]
        public ActionResult Update(int productId, Product model)
        {
            var originalEntry = Products.Single(x => x.Id == productId);
            originalEntry.Name = model.Name;
            originalEntry.Description = model.Description;
            originalEntry.Price = model.Price;
            return NoContent();

        }


        [HttpDelete("{productId}")]

        public ActionResult Delete( int productId)
        {
            Products = Products.Where(x => x.Id != productId).ToList();
            
            return NoContent();
        }

        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id= 1,
                Name= "Guitarra Electrica",
                Price= 400,
                Description= "Ideal Para aprender a tocar"
            },
            new Product
            {
                Id= 2,
                Name = "Amplificador Guitarra",
                Price= 1200,
                Description = "Ideal para comenzar"
            },
        };
    }
}
