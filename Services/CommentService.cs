using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment_03.Data;
using Assignment_03.Models;
using Microsoft.EntityFrameworkCore;


namespace Assignment_03.Services
{
    public class CommentService
    {
        private readonly ApplicationContext _context;

        public CommentService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllCommentsAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment> GetCommentByIdAsync(int id)
        {
            return await _context.Comments.FindAsync(id);
        }

        public async Task AddCommentAsync(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }

        // Implement other CRUD operations as needed
    }
}
