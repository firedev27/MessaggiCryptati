using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyCollection
{
    class BiTable
    {
        ArrayList firstValue = new ArrayList();
        ArrayList secondValue = new ArrayList();

        public void Add(object fV, object sV)
        {
            firstValue.Add(fV);
            secondValue.Add(sV);
        }

        public object GetByFirstValue(object fV)
        {
            if (firstValue.Contains(fV))
            {
                return secondValue[firstValue.IndexOf(fV)];
            }
            else
            {
                return null;
            }
        }

        public object GetBySecondValue(object sV)
        {
            if (secondValue.Contains(sV))
            {
                return firstValue[secondValue.IndexOf(sV)];
            }
            else
            {
                return null;
            }
        }
    }


}
