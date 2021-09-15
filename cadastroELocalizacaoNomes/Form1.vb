
Public Class Form1
    'cria o array para armazenar os nomes inseridos pelo usuario
    Dim nomes As New ArrayList

    Private Sub btnIniciarCdstro_Click(sender As Object, e As EventArgs) Handles btnIniciarCadastro.Click
        ' valida se o usuario informou qtd nomes para cadastro maior que 0
        If (numQtdNomes.Value <= 0) Then
            MsgBox("Por favor, informe quantos nomes você deseja cadastrar no sistema.", MsgBoxStyle.Critical, "Atenção!")
            Exit Sub
        End If

        ' se passar validacao, fazer loop para coletar a qtd de nomes informada pelo usuario
        Dim qtdNomes As Integer = numQtdNomes.Value

        For i As Integer = 0 To qtdNomes - 1
            Dim tempVar As String = InputBox("Infome o nome: ", "Preencha os dados")
            nomes.Add(tempVar)
        Next
        MsgBox("Nomes cadastrados com sucesso!", MsgBoxStyle.OkOnly, "Confirmação de cadastro")
    End Sub
  
    Private Sub btnLocalizarNome_Click(sender As Object, e As EventArgs) Handles btnLocalizarNome.Click
        ' cria a variavel para guarda o nome que o usuario deseja buscar no sistema
        Dim nomeBusca As String = txtNomeBusca.Text

        ' valida se um nome foi inserido para a busca
        If (nomeBusca = Nothing Or IsNumeric(nomeBusca)) Then
            MsgBox("Por favor, informe um nome para ser localizado no sistema." & vbCrLf & "Obs: Números não são aceitos. ", MsgBoxStyle.Critical, "Atenção!")
            Exit Sub
        End If

        ' se passar validacao, procura pelo nome no array nomes
        For Each nome As String In nomes
            If nome = nomeBusca Then
                MsgBox("O nome '" & nomeBusca & "' FOI ENCONTRADO no sistema.", MsgBoxStyle.Information, "Resultado:")
                txtNomeBusca.Text = Nothing
                Exit Sub
            End If
        Next
        ' caso o nome nao seja encontrado, exibe msg informando
        MsgBox("O nome '" & nomeBusca & "' NÃO FOI ENCONTRADO no sistema.", MsgBoxStyle.Information, "Resultado:")
        txtNomeBusca.Text = Nothing
        Exit Sub
    End Sub
    End Class
