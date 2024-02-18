Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Threading.Tasks
Imports RestEase
Imports System.Runtime.CompilerServices
Imports Data2.Floriday.API2023V1.Models

Namespace Floriday.API2023V1
    Public Interface IFloridayAPI
        <Header("Authorization")>
        Property Authorization As AuthenticationHeaderValue
        <Header("X-Api-Key")>
        Property APIKey As String
        <[Get]("/additional-services")>
        Function GetAdditionalServicesAsync() As Task(Of Response(Of AdditionalService))
        <[Get]("/additional-services/{additionalServiceId}")>
        Function GetAdditionalServiceByIdAsync(
        <Path> ByVal additionalServiceId As String) As Task(Of Response(Of AdditionalService))
        <[Get]("/additional-services/sync/{sequenceNumber}")>
        Function GetAdditionalServiceBySequenceNumberAsync(
        <Path> ByVal sequenceNumber As Long,
        <Query> ByVal limit As Integer?) As Task(Of Response(Of SyncResultOfAdditionalService))
        <[Get]("/additional-services/current-max-sequence")>
        Function GetAdditionalServicesMaxSequenceAsync() As Task(Of Response(Of Long))
        <[Get]("/clock-supply-lines/sync/{sequenceNumber}")>
        Function GetClockSupplyLinesBySequenceNumberAsync(
        <Path> ByVal sequenceNumber As Long,
        <Query> ByVal limitResult As Integer?) As Task(Of Response(Of SyncResultOfClockSupplyLine))
        <[Get]("/clock-supply-lines/current-max-sequence")>
        Function GetClockSupplyLinesMaxSequenceAsync() As Task(Of Response(Of Long))
        <[Get]("/clock-presales-supply-lines/sync/{sequenceNumber}")>
        Function GetClockPresalesSupplyLinesBySequenceNumberAsync(
        <Path> ByVal sequenceNumber As Long,
        <Query> ByVal limitResult As Integer?) As Task(Of Response(Of SyncResultOfClockPresalesSupplyLine))
        <[Get]("/clock-presales-supply-lines/current-max-sequence")>
        Function GetClockPresalesSupplyLinesMaxSequenceAsync() As Task(Of Response(Of Long))
        <[Get]("/clock-presales-supply-lines/{clockPresalesSupplyLineId}")>
        Function GetClockPresalesSupplyLineByIdAsync(
        <Path> ByVal clockPresalesSupplyLineId As String) As Task(Of Response(Of ClockPresalesSupplyLine))
        <Put("/clock-presales-supply-lines/{clockPresalesSupplyLineId}")>
    End Interface
End Namespace

Namespace Floriday.API2023V1
    Module IFloridayAPIExtensions
        <Extension()>
        Function AddImageAsync(ByVal api As IFloridayAPI, ByVal image As Byte()) As Task(Of Response(Of MediaReference))
            Dim content = New MultipartFormDataContent()
            Dim imageContent = New ByteArrayContent(image)
            content.Add(imageContent)
            Return api.AddImageAsync(content)
        End Function
    End Module
End Namespace
