using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private IItemService _itemService;
    public ItemController(IItemService itemService)
    {
        _itemService = itemService;
    }
    [HttpGet]
    public ActionResult Get()
    {
        try
        {
            return Ok(_itemService.Get());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpGet("{id}")]
    public ActionResult GetById(int id)
    {
        try
        {
            return Ok(_itemService.GetById(id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpGet("owner/{ownerId}")]
    public ActionResult GetByOwnerId(int ownerId)
    {
        try
        {
            return Ok(_itemService.GetByOwnerId(ownerId));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        try
        {
            return Ok(_itemService.Delete(id));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPost]
    public ActionResult Post(Item item)
    {
        try
        {
            return Ok(_itemService.Add(item));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    [HttpPut]
    public ActionResult Put(Item item)
    {
        try
        {
            return Ok(_itemService.Update(item));
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}
