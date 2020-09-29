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

    # Calculate average of the changes for this time period
    for i in range(len(total_net)-1):
        #Subtract total changes between any two given months before assigning to a list
        average_change.append(total_net[i+1]-total_net[i])

    # Greatest Increase in Profit (Pull $$$$)
    greatest_increase = max(average_change)

    # Greatest Decrease in Profit (Pull $$$$)
    greatest_decrease = min(average_change)


    # Pulling month that corresponds with greatest increase/decrease
    increase_month = average_change.index(max(average_change)) + 1
    decrease_month = average_change.index(min(average_change)) + 1

    #Print statements
    print("Financial Analysis")
    print("----------------------")
    print(f"Total Months: {len(total_months)}")
    print(f"Total: ${sum(total_net)}")
    print(f"Average Change: {round(sum(average_change)/len(average_change),2)}")
    print(f"Greatest Increase in Profits: {total_months[increase_month]} (${(str(greatest_increase))})") 
    print(f"Greatest Decrease in Profits: {total_months[decrease_month]} (${(str(greatest_decrease))})")

    #Create where summary will be save
    cvspath = os.path.join('Analysis', 'Analysis_Summary.txt')
    with open(cvspath,"w") as file:

    # Outputting to PyBank Analysis folder
        file.write("Financial Analysis")
        file.write("\n") 
        file.write("----------------------")
        file.write("\n")
        file.write(f"Total Months: {len(total_months)}")
        file.write("\n")
        file.write(f"Total: ${sum(total_net)}")
        file.write("\n")
        file.write(f"Average Change: {round(sum(average_change)/len(average_change),2)}")
        file.write("\n")
        file.write(f"Greatest Increase in Profits: {total_months[increase_month]} (${(str(greatest_increase))})") 
        file.write("\n")
        file.write(f"Greatest Decrease in Profits: {total_months[decrease_month]} (${(str(greatest_decrease))})")




