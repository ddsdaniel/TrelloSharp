namespace TrelloSharp.ViewModels
{
    public class CheckItemViewModel:EntityBase
    {
        public string IdChecklist { get; set; }
        public string State { get; set; }
        public object IdMember { get; set; }
        public string Name { get; set; }
        public NameDataViewModel NameData { get; set; }
        public double Pos { get; set; }
        public object Due { get; set; }
    }
}