namespace svietnamAPI.Infras.Data.DatabaseContext.Entities
{
    public interface INameIdentiﬁable
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Slug { get; set; }
    }
}