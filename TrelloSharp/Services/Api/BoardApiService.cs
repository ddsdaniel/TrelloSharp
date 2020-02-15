using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.Entities;

namespace TrelloSharp.Services.Api
{
    public class BoardApiService : ApiServiceBase
    {
        public Board Board { get; private set; }

        protected BoardApiService(Board board, string key, string token) : base(key, token)
        {
            Board = board;
        }

        public async Task<List<Member>> GetMembers()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/members?key={Key}&token={Token}";

            var members = await Get<Member[]>(url);

            return members.ToList();
        }

        public async Task<List<CustomField>> GetCustomFields()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/customFields?key={Key}&token={Token}";

            var customFields = await Get<CustomField[]>(url);

            return customFields.ToList();
        }

        public async Task<List<CheckList>> GetCheckLists()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/checklists?key={Key}&token={Token}";

            var checklists = await Get<CheckList[]>(url);

            return checklists.ToList();
        }

        public async Task<List<Card>> GetCards()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/cards?filter=open&customFieldItems=true&key={Key}&token={Token}";

            var cards = await Get<Card[]>(url);

            return cards.ToList();
        }

        public async Task<List<List>> GetLists()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/lists?filter=open&key={Key}&token={Token}";

            var lists = await Get<List[]>(url);

            return lists.ToList();
        }
    }
}
