using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_03.Data;
using Assignment_03.Models;
using Microsoft.EntityFrameworkCore;


namespace Assignment_03.Services
{
    public class UserService
    {
        private readonly ApplicationContext _context;

        public UserService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        // Implement other CRUD operations as needed
    }
}
