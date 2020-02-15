using Flunt.Notifications;

namespace TrelloSharp.Entities
{
    public abstract class EntityBase : Notifiable
    {
        public string Id { get; private set; }
    }
}
