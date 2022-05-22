using System;

namespace TrelloSharp.ViewModels
{
    public class AttachmentViewModel : EntityBase
    {
        public int? Bytes { get; set; }
        public DateTime Date { get; set; }
        public string EdgeColor { get; set; }
        public string IdMember { get; set; }
        public bool IsUpload { get; set; }
        public string MimeType { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Pos { get; set; }
        public string FileName { get; set; }
    }
}
