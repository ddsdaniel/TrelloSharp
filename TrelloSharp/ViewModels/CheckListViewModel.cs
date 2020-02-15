using System.Collections.Generic;

namespace TrelloSharp.ViewModels
{
    public class CheckListViewModel : EntityBase
    {
        public string Name { get; set; }
        public string IdBoard { get; set; }
        public string IdCard { get; set; }
        public int Pos { get; set; }
        public List<CheckItemViewModel> CheckItems { get; set; }
    }
}
