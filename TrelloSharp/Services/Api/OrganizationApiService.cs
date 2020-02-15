using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.ViewModels;
using TrelloSharp.Enums;

namespace TrelloSharp.Services.Api
{
    public class OrganizationApiService : ApiServiceBase
    {
        public string OrganizationId { get; private set; }

        public OrganizationApiService(string organizationId, string appKey, string userToken)
            : base(appKey, userToken)
        {
            OrganizationId = organizationId;
        }

        public async Task<List<BoardViewModel>> GetBoards(BoardFilter boardFilter)
        {
            var filter = boardFilter == BoardFilter.All 
                ? "all" 
                : "open";

            var url = $"{UrlBase}/organizations/{OrganizationId}/boards?filter={filter}&fields=all&key={AppKey}&token={UserToken}";

            var boards = await Get<BoardViewModel[]>(url);

            return boards.ToList();
        }

    }
}
