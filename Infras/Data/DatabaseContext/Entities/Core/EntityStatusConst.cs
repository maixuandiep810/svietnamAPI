namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public static class EntityStatusConst
    {
        public static EntityStatus Product_Enabled = new EntityStatus
        {
            Id = 13101
        };
        public static EntityStatus Product_Disabled = new EntityStatus
        {
            Id = 13102
        };
        public static EntityStatus Product_Approved = new EntityStatus
        {
            Id = 13103
        };
        public static EntityStatus Product_Pending = new EntityStatus
        {
            Id = 13104
        };
        public static EntityStatus Product_Banned = new EntityStatus
        {
            Id = 13105
        };
        public static EntityStatus GlobalProductCategory_Enabled = new EntityStatus
        {
            Id = 13111
        };
        public static EntityStatus GlobalProductCategory_Disabled = new EntityStatus
        {
            Id = 13112
        };
        public static EntityStatus GlobalProductCategory_Approved = new EntityStatus
        {
            Id = 13113
        };
        public static EntityStatus GlobalProductCategory_Pending = new EntityStatus
        {
            Id = 13114
        };



        public static EntityStatus Document_Approved = new EntityStatus
        {
            Id = 11101
        };
        public static EntityStatus Document_Pending = new EntityStatus
        {
            Id = 11102
        };
    }
}