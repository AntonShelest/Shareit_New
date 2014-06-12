using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace FancyImageUploader.Models
{
    [Table("Files")]
    public class FileModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FileId { get; set; }
        //[Required]
        //[Display(Name = "User name")]
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public int FolderId { get; set; }
    }

}