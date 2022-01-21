using System;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class DocumentCreateDto
    {
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Desciption { get; set; }
        public int DocumentTypeId { get; set; }
    }
}