# Tic tac Toe Game with AI in Python

"""

    A Simple Tic Tac Toe Game to be played with the AI.

    In tis Game the User is given the symbol of X,
    and the AI is given the O symbol.

"""

board = [' ' for x in range(10)]


def insertLetter(letter, pos):
    global board
    board[pos] = letter


def spaceIsFree(pos):
    return board[pos] == ' '


def printBoard(board):
    # "board" is a list of 10 Strings representing the board (ignore index 0)
    print('     |     |')
    print('  ' + board[1] + '  |  ' + board[2] + '  |  ' + board[3])
    print('     |     |')
    print('-----------------')
    print('     |     |')
    print('  ' + board[4] + '  |  ' + board[5] + '  |  ' + board[6])
    print('     |     |')
    print('-----------------')
    print('     |     |')
    print('  ' + board[7] + '  |  ' + board[8] + '  |  ' + board[9])
    print('     |     |')


def isWinner(bo, le):
    # Given a board and a player's Letter, this function returns True if that player has won.
    # We use bo instead of the board and le instead of letter so we won't have to type as much.
    return (bo[1] == le and bo[2] == le and bo[3] == le) or (bo[4] == le and bo[5] == le and bo[6] == le) or (bo[7] == le and bo[8] == le and bo[9] == le) or (bo[1] == le and bo[4] == le and bo[7] == le) or (bo[2] == le and bo[5] == le and bo[8] == le) or (bo[3] == le and bo[6] == le and bo[9] == le) or (bo[1] == le and bo[5] == le and bo[9] == le) or (bo[3] == le and bo[5] == le and bo[7] == le)


def playerMove():
    run = True
    while run:
        move = input('Please select a position to place an \'X\' (1-9): ')
        try:
            move = int(move)
            if move > 0 and move < 10:
                if spaceIsFree(move):
                    run = False
                    insertLetter('X', move)
                else:
                    print('Sorry, this place is occupied!')
            else:
                print('Please type a number within the range!')
        except:
            print('Please type a number!')


def compMove():
    possibleMoves = [x for x, letter in enumerate(board) if letter == ' ' and x != 0]
    cornersOpen = []
    edgesOpen = []
    move = 0

    # Check for possible winning move to take or to block opponents winning move
    for lett in ['O', 'X']:
        for i in possibleMoves:
            boardCopy = board[:]
            boardCopy[i] = lett
            if isWinner(boardCopy, lett):
                move = i
                return move

    # Try to take one of the corners
    for i in possibleMoves:
        if i in [1, 3, 7, 9]:
            cornersOpen.append(i)

    # Try to take the center
    if len(cornersOpen) > 0:
        move = selectRandom(cornersOpen)
        return move

    if 5 in possibleMoves:
        move = 5
        return move

    for i in possibleMoves:
        if i in [2, 4, 6, 8]:
            edgesOpen.append(i)

    # Take any edge
    if len(edgesOpen) > 0:
        move = selectRandom(edgesOpen)

    return move


def selectRandom(list):
    import random
    length = len(list)
    rand = random.randrange(0, length)
    return list[rand]


def isBoardFull(board):
    if board.count(' ') > 1:
        return False
    else:
        return True


def main():
    # Main game loop
    print('Welcome to Tic Tac Toe, to win complete a straight line of your letter (Diagonal, Horizontal, Vertical). '
          'The board has positions 1-9 starting at the top left.')
    printBoard(board)

    while not(isBoardFull(board)):
        if not(isWinner(board, 'O')):
            playerMove()
            printBoard(board)
        else:
            print('Sorry, O\'s won this time!')
            break

        if not(isWinner(board, 'X')):
            move = compMove()
            if move == 0:
                print('Tie Game! No more spaces left to move.')
            else:
                insertLetter('O', move)
                print('Computer placed and \'O\' in position ', move, ':')
                printBoard(board)
        else:
            print('X\'s won this time! Good Job!')
            break

    if isBoardFull(board):
        print('Game Tied!')


main()

while True:
    answer = input('Do you want to play again? (Y/N)').lower()
    if answer == 'y' or answer == 'n':
        board = [' ' for x in range(10)]
        print('------------------------------------------------------------------')
        main()
    else:
        break
