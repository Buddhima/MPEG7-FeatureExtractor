using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Filters;

namespace WindowsFormsApplication1.Utils
{
    class ImagePreprocessor
    {
        enum PreProcessMethods { SMOOTH, GRAYSCALE, POSTERIZE, COLOR_REDUCTION };
        private Grayscale gScale;
        private SobelEdgeDetector sobelDetector;
        private SimplePosterization posterization;

        public ImagePreprocessor() {
            gScale = new Grayscale(0.2125, 0.7154, 0.0721);
            sobelDetector = new SobelEdgeDetector();
            posterization = new SimplePosterization();
        }

        public Bitmap preProcessImage(Bitmap image) {
            return preProcessImage(image, gScale, sobelDetector, posterization);
        }

        private Bitmap preProcessImage(Bitmap image, Grayscale gScale, SobelEdgeDetector sEgDetector, SimplePosterization posterization)
        {
            Bitmap temp = image;
            temp = gScale.Apply(temp);            
            posterization.ApplyInPlace(temp);
            

            return temp;
        }

        private Bitmap smoothing(Bitmap image)
        {
            // create filter
            BilateralSmoothing filter = new BilateralSmoothing();
            filter.KernelSize = 7;
            filter.SpatialFactor = 10;
            filter.ColorFactor = 60;
            filter.ColorPower = 0.5;
            // apply the filter
            filter.ApplyInPlace(image);
            return image;
        }

        private Bitmap thresholdImage(Bitmap image, int thresholdVal)
        {
            Threshold thrshold = new Threshold();
            thrshold.ThresholdValue = thresholdVal;
            thrshold.ApplyInPlace(image);

            return image;
        }

        private Bitmap reducedColor(Bitmap image, int numColors)
        {
            // create color image quantization routine
            ColorImageQuantizer ciq = new ColorImageQuantizer(new MedianCutQuantizer());
            // create 16 colors table
            Color[] colorTable = ciq.CalculatePalette(image, numColors);
            // create dithering routine
            FloydSteinbergColorDithering dithering = new FloydSteinbergColorDithering();
            dithering.ColorTable = colorTable;
            // apply the dithering routine
            Bitmap newImage = dithering.Apply(image);

            return newImage;
        }
    }
}
