namespace WinForms_MapControl_Lesson2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.CartesianMapCoordinateSystem cartesianMapCoordinateSystem1 = new DevExpress.XtraMap.CartesianMapCoordinateSystem();
            DevExpress.XtraMap.VectorItemsLayer vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.AttributeItemKeyProvider attributeItemKeyProvider1 = new DevExpress.XtraMap.AttributeItemKeyProvider();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem1 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem2 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem3 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem4 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem5 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem6 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem7 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ColorizerKeyItem colorizerKeyItem8 = new DevExpress.XtraMap.ColorizerKeyItem();
            DevExpress.XtraMap.ShapefileDataAdapter shapefileDataAdapter1 = new DevExpress.XtraMap.ShapefileDataAdapter();
            DevExpress.XtraMap.CartesianSourceCoordinateSystem cartesianSourceCoordinateSystem1 = new DevExpress.XtraMap.CartesianSourceCoordinateSystem();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.CartesianPoint(-100D, -50D);
            this.mapControl1.CoordinateSystem = cartesianMapCoordinateSystem1;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            attributeItemKeyProvider1.AttributeName = "CATEGORY";
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1;
            colorizerKeyItem1.Key = 1;
            colorizerKeyItem1.Name = "Restaurant";
            colorizerKeyItem2.Key = 2;
            colorizerKeyItem2.Name = "Business room";
            colorizerKeyItem3.Key = 3;
            colorizerKeyItem3.Name = "Bathroom";
            colorizerKeyItem4.Key = 4;
            colorizerKeyItem4.Name = "Living room";
            colorizerKeyItem5.Key = 5;
            colorizerKeyItem5.Name = "Other";
            colorizerKeyItem6.Key = 6;
            colorizerKeyItem6.Name = "Service room";
            colorizerKeyItem7.Key = 7;
            colorizerKeyItem7.Name = "Pool";
            colorizerKeyItem8.Key = 8;
            colorizerKeyItem8.Name = "Gym";
            keyColorColorizer1.Keys.Add(colorizerKeyItem1);
            keyColorColorizer1.Keys.Add(colorizerKeyItem2);
            keyColorColorizer1.Keys.Add(colorizerKeyItem3);
            keyColorColorizer1.Keys.Add(colorizerKeyItem4);
            keyColorColorizer1.Keys.Add(colorizerKeyItem5);
            keyColorColorizer1.Keys.Add(colorizerKeyItem6);
            keyColorColorizer1.Keys.Add(colorizerKeyItem7);
            keyColorColorizer1.Keys.Add(colorizerKeyItem8);
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette;
            vectorItemsLayer1.Colorizer = keyColorColorizer1;
            shapefileDataAdapter1.FileUri = new System.Uri("C:\\Users\\Public\\Documents\\DevExpress Demos 14.2\\Components\\Data\\Hotels\\Hotel1.shp" +
        "", System.UriKind.Absolute);
            shapefileDataAdapter1.SourceCoordinateSystem = cartesianSourceCoordinateSystem1;
            vectorItemsLayer1.Data = shapefileDataAdapter1;
            this.mapControl1.Layers.Add(vectorItemsLayer1);
            colorListLegend1.Header = "Room Type";
            colorListLegend1.Layer = vectorItemsLayer1;
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.MaxZoomLevel = 3D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl1.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl1.NavigationPanelOptions.ShowMilesScale = false;
            this.mapControl1.Size = new System.Drawing.Size(665, 404);
            this.mapControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 404);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
    }
}

