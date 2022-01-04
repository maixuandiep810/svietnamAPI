using System.Collections.Generic;
using System.Reflection.Metadata;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Document : IBaseEntity<int>,
        ISoftDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
        public string Desciption { get; set; }
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public bool IsDeleted { get; set; }

        public Document()
        {
        }
    }
}