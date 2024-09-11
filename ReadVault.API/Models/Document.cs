using System;
using System.ComponentModel.DataAnnotations;

namespace ReadVaultApp.Models
{
    public class Document
    {
        public int Id { get; set; }

           [Required]
            [StringLength(255, ErrorMessage = "File name is too damn long.")]
                public string FileName { get; set; }

           [Required]
            [StringLength(500, ErrorMessage = "File path is way too long.")]
                public string FilePath { get; set; }

            [StringLength(1000, ErrorMessage = "Description is too long, dont write romans.")]
                public string Description { get; set; }

                public DateTime UploadDate { get; set; }

        // Ensure that the file path is set through a method to validate it
        public void SetFilePath(string path)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentException("File path cannot be empty.", nameof(path));
            }

            FilePath = path;
        }
    }
}