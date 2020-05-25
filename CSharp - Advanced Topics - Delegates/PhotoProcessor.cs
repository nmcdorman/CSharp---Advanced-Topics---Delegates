using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp___Advanced_Topics___Delegates
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);


        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            // Not extensible
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            filterHandler(photo);

            photo.Save();
        }
        
    }
}
