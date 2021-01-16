using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentsSocialMedia.Web.Infrastructure.ValidationAttributres
{
    public class ValidateImagesExtensionAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            ICollection<string> allowedExtensions = new List<string>() { ".jpg", ".png", ".gif" };

            if (value is IFormFile imageValue)
            {
                string extension = Path.GetExtension(imageValue.FileName);
                if (!allowedExtensions.Contains(extension))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
