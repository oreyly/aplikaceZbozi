using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikaceZbozi
{
    interface IMaStromKategoriiASeznamZbozi
    {
        StromKategorii stromKategorii { get; set; }
        System.Windows.Forms.FlowLayoutPanel flpSeznamZbozi { get; set; }
        void OtevriPredchozi();
    }
}
