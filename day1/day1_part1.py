file = open("day1-input.txt", "r")

sum = 0

for line in file.readlines():
    line = [char for char in line if char.isdigit()]
    sum += int(line[0] + line[-1])

print("Total:", sum)