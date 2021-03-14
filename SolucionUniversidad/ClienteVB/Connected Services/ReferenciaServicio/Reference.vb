﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace ReferenciaServicio
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ReferenciaServicio.ServicioEscuelaSoap")>  _
    Public Interface ServicioEscuelaSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Listar", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Listar() As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Listar", ReplyAction:="*")>  _
        Function ListarAsync() As System.Threading.Tasks.Task(Of System.Data.DataSet)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Actualizar", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Actualizar(ByVal codEscuela As String, ByVal laEscuela As String) As String()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Actualizar", ReplyAction:="*")>  _
        Function ActualizarAsync(ByVal codEscuela As String, ByVal laEscuela As String) As System.Threading.Tasks.Task(Of String())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Agregar", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Agregar(ByVal codEscuela As String, ByVal laEscuela As String) As String()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Agregar", ReplyAction:="*")>  _
        Function AgregarAsync(ByVal codEscuela As String, ByVal laEscuela As String) As System.Threading.Tasks.Task(Of String())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Buscar", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Buscar(ByVal texto As String, ByVal criterio As String) As System.Data.DataSet
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Buscar", ReplyAction:="*")>  _
        Function BuscarAsync(ByVal texto As String, ByVal criterio As String) As System.Threading.Tasks.Task(Of System.Data.DataSet)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Eliminar", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Eliminar(ByVal codEscuela As String) As String()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Eliminar", ReplyAction:="*")>  _
        Function EliminarAsync(ByVal codEscuela As String) As System.Threading.Tasks.Task(Of String())
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServicioEscuelaSoapChannel
        Inherits ReferenciaServicio.ServicioEscuelaSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServicioEscuelaSoapClient
        Inherits System.ServiceModel.ClientBase(Of ReferenciaServicio.ServicioEscuelaSoap)
        Implements ReferenciaServicio.ServicioEscuelaSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Listar() As System.Data.DataSet Implements ReferenciaServicio.ServicioEscuelaSoap.Listar
            Return MyBase.Channel.Listar
        End Function
        
        Public Function ListarAsync() As System.Threading.Tasks.Task(Of System.Data.DataSet) Implements ReferenciaServicio.ServicioEscuelaSoap.ListarAsync
            Return MyBase.Channel.ListarAsync
        End Function
        
        Public Function Actualizar(ByVal codEscuela As String, ByVal laEscuela As String) As String() Implements ReferenciaServicio.ServicioEscuelaSoap.Actualizar
            Return MyBase.Channel.Actualizar(codEscuela, laEscuela)
        End Function
        
        Public Function ActualizarAsync(ByVal codEscuela As String, ByVal laEscuela As String) As System.Threading.Tasks.Task(Of String()) Implements ReferenciaServicio.ServicioEscuelaSoap.ActualizarAsync
            Return MyBase.Channel.ActualizarAsync(codEscuela, laEscuela)
        End Function
        
        Public Function Agregar(ByVal codEscuela As String, ByVal laEscuela As String) As String() Implements ReferenciaServicio.ServicioEscuelaSoap.Agregar
            Return MyBase.Channel.Agregar(codEscuela, laEscuela)
        End Function
        
        Public Function AgregarAsync(ByVal codEscuela As String, ByVal laEscuela As String) As System.Threading.Tasks.Task(Of String()) Implements ReferenciaServicio.ServicioEscuelaSoap.AgregarAsync
            Return MyBase.Channel.AgregarAsync(codEscuela, laEscuela)
        End Function
        
        Public Function Buscar(ByVal texto As String, ByVal criterio As String) As System.Data.DataSet Implements ReferenciaServicio.ServicioEscuelaSoap.Buscar
            Return MyBase.Channel.Buscar(texto, criterio)
        End Function
        
        Public Function BuscarAsync(ByVal texto As String, ByVal criterio As String) As System.Threading.Tasks.Task(Of System.Data.DataSet) Implements ReferenciaServicio.ServicioEscuelaSoap.BuscarAsync
            Return MyBase.Channel.BuscarAsync(texto, criterio)
        End Function
        
        Public Function Eliminar(ByVal codEscuela As String) As String() Implements ReferenciaServicio.ServicioEscuelaSoap.Eliminar
            Return MyBase.Channel.Eliminar(codEscuela)
        End Function
        
        Public Function EliminarAsync(ByVal codEscuela As String) As System.Threading.Tasks.Task(Of String()) Implements ReferenciaServicio.ServicioEscuelaSoap.EliminarAsync
            Return MyBase.Channel.EliminarAsync(codEscuela)
        End Function
    End Class
End Namespace
