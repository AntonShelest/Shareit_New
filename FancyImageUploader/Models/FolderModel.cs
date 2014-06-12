using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace FancyImageUploader.Models
{
    [Table("Folders")]
    public class FolderModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int FolderId { get; set; }

        public string FolderName { get; set; }
        public int FolderUserId { get; set; }
        public int SupFolderId { get; set; }
        public int FolderRights { get; set; }
        public string FolderLink { get; set; }
    }
}