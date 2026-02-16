weight = float(input())
num = int(input())
float relativeWeight;

if num == 1:
  relativeWeight = 0.38
elif num == 2:
  relativeWeight = 0.91
elif num == 3:
  relativeWeight = 0.38
elif num == 4:
  relativeWeight = 2.53
elif num == 5:
  relativeWeight = 1.07
elif num == 6:
  relativeWeight = 0.89
elif num == 7:
  relativeWeight = 1.14
else:
  print("Invalid")

destinationWeight = weight * relativeWeight
print(destinationWeight)