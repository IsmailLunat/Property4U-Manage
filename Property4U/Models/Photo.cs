using System;
using System.ComponentModel.DataAnnotations;

namespace Property4U.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        public int PropertyId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Photo Title cannot be longer than 50 characters.")]
        [Display(Name = "Title")]
        public string PhotoTitle { get; set; }

        [DataType(DataType.Text)]
        public string AltText { get; set; }

        [DataType(DataType.Html)]
        public string Caption { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Uploaded from")]
        public string UploadedFrom { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Uploaded to")]
        public string UploadedTo { get; set; }

        public double? Size { get; set; }

        [Display(Name = "Type")]
        public string Extension { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Uploaded On")]
        public DateTime UploadedOn { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Last Edit")]
        public DateTime? LastEdit { get; set; }

        public virtual Property Property { get; set; }
    }
}