using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.xx_Hetlibrary
{
    class ModBusText_HetMD : System.Windows.Forms.TextBox
    {
        ElkonScada.XX_Connection.ModbusConnection HetmodbusClass = ElkonScada.XX_Connection.ModbusConnection.HetConnection();
        public void Task()
        {

        }
    }
}
