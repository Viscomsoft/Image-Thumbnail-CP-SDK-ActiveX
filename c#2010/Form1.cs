using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IMAGETHUMBNAILCPLib;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {

        private Color oldBackColor;
        private Color oldBorderColor;
        private Color oldShadowColor;
        private Color oldClipColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbofilter.Items.Add("JPG | BMP | GIF | PNG");
            cbofilter.Items.Add("JPG | BMP | GIF | PNG | PSD| TIF");
            cbofilter.Items.Add("PDF | TIF");
            cbofilter.Items.Add("All Supported Image formats");
            cbofilter.SelectedIndex = 3;
            
            cborotate.Items.Add("No Rotate");
            cborotate.Items.Add("Rotate90FlipNone");
            cborotate.Items.Add("Rotate180FlipNone");
            cborotate.Items.Add("Rotate270FlipNone");
            cborotate.Items.Add("RotateNoneFlipX");
            cborotate.Items.Add("Rotate90FlipX");
            cborotate.Items.Add("Rotate180FlipX");
            cborotate.Items.Add("Rotate270FlipX");
            cborotate.Items.Add("RotateNoneFlipY");
            cborotate.Items.Add("Rotate90FlipY");
            cborotate.Items.Add("Rotate180FlipY");
            cborotate.Items.Add("Rotate270FlipY");
            cborotate.SelectedIndex = 0;

            GetOriginalStyle();

            this.scrollTypeComboBox.Items.AddRange(new string[] { "Vertical", "Horizontal" });
            this.scrollTypeComboBox.SelectedIndex = 0;


            this.displayModeComboBox.Items.AddRange(new string[]{"Fast Speed, poor Quality","Normal Speed, Normal Quality"
,"Slow Speed, High Quality","Very Slow Speed, Best Quality "});
            this.displayModeComboBox.SelectedIndex = 1;
        }

        private void GetOriginalStyle()
        {
            this.oldBackColor = this.axImageThumbnailCP1.BackgroundColor;
            this.oldBorderColor = this.axImageThumbnailCP1.ClipBorderColor;

            this.oldShadowColor = this.axImageThumbnailCP1.ClipShadowColor;
            this.oldClipColor = this.axImageThumbnailCP1.ClipColor;
        }

        private void scrollTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.ScrollBarType = (short)this.scrollTypeComboBox.SelectedIndex;
            this.axImageThumbnailCP1.Refresh();
        }

        private void scrollUpButton_Click(object sender, EventArgs e)
        {
            switch (this.axImageThumbnailCP1.ScrollBarType)
            {
                case 0:
                    this.axImageThumbnailCP1.VScroll(0);
                    break;
                case 1:
                    this.axImageThumbnailCP1.HScroll(0);
                    break;
            }
        }

        private void scrollDownButton_Click(object sender, EventArgs e)
        {
            switch (this.axImageThumbnailCP1.ScrollBarType)
            {
                case 0:
                    this.axImageThumbnailCP1.VScroll(1);
                    break;
                case 1:
                    this.axImageThumbnailCP1.HScroll(1);
                    break;
            }
        }

        private void displayModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.DisplayMode = (MYDISPLAYMODE)(this.displayModeComboBox.SelectedIndex);
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All Files (*.*)|*.*|PDF (*.pdf)|*.pdf|PhotoShop (*.psd)|*.psd|JPEG 2000 (*.j2k)|*.j2k;*.j2c|JPEG (*.jpg)|*.jpg|PCX (*.pcx)|*.pcx|WMF (*.wmf)|*.wmf|Wireless Bitmap (*.wbmp)|*.wbmp|Bitmap (*.bmp)|*.bmp|TIF (*.tif)|*.tif|TGA (*.tga)|*.tga|Gif (*.gif)|*.gif |PGX (*.pgx)|*.pgx|RAS (*.ras)|*.ras|PNM (*.pnm)|*.pnm|PNG (*.png)|*.png|Icon (*.ico)|*.ico";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.AddClip(ofd.FileName, string.Empty);
                    this.axImageThumbnailCP1.UnSelectAllClip();
                    this.axImageThumbnailCP1.SelectClip((short)(this.axImageThumbnailCP1.ClipCount - 1));
                    this.axImageThumbnailCP1.VScroll(7);
                }
            }
        }

        private void bgColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.BackgroundColor = cd.Color;
                    this.axImageThumbnailCP1.Focus();
                }
            }
        }

        private void clipColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.ClipColor = cd.Color;
                    this.axImageThumbnailCP1.Focus();
                }
            }
        }

        private void highColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.ClipHighlightColor = cd.Color;
                    this.axImageThumbnailCP1.Focus();
                }
            }
        }

        private void borderColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.ClipBorderColor = cd.Color;
                    this.axImageThumbnailCP1.Focus();
                }
            }
        }

        private void shaddowColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.ClipShadowColor = cd.Color;
                    this.axImageThumbnailCP1.Focus();
                }
            }
        }

        private void textColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    this.axImageThumbnailCP1.ClipTextColor = cd.Color;
                    this.axImageThumbnailCP1.Focus();
                }
            }
        }

        private void captionButton_Click(object sender, EventArgs e)
        {
            SetClipInfo();
        }

        private void SetClipInfo()
        {
            int icount = this.axImageThumbnailCP1.ClipCount;

            for (int i = 0; i <= icount; i++)
            {
                this.axImageThumbnailCP1.SetClipInfo((short)i, string.Empty, "Demo " + i.ToString());
            }

            this.axImageThumbnailCP1.Focus();
        }

        private void acdcButton_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.BackgroundColor = Color.FromArgb(128, 128, 128);
            this.axImageThumbnailCP1.ClipBorderColor = Color.FromArgb(128, 128, 128);
            this.axImageThumbnailCP1.ClipShadowColor = Color.FromArgb(128, 128, 128);
            this.axImageThumbnailCP1.ClipColor = Color.FromArgb(128, 128, 128);
            this.axImageThumbnailCP1.ClipFontSize = 10;
            this.axImageThumbnailCP1.ClipFontName = "12";
            this.axImageThumbnailCP1.ClipFontTopPos = 95;
            this.axImageThumbnailCP1.ClipTopMargin = 0;
            this.axImageThumbnailCP1.ClipBottomMargin = 15;
            this.axImageThumbnailCP1.ClipWidth = 110;
            this.axImageThumbnailCP1.ClipHeight = 120;

            this.SetClipInfo();
        }

        private void normalStyleButton_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.BackgroundColor = this.oldBackColor;
            this.axImageThumbnailCP1.ClipBorderColor = this.oldBorderColor;

            this.axImageThumbnailCP1.ClipShadowColor = this.oldShadowColor;
            this.axImageThumbnailCP1.ClipColor = this.oldClipColor;

        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
           
            this.axImageThumbnailCP1.DeleteAllClips();
            this.axImageThumbnailCP1.Focus();
        }

        private void deleteClipButton_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.DeleteSelectedClip();
            this.axImageThumbnailCP1.Focus();
        }

        private void displayFileNameButton_Click(object sender, EventArgs e)
        {

            for (short i = 0; i <= this.axImageThumbnailCP1.ClipCount; i++)
            {
                if (this.axImageThumbnailCP1.GetSelect(i))
                {
                    MessageBox.Show(this.axImageThumbnailCP1.GetClipFilePath(i));
                    return;
                }
            }
        }

        

        private void axImageThumbnailCP1_OnDropFiles(object sender, AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_OnDropFilesEvent e)
        {
            this.axImageThumbnailCP1.SelectClip((short)(this.axImageThumbnailCP1.ClipCount - 1));
            this.axImageThumbnailCP1.VScroll(7);
        }

        private void topMarginButton_Click(object sender, EventArgs e)
        {
            SetClipMargins();
        }

        private void SetClipMargins()
        {
            this.axImageThumbnailCP1.ClipTopMargin = (short)this.topMargin.Value;
            this.axImageThumbnailCP1.ClipBottomMargin = (short)this.bottomMargin.Value;
        }

        private void bottomMarginButton_Click(object sender, EventArgs e)
        {
            SetClipMargins();
        }

        private void fontSizeButton_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.ClipFontSize = (short)this.fontSize.Value;
        }

        private void fontTopButton_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.ClipFontTopPos = (short)this.fontTop.Value;
        }

        private void clipWidthButton_Click(object sender, EventArgs e)
        {
            this.SetClipSize();
        }

        private void SetClipSize()
        {
            this.axImageThumbnailCP1.ClipWidth = (short)this.clipWidth.Value;
            this.axImageThumbnailCP1.ClipHeight = (short)this.clipHeight.Value;
        }

        private void boldCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.ClipFontBold = this.boldCheckBox.Checked;
        }

        private void italicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.ClipFontItalic = this.italicCheckBox.Checked;
        }

        private void underlineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.ClipFontUnderline = this.underlineCheckBox.Checked;
        }

        private void addTypeButton_Click(object sender, EventArgs e)
        {
            if (this.fileExtTextBox.Text.Trim() != string.Empty)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select the image file";
                    ofd.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp|Gif (*.gif)|*.gif|Icon (*.ico)|*.ico";

                    if (ofd.ShowDialog(this) == DialogResult.OK)
                    {
                        this.axImageThumbnailCP1.AddCustomType(this.fileExtTextBox.Text.Trim(), ofd.FileName);
                    }
                }
            }
            else
            {
                MessageBox.Show("please input file extension");

            }
        }

        private void deleteTypeButton_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex > -1)
            {
                if (this.axImageThumbnailCP1.RemoveCustomType((string)this.listBox1.SelectedItem))
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItem);
                }
                else
                {
                    MessageBox.Show("cannot find this extension");
                }
            }
            else
            {
                MessageBox.Show("Please select the list box first");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strpath = this.axImageThumbnailCP1.BrowseFolder("select folder");

            if (strpath != "")
            {
                if (cbofilter.SelectedIndex==0)
                    this.axImageThumbnailCP1.AddClipsFromFolder(strpath, "jpg|bmp|gif|png");
                else if (cbofilter.SelectedIndex == 1)
                    this.axImageThumbnailCP1.AddClipsFromFolder(strpath, "jpg|bmp|gif|png|psd|tif");
                else if (cbofilter.SelectedIndex == 2)
                    this.axImageThumbnailCP1.AddClipsFromFolder(strpath, "pdf|tif");
                else if (cbofilter.SelectedIndex == 3)
                    this.axImageThumbnailCP1.AddClipsFromFolder(strpath, "psd|pdf|tif|pcx|png|gif|tga|wbmp|wmf|j2k|jp2|j2c|pgx|ras|pmn|ico|bmp|jpg|png");




            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (short i = 0; i <= this.axImageThumbnailCP1.ClipCount; i++)
            {
                if (this.axImageThumbnailCP1.GetSelect(i))
                {
                    this.axImageThumbnailCP1.Rotate(i, (short)this.cborotate.SelectedIndex);


                }
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.UnSelectAllClip();
            this.axImageThumbnailCP1.SelectClip(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.UnSelectAllClip();
            this.axImageThumbnailCP1.SelectClip(1);
            this.axImageThumbnailCP1.SelectClip(2);
            this.axImageThumbnailCP1.SelectClip(3);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.axImageThumbnailCP1.UnSelectClip(1);
            this.axImageThumbnailCP1.UnSelectClip(2);
            this.axImageThumbnailCP1.UnSelectClip(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            long iFirstClip = (long)axImageThumbnailCP1.CurrentVisibleFirstClipIndex();
            long iTotalVisibleClip = (long)axImageThumbnailCP1.CurrentVisibleClipCount();
            long iTotalClip = iFirstClip + iTotalVisibleClip - 1;        
            long i;

             for(i=iFirstClip; i<=iTotalClip;i++)
                 MessageBox.Show(axImageThumbnailCP1.GetClipFilePath((short)i));
        }

        private void clipHeightButton_Click(object sender, EventArgs e)
        {
            this.SetClipSize();
        }

        private void axImageThumbnailCP1_RightPress(object sender, AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_RightPressEvent e)
        {
            this.indexTextBox.Text = e.iClipIndex.ToString();
            this.fileNameTextBox.Text = e.strFilePath;
            this.PageNoTextBox.Text = e.iPageNo.ToString();

            if ((e.iClipIndex % 4) == 0)
            {
                this.axImageThumbnailCP1.VScroll(1);
            }
        }

        private void axImageThumbnailCP1_ClickEvent(object sender, AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_ClickEvent e)
        {
            this.indexTextBox.Text = e.iClipIndex.ToString();
            this.fileNameTextBox.Text = e.strFilePath;
            this.PageNoTextBox.Text = e.iPageNo.ToString();
        }

        private void axImageThumbnailCP1_LeftPress(object sender, AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_LeftPressEvent e)
        {
            this.indexTextBox.Text = e.iClipIndex.ToString();
            this.fileNameTextBox.Text = e.strFilePath;
            this.PageNoTextBox.Text = e.iPageNo.ToString();

            if ((e.iClipIndex % 4) == 0)
            {
                this.axImageThumbnailCP1.VScroll(0);
            }
        }

        private void axImageThumbnailCP1_OnDropFiles_1(object sender, AxIMAGETHUMBNAILCPLib._DImageThumbnailCPEvents_OnDropFilesEvent e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strPDFProperty;
            int iCurIndex;

        iCurIndex = axImageThumbnailCP1.GetCurSel();


        strPDFProperty = "PDF Resolution:" + axImageThumbnailCP1.GetClipPDFWidth((short)iCurIndex).ToString() + "x" + axImageThumbnailCP1.GetClipPDFHeight((short)iCurIndex).ToString() + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Title:" + axImageThumbnailCP1.GetClipPDFTitle((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Subject:" + axImageThumbnailCP1.GetClipPDFSubject((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Author:" + axImageThumbnailCP1.GetClipPDFAuthor((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Creation Date:" + axImageThumbnailCP1.GetClipPDFCreationDate((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Modify Date:" + axImageThumbnailCP1.GetClipPDFModifyDate((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Version No:" + axImageThumbnailCP1.GetClipPDFVersionNo((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "PDF Keyword:" + axImageThumbnailCP1.GetClipPDFKeyword((short)iCurIndex) + "\r\n";
        strPDFProperty = strPDFProperty + "Total Page:" + axImageThumbnailCP1.GetClipPDFTotalPage((short)iCurIndex) + "\r\n";

        MessageBox.Show(strPDFProperty);
        }

    }

}
    
