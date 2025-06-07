using GameZone.Helpers.Attributes;
using GameZone.Helpers;
using GameZone.Models;
using System.ComponentModel.DataAnnotations;

namespace GameZone.Areas.Owner.ViewModelOwner
{
    public class EditGameStation : GameStationVM
    {
        public int Id { get; set; }
        public string? CurrentCover { get; set; }
        [Display(Name = "Image")]
        [Required(ErrorMessage = "Please, Insert an Image!.")]

        [AllowedExtensions(FileSettings.AllowedExtensions)]
        [MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
        public string? Image { get; set; }
    }
}
