''' <summary>
''' Clase donde se ponen algunos atributos y metodos que estan en todos los formularios
''' (por ejemplo la cadena de conexion, o la subrutina para confirmar la salida)
''' </summary>
''' <remarks></remarks>
Public Class Atributos_Compartidos
    Dim cadena_conexion As String = ""
    Dim confirmacion_salida As Boolean

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

    Public Property _confirmacion_salida As Boolean
        Get
            Return confirmacion_salida
        End Get
        Set(value As Boolean)
            Me.confirmacion_salida = value
        End Set
    End Property

    Public Sub New()

        'Asigna la cadena de conexion segun la compu actual (por el tema de Git y eso)
        Select Case Environment.UserName
            Case "Luciano" 'Lucho
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=LAPATOP\LUCIANOSQL;User ID=Luciano;Initial Catalog=ConsultorioOdontologicoBD;Password=Luciano"
            Case "NOTEBOOK" 'maxeeeh
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=BGH\MORILLASSQL;User ID=Morillas;Initial Catalog=ConsultorioOdontologicoBD;password=Morillas"
        End Select

    End Sub

    Public Function confirmar_salida(e As FormClosingEventArgs) As Boolean

        Dim respuesta As Boolean

        If MessageBox.Show("          ¿Esta seguro que desea salir?", "Importante", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then
            respuesta = False
        Else
            respuesta = True
        End If

        Return respuesta
    End Function
End Class
