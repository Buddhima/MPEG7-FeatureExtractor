using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AForge.Imaging;
using AForge.Math.Geometry;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging.ColorReduction;
using WindowsFormsApplication1.Utils;

namespace WindowsFormsApplication1
{
    class BlobHandler : DescriptorHandler
    {
        private Grayscale gScale;
        private SobelEdgeDetector sDetector;
        private Bitmap image;
        private Bitmap originalImage;

        private Graphics g;

        //circles,triangles,polygon-square,polygon-rectangle,polygon-unknown,trapizoid
        private int[] shapeCount;
        private ImagePreprocessor imgProcessor;

        public BlobHandler() {
            imgProcessor = new ImagePreprocessor();
        }
        public override void calcDescriptorInfo(Bitmap inImage)
        {
            shapeCount = new int[6];
            
            originalImage = image;
            image = imgProcessor.preProcessImage(inImage);

            g = Graphics.FromImage(originalImage);

            BlobCounter bCounter = new BlobCounter();
            bCounter.ProcessImage(image);
            Blob[] blobs = bCounter.GetObjectsInformation();

            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

            for (int i = 0; i < blobs.Length; i++)
            {
                if (blobs[i].Area < 100)
                {
                    continue;
                }
                List<IntPoint> edgePts = bCounter.GetBlobsEdgePoints(blobs[i]);
                checkShape(shapeChecker, edgePts);

            }

            g.Dispose();    
        }
        

        private void checkShape(SimpleShapeChecker shapeChecker, List<IntPoint> edgePts)
        { 
            AForge.Point center;
            float radius;
            List<IntPoint> corners;
            if(edgePts.Count>4 && shapeChecker.IsCircle(edgePts,out center,out radius)){
                //shape is a circle
                drawEllipse(center, radius);
                shapeCount[0]++;
            }
            else if(edgePts.Count>3 && shapeChecker.IsConvexPolygon(edgePts,out corners)){
                PolygonSubType subType = shapeChecker.CheckPolygonSubType(corners);

                if (subType == PolygonSubType.Unknown)
                {
                    shapeCount[4]++;
                }
                else if (subType == PolygonSubType.Square)
                {
                    shapeCount[2]++;
                }
                else if (subType == PolygonSubType.Rectangle)
                {
                    shapeCount[3]++;
                }
                else if (subType == PolygonSubType.Trapezoid)
                {
                    shapeCount[5]++;
                }
                else if (subType == PolygonSubType.EquilateralTriangle)
                {
                    shapeCount[1]++;
                }
                else if (subType == PolygonSubType.IsoscelesTriangle) {
                    shapeCount[1]++;
                }

                drawPolygon(corners);
                
            }
            else if(shapeChecker.IsTriangle(edgePts)){
                //triangle
                shapeCount[1]++;
                
            }
        }

        private void drawEllipse(AForge.Point center, float radius) {
            
            Pen redPen = new Pen(Color.Red, 2);
            g.DrawEllipse(redPen,
                (float)(center.X - radius), (float)(center.Y - radius),
                (float)(radius * 2), (float)(radius * 2));
            
            redPen.Dispose();
        }

        private void drawPolygon(List<IntPoint> corners) {
            Pen yellowPen = new Pen(Color.Yellow, 2);
            g.DrawPolygon(yellowPen, ToPointsArray(corners));
            
        }

         private System.Drawing.Point[] ToPointsArray(List<IntPoint> points)
	        {
	            System.Drawing.Point[] array = new System.Drawing.Point[points.Count];
	 
	            for (int i = 0, n = points.Count; i < n; i++)
	            {
	                array[i] = new System.Drawing.Point(points[i].X, points[i].Y);
	            }
	 
	            return array;
	        }

        

        public Bitmap Image {
            get{return image;}
        }
        public int[] ShapeCount {
            get { return shapeCount; }
        }
        public Bitmap OriginalImage {
            get{return originalImage;}
        }
    }
}
