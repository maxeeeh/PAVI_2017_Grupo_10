''' <summary>
''' Clase que genera la cadena de conexion dependiendo de la computadora (para lucho, maxi, leo y ana).
''' Esto sirve para no tener que andar cambiando la cadena de conexion cada vez que hacemos un sync.
''' </summary>
''' <remarks></remarks>
Public Class Cadena_Conexion
    Dim cadena_conexion As String = ""

    ''' <summary>
    ''' Valor de la cadena de conexion, determinada automaticamente segun en que compu este (para lucho, maxi, leo y ana)
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

    Public Sub New()

        'Asigna la cadena de conexion segun la compu actual (por el tema de Git y eso)
        Select Case Environment.UserName
            Case "Luciano" 'Lucho
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=LAPATOP\LUCIANOSQL;User ID=Luciano;Initial Catalog=ConsultorioOdontologicoBD;Password=Luciano"
            Case "NOTEBOOK" 'maxeeeh
                Me._cadena_conexion = "Provider=SQLNCLI11;Data Source=BGH\MORILLASSQL;User ID=Morillas;Initial Catalog=ConsultorioOdontologicoBD;password=Morillas"
        End Select

    End Sub
End Class
