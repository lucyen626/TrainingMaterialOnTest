using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopService.Interfaces
{
    public interface ICatalog
    {
        ICatalog Create();
        IEnumerable<Product> Items { get; }
    }
}
