Public Class frm_factura_report
    Dim clase_auxiliar As New Atributos_Compartidos

    Dim nro_factura As Integer = 13 'El valor de esta variable tiene que ser pasado por parametro al crear la ventana
    Private _p1 As Integer

    Private Sub Factura_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = ""

        sql &= "SELECT F.id_factura, F.id_paciente, P.apellido + ', ' + P.nombre AS nombre_apellido_paciente"
        sql &= ", F.monto_total, F.fecha, F.id_forma_pago, FP.descripcion AS descripcion_forma_pago"
        sql &= " FROM Factura F JOIN Paciente P ON F.id_paciente = P.id_paciente"
        sql &= " JOIN FormaPago FP ON F.id_forma_pago = FP.id_forma_pago"
        sql &= " WHERE F.id_factura = " & nro_factura
        Me.FacturaBindingSource.DataSource = clase_auxiliar.ejecuto_sql(sql)

        'La idea es agregar un handler(quien va manipular el subreport o subproceso) e indicar el sub que se encarga del subreport
        AddHandler rv_factura.LocalReport.SubreportProcessing, AddressOf Me.SubreportProcessingEventHandler

        Me.rv_factura.RefreshReport()


    End Sub

    Private Sub SubreportProcessingEventHandler(sender As Object, e As Microsoft.Reporting.WinForms.SubreportProcessingEventArgs)
        Dim sql As String = ""

        sql &= "SELECT DF.id_factura, DF.id_intervencion, DF.precio, I.fecha AS fecha_intervencion"
        sql &= " FROM Factura F JOIN DetalleFactura DF ON F.id_factura = DF.id_factura"
        sql &= " JOIN Intervencion I ON DF.id_intervencion = I.id_intervencion"
        sql &= " WHERE F.id_factura = " & nro_factura

        'Le digo explicitamente como se llama su DataSet aunque se lo haya definido en el diseño y le paso su fuente de datos
        e.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DS_Detalle_Factura", clase_auxiliar.ejecuto_sql(sql)))
    End Sub

    'Este metodo es el que crea el form
    Sub New(ByVal id_factura As Integer)
        InitializeComponent() 'Es quien se encarga de inicializar todo lo que contiene el form (el designer), en otras palabras renderiza el form

        nro_factura = id_factura
    End Sub

    Sub New()
        InitializeComponent()
    End Sub
End Class