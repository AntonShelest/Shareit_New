using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyImageUploader.Models
{
    public class ImagesModel
    {
        public ImagesModel()
        {
            Images = new List<string>();
        }

        public List<string> Images { get; set; }
    }

    public class AlbumsModel
    {
        public AlbumsModel()
        {
            Albums = new List<FileModel>();
        }
        public List<FileModel> Albums { get; set; }
    }
}