Imports System

Module Program

    Sub Main()
        Dim ans As String = ""
        Dim i As Integer = 0

        While ans.ToLower <> "n"

            Console.Write("Input number from 1 to 10 only: ")
            i = Console.ReadLine()

            If i > 10 Then
                Console.WriteLine("Invalid number, must be 1 to 10 only!")
                Console.WriteLine()
            Else
                If i = 1 Then
                    Console.WriteLine("001")
                    Console.WriteLine()
                End If

                If i = 2 Then
                    Console.WriteLine("001 002")
                    Console.WriteLine("002 004")
                    Console.WriteLine()
                End If

                If i = 3 Then
                    Console.WriteLine("001 002 003")
                    Console.WriteLine("002 004 006")
                    Console.WriteLine("003 006 009")
                    Console.WriteLine()
                End If

                If i = 4 Then
                    Console.WriteLine("001 002 003 004")
                    Console.WriteLine("002 004 006 008")
                    Console.WriteLine("003 006 009 012")
                    Console.WriteLine("004 008 012 016")
                    Console.WriteLine()
                End If

                If i = 5 Then
                    Console.WriteLine("001 002 003 004 005")
                    Console.WriteLine("002 004 006 008 010")
                    Console.WriteLine("003 006 009 012 015")
                    Console.WriteLine("004 008 012 016 020")
                    Console.WriteLine("005 010 015 020 025")
                    Console.WriteLine()
                End If

                If i = 6 Then
                    Console.WriteLine("001 002 003 004 005 006")
                    Console.WriteLine("002 004 006 008 010 012")
                    Console.WriteLine("003 006 009 012 015 018")
                    Console.WriteLine("004 008 012 016 020 024")
                    Console.WriteLine("005 010 015 020 025 030")
                    Console.WriteLine("006 012 018 024 030 036")
                    Console.WriteLine()
                End If

                If i = 7 Then
                    Console.WriteLine("001 002 003 004 005 006 007")
                    Console.WriteLine("002 004 006 008 010 012 014")
                    Console.WriteLine("003 006 009 012 015 018 021")
                    Console.WriteLine("004 008 012 016 020 024 028")
                    Console.WriteLine("005 010 015 020 025 030 035")
                    Console.WriteLine("006 012 018 024 030 036 042")
                    Console.WriteLine("007 014 021 028 035 042 049")
                    Console.WriteLine()
                End If

                If i = 8 Then
                    Console.WriteLine("001 002 003 004 005 006 007 008")
                    Console.WriteLine("002 004 006 008 010 012 014 016")
                    Console.WriteLine("003 006 009 012 015 018 021 024")
                    Console.WriteLine("004 008 012 016 020 024 028 032")
                    Console.WriteLine("005 010 015 020 025 030 035 040")
                    Console.WriteLine("006 012 018 024 030 036 042 048")
                    Console.WriteLine("007 014 021 028 035 042 049 056")
                    Console.WriteLine("008 016 024 032 040 048 056 064")
                    Console.WriteLine()
                End If

                If i = 9 Then
                    Console.WriteLine("001 002 003 004 005 006 007 008 009")
                    Console.WriteLine("002 004 006 008 010 012 014 016 018")
                    Console.WriteLine("003 006 009 012 015 018 021 024 027")
                    Console.WriteLine("004 008 012 016 020 024 028 032 036")
                    Console.WriteLine("005 010 015 020 025 030 035 040 045")
                    Console.WriteLine("006 012 018 024 030 036 042 048 054")
                    Console.WriteLine("007 014 021 028 035 042 049 056 063")
                    Console.WriteLine("008 016 024 032 040 048 056 064 072")
                    Console.WriteLine("009 018 027 036 045 054 063 072 081")
                    Console.WriteLine()
                End If

                If i = 10 Then
                    Console.WriteLine("001 002 003 004 005 006 007 008 009 010")
                    Console.WriteLine("002 004 006 008 010 012 014 016 018 020")
                    Console.WriteLine("003 006 009 012 015 018 021 024 027 030")
                    Console.WriteLine("004 008 012 016 020 024 028 032 036 040")
                    Console.WriteLine("005 010 015 020 025 030 035 040 045 050")
                    Console.WriteLine("006 012 018 024 030 036 042 048 054 060")
                    Console.WriteLine("007 014 021 028 035 042 049 056 063 070")
                    Console.WriteLine("008 016 024 032 040 048 056 064 072 080")
                    Console.WriteLine("009 018 027 036 045 054 063 072 081 090")
                    Console.WriteLine("010 020 030 040 050 060 070 080 090 100")
                    Console.WriteLine()
                End If

            End If

            Console.WriteLine("Do you want to enter number again [Yy/Nn] ")
            ans = Console.ReadLine()

            If ans.ToLower = "n" Then
                Console.WriteLine("Thank you.")
            End If
        End While

        Console.ReadLine()

    End Sub

End Module
