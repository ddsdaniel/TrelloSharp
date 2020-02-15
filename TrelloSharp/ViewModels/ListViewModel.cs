using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloSharp.ViewModels
{
    public class ListViewModel : EntityBase
    {
        public string Name { get; set; }
        public bool Closed { get; set; }
        public string IdBoard { get; set; }
        public double Pos { get; set; }
        public bool Subscribed { get; set; }
        public object SoftLimit { get; set; }
    }
}
