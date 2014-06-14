using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyImageUploader.Models
{
    public class AlbumModel
    {
        public AlbumModel()
        {
            Photos = new List<FileModel>();
        } 

        public AlbumModel(List<FileModel> files)
        {
            Photos = files;
        }

        public List<FileModel> Photos { get; set; }
    }
}