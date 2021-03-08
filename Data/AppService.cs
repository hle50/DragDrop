namespace DragDrop.Data
{
    using DragDrop.Model;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AppService" />.
    /// </summary>
    public class AppService
    {
        /// <summary>
        /// The GetOrderList.
        /// </summary>
        /// <returns>The <see cref="List{Order}"/>.</returns>
        public List<Order> GetOrderList()
        {
            Random rnd = new Random();
            return new List<Order>
            {
                new Order
                {
                    Id = 1,
                    Job = rnd.Next(1, 100000),
                    ArriveDateTime = DateTime.Now,
                    Type = "A",
                },
                new Order
                {
                    Id = 2,
                    Job = rnd.Next(1, 100000),
                    ArriveDateTime = DateTime.Now,
                    Type = "A",
                },
                new Order
                {
                    Id = 3,
                    Job = rnd.Next(1, 100000),
                    ArriveDateTime = DateTime.Now,
                    Type = "B",
                },
                new Order
                {
                    Id = 4,
                    Job = rnd.Next(1, 100000),
                    ArriveDateTime = DateTime.Now,
                    Type = "A",
                },
            };
        }

        /// <summary>
        /// The GetOperatorList.
        /// </summary>
        /// <returns>The <see cref="List{Operator}"/>.</returns>
        public List<Operator> GetOperatorList()
        {
            return new List<Operator>
            {
                new Operator
                {
                    Id = 1,
                    Name = "John",
                    Team = "Team A",
                    Products = new[]{"A"},
                    Open = 0,
                    Capicity = 5,
                },
                new Operator
                {
                    Id = 2,
                    Name = "Mary",
                    Team = "Team A",
                    Products = new[]{"A", "B"},
                    Open = 3,
                    Capicity = 2,
                },
                 new Operator
                {
                     Id = 3,
                    Name = "Peter",
                    Team = "Team B",
                    Products = new[]{"A"},
                    Open = 3,
                    Capicity = 2,
                },
                  new Operator
                {
                      Id = 4,
                    Name = "Paul",
                    Team = "Team B",
                    Products = new[]{"A", "B"},
                    Open = 1,
                    Capicity = 2,
                }
            };
        }
    }
}
