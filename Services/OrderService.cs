using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_03.Data;
using Assignment_03.Models;
using Microsoft.EntityFrameworkCore;


namespace Assignment_03.Services
{
    public class OrderService
    {
        private readonly ApplicationContext _context;

        public OrderService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task AddOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        // Implement other CRUD operations as needed
    }
}
