using ShoeInventoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ShoeInventoryApp.Services
{
    public class ShoeColorVariationService
    {
        private readonly AppDbContext _context;

        public ShoeColorVariationService(AppDbContext context)
        {
            _context = context;
        }

        // Get all color variations
        public async Task<List<ShoeColorVariation>> GetAllVariationsAsync()
        {
            return await _context.ShoeColorVariations.ToListAsync();
        }

        // Get variation by Id
        public async Task<ShoeColorVariation?> GetVariationByIdAsync(int id)
        {
            return await _context.ShoeColorVariations.FindAsync(id);
        }

        // Add a new color variation
        public async Task AddVariationAsync(ShoeColorVariation variation)
        {
            _context.ShoeColorVariations.Add(variation);
            await _context.SaveChangesAsync();
        }

        // Update variation
        public async Task UpdateVariationAsync(ShoeColorVariation variation)
        {
            _context.ShoeColorVariations.Update(variation);
            await _context.SaveChangesAsync();
        }

        // Delete variation
        public async Task DeleteVariationAsync(int id)
        {
            var variation = await _context.ShoeColorVariations.FindAsync(id);
            if (variation != null)
            {
                _context.ShoeColorVariations.Remove(variation);
                await _context.SaveChangesAsync();
            }
        }
    }
}
