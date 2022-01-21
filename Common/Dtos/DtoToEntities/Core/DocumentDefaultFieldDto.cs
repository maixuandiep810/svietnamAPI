using System;
using svietnamAPI.Infras.Data.DatabaseContext.Entities.Core;

namespace svietnamAPI.Common.Dtos.DtoToEntities.Core
{
    public class DocumentDefaultFieldDto
    {
        public int EntityStatusId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }

        public DocumentDefaultFieldDto()
        {
            EntityStatusId = EntityStatusConst.Document_Pending.Id;
            IsDeleted = false;
            CreatedAt = DateTime.Now;
        }
    }
}