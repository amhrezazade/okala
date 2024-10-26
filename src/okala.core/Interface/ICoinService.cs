using okala.core.Model.Response;
using okala.core.Model.Common;
using okala.core.Model.Request;

namespace okala.core.Interface;
public interface ICoinService
{
    /// <summary>
    /// Gets the Quotes info of selected code
    /// </summary>
    /// <param name="request">ctarget code</param>
    /// <returns></returns>
    Task<Response<QuotesInfoResponseModel>> GetQuotesInfo(QuotesInfoRequestModel requestModel);
}