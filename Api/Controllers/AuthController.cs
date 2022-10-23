using Api.Models;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost]
    public User ValidadeCredentials(Credentials credentials)
    {
        return new User();
    }

}