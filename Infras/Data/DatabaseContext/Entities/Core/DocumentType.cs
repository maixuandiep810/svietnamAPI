using System.Reflection.Metadata;
using System.Collections;
using System.Collections.Generic;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class DocumentType : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }

        public ICollection<Document> Documents { get; set; }

        public DocumentType()
        {
            Documents = new List<Document>();
        }
    }
}