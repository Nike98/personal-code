' =========================================================================================================
' =========================================================================================================
'
'                                            EXPLAINATION
'
'                 This program is to implement the use of an Abstract class
'         An Abstract class is a class which inherits other classes and overrides their data
'       An exception with Abstract Classes is that as per the concept of Data Abstraction goes...
'           They can either be used or stay dormant within the code not working at all.
'
'
'                      This program here shoes the use of an Abstract Class 
'                          with an Abstract and Non Abstract Meathod
'
'
' =========================================================================================================
' =========================================================================================================


Imports System.Console

Public MustInherit Class Shape

    Public Sub Area(ByVal Length As Integer, ByVal Breadth As Integer)                          ' Non Abstract Meathod

        WriteLine(" The Area = " & (0.5 * Length) / Breadth)

    End Sub

    Public MustOverride Sub Add(ByVal a As Integer, ByVal b As Integer)                         ' Abstract Meathod Declared here

End Class

Public Class Sum

    Inherits Shape

    Public Overrides Sub Add(a As Integer, b As Integer)                                        ' Definition of the Abstract Meathod declared above
        WriteLine(" The Sum = " & a + b)
    End Sub
End Class

Module Module1

    Sub Main()

        Dim obj As New Sum

        obj.Area(20, 5)                                                                         ' Non abstract meathod called by the object of Class Sum here

        obj.Add(20, 2)                                                                          ' Abstract meathod called by the object of Class Sum

        ReadLine()

    End Sub

End Module
