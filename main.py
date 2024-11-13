import time
import os
import sys

b = [
    " x  x x   ",
    "x  x   x  ",
    "  x  x  x ",
    "x x x x   ",
    " x  x  xx ",
    "        x ",
    "    x    ",
    " x        ",
    "        x ",
    " x   x    ",
]


def set_char(s, i, c):
    ls = list(s)
    ls[i] = c
    return ''.join(ls)


def gravity():
    global b
    f = False
    for y in reversed(range(0, len(b) - 1)):
        for x in range(0, len(b[y])):
            if y == len(b) - 1:
                break
            if b[y][x] == ' ':
                continue
            if b[y + 1][x] == ' ':
                b[y + 1] = set_char(b[y + 1], x, b[y][x])
                b[y] = set_char(b[y], x, ' ')
                f = True
    return f


os.system(f'cmd /c "mode con: cols=80 lines=25"')
while True:
    if not gravity():
        break
    sys.stdout.write("\x1b[5;10H")
    for y in b:
        print(y)
    time.sleep(0.5)
