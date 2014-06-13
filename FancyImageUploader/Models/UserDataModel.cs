using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FancyImageUploader.Models
{
    public class UserDataModel
    {
        public UserDataModel()
        {
            Albums = new List<AlbumModel>();
        }
        public List<AlbumModel> Albums { get; set; }
    }
}