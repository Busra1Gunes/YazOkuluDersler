using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer
{
    public class EntityOgretmen
    {
        private int ogrtid;
        private string ogrtad;
        private string ogrtbrans;


        public int OGRTID
        {
            get
            {
                return ogrtid;
            }

            set
            {
                ogrtid = value;
            }
        }

        public string OGRTAD
        {
            get
            {
                return ogrtad;
            }

            set
            {
                ogrtad = value;
            }
        }

        public string OGRTBRANS
        {
            get
            {
                return ogrtbrans;
            }

            set
            {
                ogrtbrans = value;
            }
        }
    }
}
