import random
import pygame
import tkinter as tk
from tkinter import messagebox


class cube(object):
    rows = 20
    width = 500

    def __init__(self, start, dirnX=1, dirnY=0, color=(255, 0, 0)):
        self.pos = start
        self.dirnX = 1
        self.dirnY = 0
        self.color = color

    def move(self, dirnX, dirnY):
        self.dirnX = dirnX
        self.dirnY = dirnY
        self.pos = (self.pos[0] + self.dirnX, self.pos[1] + self.dirnY)     # Change the position

    def draw(self, surface, eyes=False):
        dis = self.width // self.rows   # Width and Height of each cube
        i = self.pos[0]     # Current row
        j = self.pos[1]     # Current column

        pygame.draw.rect(surface, self.color, (i * dis + 1, j * dis + 1, dis - 2, dis - 2))
        # By multiplying the value of the row and column of the cube with the
        # Width and Height of each cube we can determine where to draw it.

        if eyes:    # Draw the Eyes
            center = dis // 2
            radius = 3
            circleMiddle = (i * dis + center - radius, j * dis + 8)
            circleMiddle2 = (i * dis + dis - radius * 2, j * dis + 8)
            pygame.draw.circle(surface, (0, 0, 0), circleMiddle, radius)
            pygame.draw.circle(surface, (0, 0, 0), circleMiddle2, radius)


class snake(object):
    body = []
    turns = {}

    def __init__(self, color, pos):
        self.color = color
        self.head = cube(pos)   # The Head at the front of the Snake
        self.body.append(self.head)     # Add the Head (which will be a Cube object) to the body list

        # Represents the direction in which the Snake is moving
        self.dirnX = 0
        self.dirnY = 1

    def move(self):
        for event in pygame.event.get():
            if event.type == pygame.QUIT:   # Check if User hit the Quit (X) Button
                pygame.quit()

            keys = pygame.key.get_pressed()     # Check which Key was pressed

            for key in keys:    # Loop through all the Keys
                if keys[pygame.K_LEFT]:
                    self.dirnX = -1
                    self.dirnY = 0
                    self.turns[self.head.pos[:]] = [self.dirnX, self.dirnY]

                elif keys[pygame.K_RIGHT]:
                    self.dirnX = 1
                    self.dirnY = 0
                    self.turns[self.head.pos[:]] = [self.dirnX, self.dirnY]

                elif keys[pygame.K_UP]:
                    self.dirnX = 0
                    self.dirnY = -1
                    self.turns[self.head.pos[:]] = [self.dirnX, self.dirnY]

                elif keys[pygame.K_DOWN]:
                    self.dirnX = 0
                    self.dirnY = 1
                    self.turns[self.head.pos[:]] = [self.dirnX, self.dirnY]

            for i, c in enumerate(self.body):   # Loop through each cube in the body
                p = c.pos[:]    # Stores the position of the cube on the grid
                if p in self.turns:     # If the cube's position is one where we turned,
                    turn = self.turns[p]    # Get the direction where we turned
                    c.move(turn[0], turn[1])    # Move our cube in that Direction
                    if i == len(self.body) - 1: # If this is the last cube in our body,
                        # remove the turn from our dictionary
                        self.turns.pop(p)

                else:
                    # If we are not turning the cube,
                    # And if the cube reaches the edge of the Screen,
                    # make it appear on the opposite side
                    if c.dirnX == -1 and c.pos[0] <= 0:
                        c.pos = (c.rows - 1, c.pos[1])
                    elif c.dirnX == 1 and c.pos[0] >= c.rows - 1:
                        c.pos = (0, c.pos[1])
                    elif c.dirnY == 1 and c.pos[1] >= c.rows - 1:
                        c.pos = (c.pos[0], 0)
                    elif c.dirnY == -1 and c.pos[1] <= 0:
                        c.pos = (c.pos[0], c.rows - 1)
                    else:   # If we haven't reached the edge, move it in our current direction
                        c.move(c.dirnX, c.dirnY)

    def reset(self, pos):
        self.head = cube(pos)
        self.body = []
        self.body.append(self.head)
        self.turns = {}
        self.dirnX = 0
        self.dirnY = 1

    def addCube(self):
        tail = self.body[-1]
        dx, dy = tail.dirnX, tail.dirnY

        # We need to know which side of the Snake to add the cube to.
        # So we check the direction we are currently moving in to determine if we
        # need to add the cube to the left, right, above or below.
        if dx == 1 and dy == 0:
            self.body.append(cube((tail.pos[0] - 1, tail.pos[1])))
        elif dx == -1 and dy == 0:
            self.body.append(cube((tail.pos[0] + 1, tail.pos[1])))
        elif dx == 0 and dy == 1:
            self.body.append(cube((tail.pos[0], tail.pos[1] - 1)))
        elif dx == 0 and dy == -1:
            self.body.append(cube((tail.pos[0], tail.pos[1] + 1)))

        # We then set the cube's direction to the direction of the Snake
        self.body[-1].dirnX = dx
        self.body[-1].dirnY = dy

    def draw(self, surface):
        for i, c in enumerate(self.body):
            if i == 0:  # For the first cube in the List, draw Eyes
                c.draw(surface, True)   # Adding the True as an argument will tell it draw Eyes
            else:
                c.draw(surface)     # Otherwise just draw a cube


def drawGrid(w, rows, surface):
    sizeBtwn = w // rows    # Gives the distance between the lines

    x = 0   # Keeps track of the current X
    y = 0   # Kepps track of the current Y
    for i in range(rows):   # Will draw one Vertical and one Horizontal line each loop
        x += sizeBtwn
        y += sizeBtwn

    pygame.draw.line(surface, (255, 255, 255), (x, 0), (x, w))
    pygame.draw.line(surface, (255, 255, 255), (0, y), (w, y))


def redrawWindow(surface):
    global rows, width, s, snack    # Add the Snack to this line
    surface.fill((0, 0, 0))     # Fills the Screen with black background
    s.draw(surface)
    snack.draw(surface)
    drawGrid(width, rows, surface)  # Draws the grid lines on the Screen
    pygame.display.update()     # Updates the Screen


def randomSnack(rows, item):
    positions = item.body   # Get all the positions of all the cubes in our Snake

    while True:     # keep generating random positions until we get a valid one
        x = random.randrange(rows)
        y = random.randrange(rows)
        if len(list(filter(lambda z: z.pos == (x, y), positions))) > 0:
            # This will check if the position generated was occupied by the Snake
            continue
        else:
            break

    return x, y


def message_box(subject, content):
    root = tk.Tk()
    root.attributes("-topmost", True)
    root.withdraw
    messagebox.showinfo(subject, content)
    try:
        root.destroy()
    except:
        pass


def main():
    global width, rows, s, snack
    width = 500     # Width of the Screen
    rows = 20       # Number of Rows

    win = pygame.display.set_mode((width, width))   # Creates the Screen object

    s = snake((255, 0, 0), (10, 10))    # Creates the Snake object

    snack = cube(randomSnack(rows, s), color=(0, 255, 0))   # Creates the Snack for the Snake

    flag = True

    clock = pygame.time.Clock()     # Creates a Clock object

    # Starting the Main Loop
    while flag:
        pygame.time.delay(50)   # This delays the game speed to not run very quickly
        clock.tick(10)          # Ensures the game runs at 10 FPS
        s.move()
        if s.body[0].pos == snack.pos:  # Check if the Head collides with the Snack
            s.addCube()     # Add a new cube to the Snake
            snack = cube(randomSnack(rows, s), color=(0, 255, 0))   # Creates a new Snack

        for x in range(len(s.body)):    # This will check if any of the positions in our body list overlap
            if s.body[x].pos in list(map(lambda z: z.pos, s.body[x + 1:])):
                print('Score: ', len(s.body))
                message_box('You Lost!', 'Play Again...')
                s.reset((10, 10))
                break

        redrawWindow(win)   # To refresh the Screen


main()
