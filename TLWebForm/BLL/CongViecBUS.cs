using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TLWebForm.DataAccess;

namespace TLWebForm.BLL
{
    public class CongViecBUS
    {
        CongViecAccess service = new CongViecAccess();

        public void MarkStatus(string id, bool status)
        {
            if(status == true)
            {
                service.MarkStatus(id, status);
                service.UpdateFinishDate(id);
            }
            else
            {
                service.MarkStatus(id, status);
                service.RemoveFinishDate(id);
            }
            
        }
        
    }
}