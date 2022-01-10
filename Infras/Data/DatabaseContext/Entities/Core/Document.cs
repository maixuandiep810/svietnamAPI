using System.Collections.Generic;
using System.Reflection.Metadata;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Document : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable,
        ISoftDeletable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Desciption { get; set; }
        public int DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
        public bool IsDeleted { get; set; }

        public Document()
        {
        }
    }
}