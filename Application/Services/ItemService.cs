using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;
public class ItemService : IItemService
{
    private IItemRepository _itemRepository;
    public ItemService(IItemRepository itemRepository)
    {
        _itemRepository = itemRepository;
    }

    public Item Add(Item item)
    {
        return _itemRepository.Add(item);
    }

    public bool Delete(int id)
    {
        return _itemRepository.Delete(id);
    }

    public IEnumerable<Item> Get()
    {
        return _itemRepository.Get();
    }

    public Item GetById(int id)
    {
        return _itemRepository.GetById(id);
    }

    public IEnumerable<Item> GetByOwnerId(int ownerId)
    {
        return _itemRepository.GetByOwnerId(ownerId);
    }

    public Item Update(Item item)
    {
        return _itemRepository.Update(item);
    }
}