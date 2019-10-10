'Project: Currency Solution
'Programmer: Alex Volz on 11/10/15
'Purpose: To convert U.S. Dollars to one of eight selectable currencies

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declare constants
        Const decCANA_DOLLAR As Decimal = 0.75
        Const decEURO As Decimal = 1.07
        Const decINDI_RUPEE As Decimal = 0.015
        Const decJAPA_YEN As Decimal = 0.0081
        Const decMEXI_PESO As Decimal = 0.06
        Const decSAFR_RAND As Decimal = 0.07
        Const decBRIT_POUND As Decimal = 1.51
        Const decCHIN_YUAN As Decimal = 0.16

        'Declare Variables
        Dim decUSDollars As Decimal
        Dim decForeignDollars As Decimal

        Decimal.TryParse(txtUSDollars.Text, decUSDollars)

        'Determine foreign currency and covert to U.S. Dollars
        Select Case True
            Case radCanaDollar.Checked
                decForeignDollars = decUSDollars * decCANA_DOLLAR
            Case radEuro.Checked
                decForeignDollars = decUSDollars * decEURO
            Case radIndiRupee.Checked
                decForeignDollars = decUSDollars * decINDI_RUPEE
            Case radJapaYen.Checked
                decForeignDollars = decUSDollars * decJAPA_YEN
            Case radMexiPeso.Checked
                decForeignDollars = decUSDollars * decMEXI_PESO
            Case radSAfrRand.Checked
                decForeignDollars = decUSDollars * decSAFR_RAND
            Case radBritPound.Checked
                decForeignDollars = decUSDollars * decBRIT_POUND
            Case radChinYuan.Checked
                decForeignDollars = decUSDollars * decCHIN_YUAN
        End Select

        'Display results
        lblForeignDollars.Text = decForeignDollars.ToString("C3")

    End Sub
End Class
