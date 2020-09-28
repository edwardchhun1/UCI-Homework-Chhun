import os
import csv

csvpath = os.path.join("..", "..", "..", "..", "..", "Desktop", "PyBank.csv")

#open csv 
with open(csvpath) as bankbudget:
    csvreader = csv.reader(bankbudget, delimiter=',')

    #Skip header as part of count
    csv_header = next(csvreader)


    #setting each variable to 0 
    total_months = 0
    total_net = 0
    


    
    for row in csv.reader(bankbudget):
        #Total Months Calculation
        total_months.append(row[0])

        #Total Profit/Loss Count
        total_net.append(int(row[1]))

