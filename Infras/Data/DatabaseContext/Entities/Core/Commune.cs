namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public class Commune : IBaseEntity<int>,
        ICodeIdentiﬁable,
        INameIdentiﬁable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}