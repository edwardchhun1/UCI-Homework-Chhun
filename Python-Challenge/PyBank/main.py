import os
import csv

csvpath = os.path.join("..", "..", "..", "..", "..", "Desktop", "PyBank.csv")

#Creating list variables for storing results - not setting to 0 anymore
    total_months = []
    total_net = []
    average_change = []

#open csv 
with open(csvpath) as bankbudget:
    csvreader = csv.reader(bankbudget, delimiter=',')

    #Skip header as part of count
    csv_header = next(csvreader)
    
    # Reading row by row for results
    for row in csv.reader(bankbudget):
       
        #Total Months Calculation
        total_months.append(row[0])

        #Total Profit/Loss Count
        total_net.append(int(row[1]))

