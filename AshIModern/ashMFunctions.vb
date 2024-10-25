Imports System.IO
Imports Structures
Imports StructureTools
Public Class ashMFunctions
    Public methodName As String
    Public isShinyCharm As Boolean
    Public isProgressive As Boolean
    Public stages As UInt16
    Public odds(,) As UInt16
    Dim magic As Char()


    Public Sub readAshM(ByVal ashMFile As String)
        Dim method As Structures.ashMFile = StructureTools.bytesToAshM(File.ReadAllBytes(ashMFile))

        methodName = method.methodName
        isShinyCharm = method.shinyCharm
        isProgressive = method.isProgressive
        stages = method.stages
        odds = method.odds


    End Sub
    Public Sub createAshMAndWrite(ByVal name As String, ByVal progressive As Boolean, ByVal shinyCharm As Boolean, ByVal odds As UInt16(,), ByVal stages As UInt16, ByVal fileName As String)
        Dim method As Structures.ashMFile
        method.magic = {"A", "s", "h", "M"}
        method.methodName = name
        method.isProgressive = progressive
        method.shinyCharm = shinyCharm
        method.stages = stages
        method.odds = odds
        Dim methodFile As Byte() = StructureTools.ashMFileToBytes(method)
        File.WriteAllBytes(fileName, methodFile)
    End Sub
End Class