using System.ComponentModel.DataAnnotations;

namespace Dima.Core.Requests.Categories
{
    public class CreateCategoryRequest : Request
    {
        [Required(ErrorMessage = "Title is invalid")]
        [MaxLength(80, ErrorMessage = "Title is too long")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is invalid")]
        public string? Description { get; set; } = string.Empty;
    }
}