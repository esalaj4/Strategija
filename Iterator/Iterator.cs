using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV6_2
{
    class Iterator : IAbstractIterator
    {
        private Box box;
        private int currentPosition;
        public Iterator(Box box)
        {
            this.box = box;
            currentPosition = 0;
        }

        public bool IsDone { get { return this.currentPosition >= box.Count; } }

        public Product First (){ return this.box[0];  }

        public Product Current{get{return this.box[currentPosition]; } }

        public Product Next()
        {
            currentPosition++;
            if(this.IsDone)
            {
                return null;
            }
            else
            {
                return this.box[currentPosition];
            }
        }




    }
}
