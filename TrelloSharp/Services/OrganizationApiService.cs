using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.ViewModels;
using TrelloSharp.Enums;
using TrelloSharp.Abstractions.Services;
using Microsoft.Extensions.Logging;

namespace TrelloSharp.Services
{
    public class OrganizationApiService : ApiService
    {
        public string OrganizationId { get; private set; }

        public OrganizationApiService(string organizationId, string appKey, string userToken, ILogger<Service> logger)
            : base(appKey, userToken, logger)
        {
            OrganizationId = organizationId;
        }

        public async Task<List<BoardViewModel>> GetBoardsAsync(BoardFilter boardFilter)
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
