using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CSPDHandler : DescriptorHandler
    {
        private int whRatio;
        private double[] hProj;
        private double[] vProj;
        private double[] tShape;
        private double[] bShape;

        public CSPDHandler() {
            hProj = new double[10];
            vProj = new double[10];
            tShape = new double[10];
            bShape = new double[10];
        }

        public override void calcDescriptorInfo(Bitmap inImage)
        {
            hProj = new double[10];
            vProj = new double[10];
            tShape = new double[10];
            bShape = new double[10];

            CSPD.CSPD cspd = new CSPD.CSPD();
            double[] descriptor = cspd.GetCSPDescriptor(inImage);
            setALlArrs(descriptor);
        }


        private void setALlArrs(double[] cspdDesc) {
            whRatio = (int) cspdDesc[0];
            for (int i = 0; i < 10; i++) {
                vProj[i] = cspdDesc[i + 1];
                hProj[i] = cspdDesc[i + 11];
                tShape[i] = cspdDesc[i + 21];
                bShape[i] = cspdDesc[i + 31];
            }
        }

        public double[] VProjection {
            get {return vProj;}
        }
        public double[] HProjection {
            get { return hProj; }
        }
        public double[] TopShape {
            get { return tShape; }
        }
        public double[] BottomShape {
            get{ return bShape; }
        }
        public int WHRatio {
            get { return whRatio; }
        }
    }
}
