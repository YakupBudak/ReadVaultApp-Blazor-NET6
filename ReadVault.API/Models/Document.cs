namespace ReadVaultApp.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Description { get; set; }
        public DateTime UploadDate { get; set; }
    }
