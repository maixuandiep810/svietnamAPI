using System;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class DocumentDto
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Desciption { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentTypeDto DocumentType { get; set; }
        public int EntityStatusId { get; set; }
        public EntityStatusDto EntityStatus { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}