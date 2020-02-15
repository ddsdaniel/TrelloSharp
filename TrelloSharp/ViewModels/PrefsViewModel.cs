using System.Collections.Generic;

namespace TrelloSharp.ViewModels
{
    public class PrefsViewModel
    {
        public string PermissionLevel { get; set; }
        public bool HideVotes { get; set; }
        public string Voting { get; set; }
        public string Comments { get; set; }
        public string Invitations { get; set; }
        public bool SelfJoin { get; set; }
        public bool CardCovers { get; set; }
        public bool IsTemplate { get; set; }
        public string CardAging { get; set; }
        public bool CalendarFeedEnabled { get; set; }
        public string Background { get; set; }
        public string BackgroundImage { get; set; }
        public List<BackgroundImageScaledViewModel> BackgroundImageScaled { get; set; }
        public bool BackgroundTile { get; set; }
        public string BackgroundBrightness { get; set; }
        public string BackgroundBottomColor { get; set; }
        public string BackgroundTopColor { get; set; }
        public bool CanBePublic { get; set; }
        public bool CanBeEnterprise { get; set; }
        public bool CanBeOrg { get; set; }
        public bool CanBePrivate { get; set; }
        public bool CanInvite { get; set; }
    }
}
