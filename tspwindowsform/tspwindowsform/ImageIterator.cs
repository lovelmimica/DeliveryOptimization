using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traveling_salesman_problem
{
    class ImageIterator
    {
        List<Image> imageList;
        Image current;

        public ImageIterator()
        {
            string[] imageUrls = Directory.GetFiles("route-images/");
            imageList = new List<Image>();
            foreach(string url in imageUrls)
            {
                Image i = Image.FromFile(url);
                imageList.Add(i);
            }
        }

        public Image Next()
        {
            int currentIndex = imageList.IndexOf(current);
            if (currentIndex == -1) return null;
            int maxIndex = imageList.Count - 1;
            if (currentIndex == maxIndex) return First();
            currentIndex++;
            current = imageList.ElementAt(currentIndex);
            return current;
        }
        public Image First()
        {
            if (imageList == null || imageList.Count == 0) return null;
            current = imageList.ElementAt(0);
            return current;
        }
    }
}
