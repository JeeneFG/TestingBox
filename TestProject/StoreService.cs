using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject
{
    public class StoreService
    {
        public List<Box> Sort(Store store)
        {
            if (store == null)
            {
                throw new ArgumentException("Ссылка не указывает на объект");
            }

            List<Box> boxes = store.Boxes;

            boxes.Sort((o1, o2) =>
            {
                BoxService service = new BoxService();
                double firstVolume = service.GetVolume(o1);
                double secondVolume = service.GetVolume(o2);

                return firstVolume.CompareTo(secondVolume);
            });

            return boxes;
        }
    }
}
