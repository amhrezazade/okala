using okala.core.Model.Request;
using okala.core.Model.Response;
using okala.core.Model.Common;
using okala.core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace okala.api.Controllers;

[ApiController]
[Route("api/coin")]
public class CoinController(ICoinService service) : ControllerBase
{
    /// <summary>
    /// Gets the Quotes info of selected code
    /// </summary>
    /// <param name="request">ctarget code</param>
    /// <returns></returns>
    [HttpGet("QuotesInfo")]
    public async Task<Response<QuotesInfoResponseModel>> GetQuotesInfo([FromQuery] QuotesInfoRequestModel request)
    {
        return await service.GetQuotesInfo(request);
    }
}