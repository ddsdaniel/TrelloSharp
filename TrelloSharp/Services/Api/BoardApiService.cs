﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrelloSharp.ViewModels;

namespace TrelloSharp.Services.Api
{
    public class BoardApiService : ApiServiceBase
    {

        public BoardApiService(string appKey, string userToken)
            : base(appKey, userToken)
        {

        }

        public async Task<BoardViewModel> Create(string name, string idOrganization)
        {
            var url = $"{UrlBase}/boards?key={AppKey}&token={UserToken}&name={name}&idOrganization={idOrganization}&defaultLists=false";

            var newBoard = await Post<BoardViewModel>(url);

            return newBoard;
        }

        public async Task<ListViewModel> CreateList(string name, string idBoard)
        {
            var url = $"{UrlBase}/boards/{idBoard}/lists?key={AppKey}&token={UserToken}&name={name}&pos=bottom";

            var newList = await Post<ListViewModel>(url);

            return newList;
        }

        public async Task<LabelViewModel> CreateLabel(string name, string idBoard)
        {
            var url = $"{UrlBase}/boards/{idBoard}/labels?key={AppKey}&token={UserToken}&name={name}";

            var newLabel = await Post<LabelViewModel>(url);

            return newLabel;
        }

        public async Task<CardViewModel> CreateCard(string name, string idList)
        {
            //TODO: idLabels
            /*
            Array<string>
            Comma-separated list of label IDs to add to the card
             */
            var url = $"{UrlBase}/cards?key={AppKey}&token={UserToken}&name={name}&idList={idList}";

            var newLabel = await Post<CardViewModel>(url);

            return newLabel;
        }

        public async Task<List<MemberViewModel>> GetMembers(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}/members?key={AppKey}&token={UserToken}";

            var members = await Get<MemberViewModel[]>(url);

            return members.ToList();
        }

        public async Task<List<CustomFieldViewModel>> GetCustomFields(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}/customFields?key={AppKey}&token={UserToken}";

            var customFields = await Get<CustomFieldViewModel[]>(url);

            return customFields.ToList();
        }

        public async Task<List<CheckListViewModel>> GetCheckLists(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}/checklists?key={AppKey}&token={UserToken}";

            var checklists = await Get<CheckListViewModel[]>(url);

            return checklists.ToList();
        }

        public async Task<List<CardViewModel>> GetCards(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}/cards?filter=open&customFieldItems=true&key={AppKey}&token={UserToken}";

            var cards = await Get<CardViewModel[]>(url);

            return cards.ToList();
        }

        public async Task<BoardViewModel> GetBoard(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}?key={AppKey}&token={UserToken}";

            var board = await Get<BoardViewModel>(url);

            return board;
        }

        public async Task<List<ListViewModel>> GetLists(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}/lists?filter=open&key={AppKey}&token={UserToken}";

            var lists = await Get<ListViewModel[]>(url);

            return lists.ToList();
        }

        public async Task<List<LabelViewModel>> GetLabels(string boardId)
        {
            var url = $"{UrlBase}/boards/{boardId}/labels?fields=all&key={AppKey}&token={UserToken}";

            var labels = await Get<LabelViewModel[]>(url);

            return labels.ToList();
        }

    }
}
