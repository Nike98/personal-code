# Description: Simple Text-based "Space Adventure Game

import random
import time


def display_intro():
    print("\n\nIt is the end of a long year of fighting Space Criminals.")
    time.sleep(2)
    print("You come to a crossroads on your trip home,")
    time.sleep(2)
    print("one path leads home where you will be handsomely")
    time.sleep(2)
    print("rewarded for a job well done,")
    time.sleep(2)
    print("and the other leads through a gamma ray burst")
    time.sleep(2)
    print("that will disintegrate you.\n")
    time.sleep(2)


def choosePath():
    path = ""
    while path != "1" and path != "2":
        path = input("Which path do you choose? (1 or 2): ")

    return path


def checkPath(chosenPath):
    print("\nYou head down the path")
    time.sleep(3)
    print("There is an Asteroid nearby that looks familiar, that must be a good sign...")
    time.sleep(2)
    print("But your skin begins to tingle...\n")
    time.sleep(5)

    correctPath = random.randint(1, 2)

    if chosenPath == str(correctPath):
        print("""
        
That tingling was just the feeling of admiration
from the citizens of the Galaxy!
        """)
        time.sleep(3)
        print("Welcome Home!\n")
    else:
        print("""
        
An extremely energetic burst of Gamma rays passes through you
causing all of the atoms in your body to dissociate.
There is no record left of your existence.

        """)


playAgain = "yes"
while playAgain == "yes" or playAgain == "y":
    display_intro()
    choice = choosePath()
    checkPath(choice)
    playAgain = input("Do you want to play again? (Type yes or y to continue): ").lower()
