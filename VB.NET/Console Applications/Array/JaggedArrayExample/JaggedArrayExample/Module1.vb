Imports System.Console

Module Module1

    Sub Main()
        Dim a As Integer()() = New Integer(10)() {}
        a(0) = New Integer() {0, 0, 1}
        a(1) = New Integer() {1, 2, 1}
        a(2) = New Integer() {2, 4, 1}
        a(3) = New Integer() {3, 6, 1}
        a(4) = New Integer() {4, 8, 1}
        a(5) = New Integer() {0, 0, 1}
        a(6) = New Integer() {1, 2, 1}
        a(7) = New Integer() {2, 4, 1}
        a(8) = New Integer() {3, 6, 1}
        a(9) = New Integer() {4, 8, 1}
        a(10) = New Integer() {0, 0, 1}

        Dim i, j As Integer

        For i = 0 To 10
            For j = 0 To 2
                WriteLine("a[{0},{1}] = {2}", i, j, a(i)(j))
            Next j
        Next i

        ReadLine()

    End Sub

End Module
