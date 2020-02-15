using Flunt.Notifications;

namespace TrelloSharp.ViewModels
{
    public abstract class EntityBase : Notifiable
    {
        public string Id { get; private set; }
    }
}
