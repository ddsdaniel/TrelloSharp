using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using System.Text;
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

        public async Task<IdViewModel> UpdateCustomField<TViewModel>(string idCard, string idCustomField, TViewModel customFieldViewModel)
        {
            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            
            var jsonString = JsonConvert.SerializeObject(customFieldViewModel, serializerSettings);

            var httpContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

            var url = $"{UrlBase}/card/{idCard}/customField/{idCustomField}/item?key={AppKey}&token={UserToken}";

            var id = await PutStringContent<IdViewModel>(url, httpContent);

            return id;
        }
    }
}
