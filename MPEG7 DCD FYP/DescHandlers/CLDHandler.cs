using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class CLDHandler : DescriptorHandler
    {
        private Image cldImage;
        private int numOfCells = 64;
        private List<int[]> RGB;


        public override void calcDescriptorInfo(Bitmap inImage)
        {
           
            CLD_Descriptor cldDesc = new CLD_Descriptor();
            cldDesc.Apply(inImage);
            cldImage = cldDesc.getColorLayoutImage();

            RGB = new List<int[]>();
            
            extractRGBFromImage(cldImage, RGB);
            
        }

        
        //we go through the returnd CLD Image, and extract rgb values 
        //of the each pixel in the middle of each cell
        private void extractRGBFromImage(Image cldImg,List<int[]> RGB) {
            int _cWidth = cldImg.Width/8;
            int _cHeight = cldImg.Height/8;
            Bitmap bmp = new Bitmap(cldImg);
            for (int i = 0; i < cldImg.Width; i=i+_cWidth) {
                for (int j = 0; j < cldImg.Height; j=j+ _cHeight) {
                    int p_x = i + (_cWidth / 2);
                    int p_y = j + (_cHeight / 2);

                    int[] temp = new int[3];
                    Color tempClr = bmp.GetPixel(p_x,p_y);
                    temp[0] = tempClr.R;
                    temp[1] = tempClr.G;
                    temp[2] = tempClr.B;

                    RGB.Add(temp);
                }
            }
        }

        
        //Conversion YcRcB to RGB (Not used) 
        private void YcRcBToRGB1(int[] Y,int[] cB,int[] cR,List<int[]> RGB) {

            for (int i = 0; i < numOfCells; i++)
            {
                int[] temp = new int[3];
                temp[0] = (int)(1.0 * Y[i] + 0 * cB[i] + 1.403 * cR[i]);
                temp[1] = (int)(1.0 * Y[i] - 0.344136 * cB[i] - 0.714136 * cR[i]);
                temp[2] = (int)(1.0 * Y[i] + 1.772 * cB[i] + 0 * cR[i]);

                RGB.Add(temp);
            }
            
        }

        
        public Image CLDImage {
            get { return cldImage; }
        }

        public List<int[]> RGBValues {
            get { return RGB; }
        }

        //we get only 16 values therefore returned 64 cells needs to be
        //reduced to 16 values
        public List<int[]> getReduce64To16Cells(List<int[]> rgbs) {

            List<int[]> reducedArr = new List<int[]>();
            int[] startRowVals = new int[] {0,16,32,48 };

            for (int i = 0; i < startRowVals.Length; i++) {
                //0,2,4,8
                for (int j = startRowVals[i]; j < startRowVals[i] + 8; j = j + 2)
                {
                    //we took 4 from 0,2,4,8
                    int[] rightRGB = rgbs[j + 1];
                    int[] bottomRGB = rgbs[j + 8];
                    int[] bottomRightRGB = rgbs[(j + 1) + 8];

                    int[] avgRGB = new int[3];
                    for (int k = 0; k < 3; k++) {
                        avgRGB[k] = (rgbs[j][k] + rightRGB[k] + bottomRGB[k] + bottomRightRGB[k]) / 4;
                    }

                    reducedArr.Add(avgRGB);
                }
            }
            return reducedArr;
        }
        
    }
}
