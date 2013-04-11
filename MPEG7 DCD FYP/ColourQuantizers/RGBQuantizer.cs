using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1.ColourQuantizers
{
    class RGBQuantizer:Quantizer
    {



        // two class level list to save results
        private List<int> existanceList;
        private List<int> propotionList;
        private List<int> positionList= new List<int>(0);

        public RGBQuantizer() 
        {
            
        }

        public override void process_cld(BINS bins, List<int[]> sortedColours)
        {
            int multiFactor = 0;
            if (bins == BINS.BINS_27)
            {
                multiFactor = 3;
            }
            else if (bins == BINS.BINS_64)
            {
                multiFactor = 4;
            }

            foreach (int[] rgb in sortedColours)
            {
                positionList.Add(getColourNumber(classifyColor(multiFactor, rgb)));
            }

        }

        public override void process_dcd(BINS bins,List<int[]> sortedColours)
        {
            int listSize = 0;
            if (bins == BINS.BINS_27) {
                listSize = 27;
            }
            else if (bins == BINS.BINS_64) {
                listSize = 64;
            }
            existanceList = new List<int>(listSize);
            propotionList = new List<int>(listSize);
            for (int i = 0; i < listSize; i++)
            {
                existanceList.Add(0);
                propotionList.Add(0);
            }

            List<KeyValuePair<string,int>> sortedQuantizedColours = quantize_dcd(bins,sortedColours);

            foreach (KeyValuePair<string,int> kvPair in sortedQuantizedColours) {
                existanceList[getColourNumber(kvPair.Key)] = 1;
                propotionList[getColourNumber(kvPair.Key)] = kvPair.Value;
            }

        }

        private List<KeyValuePair<string,int>> quantize_dcd(BINS bins,List<int[]> colourVector)
        {
            int multiFactor = 0;
            if (bins == BINS.BINS_27) {
                multiFactor = 3;
            }else if(bins == BINS.BINS_64){
                multiFactor = 4;
            }
            
            

            Dictionary<string, int> quantizedColourDic = new Dictionary<string, int>();

            foreach (int[] rgb in colourVector)
            {
                string key = classifyColor(multiFactor, rgb);

                try
                {
                    quantizedColourDic[key] += rgb[3];
                }
                catch (KeyNotFoundException knfe)
                {
                    quantizedColourDic.Add(key, rgb[3]);

                }
                catch (Exception e) { 
                    
                }               

            }

            List<KeyValuePair<string,int>> sortedQuantizedcolours = quantizedColourDic.ToList();

            sortedQuantizedcolours.Sort(delegate(KeyValuePair<string,int> a, KeyValuePair<string,int> b) 
                    { 
                        return a.Value.CompareTo(b.Value); 
                    });

            List<KeyValuePair<string, int>> domColors = new List<KeyValuePair<string, int>>();
            for (int i = sortedQuantizedcolours.Count - 1; i >= 0; i--)
            {
                if (sortedQuantizedcolours[i].Value > 5)
                {
                    domColors.Add(sortedQuantizedcolours[i]);
                }
            }

            return domColors;

        }

        private static string classifyColor(int multiFactor, int[] rgb)
        {
            int chunckSize = (int)Math.Ceiling((double)255 / multiFactor);
            int colorIdx = (1 * (rgb[0] / chunckSize)) + (multiFactor * (rgb[1] / chunckSize)) +
                ((int)Math.Pow(multiFactor, 2) * (rgb[2] / chunckSize));
            string key = "Color-" + colorIdx;
            return key;
        }
       
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
    }
}
