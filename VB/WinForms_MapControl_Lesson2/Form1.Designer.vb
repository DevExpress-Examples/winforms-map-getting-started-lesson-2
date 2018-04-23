Namespace WinForms_MapControl_Lesson2
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim cartesianMapCoordinateSystem1 As New DevExpress.XtraMap.CartesianMapCoordinateSystem()
            Dim vectorItemsLayer1 As New DevExpress.XtraMap.VectorItemsLayer()
            Dim keyColorColorizer1 As New DevExpress.XtraMap.KeyColorColorizer()
            Dim attributeItemKeyProvider1 As New DevExpress.XtraMap.AttributeItemKeyProvider()
            Dim colorizerKeyItem1 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem2 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem3 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem4 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem5 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem6 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem7 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim colorizerKeyItem8 As New DevExpress.XtraMap.ColorizerKeyItem()
            Dim shapefileDataAdapter1 As New DevExpress.XtraMap.ShapefileDataAdapter()
            Dim cartesianSourceCoordinateSystem1 As New DevExpress.XtraMap.CartesianSourceCoordinateSystem()
            Dim colorListLegend1 As New DevExpress.XtraMap.ColorListLegend()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.CartesianPoint(-100R, -50R)
            Me.mapControl1.CoordinateSystem = cartesianMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            attributeItemKeyProvider1.AttributeName = "CATEGORY"
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
            colorizerKeyItem1.Key = 1
            colorizerKeyItem1.Name = "Restaurant"
            colorizerKeyItem2.Key = 2
            colorizerKeyItem2.Name = "Business room"
            colorizerKeyItem3.Key = 3
            colorizerKeyItem3.Name = "Bathroom"
            colorizerKeyItem4.Key = 4
            colorizerKeyItem4.Name = "Living room"
            colorizerKeyItem5.Key = 5
            colorizerKeyItem5.Name = "Other"
            colorizerKeyItem6.Key = 6
            colorizerKeyItem6.Name = "Service room"
            colorizerKeyItem7.Key = 7
            colorizerKeyItem7.Name = "Pool"
            colorizerKeyItem8.Key = 8
            colorizerKeyItem8.Name = "Gym"
            keyColorColorizer1.Keys.Add(colorizerKeyItem1)
            keyColorColorizer1.Keys.Add(colorizerKeyItem2)
            keyColorColorizer1.Keys.Add(colorizerKeyItem3)
            keyColorColorizer1.Keys.Add(colorizerKeyItem4)
            keyColorColorizer1.Keys.Add(colorizerKeyItem5)
            keyColorColorizer1.Keys.Add(colorizerKeyItem6)
            keyColorColorizer1.Keys.Add(colorizerKeyItem7)
            keyColorColorizer1.Keys.Add(colorizerKeyItem8)
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            vectorItemsLayer1.Colorizer = keyColorColorizer1
            shapefileDataAdapter1.FileUri = New System.Uri("C:\Users\Public\Documents\DevExpress Demos 14.2\Components\Data\Hotels\Hotel1.shp" & "", System.UriKind.Absolute)
            shapefileDataAdapter1.SourceCoordinateSystem = cartesianSourceCoordinateSystem1
            vectorItemsLayer1.Data = shapefileDataAdapter1
            Me.mapControl1.Layers.Add(vectorItemsLayer1)
            colorListLegend1.Header = "Room Type"
            colorListLegend1.Layer = vectorItemsLayer1
            Me.mapControl1.Legends.Add(colorListLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MaxZoomLevel = 3R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.ShowCoordinates = False
            Me.mapControl1.NavigationPanelOptions.ShowKilometersScale = False
            Me.mapControl1.NavigationPanelOptions.ShowMilesScale = False
            Me.mapControl1.Size = New System.Drawing.Size(665, 404)
            Me.mapControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(665, 404)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
    End Class
End Namespace

