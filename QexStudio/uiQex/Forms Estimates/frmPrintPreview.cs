using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using System.Drawing.Drawing2D;
using Qex;

namespace uiGR2020
{
    public partial class frmPrintPreview : Form
    {
        public DataListView _dataListView;
        public TreeListView _treeListView;

        public frmPrintPreview(DataListView dataListView)
        {
            InitializeComponent();
            _dataListView = dataListView;
            this.listViewPrinter1.ListView = _dataListView;
            Presupuesto pres = Presupuesto.getById(frmMain._pres_id);
            this.txtHeader.Text = "Presupuesto: " +  pres.nombre;
            this.txtFooter.Text = "Fecha: " + DateTime.Now.ToShortDateString();
        }

        public frmPrintPreview(TreeListView treeListView)
        {
            InitializeComponent();
            _treeListView = treeListView;
            this.listViewPrinter1.ListView = _treeListView;
            Presupuesto pres = Presupuesto.getById(frmMain._pres_id);
            this.txtHeader.Text = "Presupuesto: " + pres.nombre;
            this.txtFooter.Text = "Fecha: " + DateTime.Now.ToShortDateString();
        }

        private void frmPrintPreview_Load(object sender, EventArgs e)
        {
            this.UpdatePrintPreview(null, null);
        }

        private void UpdatePrintPreview(object sender, EventArgs e)
        {
            this.listViewPrinter1.Header = this.txtHeader.Text; //Replace("\\t", "\t");
            this.listViewPrinter1.Footer = this.txtFooter.Text;
            this.listViewPrinter1.IsShrinkToFit = this.checkShrink.Checked;
            this.listViewPrinter1.IsListHeaderOnEachPage = this.checkListHeaderEveryPage.Checked;
            float fontSize = 10;
            try
            {
                fontSize = Convert.ToSingle(this.txtFontSize.Text);
            }
            catch (Exception)
            {
            }
            if (this.radSimple.Checked)
            {
                this.ApplyMinimalFormatting(fontSize);
            }
            if (this.radModerno.Checked)
            {
                this.ApplyModernFormatting(fontSize);
            }

            this.printPreviewControl1.InvalidatePreview();
        }

        /// <summary>
        /// Give the report a minimal set of default formatting values.
        /// </summary>
        public void ApplyMinimalFormatting(float fontSize)
        {
            this.listViewPrinter1.CellFormat = null;
            this.listViewPrinter1.ListFont = new Font("Tahoma", fontSize);

            this.listViewPrinter1.HeaderFormat = BlockFormat.Header(new Font("Verdana", 16, FontStyle.Bold));
            this.listViewPrinter1.HeaderFormat.TextBrush = Brushes.Black;
            this.listViewPrinter1.HeaderFormat.BackgroundBrush = null;
            this.listViewPrinter1.HeaderFormat.SetBorderPen(Sides.Bottom, new Pen(Color.Black, 0.5f));

            this.listViewPrinter1.FooterFormat = BlockFormat.Footer();
            this.listViewPrinter1.GroupHeaderFormat = BlockFormat.GroupHeader();
            this.listViewPrinter1.GroupHeaderFormat.SetBorder(Sides.Bottom, 2, new LinearGradientBrush(new Rectangle(0, 0, 1, 1), Color.Gray, Color.White, LinearGradientMode.Horizontal));

            this.listViewPrinter1.ListHeaderFormat = BlockFormat.ListHeader();
            this.listViewPrinter1.ListHeaderFormat.BackgroundBrush = null;

            this.listViewPrinter1.WatermarkFont = null;
            this.listViewPrinter1.WatermarkColor = Color.Empty;
        }

        /// <summary>
        /// Give the report a minimal set of default formatting values.
        /// </summary>
        public void ApplyModernFormatting(float fontSize)
        {
            this.listViewPrinter1.CellFormat = null;
            this.listViewPrinter1.ListFont = new Font("Ms Sans Serif", fontSize);
            this.listViewPrinter1.ListGridPen = new Pen(Color.DarkGray, 0.5f);

            this.listViewPrinter1.HeaderFormat = BlockFormat.Header(new Font("Verdana", 16, FontStyle.Bold));
            this.listViewPrinter1.HeaderFormat.BackgroundBrush = new LinearGradientBrush(new Rectangle(0, 0, 1, 1), Color.DarkGray, Color.DarkGray, LinearGradientMode.Horizontal);

            this.listViewPrinter1.FooterFormat = BlockFormat.Footer();
            this.listViewPrinter1.FooterFormat.BackgroundBrush = new LinearGradientBrush(new Rectangle(0, 0, 1, 1), Color.DarkGray, Color.DarkGray, LinearGradientMode.Horizontal);

            this.listViewPrinter1.GroupHeaderFormat = BlockFormat.GroupHeader();
            this.listViewPrinter1.ListHeaderFormat = BlockFormat.ListHeader(new Font("Verdana", 12));

            this.listViewPrinter1.WatermarkFont = null;
            this.listViewPrinter1.WatermarkColor = Color.Empty;
        }

        /// <summary>
        /// Give the report a some outrageous formatting values.
        /// </summary>
        public void ApplyOverTheTopFormatting(float fontSize)
        {
            this.listViewPrinter1.CellFormat = null;
            this.listViewPrinter1.ListFont = new Font("Ms Sans Serif", fontSize);
            this.listViewPrinter1.ListGridPen = new Pen(Color.Blue, 0.5f);

            this.listViewPrinter1.HeaderFormat = BlockFormat.Header(new Font("Comic Sans MS", 36));
            this.listViewPrinter1.HeaderFormat.TextBrush = new LinearGradientBrush(new Rectangle(0, 0, 1, 1), Color.Black, Color.Blue, LinearGradientMode.Horizontal);

            ////this.listViewPrinter1.HeaderFormat.BackgroundBrush = new TextureBrush(this.dataListView1.SmallImageList.Images["music"], WrapMode.Tile);
            this.listViewPrinter1.HeaderFormat.SetBorder(Sides.All, 10, new LinearGradientBrush(new Rectangle(0, 0, 1, 1), Color.Purple, Color.Pink, LinearGradientMode.Horizontal));

            this.listViewPrinter1.FooterFormat = BlockFormat.Footer(new Font("Comic Sans MS", 12));
            this.listViewPrinter1.FooterFormat.TextBrush = Brushes.Blue;
            this.listViewPrinter1.FooterFormat.BackgroundBrush = new LinearGradientBrush(new Rectangle(0, 0, 1, 1), Color.Gold, Color.Green, LinearGradientMode.Horizontal);
            this.listViewPrinter1.FooterFormat.SetBorder(Sides.All, 5, new SolidBrush(Color.FromArgb(128, Color.Green)));

            this.listViewPrinter1.GroupHeaderFormat = BlockFormat.GroupHeader();
            this.listViewPrinter1.GroupHeaderFormat.SetBorder(Sides.Bottom, 5, new HatchBrush(HatchStyle.LargeConfetti, Color.Blue, Color.Empty));

            this.listViewPrinter1.ListHeaderFormat = BlockFormat.ListHeader(new Font("Comic Sans MS", 12));
            this.listViewPrinter1.ListHeaderFormat.BackgroundBrush = Brushes.PowderBlue;
            this.listViewPrinter1.ListHeaderFormat.TextBrush = Brushes.Black;

            this.listViewPrinter1.WatermarkFont = new Font("Comic Sans MS", 72);
            this.listViewPrinter1.WatermarkColor = Color.Red;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.listViewPrinter1.PrintWithDialog();
            this.Close();
        }

        private void radio150_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Zoom = 1.5;
            this.UpdatePrintPreview(null, null);
        }

        private void radio100_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Zoom = 1;
            this.UpdatePrintPreview(null, null);
        }

        private void radio75_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Zoom = 0.75;
            this.UpdatePrintPreview(null, null);
        }

        private void radio50_CheckedChanged(object sender, EventArgs e)
        {
            this.printPreviewControl1.Zoom = 0.5;
            this.UpdatePrintPreview(null, null);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.listViewPrinter1.PrintWithDialog();
            this.Close();
        }
    }
}
