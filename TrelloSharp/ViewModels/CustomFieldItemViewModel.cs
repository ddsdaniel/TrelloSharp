namespace TrelloSharp.ViewModels
{
    public class CustomFieldItemViewModel: EntityBase
    {
        public ValueViewModel Value { get; set; } //TODO: implement other types
        public string IdCustomField { get; set; }
        public string IdModel { get; set; }
        public string ModelType { get; set; }
    }
}