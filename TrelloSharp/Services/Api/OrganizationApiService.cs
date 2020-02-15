using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.Entities;
using TrelloSharp.Enums;

namespace TrelloSharp.Services.Api
{
    public class OrganizationApiService : ApiServiceBase
    {
        public Organization Organization { get; private set; }

        protected OrganizationApiService(Organization organization, string key, string token)
            : base(key, token)
        {
            Organization = organization;
        }

        public async Task<List<Board>> GetBoards(BoardFilter boardFilter)
        {
            var filter = boardFilter == BoardFilter.All 
                ? "all" 
                : "open";

            var url = $"{UrlBase}/organizations/{Organization.Id}/boards?filter={filter}&fields=all&key={Key}&token={Token}";

            var boards = await Get<Board[]>(url);

            return boards.ToList();
        }

    }
}
