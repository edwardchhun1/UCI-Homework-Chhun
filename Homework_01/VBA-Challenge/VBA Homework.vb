Sub StockMarket():

For Each ws In Worksheets

    ' Insert Header Values
    ws.Range("I1").Value = "Ticker"
    ws.Range("J1").Value = "Yearly Change"
    ws.Range("K1").Value = "Percent Change"
    ws.Range("L1").Value = "Total Stock Volume"
    
    ' Bonus header/field declaration
    ws.Range("N2").Value = "Greatest % Increase"
    ws.Range("N3").Value = "Greatest % Decrease"
    ws.Range("N4").Value = "Greatest Total Volume"
    ws.Range("O1").Value = "Ticker"
    ws.Range("P1").Value = "Value"

' Assigning variables
    Dim i As Long

    ' Declare Ticker Name
    Dim Ticker_Name As String

    'Initial Open Price
    Dim Open_Price As Double
    
    ' Year end Close Price
    Dim Close_Price As Double
       
    ' Total Volume
    Dim Total_Volume As Double
       
    ' Year price change variables
    Dim YearlyPriceChange As Double
   
    ' Year price change percent
    Dim Percent_Change As Double
    
    ' Set variables to 0 -- Doing math need to declare 0 first
    Open_Price = 0
    Close_Price = 0
    Total_Volume = 0
    YearlyPriceChange = 0
    Percent_Change = 0

' Begin Calculations and For Loop

    ' Generate results starting on Row 2 for each unique Ticker Value
    Dim Ticker_Tracker As Long
    Ticker_Tracker = 2

    ' Gather data through the last row
    Dim lastrow As Long
    lastrow = ws.Cells(Rows.Count, 1).End(xlUp).Row

        ' Initializing the very first open price
        Open_Price = ws.Cells(2, 3).Value

        ' Begin for loop
        For i = 2 To lastrow
    
            ' Cycle through the ticker values and retain the value when unique value changes
            If ws.Cells(i + 1, 1).Value <> ws.Cells(i, 1).Value Then
        
                ' when the +1 value is not the same take the previous ticker value
                Ticker_Name = ws.Cells(i, 1).Value

                ' Calculate the YearlyPriceChange
                Close_Price = ws.Cells(i, 6).Value
                YearlyPriceChange = Close_Price - Open_Price
            
                ' Calculate the Percent_Change
                If Open_Price <> 0 Then
                    Percent_Change = (YearlyPriceChange / Open_Price) * 100

                ' Calculating total volume for given ticker
                Total_Volume = Total_Volume + ws.Cells(i, 7).Value
                'when 2nd and 3rd have the same ticker value = add
                ' should be an else statement as well - if they do match we need to continue adding for accumulated 'A' ticker
                
' ----------------------------------------------------------------------
' Getting the values to be input into the cells

                'Print Ticker Value
                ws.Range("I" & Ticker_Tracker).Value = Ticker_Name

                'Print Yearly Change Value
                ws.Range("J" & Ticker_Tracker).Value = YearlyPriceChange

                'Print Yearly Percent Change and setting value to two decimals & % symbol
                ws.Range("K" & Ticker_Tracker).Value = (Str(Percent_Change) & "%")
             
                ' Print Total Volume
                ws.Range("L" & Ticker_Tracker).Value = Total_Volume

                ' Looping again and print for next set of ticker values
                Ticker_Tracker = Ticker_Tracker + 1

                ' Set variable back to 0 for the next tickers - open price is picking up the next open price in the series
                YearlyPriceChange = 0
                Close_Price = 0
                Open_Price = ws.Cells(i + 1, 3).Value
                Percent_Change = 0
                Total_Volume = 0
            
            End If

        Else
            Total_Volume = Total_Volume + ws.Cells(i, 7).Value
        End If

    Next i

' CHALLENGE CALCULATION AND VARIABLE ASSIGNMENTS
    ' Declaring values for your min and max values
    ' Also inserting the scan thru last row
    Dim GreatestIncrease As Double
    Dim GreatestDecrease As Double
    Dim IncreaseTicker As String
    Dim DecreaseTicker As String
    Dim GreatestVolume As Double
    Dim VolumeTicker As String

    Dim PercentLastRow As Long
        PercentLastRow = ws.Cells(Rows.Count, 11).End(xlUp).Row

    ' Set Increase and Decrease Value to 0
    GreatestIncrease = 0
    GreatestDecrease = 0

    ' Begin for loop
        For i = 2 To PercentLastRow

' Begin Conditional Calculations

    'Calculating the Greatest Increase
    ' Greatest Increase starts at 0 , condition states as it loops if new value is greater than the stored value in Greatest Increase that is your new PercentLoop value
    If GreatestIncrease < ws.Cells(i, 11).Value Then
        GreatestIncrease = ws.Cells(i, 11).Value
                
        ' Print the ticker value found during Greatest Increase
        ws.Range("O2").Value = ws.Cells(i, 9).Value

         ' Print the highest % increase found in Greatest Increase
        ws.Range("P2").Value = (Str(GreatestIncrease * 100) & "%")
     
    ' Adding Greatest Decrease conditionals
    ' Greatest Decrease starts at 0 , condition states as it loops if new value is LESS than the stored value in GreaterDecrease that is your new PercentLoop value
    ' 0 starting point. 0 is > -1 ... - 1 is now PercentCellLoop.
    ElseIf GreatestDecrease > ws.Cells(i, 11).Value Then
    GreatestDecrease = ws.Cells(i, 11).Value
        
        ' Print the ticker value found during PercentCellLoop
        ws.Range("O3").Value = ws.Cells(i, 9).Value

        ' Print the lowest % decrease found in PercentCellLoop
        ws.Range("P3").Value = (Str(GreatestDecrease * 100) & "%")
    
    End If

        Next i 
' 
    Dim VolumeLastRow As Long
        VolumeLastRow = ws.Cells(Rows.Count, 12).End(xlUp).Row

    ' Set Increase and Decrease Value to 0
    GreatestVolume = 0
   
    ' Begin for loop
        For i = 2 To VolumeLastRow


    If GreatestVolume < ws.Cells(i, 12).Value Then
        GreatestVolume = ws.Cells(i, 12).Value
                
        ' Print the ticker value found during Greatest Volume Search
        ws.Range("O4").Value = ws.Cells(i, 9).Value

        ' Print the highest volume found in Greatest Volume Search
        ws.Range("P4").Value = (GreatestVolume)

'Adding Color for Conditional Formatting
If ws.Cells(i, 10).Value >= 0 Then
ws.Cells(i, 10).Interior.ColorIndex = 4
        
'Adding Red for negative values
ElseIf ws.Cells(i, 10).Value < 0 Then
ws.Cells(i, 10).Interior.ColorIndex = 3

End If

Next i
Next ws

End Sub





