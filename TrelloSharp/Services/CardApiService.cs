using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrelloSharp.Abstractions.Services;
using TrelloSharp.ViewModels;

namespace TrelloSharp.Services
{
    public class CardApiService : ApiService
    {

        public CardApiService(string appKey, string userToken, ILogger<Service> logger)
            : base(appKey, userToken, logger)
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

        public async Task<List<ActionViewModel>> GetActionsAsync(string cardId)
        {
            var todosTipos = "acceptEnterpriseJoinRequest,addAttachmentToCard,addChecklistToCard,addMemberToBoard,addMemberToCard,addMemberToOrganization,addOrganizationToEnterprise,addToEnterprisePluginWhitelist,addToOrganizationBoard,commentCard,convertToCardFromCheckItem,copyBoard,copyCard,copyCommentCard,createBoard,createCard,createList,createOrganization,deleteBoardInvitation,deleteCard,deleteOrganizationInvitation,disableEnterprisePluginWhitelist,disablePlugin,disablePowerUp,emailCard,enableEnterprisePluginWhitelist,enablePlugin,enablePowerUp,makeAdminOfBoard,makeNormalMemberOfBoard,makeNormalMemberOfOrganization,makeObserverOfBoard,memberJoinedTrello,moveCardFromBoard,moveCardToBoard,moveListFromBoard,moveListToBoard,removeChecklistFromCard,removeFromEnterprisePluginWhitelist,removeFromOrganizationBoard,removeMemberFromCard,removeOrganizationFromEnterprise,unconfirmedBoardInvitation,unconfirmedOrganizationInvitation,updateBoard,updateCard,updateCheckItemStateOnCard,updateChecklist,updateList,updateMember,updateOrganization";

            var url = $"{UrlBase}/cards/{cardId}/actions?key={AppKey}&token={UserToken}&filter={todosTipos}";

            var actions = await Get<ActionViewModel[]>(url);

            return actions.ToList();
        }

        public async Task<List<AttachmentViewModel>> GetAttachmentsAsync(string cardId)
        {
            var url = $"{UrlBase}/cards/{cardId}/attachments?key={AppKey}&token={UserToken}";

            var actions = await Get<AttachmentViewModel[]>(url);

            return actions.ToList();
        }

        
    }
}
