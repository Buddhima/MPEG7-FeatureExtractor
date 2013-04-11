using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.ColourQuantizers
{
    class RGBHistogramQuantizer : Quantizer
    {
        enum Colors { R, G, B };

        List<int> existanceList = new List<int>(30);
        List<int> proportionList = new List<int>(30);


        public override List<int> getList(FEATURE_VECTOR vecType)
        {
            if (vecType == FEATURE_VECTOR.EXISTENCE)
            {
                return existanceList;
            }
            else if (vecType == FEATURE_VECTOR.PROPORTION)
            {
                return proportionList;
            }

            return null;
        }

        public override void process_dcd(BINS bins, List<int[]> sortedColours)
        {
            for (int i = 0; i < existanceList.Capacity; i++) {
                existanceList.Add(0);
                proportionList.Add(0);
            }
            Dictionary<string, int> _quantizedColors = quantize_dcd(sortedColours);

            foreach (KeyValuePair<string, int> kvPair in _quantizedColors) {
                existanceList[parseColorKey(kvPair.Key)]=1;
                proportionList[parseColorKey(kvPair.Key)]=kvPair.Value;
            }
        }

        private Dictionary<string, int> quantize_dcd(List<int[]> colors)
        {
            Dictionary<string, int> _DCDOutput = new Dictionary<string, int>();
            foreach (int[] rgb in colors) {
                for (int i = 0; i < 3; i++) {
                    String key = null;
                    if (i == 0) {
                        key = getColorBinKey(rgb[i], Colors.R);
                    }
                    else if (i == 1) {
                        key = getColorBinKey(rgb[i], Colors.G);
                    }
                    else if (i == 2) {
                        key = getColorBinKey(rgb[i], Colors.B);
                    }
                    int _val = 0;
                    if (_DCDOutput.ContainsKey(key))
                    {
                        _DCDOutput.TryGetValue(key, out _val);
                        _DCDOutput.Remove(key);
                        _val += rgb[3];
                        _DCDOutput.Add(key, _val);
                    }
                    else {
                        _DCDOutput.Add(key, rgb[3]);
                    }
                }
            }

            return _DCDOutput;
        }
        
        private String getColorBinKey(int color, Colors type) {
            int bin = color / 25;
            String key;
            if (type == Colors.R) {
                key = "R";
            }
            else if (type == Colors.G)
            {
                key = "G";
            }
            else if (type == Colors.B)
            {
                key = "B";
            }
            else {
                return null;
            }

            if (color < 250)
            {
                return key + bin.ToString();
            }
            else {
                return key + "9";
            }
        }

        private int parseColorKey(String key) {
            int multiplyIdx = 0;
            int numOfBinsForEachColor = 10;
            if (key.Contains('R')) {
                multiplyIdx = 0;
            }
            else if (key.Contains('G')) {
                multiplyIdx = 1;
            }
            else if (key.Contains('B'))
            {
                multiplyIdx = 2;
            }
            else {
                return -1;
            }

            int idx = int.Parse(key.Substring(1));
            return (multiplyIdx * numOfBinsForEachColor) + idx;
        }




        public override void process_cld(Quantizer.BINS bins, List<int[]> sortedColours)
        {
            throw new NotImplementedException();
        }
    }
}
