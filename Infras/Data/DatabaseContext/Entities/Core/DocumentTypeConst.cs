using System.Reflection.Metadata;
namespace svietnamAPI.Infras.Data.DatabaseContext.Entities.Core
{
    public static class DocumentTypeConst
    {
        public static DocumentType Image_png = new DocumentType {
            Id = 10001,
            Extension = ".png"
        };
        public static DocumentType Image_jpg = new DocumentType {
            Id = 10002,
            Extension = ".jpg"
        };
        public static DocumentType Image_jpeg = new DocumentType {
            Id = 10003,
            Extension = ".jpeg"
        };
        public static DocumentType Csv = new DocumentType {
            Id = 10004,
            Extension = ".csv"
        };
        public static DocumentType Video_mp4 = new DocumentType {
            Id = 10005,
            Extension = ".mp4"
        };
        public static DocumentType Videp_mpeg = new DocumentType {
            Id = 10006,
            Extension = ".mpeg"
        };
    }
}