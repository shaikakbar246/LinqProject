using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.DesignPatterns.BehaviouralDesignPattern.CommandDesignPattern.CommandExample1
{
    public  class CommandExample1
    {
        public static void Main(string[] args)
        {
            Kitchen kitchen= new Kitchen();
            IOrderCommand pastaorder = new PastaOrderCommand(kitchen);
            IOrderCommand burgerorder = new BurgerOrderCommand(kitchen);

            Waiter waiter= new Waiter();
            waiter.TakeOrder(pastaorder);
            waiter.TakeOrder(burgerorder);

            // Later, the waiter sends all orders to the kitchen
            waiter.PlaceOrders();
            Console.ReadKey();
        }
    }
    //Command Interface
    public interface IOrderCommand 
    {
        void Execute();
    }
    public class Kitchen
    {
        public void PreparePasta()
        {
            Console.WriteLine("Preparing Pasta...");
        }

        public void PrepareBurger()
        {
            Console.WriteLine("Preparing Burger...");
        }
    }

    public class PastaOrderCommand : IOrderCommand
    {
        private Kitchen _kitchen;
        public PastaOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }
        public void Execute()
        {
            _kitchen.PreparePasta();
        }
    }
    public class BurgerOrderCommand : IOrderCommand
    {
        private Kitchen _kitchen;

        public BurgerOrderCommand(Kitchen kitchen)
        {
            _kitchen = kitchen;
        }
        public void Execute()
        {
            _kitchen.PrepareBurger();
        }
    }
    //Invoker - Waiter
    public class Waiter
    {
        private List<IOrderCommand>_orders= new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand orderCommand)
        {
            _orders.Add(orderCommand);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }
            _orders.Clear();
        }
    }
    // Testing the Command Design Pattern
    // Client Code

}
