using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuOrderMvvm.Prism
{
    internal interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}
