namespace DXApplication2.Module
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pictureBox2});
            this.Detail.HeightF = 481.25F;
            this.Detail.Name = "Detail";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("pictureBox2.ImageSource"));
            this.pictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(76.66669F, 71.11113F);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.SizeF = new System.Drawing.SizeF(250.6944F, 258.3333F);
            this.pictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // collectionDataSource1
            // 
            this.collectionDataSource1.Name = "collectionDataSource1";
            this.collectionDataSource1.ObjectTypeName = "L1.Domain.Models.CustomerInvoice";
            this.collectionDataSource1.TopReturnedRecords = 0;
            // 
            // XtraReport1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.collectionDataSource1});
            this.DataSource = this.collectionDataSource1;
            this.DisplayName = "test";
            this.Extensions.Add("DataSerializationExtension", "XtraReport");
            this.Extensions.Add("DataEditorExtension", "XtraReport");
            this.Extensions.Add("ParameterEditorExtension", "XtraReport");
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.PageColor = System.Drawing.Color.Transparent;
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPictureBox pictureBox2;
        private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
    }
}
