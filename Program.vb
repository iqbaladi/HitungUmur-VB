Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(vbCrLf + "Panjenengan Jenenge Sampean : ")
        Dim nama = Console.ReadLine()

        Console.WriteLine(vbCrLf + "Panjenengan sakniki lair taun : ")
        Dim t = Console.ReadLine()

        Dim x As String

        Dim currentDate = DateTime.Now
        x = 2019 - t
        Console.WriteLine($"{vbCrLf}Hai {nama}, umur anda sekarang {x} Tahun, pada {currentDate:d} jam {currentDate:t}")

        If x < 6 Then
            Console.WriteLine($"{vbCrLf} {nama} Masih dalam keadaan Balita")
        ElseIf x < 14 Then
            Console.WriteLine($"{vbCrLf} {nama} Sudah dalam masa Anak-anak")
        ElseIf x < 19 Then
            Console.WriteLine($"{vbCrLf} {nama} Sudah Remaja Saat Ini")
        ElseIf x < 51 Then
            Console.WriteLine($"{vbCrLf} {nama} Sudah Dewasa Sekarang")
        Else
            Console.WriteLine($"{vbCrLf} {nama} sudah Tua")
        End If
        Console.WriteLine(vbCrLf + "Tekan Enter untuk keluar aplikasi")
        Console.ReadKey(True)
        Console.ReadLine()
    End Sub
End Module
