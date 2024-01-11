using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            //Show -order OBJECT-
            Console.WriteLine(order);
            //Show only the Status from -order OBJECT-
            Console.WriteLine(order.Status);

            //String receives order.Status'PendingPayment' but is nor parameter from an object
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //'OrderStatus os' is just an independent 'OrderStatus' variable
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}