ALL FILES FOR TESTING MUST BE RUN IN VISUAL STUDIO


BACKTRACKING.FSX

Backtracking.fsx is the basic algorithm for solving the sudoku board. To run this F# program, you must 
1. Highlight the entirety of lines 6-12, comments excluded, and hit Alt+Enter. This entails "type pos..." to "...stackStart = [(-1,-1)]".
2. You must then highlight lines 18-126, from "type board..." to "...solvePos b.spaces counter" and hit Alt+Enter twice, as the function is finicky.
3. Load a sudoku game as described under the TESTGAMES.FSX header.
4. Load this game into Backtracking.fsx by highlighting line 128 and hitting Alt+Enter. If you wish to view the original board, you may highlight line 130 and hit Alt+Enter for it to be displayed.
5. To solve the board, highlight line 133 (or 132-134 if you wish to see the timing) and hit Alt+Enter. To have this board printed out, highlight line 136 and hit Alt+Enter.
6. To try a new board out, repeat the process from step 3.

TESTGAMES.FSX

TestGames.fsx contains all 60 of the test games of sudoku. Simply highlight the game you want to load, hit Alt+Enter, and continue with whichever method you were testing.
