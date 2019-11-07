using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil1_2.Entities
{
    public class Host
    {
        Tfussa tfussa= new Tfussa();

        public void AddYomBadid(int[]luach)
        {
            tfussa.Mat[luach[0],luach[1]] = true;
        }

        public bool CheckYomPanuy(int[] luach)
        {
            return tfussa.Mat[luach[0], luach[1]] == false;
        }

        public bool AddYamim(List<int[]> list)
        {
            for (int i = 1; i < list.Count-1; i++)
            {
                if (!CheckYomPanuy(list[i]))
                {
                    return false;
                }
            }
            foreach (int[] item in list)
            {
                AddYomBadid(item);
            }
            return true;
        }
        public Host()
        {
            // default
        }
        public Host(List<int[]> list)
        {
            AddYamim(list);
        }
    }
}
