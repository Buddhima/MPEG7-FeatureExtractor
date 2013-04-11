using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.DescHandlers;
using System.IO;
using WindowsFormsApplication1.FileAccessors;
using WindowsFormsApplication1.ColourQuantizers;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DescHandlerFactory descFactory;
        private Dictionary<string, Bitmap> images;
        FileSystemReader fsr;


        public Form1()
        {
            InitializeComponent();
            descFactory = new DescHandlerFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dcdBtn_Click(object sender, EventArgs e)
        {
            String folderPath = inputFileTxt.Text;
            // Read images
            images = fsr.readFiles(folderPath);
            DCDHandler dcdHandler = (DCDHandler) descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.DCD);
            
            if (outDirTxt.Text == null || outDirTxt.Text.Length == 0)
            {
                DialogResult outDirNotSetWarning = MessageBox.Show("Output Directory is not set. Results will be written to input directory. Continue?",
                        "Warning", MessageBoxButtons.YesNo);
                if (outDirNotSetWarning == DialogResult.Yes)
                {
                    FileSystemWriter fsw = new FileSystemWriter(inputFileTxt.Text + "\\ExistanceResult.txt");
                    FileSystemWriter fsw2 = new FileSystemWriter(inputFileTxt.Text + "\\PropotionResult.txt");
                    writeDCDInfo(dcdHandler, fsw, fsw2);
                }
                else {
                    return;
                }
            }
            else
            {
                FileSystemWriter fsw = new FileSystemWriter(outDirTxt.Text + "\\ExistanceResult.txt");
                FileSystemWriter fsw2 = new FileSystemWriter(outDirTxt.Text + "\\PropotionResult.txt");
                writeDCDInfo(dcdHandler, fsw, fsw2);
            }
            
        }

        private void writeDCDInfo(DCDHandler dcdHandler, FileSystemWriter fsw, FileSystemWriter fsw2)
        {
            foreach (KeyValuePair<string, Bitmap> image in images)
            {
                dcdHandler.calcDescriptorInfo(image.Value);
                // write to file
                string[] pathParts = image.Key.Split('\\');
                string imageNameAndExt = pathParts[pathParts.Length - 1];
                string imageName="";
                string[] imageNameParts = imageNameAndExt.Split('.');

                // To handle file names with '.'
                for (int i = 0; i < imageNameParts.Length - 1;i++ )
                {
                    imageName += imageNameParts[i];
                    if (i < imageNameParts.Length - 2) {
                        imageName += ".";
                    }

                }

                List<int[]> rgbpList = dcdHandler.DominantRGB;
                Quantizer q = null;

                if (hsl_15_rb.Checked)
                {
                    q = getQuantizer("HSV_QUANTIZER");
                    q.process_dcd(Quantizer.BINS.BINS_15, rgbpList);
                }else if(hsl_27_rb.Checked){
                    q = getQuantizer("HSV_QUANTIZER");
                    q.process_dcd(Quantizer.BINS.BINS_27, rgbpList);
                }
                else if (hsl_48_rb.Checked) {
                    q = getQuantizer("HSV_QUANTIZER");
                    q.process_dcd(Quantizer.BINS.BINS_48, rgbpList);
                }
                else if (rgb_27_rb.Checked)
                {
                    q = getQuantizer("COLOUR_27_QUANTIZER");
                    q.process_dcd(Quantizer.BINS.BINS_27, rgbpList);
                }
                else if (rgb_64_rb.Checked) {
                    q = getQuantizer("COLOUR_27_QUANTIZER");
                    q.process_dcd(Quantizer.BINS.BINS_64, rgbpList);
                }
                else if (lab_x_rb.Checked)
                {
                    q = getQuantizer("RGB_HISTOGRAM_QUANTIZER");
                }
                
                fsw.writeFile(imageName, q.getList(Quantizer.FEATURE_VECTOR.EXISTENCE));

                // write propotion
                fsw2.writeFile(imageName, q.getList(Quantizer.FEATURE_VECTOR.PROPORTION));

            }
            // close the connection
            fsw.closeFile();
            fsw2.closeFile();
            MessageBox.Show("DCD DONE!");

        }

        private Quantizer getQuantizer(string quantizerName) // make this to return quantizer*****quantizer constructor has rgbList
        {
            
            if (quantizerName == "COLOUR_27_QUANTIZER")
            {
                return new RGBQuantizer();
                
            }
            else if (quantizerName == "HSV_QUANTIZER")
            {
                return new HSVQuantizer();
            }
            else if (quantizerName == "RGB_HISTOGRAM_QUANTIZER") {
                return new RGBHistogramQuantizer();
            }
            return null;
        }

        private void inDirSelectBtn_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fileDialog = new OpenFileDialog();
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                
                inputFileTxt.Text = folderDialog.SelectedPath;
                fsr = new FileSystemReader();
                
            } 
        }

        private void outDirSelectBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {

                outDirTxt.Text = folderDialog.SelectedPath;
                

            }
        }

        private void cldBtn_Click(object sender, EventArgs e)
        {
            String folderPath = inputFileTxt.Text;
            // Read image files
            images = fsr.readFiles(folderPath);
            CLDHandler cldHandler = (CLDHandler)descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.CLD);
         
            

            if (outDirTxt.Text == null || outDirTxt.Text.Length == 0)
            {
                DialogResult outDirNotSetWarning = MessageBox.Show("Output Directory is not set. Results will be written to input directory. Continue?",
                    "Warning", MessageBoxButtons.YesNo);
                if (outDirNotSetWarning == DialogResult.Yes)
                {
                    FileSystemWriter fsw = new FileSystemWriter(inputFileTxt.Text + "\\PositionResult.txt");
                    writeDCDInfo(cldHandler, fsw);
                }
                else {
                    return;
                }

            }
            else
            {
                FileSystemWriter fsw = new FileSystemWriter(outDirTxt.Text + "\\PositionResult.txt");
                writeDCDInfo(cldHandler, fsw);
            }
            
        }

        private void writeDCDInfo(CLDHandler cldHandler, FileSystemWriter fsw)
        {
            foreach (KeyValuePair<string, Bitmap> image in images)
            {
                cldHandler.calcDescriptorInfo(image.Value);
                // write to file
                string[] pathParts = image.Key.Split('\\');
                string imageNameAndExt = pathParts[pathParts.Length - 1];
                string imageName = imageNameAndExt.Split('.').ElementAt(0);
                List<int[]> rgbList = cldHandler.RGBValues;
                
                Quantizer q=null;

                if (Reduce16PositionsCheck.Checked)
                {
                    rgbList = cldHandler.getReduce64To16Cells(rgbList);
                }

                if (hsl_15_rb.Checked)
                {
                    q = getQuantizer("HSV_QUANTIZER");
                    q.process_cld(Quantizer.BINS.BINS_15, rgbList);
                }
                else if (hsl_27_rb.Checked)
                {
                    q = getQuantizer("HSV_QUANTIZER");
                    q.process_cld(Quantizer.BINS.BINS_27, rgbList);
                }
                else if (hsl_48_rb.Checked)
                {
                    q = getQuantizer("HSV_QUANTIZER");
                    q.process_cld(Quantizer.BINS.BINS_48, rgbList);
                }
                else if (rgb_27_rb.Checked)
                {
                    q = getQuantizer("COLOUR_27_QUANTIZER");
                    q.process_cld(Quantizer.BINS.BINS_27, rgbList);
                }
                else if (rgb_64_rb.Checked)
                {
                    q = getQuantizer("COLOUR_27_QUANTIZER");
                    q.process_cld(Quantizer.BINS.BINS_64, rgbList);
                }
                else if (lab_x_rb.Checked)
                {
                    q = getQuantizer("RGB_HISTOGRAM_QUANTIZER");
                }

                
                fsw.writeFile(imageName, q.getList(Quantizer.FEATURE_VECTOR.POSITION));

            }
            // close the connection
            fsw.closeFile();

            MessageBox.Show("CLD DONE!");

        }

        
        private void cspdBtn_Click(object sender, EventArgs e)
        {
            String fileName = inputFileTxt.Text;
            Image image = Image.FromFile(fileName);
            CSPDHandler cspdHandler = (CSPDHandler)descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.CSPD);
            cspdHandler.calcDescriptorInfo(new Bitmap(fileName));
            
            CSPDResult cspdForm = new CSPDResult();
            cspdForm.setCSPDInfo(image,cspdHandler.WHRatio, cspdHandler.VProjection, cspdHandler.HProjection, cspdHandler.TopShape, cspdHandler.BottomShape);
            cspdForm.Show();
        }

        private void shapeBtn_Click(object sender, EventArgs e)
        {
            String fileName = inputFileTxt.Text;
            BlobHandler bHandler = (BlobHandler)descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.SHAPE);
            bHandler.calcDescriptorInfo(new Bitmap(fileName));
            ShapeResult shapeForm = new ShapeResult();
            shapeForm.setShapeInfo(bHandler.OriginalImage,bHandler.Image,bHandler.ShapeCount);
            shapeForm.Show();

        }

        
    }
}
