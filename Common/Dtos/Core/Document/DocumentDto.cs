namespace svietnamAPI.Common.Dtos.Core.Document
{
    public class DocumentDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Desciption { get; set; }
        public int DocumentTypeId { get; set; }
        public virtual DocumentTypeDto DocumentType { get; set; }
        public bool IsDeleted { get; set; }
    }
}