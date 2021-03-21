using BookStore.Data;
using BookStore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }
    }
}
