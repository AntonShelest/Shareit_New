using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyImageUploader.Models.ERD
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int FolderId { get; set; }
    }
}