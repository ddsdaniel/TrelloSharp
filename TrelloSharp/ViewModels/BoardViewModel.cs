using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloSharp.ViewModels
{
    public class BoardViewModel : EntityBase
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public object DescData { get; set; }
        public bool Closed { get; set; }
        public string IdOrganization { get; set; }
        public object IdEnterprise { get; set; }
        public object Limits { get; set; }
        public object Pinned { get; set; }
        public string ShortLink { get; set; }
        public List<object> PowerUps { get; set; }
        public DateTime DateLastActivity { get; set; }
        public List<object> IdTags { get; set; }
        public object DatePluginDisable { get; set; }
        public object CreationMethod { get; set; }
        public object IxUpdate { get; set; }
        public bool EnterpriseOwned { get; set; }
        public object EdBoardSource { get; set; }        
        public bool Starred { get; set; }
        public string Url { get; set; }
        public PrefsViewModel Prefs { get; set; }
        public bool Subscribed { get; set; }
        public LabelNameViewModel LabelNames { get; set; }
        public DateTime DateLastView { get; set; }
        public string ShortUrl { get; set; }
        public object TemplateGallery { get; set; }
        public List<MembershipViewModel> Memberships { get; set; }
    }
}
