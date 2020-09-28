import os
import csv

csvpath = os.path.join("..", "..", "..", "..", "..", "Desktop", "PyPoll.csv")

# Creating list variables for storing results
total_votes = 0
unique_candidates = []
vote_count = []

#open csv 
with open(csvpath) as pollcount:
    csvreader = csv.reader(pollcount, delimiter=',')

    #Skip header as part of count
    csv_header = next(csvreader)
    
    # Reading row by row for results
    for row in csv.reader(pollcount):
    
    #Total Votes Calculation
        total_votes += 1

    #Unique Candidates and totals for each candidate - Row 2 = utilize column 3
        candidates = (row[2])
       
        # indexing/storing unique candidates in list - each time unique value shows up add 1 to vote count
        if candidates in unique_candidates:
            candidate_index = unique_candidates.index(candidates)
            vote_count[candidate_index] = vote_count[candidate_index] + 1
        else:
            unique_candidates.append(candidates)
            vote_count.append(1)

percent = []
max_votes = vote_count[0]
max_index = 0

for i in range(len(unique_candidates)):
    #calculating percentage - i to continue looping
    vote_percentage = round(vote_count[i]/total_votes*100, 2)
    percent.append(vote_percentage)


#declaring winner variable
election_winner = unique_candidates[max_index]

#Print Output
print("Election Results")
print("----------------------")
print(f"Total Votes: {total_votes}")
print("----------------------")
#printing loop results for candidates
for i in range(len(unique_candidates)):
    print(f"{unique_candidates[i]} : {percent[i]}% ({vote_count[i]})")
print("----------------------")
print(f"Winner: {election_winner}")
print("----------------------")