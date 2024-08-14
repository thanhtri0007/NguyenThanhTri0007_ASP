using System.Collections.Generic;

namespace thanhtri_2121110007.Context
{
    public class CombinedViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
