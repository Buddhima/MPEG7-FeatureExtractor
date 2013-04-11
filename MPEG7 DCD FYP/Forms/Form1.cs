using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.DescHandlers;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DescHandlerFactory descFactory;
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
            String fileName = inputFileTxt.Text;

            DCDHandler dcdHandler = (DCDHandler) descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.DCD);
            dcdHandler.calcDescriptorInfo(fileName);

            DCDResult dcdForm = new DCDResult();
            dcdForm.setDCDInfo(fileName,dcdHandler.DominantRGB);
            dcdForm.Show();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                String str = fileDialog.FileName;
                inputFileTxt.Text = fileDialog.FileName;    
            }
        }

        private void cldBtn_Click(object sender, EventArgs e)
        {
            String fileName = inputFileTxt.Text;
            CLDHandler cldHandler = (CLDHandler)descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.CLD);
            cldHandler.calcDescriptorInfo(fileName);

            CLDResult cldForm = new CLDResult();
            cldForm.setCLDInfo(cldHandler.CLDImage,cldHandler.RGBValues);
            cldForm.Show();
        }

        private void cspdBtn_Click(object sender, EventArgs e)
        {
            String fileName = inputFileTxt.Text;
            Image image = Image.FromFile(fileName);
            CSPDHandler cspdHandler = (CSPDHandler)descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.CSPD);
            cspdHandler.calcDescriptorInfo(fileName);
            
            CSPDResult cspdForm = new CSPDResult();
            cspdForm.setCSPDInfo(image,cspdHandler.WHRatio, cspdHandler.VProjection, cspdHandler.HProjection, cspdHandler.TopShape, cspdHandler.BottomShape);
            cspdForm.Show();
        }

        private void shapeBtn_Click(object sender, EventArgs e)
        {
            String fileName = inputFileTxt.Text;
            BlobHandler bHandler = (BlobHandler)descFactory.getDescriptorHandler(DescHandlerFactory.Descriptor.SHAPE);
            bHandler.calcDescriptorInfo(fileName);
            ShapeResult shapeForm = new ShapeResult();
            shapeForm.setShapeInfo(bHandler.OriginalImage,bHandler.Image,bHandler.AreaBasket);
            shapeForm.Show();

        }
    }
}
