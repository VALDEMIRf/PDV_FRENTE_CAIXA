﻿Imports System.Data.SqlClient
Module mdlConexao
    ' Public con As New SqlConnection("Data Source=DESKTOP-9357516;Initial Catalog=sistemavb;Integrated Security=True")
    Public con As New SqlConnection("Data Source=DESKTOP-R5VHKNO\SQLEXPRESS;Initial Catalog=frente_caixa;Integrated Security=True")

    Sub abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub

    Public usuarioNome As String

    Public idempresa As String

End Module
