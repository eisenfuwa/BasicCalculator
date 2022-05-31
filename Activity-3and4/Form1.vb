Public Class Form1
    Dim InitialValue As Double
    Dim SelectedOperator As String

    Private Sub OnNumberClick(btn As Button, e As EventArgs) Handles BtnZero.Click, BtnOne.Click, BtnTwo.Click, BtnThree.Click, BtnFour.Click, BtnFive.Click, BtnSix.Click, BtnSeven.Click, BtnEight.Click, BtnNine.Click, BtnDecimal.Click
		If ViewBox.Text = "0" And btn Is BtnDecimal Then
			ViewBox.Text = "0."
		ElseIf ViewBox.Text = "0" Then
			ViewBox.Text = btn.Text
		Else
			ViewBox.Text += btn.Text
		End If
		
		If SelectedOperator = Nothing Then
			InitialValue = Double.Parse(ViewBox.Text)
		End If
    End Sub
	
	Private Sub OnOperatorClick(opt As Button, e As EventArgs) Handles BtnAdd.Click, BtnSubtract.Click, BtnMultiply.Click, BtnDivide.Click, BtnModulo.Click, BtnExponent.Click, BtnClear.Click
		If opt IsNot BtnClear Then
			SelectedOperator = opt.Text
		ElseIf opt Is BtnClear Then
            InitialValue = Nothing
			SelectedOperator = Nothing
        End If
		ViewBox.Text = "0"
	End Sub
	
	Private Sub OnEqualClick(opt As Button, e As EventArgs) Handles BtnEqual.Click
		If SelectedOperator = "+" Then
			ViewBox.Text = (InitialValue + Double.Parse(ViewBox.Text))
		ElseIf SelectedOperator = "-" Then
			ViewBox.Text = (InitialValue - Double.Parse(ViewBox.Text))
		ElseIf SelectedOperator = "*" Then
			ViewBox.Text = (InitialValue * Double.Parse(ViewBox.Text))
		ElseIf SelectedOperator = "/" Then
			ViewBox.Text = (InitialValue / Double.Parse(ViewBox.Text))
		ElseIf SelectedOperator = "%" Then
			ViewBox.Text = (InitialValue Mod Double.Parse(ViewBox.Text))
		ElseIf SelectedOperator = "xⁿ" Then
			ViewBox.Text = (InitialValue ^ Double.Parse(ViewBox.Text))
		End If
	End Sub
End Class
