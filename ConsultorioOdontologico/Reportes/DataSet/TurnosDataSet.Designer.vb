﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''<summary>
'''Represents a strongly typed in-memory cache of data.
'''</summary>
<Global.System.Serializable(),  _
 Global.System.ComponentModel.DesignerCategoryAttribute("code"),  _
 Global.System.ComponentModel.ToolboxItem(true),  _
 Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedDataSetSchema"),  _
 Global.System.Xml.Serialization.XmlRootAttribute("TurnosDataSet"),  _
 Global.System.ComponentModel.Design.HelpKeywordAttribute("vs.data.DataSet")>  _
Partial Public Class TurnosDataSet
    Inherits Global.System.Data.DataSet
    
    Private tableTurnos As TurnosDataTable

    Private _schemaSerializationMode As Global.System.Data.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Sub New()
        MyBase.New()
        Me.BeginInit()
        Me.InitClass()
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler MyBase.Relations.CollectionChanged, schemaChangedHandler
        Me.EndInit()
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context, False)
        If (Me.IsBinarySerialized(info, context) = True) Then
            Me.InitVars(False)
            Dim schemaChangedHandler1 As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler1
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler1
            Return
        End If
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(String)), String)
        If (Me.DetermineSchemaSerializationMode(info, context) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Turnos")) Is Nothing) Then
                MyBase.Tables.Add(New TurnosDataTable(ds.Tables("Turnos")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars()
        Else
            Me.ReadXmlSchema(New Global.System.Xml.XmlTextReader(New Global.System.IO.StringReader(strSchema)))
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As Global.System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler MyBase.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.Browsable(False), _
     Global.System.ComponentModel.DesignerSerializationVisibility(Global.System.ComponentModel.DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property Turnos() As TurnosDataTable
        Get
            Return Me.tableTurnos
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.BrowsableAttribute(True), _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Visible)> _
    Public Overrides Property SchemaSerializationMode() As Global.System.Data.SchemaSerializationMode
        Get
            Return Me._schemaSerializationMode
        End Get
        Set(value As Global.System.Data.SchemaSerializationMode)
            Me._schemaSerializationMode = value
        End Set
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property Tables() As Global.System.Data.DataTableCollection
        Get
            Return MyBase.Tables
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
     Global.System.ComponentModel.DesignerSerializationVisibilityAttribute(Global.System.ComponentModel.DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property Relations() As Global.System.Data.DataRelationCollection
        Get
            Return MyBase.Relations
        End Get
    End Property

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Sub InitializeDerivedDataSet()
        Me.BeginInit()
        Me.InitClass()
        Me.EndInit()
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Overrides Function Clone() As Global.System.Data.DataSet
        Dim cln As TurnosDataSet = CType(MyBase.Clone, TurnosDataSet)
        cln.InitVars()
        cln.SchemaSerializationMode = Me.SchemaSerializationMode
        Return cln
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As Global.System.Xml.XmlReader)
        If (Me.DetermineSchemaSerializationMode(reader) = Global.System.Data.SchemaSerializationMode.IncludeSchema) Then
            Me.Reset()
            Dim ds As Global.System.Data.DataSet = New Global.System.Data.DataSet()
            ds.ReadXml(reader)
            If (Not (ds.Tables("Turnos")) Is Nothing) Then
                MyBase.Tables.Add(New TurnosDataTable(ds.Tables("Turnos")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, False, Global.System.Data.MissingSchemaAction.Add)
            Me.InitVars()
        Else
            Me.ReadXml(reader)
            Me.InitVars()
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Protected Overrides Function GetSchemaSerializable() As Global.System.Xml.Schema.XmlSchema
        Dim stream As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
        Me.WriteXmlSchema(New Global.System.Xml.XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return Global.System.Xml.Schema.XmlSchema.Read(New Global.System.Xml.XmlTextReader(stream), Nothing)
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Friend Overloads Sub InitVars()
        Me.InitVars(True)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Friend Overloads Sub InitVars(ByVal initTable As Boolean)
        Me.tableTurnos = CType(MyBase.Tables("Turnos"), TurnosDataTable)
        If (initTable = True) Then
            If (Not (Me.tableTurnos) Is Nothing) Then
                Me.tableTurnos.InitVars()
            End If
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Private Sub InitClass()
        Me.DataSetName = "TurnosDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/TurnosDataSet.xsd"
        Me.EnforceConstraints = True
        Me.SchemaSerializationMode = Global.System.Data.SchemaSerializationMode.IncludeSchema
        Me.tableTurnos = New TurnosDataTable()
        MyBase.Tables.Add(Me.tableTurnos)
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Private Function ShouldSerializeTurnos() As Boolean
        Return False
    End Function

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As Global.System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = Global.System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars()
        End If
    End Sub

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Shared Function GetTypedDataSetSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
        Dim ds As TurnosDataSet = New TurnosDataSet()
        Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
        Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
        Dim any As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
        any.Namespace = ds.Namespace
        sequence.Items.Add(any)
        type.Particle = sequence
        Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
        If xs.Contains(dsSchema.TargetNamespace) Then
            Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
            Try
                Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                dsSchema.Write(s1)
                Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                Do While schemas.MoveNext
                    schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                    s2.SetLength(0)
                    schema.Write(s2)
                    If (s1.Length = s2.Length) Then
                        s1.Position = 0
                        s2.Position = 0

                        Do While ((s1.Position <> s1.Length) _
                                    AndAlso (s1.ReadByte = s2.ReadByte))


                        Loop
                        If (s1.Position = s1.Length) Then
                            Return type
                        End If
                    End If

                Loop
            Finally
                If (Not (s1) Is Nothing) Then
                    s1.Close()
                End If
                If (Not (s2) Is Nothing) Then
                    s2.Close()
                End If
            End Try
        End If
        xs.Add(dsSchema)
        Return type
    End Function

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Delegate Sub TurnosRowChangeEventHandler(ByVal sender As Object, ByVal e As TurnosRowChangeEvent)

    '''<summary>
    '''Represents the strongly named DataTable class.
    '''</summary>
    <Global.System.Serializable(), _
     Global.System.Xml.Serialization.XmlSchemaProviderAttribute("GetTypedTableSchema")> _
    Partial Public Class TurnosDataTable
        Inherits Global.System.Data.TypedTableBase(Of TurnosRow)

        Private columnfecha As Global.System.Data.DataColumn

        Private columnhora_desde As Global.System.Data.DataColumn

        Private columnhora_hasta As Global.System.Data.DataColumn

        Private columnpac As Global.System.Data.DataColumn

        Private columnemp As Global.System.Data.DataColumn

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New()
            MyBase.New()
            Me.TableName = "Turnos"
            Me.BeginInit()
            Me.InitClass()
            Me.EndInit()
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub New(ByVal table As Global.System.Data.DataTable)
            MyBase.New()
            Me.TableName = table.TableName
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Sub New(ByVal info As Global.System.Runtime.Serialization.SerializationInfo, ByVal context As Global.System.Runtime.Serialization.StreamingContext)
            MyBase.New(info, context)
            Me.InitVars()
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property fechaColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnfecha
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property hora_desdeColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnhora_desde
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property hora_hastaColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnhora_hasta
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property pacColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnpac
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property empColumn() As Global.System.Data.DataColumn
            Get
                Return Me.columnemp
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), _
         Global.System.ComponentModel.Browsable(False)> _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Default Public ReadOnly Property Item(ByVal index As Integer) As TurnosRow
            Get
                Return CType(Me.Rows(index), TurnosRow)
            End Get
        End Property

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event TurnosRowChanging As TurnosRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event TurnosRowChanged As TurnosRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event TurnosRowDeleting As TurnosRowChangeEventHandler

        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Event TurnosRowDeleted As TurnosRowChangeEventHandler

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overloads Sub AddTurnosRow(ByVal row As TurnosRow)
            Me.Rows.Add(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overloads Function AddTurnosRow(ByVal fecha As String, ByVal hora_desde As String, ByVal hora_hasta As String, ByVal pac As String, ByVal emp As String) As TurnosRow
            Dim rowTurnosRow As TurnosRow = CType(Me.NewRow, TurnosRow)
            Dim columnValuesArray() As Object = New Object() {fecha, hora_desde, hora_hasta, pac, emp}
            rowTurnosRow.ItemArray = columnValuesArray
            Me.Rows.Add(rowTurnosRow)
            Return rowTurnosRow
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Overrides Function Clone() As Global.System.Data.DataTable
            Dim cln As TurnosDataTable = CType(MyBase.Clone, TurnosDataTable)
            cln.InitVars()
            Return cln
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function CreateInstance() As Global.System.Data.DataTable
            Return New TurnosDataTable()
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub InitVars()
            Me.columnfecha = MyBase.Columns("fecha")
            Me.columnhora_desde = MyBase.Columns("hora_desde")
            Me.columnhora_hasta = MyBase.Columns("hora_hasta")
            Me.columnpac = MyBase.Columns("pac")
            Me.columnemp = MyBase.Columns("emp")
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Private Sub InitClass()
            Me.columnfecha = New Global.System.Data.DataColumn("fecha", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnfecha)
            Me.columnhora_desde = New Global.System.Data.DataColumn("hora_desde", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnhora_desde)
            Me.columnhora_hasta = New Global.System.Data.DataColumn("hora_hasta", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnhora_hasta)
            Me.columnpac = New Global.System.Data.DataColumn("pac", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnpac)
            Me.columnemp = New Global.System.Data.DataColumn("emp", GetType(String), Nothing, Global.System.Data.MappingType.Element)
            MyBase.Columns.Add(Me.columnemp)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function NewTurnosRow() As TurnosRow
            Return CType(Me.NewRow, TurnosRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function NewRowFromBuilder(ByVal builder As Global.System.Data.DataRowBuilder) As Global.System.Data.DataRow
            Return New TurnosRow(builder)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Function GetRowType() As Global.System.Type
            Return GetType(TurnosRow)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowChanged(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TurnosRowChangedEvent) Is Nothing) Then
                RaiseEvent TurnosRowChanged(Me, New TurnosRowChangeEvent(CType(e.Row, TurnosRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowChanging(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TurnosRowChangingEvent) Is Nothing) Then
                RaiseEvent TurnosRowChanging(Me, New TurnosRowChangeEvent(CType(e.Row, TurnosRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowDeleted(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TurnosRowDeletedEvent) Is Nothing) Then
                RaiseEvent TurnosRowDeleted(Me, New TurnosRowChangeEvent(CType(e.Row, TurnosRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Protected Overrides Sub OnRowDeleting(ByVal e As Global.System.Data.DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TurnosRowDeletingEvent) Is Nothing) Then
                RaiseEvent TurnosRowDeleting(Me, New TurnosRowChangeEvent(CType(e.Row, TurnosRow), e.Action))
            End If
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub RemoveTurnosRow(ByVal row As TurnosRow)
            Me.Rows.Remove(row)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Shared Function GetTypedTableSchema(ByVal xs As Global.System.Xml.Schema.XmlSchemaSet) As Global.System.Xml.Schema.XmlSchemaComplexType
            Dim type As Global.System.Xml.Schema.XmlSchemaComplexType = New Global.System.Xml.Schema.XmlSchemaComplexType()
            Dim sequence As Global.System.Xml.Schema.XmlSchemaSequence = New Global.System.Xml.Schema.XmlSchemaSequence()
            Dim ds As TurnosDataSet = New TurnosDataSet()
            Dim any1 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any1.Namespace = "http://www.w3.org/2001/XMLSchema"
            any1.MinOccurs = New Decimal(0)
            any1.MaxOccurs = Decimal.MaxValue
            any1.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any1)
            Dim any2 As Global.System.Xml.Schema.XmlSchemaAny = New Global.System.Xml.Schema.XmlSchemaAny()
            any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
            any2.MinOccurs = New Decimal(1)
            any2.ProcessContents = Global.System.Xml.Schema.XmlSchemaContentProcessing.Lax
            sequence.Items.Add(any2)
            Dim attribute1 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute1.Name = "namespace"
            attribute1.FixedValue = ds.Namespace
            type.Attributes.Add(attribute1)
            Dim attribute2 As Global.System.Xml.Schema.XmlSchemaAttribute = New Global.System.Xml.Schema.XmlSchemaAttribute()
            attribute2.Name = "tableTypeName"
            attribute2.FixedValue = "TurnosDataTable"
            type.Attributes.Add(attribute2)
            type.Particle = sequence
            Dim dsSchema As Global.System.Xml.Schema.XmlSchema = ds.GetSchemaSerializable
            If xs.Contains(dsSchema.TargetNamespace) Then
                Dim s1 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Dim s2 As Global.System.IO.MemoryStream = New Global.System.IO.MemoryStream()
                Try
                    Dim schema As Global.System.Xml.Schema.XmlSchema = Nothing
                    dsSchema.Write(s1)
                    Dim schemas As Global.System.Collections.IEnumerator = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator
                    Do While schemas.MoveNext
                        schema = CType(schemas.Current, Global.System.Xml.Schema.XmlSchema)
                        s2.SetLength(0)
                        schema.Write(s2)
                        If (s1.Length = s2.Length) Then
                            s1.Position = 0
                            s2.Position = 0

                            Do While ((s1.Position <> s1.Length) _
                                        AndAlso (s1.ReadByte = s2.ReadByte))


                            Loop
                            If (s1.Position = s1.Length) Then
                                Return type
                            End If
                        End If

                    Loop
                Finally
                    If (Not (s1) Is Nothing) Then
                        s1.Close()
                    End If
                    If (Not (s2) Is Nothing) Then
                        s2.Close()
                    End If
                End Try
            End If
            xs.Add(dsSchema)
            Return type
        End Function
    End Class

    '''<summary>
    '''Represents strongly named DataRow class.
    '''</summary>
    Partial Public Class TurnosRow
        Inherits Global.System.Data.DataRow

        Private tableTurnos As TurnosDataTable

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Friend Sub New(ByVal rb As Global.System.Data.DataRowBuilder)
            MyBase.New(rb)
            Me.tableTurnos = CType(Me.Table, TurnosDataTable)
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property fecha() As String
            Get
                Try
                    Return CType(Me(Me.tableTurnos.fechaColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'fecha' in table 'Turnos' is DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableTurnos.fechaColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property hora_desde() As String
            Get
                Try
                    Return CType(Me(Me.tableTurnos.hora_desdeColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'hora_desde' in table 'Turnos' is DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableTurnos.hora_desdeColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property hora_hasta() As String
            Get
                Try
                    Return CType(Me(Me.tableTurnos.hora_hastaColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'hora_hasta' in table 'Turnos' is DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableTurnos.hora_hastaColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property pac() As String
            Get
                Try
                    Return CType(Me(Me.tableTurnos.pacColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'pac' in table 'Turnos' is DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableTurnos.pacColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Property emp() As String
            Get
                Try
                    Return CType(Me(Me.tableTurnos.empColumn), String)
                Catch e As Global.System.InvalidCastException
                    Throw New Global.System.Data.StrongTypingException("The value for column 'emp' in table 'Turnos' is DBNull.", e)
                End Try
            End Get
            Set(value As String)
                Me(Me.tableTurnos.empColumn) = value
            End Set
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsfechaNull() As Boolean
            Return Me.IsNull(Me.tableTurnos.fechaColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetfechaNull()
            Me(Me.tableTurnos.fechaColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function Ishora_desdeNull() As Boolean
            Return Me.IsNull(Me.tableTurnos.hora_desdeColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub Sethora_desdeNull()
            Me(Me.tableTurnos.hora_desdeColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function Ishora_hastaNull() As Boolean
            Return Me.IsNull(Me.tableTurnos.hora_hastaColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub Sethora_hastaNull()
            Me(Me.tableTurnos.hora_hastaColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IspacNull() As Boolean
            Return Me.IsNull(Me.tableTurnos.pacColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetpacNull()
            Me(Me.tableTurnos.pacColumn) = Global.System.Convert.DBNull
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Function IsempNull() As Boolean
            Return Me.IsNull(Me.tableTurnos.empColumn)
        End Function

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub SetempNull()
            Me(Me.tableTurnos.empColumn) = Global.System.Convert.DBNull
        End Sub
    End Class

    '''<summary>
    '''Row event argument class
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
    Public Class TurnosRowChangeEvent
        Inherits Global.System.EventArgs

        Private eventRow As TurnosRow

        Private eventAction As Global.System.Data.DataRowAction

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public Sub New(ByVal row As TurnosRow, ByVal action As Global.System.Data.DataRowAction)
            MyBase.New()
            Me.eventRow = row
            Me.eventAction = action
        End Sub

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property Row() As TurnosRow
            Get
                Return Me.eventRow
            End Get
        End Property

        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")> _
        Public ReadOnly Property Action() As Global.System.Data.DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class