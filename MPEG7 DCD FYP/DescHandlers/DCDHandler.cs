using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class DCDHandler : DescriptorHandler
    {
        private List<int[]> _DominantRGB;

        public DCDHandler() {
            _DominantRGB = new List<int[]>();
        }

        public override void calcDescriptorInfo(Bitmap inImage)
        {
            _DominantRGB.Clear();
            //Bitmap inImage = new Bitmap(fileName);
            DCD_Descriptor dcd = new DCD_Descriptor();
            dcd.extractDescriptor(inImage);
            int[][] dColors = dcd.colorValues;
            int[] dPrecentages = dcd.percentages;
            correctRGBAndPrecentage(dColors, dPrecentages);
            sortOnPercentage(_DominantRGB);
            
        }

        //values returned by the library is not in the range of 0-255
        //this neesds to be scaled
        private void correctRGBAndPrecentage(int[][] rgb,int[] precentages) {
            for (int i = 0; i < rgb.Length && rgb[i] != null; i++) {
                int[] temp = new int[4];

                temp[0] = rgb[i][0] * 8;
                temp[1] = rgb[i][1] * 8;
                temp[2] = rgb[i][2] * 8;
                temp[3] = (precentages[i] * 100) / 31;

                _DominantRGB.Add(temp);
            }
        }

        //sort by precentage
        private void sortOnPercentage(List<int[]> dcdInfo) {
            dcdInfo.Sort(delegate(int[] a, int[] b) { return a[3].CompareTo(b[3]); });
        }


        public List<int[]> DominantRGB {
            get { return _DominantRGB; }
        }
       
    }
}
