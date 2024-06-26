﻿using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Data;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopOnline.Api.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ShopOnlineDbContext _dbContext;

        public CommentRepository(ShopOnlineDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Comment> AddComment(Comment comment)
        {
            await _dbContext.Comments.AddAsync(comment);
            await _dbContext.SaveChangesAsync();
            return comment;
        }

        public async Task<IEnumerable<Comment>> GetCommentsByProduct(int productId)
        {
            return await _dbContext.Comments
                                   .Where(c => c.ProductId == productId)
                                   .ToListAsync();
        }

        public async Task<Comment> GetComment(int id)
        {
            return await _dbContext.Comments.FirstOrDefaultAsync(c => c.Id == id);
        }


        public async Task DeleteComment(int id)
        {
            var comment = await GetComment(id);
            if (comment != null)
            {
                _dbContext.Comments.Remove(comment);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task<int?> GetLastCommentId()
        {
            return await _dbContext.Comments.MaxAsync(c => (int?)c.Id);
        }
    }
}
