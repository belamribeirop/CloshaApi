using Domain.Entities;

namespace Domain.Interfaces;
public interface IItemRepository
{
    IQueryable<Item> Get();
    IQueryable<Item> GetByOwnerId(int ownerId);
    Item GetById(int id);
    Item Post(Item item);
    Item Put(Item item);
    bool Delete(int id);
}