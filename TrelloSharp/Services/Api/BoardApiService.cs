using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.ViewModels;

namespace TrelloSharp.Services.Api
{
    public class BoardApiService : ApiServiceBase
    {
        public BoardViewModel Board { get; private set; }

        protected BoardApiService(BoardViewModel board, string key, string token) : base(key, token)
        {
            Board = board;
        }

        public async Task<List<MemberViewModel>> GetMembers()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/members?key={Key}&token={Token}";

            var members = await Get<MemberViewModel[]>(url);

            return members.ToList();
        }

        public async Task<List<CustomFieldViewModel>> GetCustomFields()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/customFields?key={Key}&token={Token}";

            var customFields = await Get<CustomFieldViewModel[]>(url);

            return customFields.ToList();
        }

        public async Task<List<CheckListViewModel>> GetCheckLists()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/checklists?key={Key}&token={Token}";

            var checklists = await Get<CheckListViewModel[]>(url);

            return checklists.ToList();
        }

        public async Task<List<CardViewModel>> GetCards()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/cards?filter=open&customFieldItems=true&key={Key}&token={Token}";

            var cards = await Get<CardViewModel[]>(url);

            return cards.ToList();
        }

        public async Task<List<ListViewModel>> GetLists()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/lists?filter=open&key={Key}&token={Token}";

            var lists = await Get<ListViewModel[]>(url);

            return lists.ToList();
        }

        public async Task<List<LabelViewModel>> GetLabels()
        {
            var url = $"{UrlBase}/boards/{Board.Id}/labels?fields=all&key={Key}&token={Token}";

            var lists = await Get<LabelViewModel[]>(url);

            return lists.ToList();
        }

    }
}
