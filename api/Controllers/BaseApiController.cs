using Microsoft.AspNetCore.Mvc;
namespace api.Controllers;

[ApiController]
[Route("api/[controller]")] //Get/api/users
public class BaseApiController : ControllerBase
{
}