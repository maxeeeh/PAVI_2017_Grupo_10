''' <summary>
''' Clase donde se ponen algunos atributos y metodos que estan en todos los formularios
''' (por ejemplo la cadena de conexion, o la subrutina para confirmar la salida)
''' </summary>
''' <remarks></remarks>
Public Class Atributos_Compartidos
    Enum tipo_conexion
        simple
        transaccion
    End Enum
    Enum resultado_transaccion
        _ok
        _error
    End Enum
    Dim configuracion_conexion As tipo_conexion = tipo_conexion.simple
    Dim control_transaccion As resultado_transaccion = resultado_transaccion._ok

    Dim cadena_conexion As String = ""
    Dim conexion As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim transaccion As OleDb.OleDbTransaction


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
    Public Sub iniciar_conexion_con_transaccion()
        Me.control_transaccion = resultado_transaccion._ok
        Me.configuracion_conexion = tipo_conexion.transaccion
    End Sub
    Public Sub cerrar_conexion_con_transaccion()
        If Me.configuracion_conexion = tipo_conexion.transaccion Then
            If Me.control_transaccion = resultado_transaccion._ok Then
                Me.transaccion.Commit()
            Else
                Me.transaccion.Rollback()
            End If
            Me.configuracion_conexion = tipo_conexion.simple
            Me.desconectar()
        End If
    End Sub
    Private Sub conectar()
        If conexion.State.ToString <> "Open" Then
            Me.conexion.ConnectionString = cadena_conexion
            Me.conexion.Open()
            Me.cmd.Connection = conexion
            Me.cmd.CommandType = CommandType.Text

            If configuracion_conexion = tipo_conexion.transaccion Then
                Me.transaccion = Me.conexion.BeginTransaction
                Me.cmd.Transaction = Me.transaccion
                Me.control_transaccion = resultado_transaccion._ok
            End If
        End If
    End Sub
    Private Sub desconectar()
        If configuracion_conexion = tipo_conexion.simple Then
            Me.conexion.Close()
        End If
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

    'Esta seria mi idea de implementar cargar_combobox (MAXI)
    Public Sub cargar_combobox(ByRef combo As ComboBox, ByVal nombre_tabla As String)
        cargar_combobox(combo, leo_tabla(nombre_tabla))
    End Sub

    'Deje tambien esta version porque sirve para el formulario de turnos (LUCHO)
    Public Sub cargar_combobox(ByRef combo As ComboBox, ByVal data As DataTable)
        combo.Items.Clear()
        combo.DataSource = data '.Rows.InsertAt(New System.Data.DataRow()
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
                Case "RichTextBox"
                    objeto.Text = ""
                Case "GroupBox"
                    blanquear_campos(objeto)
                    'Case Else
                    '    MessageBox.Show("El formato de control no esta configurado para el: " & objeto.GetType().Name)
            End Select

        Next
    End Sub

    Public Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecuto_sql("SELECT * FROM " & nombre_tabla)
    End Function

    Public Function leo_tabla_soporte(ByVal nombre_tabla As String) As DataTable
        Return ejecuto_sql("SELECT * FROM " & nombre_tabla & " WHERE habilitado = 1 ORDER BY descripcion ASC")
    End Function

    Public Function ejecuto_sql(ByVal sql As String) As DataTable
        Me.conectar()
        cmd.CommandText = sql
        Dim tabla As New DataTable
        tabla.Load(cmd.ExecuteReader())
        Me.desconectar()
        Return tabla
    End Function

    Public Sub insertar_modificar_eliminar(ByVal sql As String)
        Me.conectar()
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        Me.desconectar()
    End Sub

End Class
