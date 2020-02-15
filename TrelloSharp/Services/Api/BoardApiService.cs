using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.ViewModels;

namespace TrelloSharp.Services.Api
{
    public class BoardApiService : ApiServiceBase
    {
        public string BoardId { get; private set; }

        public BoardApiService(string boardId, string appKey, string userToken) : base(appKey, userToken)
        {
            BoardId = boardId;
        }

        public async Task<List<MemberViewModel>> GetMembers()
        {
            var url = $"{UrlBase}/boards/{BoardId}/members?key={AppKey}&token={UserToken}";

            var members = await Get<MemberViewModel[]>(url);

            return members.ToList();
        }

        public async Task<List<CustomFieldViewModel>> GetCustomFields()
        {
            var url = $"{UrlBase}/boards/{BoardId}/customFields?key={AppKey}&token={UserToken}";

            var customFields = await Get<CustomFieldViewModel[]>(url);

            return customFields.ToList();
        }

        public async Task<List<CheckListViewModel>> GetCheckLists()
        {
            var url = $"{UrlBase}/boards/{BoardId}/checklists?key={AppKey}&token={UserToken}";

            var checklists = await Get<CheckListViewModel[]>(url);

            return checklists.ToList();
        }

        public async Task<List<CardViewModel>> GetCards()
        {
            var url = $"{UrlBase}/boards/{BoardId}/cards?filter=open&customFieldItems=true&key={AppKey}&token={UserToken}";

            var cards = await Get<CardViewModel[]>(url);

            return cards.ToList();
        }

        public async Task<BoardViewModel> GetBoard(string id)
        {
            var url = $"{UrlBase}/boards/{BoardId}?key={AppKey}&token={UserToken}";

            var board = await Get<BoardViewModel>(url);

            return board;
        }

        public async Task<List<ListViewModel>> GetLists()
        {
            var url = $"{UrlBase}/boards/{BoardId}/lists?filter=open&key={AppKey}&token={UserToken}";

            var lists = await Get<ListViewModel[]>(url);

            return lists.ToList();
        }

        public async Task<List<LabelViewModel>> GetLabels()
        {
            var url = $"{UrlBase}/boards/{BoardId}/labels?fields=all&key={AppKey}&token={UserToken}";

            var labels = await Get<LabelViewModel[]>(url);

            return labels.ToList();
        }

    }
}
