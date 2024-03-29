namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class EntityStatus : IBaseEntity<int>,
        IGlobalCodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string GlobalCode { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int EntityTypeId { get; set; }
        public EntityType EntityType { get; set; }
    }
}