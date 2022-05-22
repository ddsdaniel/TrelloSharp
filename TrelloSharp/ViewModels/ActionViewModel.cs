using System;

namespace TrelloSharp.ViewModels
{
    public class ActionViewModel : EntityBase
    {
        public string idMemberCreator { get; set; }
        public ActionDataViewModel data { get; set; }
        public string type { get; set; }
        public MemberViewModel memberCreator { get; set; }
        public DateTime date { get; set; }
    }
}
