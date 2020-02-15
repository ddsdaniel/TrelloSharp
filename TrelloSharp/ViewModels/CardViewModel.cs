using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloSharp.ViewModels
{
    public class CardViewModel : EntityBase
    {
        public object CheckItemStates { get; set; }
        public bool Closed { get; set; }
        public DateTime DateLastActivity { get; set; }
        public string Desc { get; set; }
        public DescDataViewModel DescData { get; set; }
        public int? DueReminder { get; set; }
        public string IdBoard { get; set; }
        public string IdList { get; set; }
        public List<object> IdMembersVoted { get; set; }
        public int IdShort { get; set; }
        public string IdAttachmentCover { get; set; }
        public List<string> IdLabels { get; set; }
        public bool ManualCoverAttachment { get; set; }
        public string Name { get; set; }
        public int Pos { get; set; }
        public string ShortLink { get; set; }
        public bool IsTemplate { get; set; }
        public BadgesViewModel Badges { get; set; }
        public bool DueComplete { get; set; }
        public object Due { get; set; }
        public List<string> IdChecklists { get; set; }
        public List<string> IdMembers { get; set; }
        public List<LabelViewModel> Labels { get; set; }
        public string ShortUrl { get; set; }
        public bool Subscribed { get; set; }
        public string Url { get; set; }
        public CoverViewModel Cover { get; set; }
        public List<CustomFieldItemViewModel> CustomFieldItems { get; set; }
    }
}
