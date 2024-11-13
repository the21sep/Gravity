using System.Security.AccessControl;
using System.Threading;

string[] b = [
    " x  x x   ",
    "x  x   x  ",
    "  x  x  x ",
    "x x x x   ",
    " x  x  xx ",
    "        x ",
    "    x     ",
    " x        ",
    "        x ",
    " x   x    "
];

string set_char(string s, int i, char c) {
    char[] ls = s.ToCharArray();
    ls[i] = c;
    s = String.Concat<char>(ls);
    return s;
}

bool gravity() {
    bool f = false;
    for (int y = b.Length - 2; y >= 0; y = y - 1) {
        for (int x = 0; x < b[y].Length; x++) {
            if (b[y][x] == ' ') {
                continue;
            }
            if (b[y + 1][x] == ' ') {
                b[y + 1] = set_char(b[y + 1], x, b[y][x]);
                b[y] = set_char(b[y], x, ' ');
                f = true;
            }
        }
    } 
    return f;
}

while (true) {
    if (!gravity()) {
        break;
    }
    Console.SetCursorPosition(10, 0);
    for (int y = 0; y < b.Length; y++) {
        Console.WriteLine(b[y]);
    }
    Thread.Sleep(300);
    
}   
