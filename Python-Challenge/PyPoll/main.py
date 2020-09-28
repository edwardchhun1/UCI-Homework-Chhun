import os
import csv

csvpath = os.path.join("..", "..", "..", "..", "..", "Desktop", "PyPoll.csv")

# Creating list variables for storing results
total_votes = []
unique_candidates = []
vote_count_candidates = []

#open csv 
with open(csvpath) as pollcount:
    csvreader = csv.reader(pollcount, delimiter=',')

    #Skip header as part of count
    csv_header = next(csvreader)
    
    # Reading row by row for results
    for row in csv.reader(pollcount):
    
    #Total Months Calculation
        total_votes.append(row[0])

    print("Election Results")
    print("----------------------")
    print(f"Total Votes: {len(total_votes)}")
    print("----------------------")
    print("----------------------")
    print("----------------------")