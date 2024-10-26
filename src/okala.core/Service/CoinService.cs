using okala.core.Model.Response;
using okala.core.Model.Common;
using okala.core.Model.Request;
using okala.core.Interface;

namespace okala.core.Service;
public class CoinService : ICoinService
{
    public async Task<Response<QuotesInfoResponseModel>> GetQuotesInfo(QuotesInfoRequestModel requestModel)
    {
        // check if code is valid or not :
        string[] validCOdes = 
        [
            "",
            "",
            "",
            "",
        ];
        return null;
    }
}