using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1.ColourQuantizers
{
    class HSVQuantizer:Quantizer
    {        

        private BINS numOFBins;
        public HSVQuantizer() {
            positionList = new List<int>();
        }

        private List<int> existanceList;
        private List<int> propotionList;
        private List<int> positionList;

        public override List<int> getList(FEATURE_VECTOR vecType)
        {
            if (vecType == FEATURE_VECTOR.EXISTENCE)
            {
                return existanceList;
            }
            else if (vecType == FEATURE_VECTOR.PROPORTION)
            {
                return propotionList;
            }
            else if (vecType == FEATURE_VECTOR.POSITION)
            {
                return positionList;
            }
            return null;
        }

        public override void process_dcd(BINS bins, List<int[]> sortedColours)
        {
            numOFBins = bins;
            if (bins == BINS.BINS_15) {
                existanceList = new List<int>(15);
                propotionList = new List<int>(15);
            }
            else if (bins == BINS.BINS_27) {
                existanceList = new List<int>(27);
                propotionList = new List<int>(27);
            }
            else if (bins == BINS.BINS_48) {
                existanceList = new List<int>(48);
                propotionList = new List<int>(48);
            }

            for (int i = 0; i < existanceList.Capacity; i++) {
                existanceList.Add(0);
                propotionList.Add(0);
            }

            List<KeyValuePair<string, int>> dominentColours = quantize_dcd(bins,sortedColours);            
            
            foreach (KeyValuePair<string, int> kv in dominentColours)
            {
                // put 1 to major colours if precentage is more than 5
                if (kv.Value > 5)
                {
                    existanceList[getColourNumber(kv.Key)] = 1;
                }
                // put the major colours' presentage
                propotionList[(getColourNumber(kv.Key))] = kv.Value;
            }
            

        }

        public override void process_cld(BINS bins, List<int[]> sortedColours)
        {
            foreach (int[] rgb in sortedColours)
            {
                positionList.Add(getColourNumber(classifyColor(bins,rgb)));
            }
        }

        private List<KeyValuePair<string, int>> quantize_dcd(BINS bins,List<int[]> sortedColours)
        {
            // Create a dictionary with quantized colours
            Dictionary<string, int> tempDic = new Dictionary<string, int>();

            foreach (int[] rgb in sortedColours)
            {
                String dicIdx = classifyColor(bins,rgb);
                try
                {
                    
                    tempDic[dicIdx] += rgb[3];
                    
                }
                catch (KeyNotFoundException knfe)
                {
                    tempDic.Add(dicIdx, rgb[3]);
                }
                catch (Exception e)
                {

                }
            }

            // Sorting
            List<KeyValuePair<string, int>> tempList = tempDic.ToList();
            tempList.Sort(delegate(KeyValuePair<string, int> a, KeyValuePair<string, int> b) { return a.Value.CompareTo(b.Value); });

            // Select Top 3
            List<KeyValuePair<string, int>> dominentColours = new List<KeyValuePair<string, int>>();
            
            for (int i = tempList.Count - 1; i >= 0; i--) {
                if (tempList[i].Value > 5) {
                        dominentColours.Add(tempList[i]);
                }
            }
                //dominentColours = tempList.GetRange(tempList.Count - NO_OF_DOMINENT_COLOURS, NO_OF_DOMINENT_COLOURS);
            

            return dominentColours;
        }

        private string classifyColor(BINS bins,int[] rgb)
        {
            Color c = Color.FromArgb(0, rgb[0], rgb[1], rgb[2]);
            float hue = c.GetHue();
            float sat = c.GetSaturation();
            float lgt = c.GetBrightness();

            int clrNum = 3;
            int interLeavingDistanceForH = 0;
            int numOfHues=0;
            String delim = "-";
            if (lgt < 0.2) return "Color"+delim+0;
            if (lgt > 0.9 && sat < .1) return "Color"+delim+1;

            if (sat < 0.25) return "Color"+delim+2;


            if (bins == BINS.BINS_15) {
                interLeavingDistanceForH = (int)360 / (15 - 3);
                numOfHues = 15 - 3;                
            }
            else if (bins == BINS.BINS_27) {
                interLeavingDistanceForH = (int)360 / (27 - 3);
                numOfHues = 27 - 3;                
            }
            else if (bins == BINS.BINS_48) {
                interLeavingDistanceForH = (int)360 / (48 - 3);
                numOfHues = 48 - 3;                
            }

            int currHue = 0;

            //go through all the color thresholds
            for (int i = 0; i < numOfHues; i++)
            {
                currHue += interLeavingDistanceForH;
                //if hue is less than curr threshold
                if (hue < currHue)
                {
                    return "Color" + delim+ clrNum;
                }
                    //if it wasn't less than anything
                else if(i==numOfHues-1){
                    
                }
                clrNum++;
            }
            return "Color"+delim+3;
        }

        
    }
}
