using Domain.Entities;
namespace Application.Interfaces;
public interface IItemService
{

    IEnumerable<Item> Get();
    IEnumerable<Item> GetByOwnerId(int ownerId);
    Item GetById(int id);
    Item Add(Item item);
    Item Update(Item item);
    bool Delete(int id);
}