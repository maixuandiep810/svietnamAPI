using System.Reflection.Metadata;
using System.Collections;
using System.Collections.Generic;

namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class DocumentType : IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }

        public virtual ICollection<Document> Documents { get; set; }

        public DocumentType()
        {
            Documents = new List<Document>();
        }
    }
}