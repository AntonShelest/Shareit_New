using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyImageUploader.Models
{
    public class FolderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public int SupFolderId { get; set; }
        public int Rights { get; set; }
        public string Link { get; set; }
    }
}