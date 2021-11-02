using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_28_RSS
{
    public class StartMsg
    {
        public virtual string StartingMsg()
        {
            return "Nu har vi använt oss av virtual även fast det är December";
        }
    }

    public class StartMsgOverride : StartMsg
    {
        public override string StartingMsg()
        {
            var dateNow = DateTime.Now;
            if (dateNow.Month == 1)
            {
                return "Nu har vi använt oss av virtual även fast det är januari";
            }
            else if (dateNow.Month == 2)
            {
                return "Nu har vi använt oss av virtual även fast det är Februari";
            }
            else if (dateNow.Month == 3)
            {
                return "Nu har vi använt oss av virtual även fast det är Mars";
            }
            else if (dateNow.Month == 4)
            {
                return "Nu har vi använt oss av virtual även fast det är April";
            }
            else if (dateNow.Month == 5)
            {
                return "Nu har vi använt oss av virtual även fast det är Maj";
            }
            else if (dateNow.Month == 6)
            {
                return "Nu har vi använt oss av virtual även fast det är Juni";
            }
            else if (dateNow.Month == 7)
            {
                return "Nu har vi använt oss av virtual även fast det är Juli";
            }
            else if (dateNow.Month == 8)
            {
                return "Nu har vi använt oss av virtual även fast det är Augusti";
            }
            else if (dateNow.Month == 9)
            {
                return "Nu har vi använt oss av virtual även fast det är September";
            }
            else if (dateNow.Month == 10)
            {
                return "Nu har vi använt oss av virtual även fast det är Oktober";
            }
            else if (dateNow.Month == 11)
            {
                return "Nu har vi använt oss av virtual även fast det är November";
            }

            else
            {
                return base.StartingMsg();
            }
        }
    }

}
