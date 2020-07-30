Partial Class Report2

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.labelsGroupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.labelsGroupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.pageHeader = New Telerik.Reporting.PageHeaderSection()
        Me.reportNameTextBox = New Telerik.Reporting.TextBox()
        Me.pageFooter = New Telerik.Reporting.PageFooterSection()
        Me.currentTimeTextBox = New Telerik.Reporting.TextBox()
        Me.pageInfoTextBox = New Telerik.Reporting.TextBox()
        Me.reportHeader = New Telerik.Reporting.ReportHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.apellidoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.apellidoDataTextBox = New Telerik.Reporting.TextBox()
        Me.correoElectronicoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.correoElectronicoDataTextBox = New Telerik.Reporting.TextBox()
        Me.estadoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.estadoDataTextBox = New Telerik.Reporting.TextBox()
        Me.identidadCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.identidadDataTextBox = New Telerik.Reporting.TextBox()
        Me.idHorariosCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idHorariosDataTextBox = New Telerik.Reporting.TextBox()
        Me.idTipoElmpleadoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.idTipoElmpleadoDataTextBox = New Telerik.Reporting.TextBox()
        Me.nombreCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.nombreDataTextBox = New Telerik.Reporting.TextBox()
        Me.rTNCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.rTNDataTextBox = New Telerik.Reporting.TextBox()
        Me.telefonoCaptionTextBox = New Telerik.Reporting.TextBox()
        Me.telefonoDataTextBox = New Telerik.Reporting.TextBox()
        Me.reportFooter = New Telerik.Reporting.ReportFooterSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Tareas.My.MySettings.ProyectoHotel"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.SelectCommand = "dbo.ReporteEmpleados"
        Me.SqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure
        '
        'labelsGroupHeaderSection
        '
        Me.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.labelsGroupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.apellidoDataTextBox, Me.correoElectronicoDataTextBox, Me.estadoDataTextBox, Me.identidadDataTextBox, Me.idHorariosDataTextBox, Me.idTipoElmpleadoDataTextBox, Me.nombreDataTextBox, Me.rTNDataTextBox, Me.telefonoDataTextBox})
        Me.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection"
        Me.labelsGroupHeaderSection.PrintOnEveryPage = True
        '
        'labelsGroupFooterSection
        '
        Me.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.labelsGroupFooterSection.Name = "labelsGroupFooterSection"
        Me.labelsGroupFooterSection.Style.Visible = False
        '
        'pageHeader
        '
        Me.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.pageHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.reportNameTextBox})
        Me.pageHeader.Name = "pageHeader"
        '
        'reportNameTextBox
        '
        Me.reportNameTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021R), Telerik.Reporting.Drawing.Unit.Inch(0.021R))
        Me.reportNameTextBox.Name = "reportNameTextBox"
        Me.reportNameTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.417R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.reportNameTextBox.StyleName = "PageInfo"
        Me.reportNameTextBox.Value = "Report2"
        '
        'pageFooter
        '
        Me.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.pageFooter.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.currentTimeTextBox, Me.pageInfoTextBox})
        Me.pageFooter.Name = "pageFooter"
        '
        'currentTimeTextBox
        '
        Me.currentTimeTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021R), Telerik.Reporting.Drawing.Unit.Inch(0.021R))
        Me.currentTimeTextBox.Name = "currentTimeTextBox"
        Me.currentTimeTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.currentTimeTextBox.StyleName = "PageInfo"
        Me.currentTimeTextBox.Value = "=NOW()"
        '
        'pageInfoTextBox
        '
        Me.pageInfoTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.24R), Telerik.Reporting.Drawing.Unit.Inch(0.021R))
        Me.pageInfoTextBox.Name = "pageInfoTextBox"
        Me.pageInfoTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.198R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.pageInfoTextBox.StyleName = "PageInfo"
        Me.pageInfoTextBox.Value = "=PageNumber"
        '
        'reportHeader
        '
        Me.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.029R)
        Me.reportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.apellidoCaptionTextBox, Me.correoElectronicoCaptionTextBox, Me.idHorariosCaptionTextBox, Me.idTipoElmpleadoCaptionTextBox, Me.nombreCaptionTextBox, Me.rTNCaptionTextBox, Me.telefonoCaptionTextBox, Me.estadoCaptionTextBox, Me.identidadCaptionTextBox})
        Me.reportHeader.Name = "reportHeader"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.458R), Telerik.Reporting.Drawing.Unit.Inch(0.787R))
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "Report2"
        '
        'apellidoCaptionTextBox
        '
        Me.apellidoCaptionTextBox.CanGrow = True
        Me.apellidoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.apellidoCaptionTextBox.Name = "apellidoCaptionTextBox"
        Me.apellidoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.apellidoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.apellidoCaptionTextBox.StyleName = "Caption"
        Me.apellidoCaptionTextBox.Value = "Apellido:"
        '
        'apellidoDataTextBox
        '
        Me.apellidoDataTextBox.CanGrow = True
        Me.apellidoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.021R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.apellidoDataTextBox.Name = "apellidoDataTextBox"
        Me.apellidoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.apellidoDataTextBox.StyleName = "Data"
        Me.apellidoDataTextBox.Value = "= Fields.Apellido"
        '
        'correoElectronicoCaptionTextBox
        '
        Me.correoElectronicoCaptionTextBox.CanGrow = True
        Me.correoElectronicoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.736R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.correoElectronicoCaptionTextBox.Name = "correoElectronicoCaptionTextBox"
        Me.correoElectronicoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.664R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.correoElectronicoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.correoElectronicoCaptionTextBox.StyleName = "Caption"
        Me.correoElectronicoCaptionTextBox.Value = "Correo Electronico:"
        '
        'correoElectronicoDataTextBox
        '
        Me.correoElectronicoDataTextBox.CanGrow = True
        Me.correoElectronicoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.736R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.correoElectronicoDataTextBox.Name = "correoElectronicoDataTextBox"
        Me.correoElectronicoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.664R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.correoElectronicoDataTextBox.StyleName = "Data"
        Me.correoElectronicoDataTextBox.Value = "= Fields.CorreoElectronico"
        '
        'estadoCaptionTextBox
        '
        Me.estadoCaptionTextBox.CanGrow = True
        Me.estadoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.472R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.estadoCaptionTextBox.Name = "estadoCaptionTextBox"
        Me.estadoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.628R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.estadoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.estadoCaptionTextBox.StyleName = "Caption"
        Me.estadoCaptionTextBox.Value = "Estado:"
        '
        'estadoDataTextBox
        '
        Me.estadoDataTextBox.CanGrow = True
        Me.estadoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.472R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.estadoDataTextBox.Name = "estadoDataTextBox"
        Me.estadoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.628R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.estadoDataTextBox.StyleName = "Data"
        Me.estadoDataTextBox.Value = "= Fields.Estado"
        '
        'identidadCaptionTextBox
        '
        Me.identidadCaptionTextBox.CanGrow = True
        Me.identidadCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.187R), Telerik.Reporting.Drawing.Unit.Inch(0.829R))
        Me.identidadCaptionTextBox.Name = "identidadCaptionTextBox"
        Me.identidadCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.identidadCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.identidadCaptionTextBox.StyleName = "Caption"
        Me.identidadCaptionTextBox.Value = "Identidad:"
        '
        'identidadDataTextBox
        '
        Me.identidadDataTextBox.CanGrow = True
        Me.identidadDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.187R), Telerik.Reporting.Drawing.Unit.Inch(0.081R))
        Me.identidadDataTextBox.Name = "identidadDataTextBox"
        Me.identidadDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.identidadDataTextBox.StyleName = "Data"
        Me.identidadDataTextBox.Value = "= Fields.Identidad"
        '
        'idHorariosCaptionTextBox
        '
        Me.idHorariosCaptionTextBox.CanGrow = True
        Me.idHorariosCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.882R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.idHorariosCaptionTextBox.Name = "idHorariosCaptionTextBox"
        Me.idHorariosCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.idHorariosCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.idHorariosCaptionTextBox.StyleName = "Caption"
        Me.idHorariosCaptionTextBox.Value = "Id Horarios:"
        '
        'idHorariosDataTextBox
        '
        Me.idHorariosDataTextBox.CanGrow = True
        Me.idHorariosDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.882R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.idHorariosDataTextBox.Name = "idHorariosDataTextBox"
        Me.idHorariosDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.idHorariosDataTextBox.StyleName = "Data"
        Me.idHorariosDataTextBox.Value = "= Fields.IdHorarios"
        '
        'idTipoElmpleadoCaptionTextBox
        '
        Me.idTipoElmpleadoCaptionTextBox.CanGrow = True
        Me.idTipoElmpleadoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.597R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.idTipoElmpleadoCaptionTextBox.Name = "idTipoElmpleadoCaptionTextBox"
        Me.idTipoElmpleadoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.idTipoElmpleadoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.idTipoElmpleadoCaptionTextBox.StyleName = "Caption"
        Me.idTipoElmpleadoCaptionTextBox.Value = "Id Tipo Elmpleado:"
        '
        'idTipoElmpleadoDataTextBox
        '
        Me.idTipoElmpleadoDataTextBox.CanGrow = True
        Me.idTipoElmpleadoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.597R), Telerik.Reporting.Drawing.Unit.Inch(0.081R))
        Me.idTipoElmpleadoDataTextBox.Name = "idTipoElmpleadoDataTextBox"
        Me.idTipoElmpleadoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.idTipoElmpleadoDataTextBox.StyleName = "Data"
        Me.idTipoElmpleadoDataTextBox.Value = "= Fields.IdTipoElmpleado"
        '
        'nombreCaptionTextBox
        '
        Me.nombreCaptionTextBox.CanGrow = True
        Me.nombreCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.312R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.nombreCaptionTextBox.Name = "nombreCaptionTextBox"
        Me.nombreCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.716R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.nombreCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.nombreCaptionTextBox.StyleName = "Caption"
        Me.nombreCaptionTextBox.Value = "Nombre:"
        '
        'nombreDataTextBox
        '
        Me.nombreDataTextBox.CanGrow = True
        Me.nombreDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.312R), Telerik.Reporting.Drawing.Unit.Inch(0.042R))
        Me.nombreDataTextBox.Name = "nombreDataTextBox"
        Me.nombreDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.nombreDataTextBox.StyleName = "Data"
        Me.nombreDataTextBox.Value = "= Fields.Nombre"
        '
        'rTNCaptionTextBox
        '
        Me.rTNCaptionTextBox.CanGrow = True
        Me.rTNCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.028R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.rTNCaptionTextBox.Name = "rTNCaptionTextBox"
        Me.rTNCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.rTNCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.rTNCaptionTextBox.StyleName = "Caption"
        Me.rTNCaptionTextBox.Value = "RTN:"
        '
        'rTNDataTextBox
        '
        Me.rTNDataTextBox.CanGrow = True
        Me.rTNDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.028R), Telerik.Reporting.Drawing.Unit.Inch(0.081R))
        Me.rTNDataTextBox.Name = "rTNDataTextBox"
        Me.rTNDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.715R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.rTNDataTextBox.StyleName = "Data"
        Me.rTNDataTextBox.Value = "= Fields.RTN"
        '
        'telefonoCaptionTextBox
        '
        Me.telefonoCaptionTextBox.CanGrow = True
        Me.telefonoCaptionTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.743R), Telerik.Reporting.Drawing.Unit.Inch(0.808R))
        Me.telefonoCaptionTextBox.Name = "telefonoCaptionTextBox"
        Me.telefonoCaptionTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.telefonoCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.telefonoCaptionTextBox.StyleName = "Caption"
        Me.telefonoCaptionTextBox.Value = "Telefono:"
        '
        'telefonoDataTextBox
        '
        Me.telefonoDataTextBox.CanGrow = True
        Me.telefonoDataTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.743R), Telerik.Reporting.Drawing.Unit.Inch(0.081R))
        Me.telefonoDataTextBox.Name = "telefonoDataTextBox"
        Me.telefonoDataTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.694R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.telefonoDataTextBox.StyleName = "Data"
        Me.telefonoDataTextBox.Value = "= Fields.Telefono"
        '
        'reportFooter
        '
        Me.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.reportFooter.Name = "reportFooter"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.281R)
        Me.detail.Name = "detail"
        '
        'Report2
        '
        Me.DataSource = Me.SqlDataSource1
        Group1.GroupFooter = Me.labelsGroupFooterSection
        Group1.GroupHeader = Me.labelsGroupHeaderSection
        Group1.Name = "labelsGroup"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.labelsGroupHeaderSection, Me.labelsGroupFooterSection, Me.pageHeader, Me.pageFooter, Me.reportHeader, Me.reportFooter, Me.detail})
        Me.Name = "Report2"
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(1.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Title")})
        StyleRule2.Style.Color = System.Drawing.Color.Black
        StyleRule2.Style.Font.Bold = True
        StyleRule2.Style.Font.Name = "Tahoma"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Caption")})
        StyleRule3.Style.Color = System.Drawing.Color.Black
        StyleRule3.Style.Font.Name = "Tahoma"
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        StyleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Data")})
        StyleRule4.Style.Font.Name = "Tahoma"
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        StyleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("PageInfo")})
        StyleRule5.Style.Font.Name = "Tahoma"
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(6.458R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents labelsGroupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents labelsGroupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents pageHeader As Telerik.Reporting.PageHeaderSection
    Friend WithEvents reportNameTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageFooter As Telerik.Reporting.PageFooterSection
    Friend WithEvents currentTimeTextBox As Telerik.Reporting.TextBox
    Friend WithEvents pageInfoTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportHeader As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents apellidoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents apellidoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents correoElectronicoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents correoElectronicoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents estadoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents estadoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents identidadCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents identidadDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idHorariosCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idHorariosDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idTipoElmpleadoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents idTipoElmpleadoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents nombreDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents rTNCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents rTNDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents telefonoCaptionTextBox As Telerik.Reporting.TextBox
    Friend WithEvents telefonoDataTextBox As Telerik.Reporting.TextBox
    Friend WithEvents reportFooter As Telerik.Reporting.ReportFooterSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
End Class