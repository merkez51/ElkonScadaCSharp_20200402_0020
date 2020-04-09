using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElkonScada.xx_Script
{
    class UretimResetleme
    {
        private static UretimResetleme UretimResetScript;
        private UretimResetleme()
        {

        }
        public static UretimResetleme UretimResetScripts()
        {
            if (UretimResetScript == null)
            {
                UretimResetScript = new UretimResetleme();
            }
            return UretimResetScript;
        }
        public bool UretimReselemeFunction(bool ResetlemeBilgisi)
    {
            ResetlemeBilgisi = true;

            return ResetlemeBilgisi;
    }
    }
   
}
