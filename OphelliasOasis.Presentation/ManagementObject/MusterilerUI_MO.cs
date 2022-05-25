using OphelliasOasis.Presentation.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OphelliasOasis.Presentation.ManagementObject
{
    public class MusterilerUI_MO
    {
        public MusterilerUI UI { get; set; }
        public MusterilerUI_MO()
        {
            UI = new MusterilerUI();
            UI.Show();
        }
    }
}
