Sub StockMarket():

For Each ws In Worksheets

    ' Insert Header Values
    ws.Range("I1").Value = "Ticker"
    ws.Range("J1").Value = "Yearly Change"
    ws.Range("K1").Value = "Percent Change"
    ws.Range("L1").Value = "Total Stock Volume"

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

' ----------------------------------------------------------------------
' Getting the values to be input into the cells

                'Print Ticker Value
                ws.Range("I" & Ticker_Tracker).Value = Ticker_Name

                'Print Yearly Change Value
                ws.Range("J" & Ticker_Tracker).Value = YearlyPriceChange

                'Print Yearly Percent Change
                ws.Range("K" & Ticker_Tracker).Value = Percent_Change

                ' Print Total Volume
                ws.Range("L" & Ticker_Tracker).Value = Total_Volume

                ' Looping again and print for next set of ticker values
                Ticker_Tracker = Ticker_Tracker + 1

                ' Set variable back to 0 for the next tickers
                YearlyPriceChange = 0
                Close_Price = 0
                Open_Price = ws.Cells(i + 1, 3).Value
                Percent_Change = 0
                Total_Volume = 0
            
            End If
        End If
    Next i
Next ws
End Sub


