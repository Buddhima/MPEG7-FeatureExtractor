using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.DescHandlers
{
    class DescHandlerFactory
    {
        public enum Descriptor { DCD, CLD, CSPD, SHAPE };

        public DescriptorHandler getDescriptorHandler(Descriptor desc) {
            if (desc == Descriptor.DCD) {
                return new DCDHandler();
            }
            else if (desc == Descriptor.CLD)
            {
                return new CLDHandler();
            }
            else if (desc == Descriptor.CSPD)
            {
                return new CSPDHandler();
            }
            else if (desc == Descriptor.SHAPE)
            {
                return new BlobHandler();
            }
            else {
                return null;
            }
        }
    }
}
