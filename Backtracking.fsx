(*  Quentin Lee
    Tom Miksch
    AI Sudoku Project
    11 May 2018
*)
type pos = int * int    //Position on the sudoku board

type space = int        //Individual space on the board

let sps = Map.empty     //Declare spaces

let stackStart = [(-1,-1)]  //Stack declaration

//The board and its functions
//Value, ToString, and Print borrowed from hw2Asol.fsx,
//then edited to make a sudoku board
//Thank you very much!
type board = {size: int; spaces: Map<pos, space>}
with
    member b.Value (p: pos) =
        match Map.tryFind p b.spaces with
        | None -> 0
        | Some v -> v

    member b.ToString =
        let cellToString tiles r c = 
          match Map.tryFind (r,c) tiles with
          | None -> if (c = 3 || c = 6)
                        then "   |"
                    else if ((r = 3 || r = 6) && c = 9)
                        then "   |\n +-" + (String.replicate b.size "--") + "----" + "+"
                    else "  "
          | Some (n:space) -> if ((r = 3 || r = 6) && c = 9) 
                                then " " + string n + " |\n +-" + (String.replicate b.size "--") + "----" + "+"
                              else if (c = 3 || c = 6)
                                then " " + string n + " |"
                              else " " + string n
        in
        let rec rowToString tiles r c = 
          if c <= 0 then ""
          else (rowToString tiles r (c - 1)) + (cellToString tiles r c)
        in
        let rec rowsToString tiles r c = 
          if r <= 0 then ""
          else if (r = 3 || r = 6) then (rowsToString tiles (r - 1) c) + " |" +
               (rowToString tiles r c) + " \n"
          else (rowsToString tiles (r - 1) c) +
               " |" + (rowToString tiles r c) + " |\n"
        in
        let bar =  " +" + (String.replicate b.size "--") + "----" + "-+\n"
        in
          "\n" + bar + (rowsToString b.spaces b.size b.size) + bar
        
  // method 'Print' prints the board to the standard output channel
    member b.Print = printf "%s" b.ToString

    //Method to solve the sudoku board
    member b.Solve (counter: int)= 

        //Checks whether or not a number is viable in a given space
        //Takes in a position, the value, and the board
        let rec checkNumber ((x,y): pos) (n: space) (sp: Map<pos, space>) =
            
            let checkRow = //Loop through the rows to find matching numbers
                let rec loop i =
                    try
                        if i = 10 then true
                        else if Map.find (x,i) sp = n then false
                        else loop (i + 1)
                    with
                        :? System.Collections.Generic.KeyNotFoundException -> loop (i + 1)  //Handles empty spaces
                loop 1

            let checkColumn = //Loop through the columns to find matching numbers
                let rec loop i =
                    try
                        if i = 10 then true
                        else if Map.find (i,y) sp = n then false
                        else loop (i + 1)
                    with
                        :? System.Collections.Generic.KeyNotFoundException -> loop (i + 1)  //Handles empty spaces
                loop 1

            let checkSquare = //Loop through the square
                let x1 = (((x-1)/3) * 3) + 1
                let y1 = (((y-1)/3) * 3) + 1

                let rec loop i j =
                    try
                        if (i > x1 + 2) then true
                        else if j > y1 + 2 then loop (i + 1) y1
                        else if Map.find (i,j) sp = n then false
                        else loop i (j + 1)
                    with
                        :? System.Collections.Generic.KeyNotFoundException -> loop i (j + 1)  //Handles empty spaces
                loop x1 y1

            checkRow && checkColumn && checkSquare  //Returns true if all work

        //Function to solve the board.
        //Takes in a board, the number to control the position on the board,
        //the number to be checked, and a list used to go back when errors
        //are encountered
        let rec solvePos (sp: Map<pos, space>) position number (stack: (int * int) list) =
            let x = (position/9) + 1  //Rows
            let y = (position%9) + 1  //Columns

            if position = 81 then {size = b.size; spaces = sp}
            else if sp.ContainsKey(x,y) then solvePos sp (position + 1) 1 stack
            else
                let validCheck n = checkNumber (x,y) n sp
                let rec solveCurrent n =
                    if n > 9 then let (p,q) = stack.Head
                                  if p = -1 then {size = b.size; spaces = Map.empty}
                                  else
                                      let x1 = (p/9) + 1
                                      let y1 = (p%9) + 1
                                      let stack = stack.Tail
                                      let sp = sp.Remove(x1,y1)
                                      solvePos sp p (q + 1) stack
                    else if validCheck n then let stack = (position,n) :: stack
                                              solvePos (sp.Add((x,y), n)) (position + 1) 1 stack
                    else solveCurrent (n + 1)
                solveCurrent number

        solvePos b.spaces counter

let initialBoard = {size = 9; spaces = sps}

initialBoard.Print

#time
let finalBoard = initialBoard.Solve 0 1 stackStart
#time

finalBoard.Print