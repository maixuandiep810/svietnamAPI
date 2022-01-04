namespace svietnamAPI.Common.Dtos.Values.EntityValidationMessage.Catalog
{
    public static class CategoryValidationMessageConst
    {
        public const string NameNotEmpty = "Tên của danh mục không được rỗng.";
        public const string SlugNotEmpty = "Slug của danh mục không được rỗng.";
        public const string IsExistedName = "Tên danh mục đã tồn tại.";
        public const string IsExistedSlug = "Slug đã tồn tại.";
        public const string IsXOR_IsRoot_ParentIdNotNull_EqualFalse = "Danh mục gốc thì không được có danh mục cha và ngược lại.";
        public const string IsNotExistedParentId = "Danh mục cha không tồn tại.";
    }
}