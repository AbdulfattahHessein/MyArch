
using Microsoft.AspNetCore.Mvc;
using MyArch.Services.Response;

using System.Net;

namespace SchoolProject.Api.Baises
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppControllerBase : ControllerBase
    {
        #region Actions
        public IActionResult ApiResult<T>(ApiResponse<T> response)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return new OkObjectResult(response);
                case HttpStatusCode.Created:
                    return new CreatedResult(string.Empty, response);
                case HttpStatusCode.Unauthorized:
                    return new UnauthorizedObjectResult(response);
                case HttpStatusCode.BadRequest:
                    return new BadRequestObjectResult(response);
                case HttpStatusCode.NotFound:
                    return new NotFoundObjectResult(response);
                case HttpStatusCode.Accepted:
                    return new AcceptedResult(string.Empty, response);
                case HttpStatusCode.UnprocessableEntity:
                    return new UnprocessableEntityObjectResult(response);
                case HttpStatusCode.NoContent:
                    return new NoContentResult();
                default:
                    return new BadRequestObjectResult(response);
            }
        }
        #endregion
    }
}
