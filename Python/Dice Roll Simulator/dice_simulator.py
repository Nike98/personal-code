import random

# Loop to allow continuous roll
while True:
    dice1 = random.randint(1,6)
    dice2 = random.randint(1,6)

    print('\nDice 1 -> ', dice1)
    print("Dice 2 -> ", dice2)
    print("The sum of both the dice: ", (dice1 + dice2))

    # Check for doubles
    if dice1 == dice2:
        print("Doubles! Roll again!")

    input('\n> Press Enter to roll again...')