using Domain.Entities;
using Domain.Interfaces;
using Infra.Context;

namespace Infra.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly AppDbContext _context;
    public ItemRepository(AppDbContext context)
    {
        _context = context;
    }
    public Item Add(Item item)
    {
        _context.Item.Add(item);
        _context.SaveChanges();
        return item;
    }

    public bool Delete(int id)
    {
        Item? item = GetById(id);
        if (item != null)
        {

            _context.Item.Remove(item);
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<Item> Get()
    {
        return _context.Item.AsQueryable();
    }

    public Item? GetById(int id)
    {
        return _context.Item.Find(id);
    }

    public IQueryable<Item> GetByOwnerId(int ownerId)
    {
        return _context.Item.Where(i => i.OwnerId == ownerId);
    }

    public Item Update(Item item)
    {
        _context.Item.Update(item);
        _context.SaveChanges();
        return item;
    }
}