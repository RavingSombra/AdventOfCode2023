file = open("day1-input.txt", "r")

sum = 0

for line in file.readlines():
    i = 0
    while i <= len(line):
        og_len = len(line)
        if("one" in line[0:i]):
            line = line.replace("one", "o1e")
            i = 0
            continue
        elif("two" in line[0:i]):
            line = line.replace("two", "t2o")
            i = 0
            continue
        elif("three" in line[0:i]):
            line = line.replace("three", "t3e")
            i = 0
            continue
        elif("four" in line[0:i]):
            line = line.replace("four", "f4r")
            i = 0
            continue
        elif("five" in line[0:i]):
            line = line.replace("five", "f5e")
            i = 0
            continue
        elif("six" in line[0:i]):
            line = line.replace("six", "s6x")
            i = 0
            continue
        elif("seven" in line[0:i]):
            line = line.replace("seven", "s7n")
            i = 0
            continue
        elif("eight" in line[0:i]):
            line = line.replace("eight", "e8t")
            i = 0
            continue
        elif("nine" in line[0:i]):
            line = line.replace("nine", "n9e")
            i = 0
            continue
        i+=1
    line = [char for char in line if char.isdigit()]
    sum += int(line[0] + line[-1])

print("Total:", sum)