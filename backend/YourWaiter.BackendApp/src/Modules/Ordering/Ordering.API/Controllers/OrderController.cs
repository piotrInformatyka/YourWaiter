using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.API.Controllers;


[ApiController]
[Route($"{OrderingModule.BasePath}/[controller]")]
internal class OrderController : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public string OrderLive() => "Ordering is live!";
}