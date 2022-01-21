using System.Collections.Generic;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class DocumentTypeDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }

        public ICollection<DocumentDto> Documents { get; set; }
    }
}