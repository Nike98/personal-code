Imports System.Console

Module Module1

    Sub Main()
        Dim pie As Double = 3.1428571428571428
        Dim radius, length, width, base, height, triSide(3), sqSide As Double

        WriteLine(" ********** INPUT THE VALUES **********" & vbCrLf)

        WriteLine(vbCrLf & " ***** SQUARE *****")
        Write(" Enter the side of the Square : ")
        sqSide = Double.Parse(ReadLine())

        WriteLine(vbCrLf & " ***** RECTANGLE *****" & vbCrLf)
        Write(" Enter the Length of the Rectangle : ")
        length = Double.Parse(ReadLine())
        Write(" Enter the Width of the Rectangle : ")
        width = Double.Parse(ReadLine())

        WriteLine(vbCrLf & " ***** CIRCLE *****" & vbCrLf)
        Write(" Enter the Radius of the Circle : ")
        radius = Double.Parse(ReadLine())

        WriteLine(vbCrLf & " ***** TRIANGLE *****" & vbCrLf)
        Write(" Enter the Base of the Triangle : ")
        base = Double.Parse(ReadLine())
        Write(" Enter the Height of the Triangle : ")
        height = Double.Parse(ReadLine())

        Write(vbCrLf & " Enter the 1st Side of the Triangle : ")
        triSide(1) = Double.Parse(ReadLine())
        Write(" Enter the 2nd Side of the Triangle : ")
        triSide(2) = Double.Parse(ReadLine())
        Write(" Enter the 3rd Side of the Triangle : ")
        triSide(3) = Double.Parse(ReadLine())


        ' Displaying Area of all the shapes

        Dim arSquare, arRectangle, arCircle, arTriangle As Double

        WriteLine(vbCrLf & " ********** AREA OF ALL THE SHAPES **********" & vbCrLf)

        WriteLine(" ***** SQUARE *****")
        arSquare = Math.Pow(sqSide, 2)
        Write(vbCrLf & " The Area of the Square = " & arSquare)

        WriteLine(vbCrLf & " ***** RECTANGLE *****" & vbCrLf)
        arRectangle = length * width
        Write(vbCrLf & " The Area of the Reactangle = " & arRectangle)

        WriteLine(vbCrLf & " ***** CIRCLE *****" & vbCrLf)
        arCircle = pie * Math.Pow(radius, 2)
        Write(vbCrLf & " The Area of the Circle = " & arCircle)

        WriteLine(vbCrLf & " ***** TRIANGLE *****" & vbCrLf)
        arTriangle = (0.5 * base) / height
        Write(vbCrLf & " The Are of the Triangle = " & arTriangle)

        ' Displaying the Perimeter of all the shapes

        Dim periSquare, periRectangle, periCircle, periTriangle As Double

        WriteLine(vbCrLf & " ********** PERIMETER OF ALL THE SHAPES **********" & vbCrLf)

        WriteLine(" ***** SQUARE ***** ")
        periSquare = 4 * sqSide
        Write(vbCrLf & " The Perimeter of the Square = " & periSquare)

        WriteLine(" ***** RECTANGLE ***** ")
        periRectangle = 2 * (length + width)
        Write(vbCrLf & " The Perimeter of the Rectangle = " & periRectangle)

        WriteLine(" ***** CIRCLE ***** ")
        periCircle = 2 * (pie * radius)
        Write(vbCrLf & " The Perimeter of the Circle = " & periCircle)

        WriteLine(" ***** TRIANGLE ***** ")
        periTriangle = triSide(1) + triSide(2) + triSide(3)
        Write(vbCrLf & " The Perimeter of the Triangle = " & periTriangle)

        ReadLine()
    End Sub

End Module
