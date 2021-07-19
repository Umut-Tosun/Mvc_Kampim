using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ImageFileManager : IImageFileService
    {
        IImageFileDal imageFileDal;

        public ImageFileManager(IImageFileDal imageDal)
        {
            imageFileDal = imageDal;
        }

        public List<ImageFile> GetList()
        {
            return imageFileDal.list();
        }

        public void ImageAdd(ImageFile imageFile)
        {
            imageFileDal.insert(imageFile);
        }
    }
}
