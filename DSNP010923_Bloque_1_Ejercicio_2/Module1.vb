Module Module1

    Sub Main(args As String())


        Dim bandera As Boolean
        bandera = True
        Dim seleccion As String

        While (bandera = True)

            Dim Num As Integer


            Console.WriteLine("Ingrese un numero")
            Num = Console.ReadLine()


            If (Num >= 0) Then
                Console.WriteLine("Es positivo")
            Else
                Console.WriteLine("Es negativo")

            End If

            Console.WriteLine("Desea evaluar otra edad?  Presione Y para continuar o cualquier otra tecla para salir")
            seleccion = Console.ReadLine()
            If (seleccion = "Y" Or seleccion = "y") Then
                bandera = True
            Else
                bandera = False 'Para salir del while externo
            End If
            Console.Clear()
        End While

    End Sub

End Module
