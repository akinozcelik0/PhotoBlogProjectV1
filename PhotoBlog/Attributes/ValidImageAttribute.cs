using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PhotoBlog.Attributes
{
    public class ValidImageAttribute : ValidationAttribute
    {
        /// <summary>
        /// Maximum file size of uploaded file in megabytes (Default = 1);
        /// </summary>
        public int MaxFileSize { get; set; } = 1;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            
            IFormFile? photo = value as IFormFile;

            if (photo == null)
                return ValidationResult.Success;

            //Photo Validation Controls
            
            if (!photo.ContentType.StartsWith("image/"))
            {
                return new ValidationResult("Invalid Picture Format!");
                
            }
            else if (photo.Length > MaxFileSize * 1024 * 1024)
            {
                return new ValidationResult($"Max {MaxFileSize}MB file size accepted!");
                
            }
              
            return ValidationResult.Success;

            
        }

    }
}
