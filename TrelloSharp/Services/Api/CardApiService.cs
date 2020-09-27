using System.Threading.Tasks;
using TrelloSharp.ViewModels;

namespace TrelloSharp.Services.Api
{
    public class CardApiService: ApiServiceBase
    {

        public CardApiService(string appKey, string userToken)
            : base(appKey, userToken)
        {

        }

        public async Task AddLabel(string idLabel, string idCard)
        {
            var url = $"{UrlBase}/cards/{idCard}/idLabels?key={AppKey}&token={UserToken}&value={idLabel}";

            await Post(url);
        }
    }
}
