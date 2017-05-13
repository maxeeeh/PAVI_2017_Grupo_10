''' <summary>
''' Clase donde se ponen algunos atributos y metodos que estan en todos los formularios
''' (por ejemplo la cadena de conexion, o la subrutina para confirmar la salida)
''' </summary>
''' <remarks></remarks>
Public Class Atributos_Compartidos
    Dim cadena_conexion As String = ""

    ''' <summary>
    ''' Valor de la cadena de conexion, determinada automaticamente segun en que compu este (para lucho, maxi, leo y ana).
    ''' Esto sirve para no tener que andar cambiando la cadena_conexion cada vez que se hace un sync
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property _cadena_conexion As String
        Get
            Return cadena_conexion
        End Get
        Set(value As String)
            Me.cadena_conexion = value
        End Set
    End Property

    Public Sub New() 'Esto es el constructor. Seria como el Load del formulario, pero para cuando se le hace New a una clase (cuando se crea un objeto)

        'Asigna la cadena de conexion segun la compu actual (por el tema de Git y eso)
        Select Case Environment.UserName
            Case "Luciano" 'Lucho
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=LAPATOP\LUCIANOSQL;User ID=Luciano;Initial Catalog=ConsultorioOdontologicoBD;Password=Luciano"
            Case "NOTEBOOK" 'maxeeeh
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=BGH\MORILLASSQL;User ID=Morillas;Initial Catalog=ConsultorioOdontologicoBD;password=Morillas"
            Case "nicoLeo" 'Leo
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=POZZO;Integrated Security=SSPI;Initial Catalog=ConsultorioOdontologicoBD"
        End Select

    End Sub

    Public Function confirmar_salida(ByRef e As FormClosingEventArgs) As Boolean

        Dim respuesta As Boolean

        If MessageBox.Show("          ¿Esta seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            respuesta = False
        Else
            respuesta = True
        End If

        Return respuesta

    End Function

    Public Sub cargar_combobox(ByRef combo As ComboBox, ByVal data As DataTable)
        combo.Items.Clear()
        combo.DataSource = data
        combo.ValueMember = data.Columns(0).ColumnName   'pk
        combo.DisplayMember = data.Columns(1).ColumnName 'descripcion
    End Sub

    Public Sub blanquear_campos(ByRef contenedor As Control) 'Blanquea todos los campos del contenedor, y de los sub contenedores

        'Dos ejemplos de contenedores son: el formulario, y algun groupbox. Si se invoca a esta subrutina con el parametro "Me" sin comillas, entonces
        'blanquea todos los campos del formulario, y se mete en cada groupbox que encuentra y le blanquea los campos tambien
        '(y si ese groupbox tiene mas groupbox adentro tambien los blanquea, y asi sucesivamente)

        For Each objeto In contenedor.Controls
            Select Case objeto.GetType().Name
                Case "TextBox"
                    objeto.Text = ""
                Case "MaskedTextBox"
                    objeto.Text = ""
                Case "ComboBox"
                    Dim combo As ComboBox = objeto
                    combo.SelectedIndex = -1
                Case "RadioButton"
                    Dim radio_button As RadioButton = objeto
                    radio_button.Checked = False
                Case "GroupBox"
                    blanquear_campos(objeto)
            End Select

        Next
    End Sub

    Public Function leo_tabla(nombre_tabla As String) As DataTable

        Dim conexion As New Data.OleDb.OleDbConnection
        Dim cmd As New Data.OleDb.OleDbCommand
        Dim tabla As New Data.DataTable
        Dim sql As String = ""

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text

        sql &= "SELECT * FROM "
        sql &= nombre_tabla

        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader())

        Return tabla

    End Function

End Class
