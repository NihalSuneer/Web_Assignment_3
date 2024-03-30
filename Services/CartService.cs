using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_03.Data;
using Assignment_03.Models;
using Microsoft.EntityFrameworkCore;


namespace Assignment_03.Services
{
    public class CartService
    {
        private readonly ApplicationContext _context;

        public CartService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Cart>> GetAllCartsAsync()
        {
            return await _context.Carts.ToListAsync();
        }

        public async Task<Cart> GetCartByIdAsync(int id)
        {
            return await _context.Carts.FindAsync(id);
        }

        public async Task AddCartAsync(Cart cart)
        {
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
        }

        // Implement other CRUD operations as needed
    }
}
