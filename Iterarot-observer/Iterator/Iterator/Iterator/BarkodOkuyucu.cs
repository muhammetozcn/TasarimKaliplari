using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface KoliIterator
    {
         void Next();
         bool isDone();
         Koli currentItem();
    }
    public class BarkodOkuyucu : KoliIterator
    {
        Koli[] koliler;
        int index = 0;
        public BarkodOkuyucu(Koli[] koliler)
        {
            this.koliler = koliler;
        }
        public Koli currentItem()
        {
            return this.koliler[index];
        }

        public bool isDone()
        {
            if (koliler.Length == index)
            {
                return false;
            }
            return true;
        }

        public void Next()
        {
            index += 1;
        }
    }
}
