using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOrderMvvm.Prism
{
    /// <summary>
    /// 下单完成的数据写入
    /// </summary>
    internal class MockOrderService : IOrderService
    {
        public void PlaceOrder(List<string> dishes)
        {
            System.IO.File.WriteAllLines(@"E:\WPFCode\order.txt", dishes.ToArray());
        }
    }
}
