using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.ColourQuantizers
{

    abstract class Quantizer
    {
        public enum BINS { BINS_15, BINS_27, BINS_48, BINS_54 , BINS_64};
        public enum FEATURE_VECTOR { EXISTENCE, PROPORTION, POSITION };

        public abstract List<int> getList(FEATURE_VECTOR vecType);
        public abstract void process_dcd(BINS bins, List<int[]> sortedColours);
        public abstract void process_cld(BINS bins, List<int[]> sortedColours);

        protected int getColourNumber(string colourName)
        {
            int colorNum = int.Parse(colourName.Split(new char[] { '-' })[1]);
            return colorNum;
        }
    }
}
