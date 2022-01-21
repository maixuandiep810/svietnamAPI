using svietnamAPI.Common.Dtos.Responses;
namespace svietnamAPI.Common.Dtos.Values
{
    public static class ResponseCodeConst
    {
        /// <summary>
        /// Base: Error Message -> 10001 - 10999 ->  001 - 999
        /// </summary>
        public const string E10001 = "Request không thỏa mãn ràng buộc.";
        public const string E10002 = "Đối tượng tạo mới không thỏa mãn ràng buộc.";


        /// <summary>
        /// Auth: Error Message -> 11001 - 11999 ->  001 - 999
        /// </summary>
        public const string E11001 = "Token gặp lỗi, xin đăng nhập lại!";
        public const string E11002 = "Khách hàng cần đăng nhập để thực hiện hành động này.";
        public const string E11003 = "Khách hàng không có quyền thực hiện hành động này.";

        /// <summary>
        /// Catalog: Error Message -> 12001 - 12999 ->  001 - 999
        /// </summary>

        /// Category -> 12001 -> 12099
        public const string E12001 = "Lỗi: Cập nhật ...";



        /// <summary>
        /// Base: Success Message -> 60001 - 60999 ->  001 - 999
        /// </summary>
        public const string S60001 = "Thành công: Lấy dữ liệu thành công";


        /// <summary>
        /// Auth: Success Message -> 61001 - 61999 ->  001 - 999
        /// </summary>

        /// <summary>
        /// Catalog: Success Message -> 62001 - 62999 ->  001 - 999
        /// </summary>

        /// GlobalProductCategory -> 62001 -> 62099
        public const string S62001 = "Thành công: Tạo Danh mục sản phẩm của hệ thống.";
        public const string S62002 = "Thành công: Cập nhật ...";
    }
}