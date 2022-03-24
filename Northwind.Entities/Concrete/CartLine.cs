using System;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Entities.Concrete
{
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
