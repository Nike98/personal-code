' This program demonstrates the functionality of meathod Overriding

Imports System.Console

' Creating a class contains data members 

Public Class Details

    Public Name As String
    Public EmpNumber As Integer
    Public City As String
    Public Zip As Integer

    ' This class is stated to be Overridable so it can be appended
    Overridable Sub Print()

        WriteLine(" Employee Name = " & Name)
        WriteLine(" Employee Number = " & EmpNumber)
        WriteLine(" City = " & City)
        WriteLine(" Zip Code = " & Zip)

    End Sub

End Class

' This is the Overriding class

Public Class Employee

    Inherits Details

    Public Overrides Sub Print()

        WriteLine(" Employee Name = " & Name)
        WriteLine(" Employee Number = " & EmpNumber)
        WriteLine(" City = " & City)
        WriteLine(" Zip Code = " & Zip)
        WriteLine(" Salary = " & Salary)                        ' Giving a new Definition while Overriding the Function Sub Print()

    End Sub

    Public Salary As Integer                                    ' Creating a new Integer variable

End Class

Module Module1

    Sub Main()

        ' Creating an object of the Overriding Class
        Dim obj As New Employee

        ' Creating an object of the Overridable Class
        Dim obj2 As New Details

        obj.Name = " Nikhil "
        obj.EmpNumber = 192168
        obj.City = " Navi Mumbai "
        obj.Zip = 410206
        obj.Salary = 80000

        obj2 = obj                                          ' Assigning the vlaues in the object of the Overriding class to the Overridable Class

        obj2.Print()                                        ' Calling the Overrided Function through that class's object

        ReadLine()

    End Sub

End Module
