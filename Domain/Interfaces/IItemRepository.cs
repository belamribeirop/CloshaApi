using Domain.Entities;

namespace Domain.Interfaces;
public interface IItemRepository
{
    IQueryable<Item> Get();
    IQueryable<Item> GetByOwnerId(int ownerId);
    Item GetById(int id);
    Item Add(Item item);
    Item Update(Item item);
    bool Delete(int id);
}