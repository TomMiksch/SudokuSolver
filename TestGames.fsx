(*Easy Tests*)
//1
let sps =
    Map.empty
    |> Map.add (1,1) 4
    |> Map.add (1,2) 6
    |> Map.add (1,4) 7
    |> Map.add (1,6) 8
    |> Map.add (1,9) 3
    |> Map.add (2,2) 7
    |> Map.add (2,3) 1
    |> Map.add (2,4) 6
    |> Map.add (2,7) 5
    |> Map.add (3,4) 1
    |> Map.add (3,5) 2
    |> Map.add (3,8) 6
    |> Map.add (3,9) 7

    |> Map.add (4,3) 3
    |> Map.add (5,2) 1
    |> Map.add (5,3) 2
    |> Map.add (5,4) 9
    |> Map.add (5,5) 3
    |> Map.add (5,6) 5
    |> Map.add (5,7) 7
    |> Map.add (5,8) 8
    |> Map.add (6,7) 9

    |> Map.add (7,1) 1
    |> Map.add (7,2) 3
    |> Map.add (7,5) 7
    |> Map.add (7,6) 2
    |> Map.add (8,3) 4
    |> Map.add (8,6) 6
    |> Map.add (8,7) 1
    |> Map.add (8,8) 5
    |> Map.add (9,1) 5
    |> Map.add (9,4) 4
    |> Map.add (9,6) 1
    |> Map.add (9,8) 7
    |> Map.add (9,9) 6;;
//2
let sps =
    Map.empty
    |> Map.add (1,1) 7
    |> Map.add (1,6) 8
    |> Map.add (1,8) 9
    |> Map.add (2,1) 3
    |> Map.add (2,5) 9
    |> Map.add (3,1) 9
    |> Map.add (3,6) 3
    |> Map.add (3,7) 6
    |> Map.add (3,9) 2

    |> Map.add (4,2) 9
    |> Map.add (4,3) 5
    |> Map.add (4,4) 2
    |> Map.add (4,7) 3
    |> Map.add (4,9) 7
    |> Map.add (5,1) 1
    |> Map.add (5,2) 8
    |> Map.add (5,4) 3
    |> Map.add (5,5) 6
    |> Map.add (5,6) 5
    |> Map.add (5,8) 2
    |> Map.add (5,9) 9
    |> Map.add (6,1) 4
    |> Map.add (6,3) 2
    |> Map.add (6,6) 9
    |> Map.add (6,7) 8
    |> Map.add (6,8) 5

    |> Map.add (7,1) 5
    |> Map.add (7,3) 6
    |> Map.add (7,4) 8
    |> Map.add (7,9) 4
    |> Map.add (8,5) 1
    |> Map.add (8,9) 8
    |> Map.add (9,2) 7
    |> Map.add (9,4) 4
    |> Map.add (9,9) 1;;
//3
let sps =
    Map.empty
    |> Map.add (1,7) 7
    |> Map.add (2,1) 5
    |> Map.add (2,2) 1
    |> Map.add (2,5) 7
    |> Map.add (2,7) 6
    |> Map.add (2,8) 9
    |> Map.add (3,2) 3
    |> Map.add (3,3) 6
    |> Map.add (3,6) 8
    |> Map.add (3,9) 2

    |> Map.add (4,1) 8
    |> Map.add (4,5) 6
    |> Map.add (4,6) 7
    |> Map.add (4,8) 1
    |> Map.add (4,9) 5
    |> Map.add (5,1) 6
    |> Map.add (5,3) 9
    |> Map.add (5,7) 8
    |> Map.add (5,9) 4
    |> Map.add (6,1) 1
    |> Map.add (6,2) 2
    |> Map.add (6,4) 5
    |> Map.add (6,5) 8
    |> Map.add (6,9) 9

    |> Map.add (7,1) 2
    |> Map.add (7,4) 6
    |> Map.add (7,7) 5
    |> Map.add (7,8) 8
    |> Map.add (8,2) 6
    |> Map.add (8,3) 4
    |> Map.add (8,5) 1
    |> Map.add (8,8) 2
    |> Map.add (8,9) 7
    |> Map.add (9,3) 5;;
//4
let sps =
    Map.empty
    |> Map.add (1,4) 4
    |> Map.add (1,7) 1
    |> Map.add (1,8) 8
    |> Map.add (1,9) 5
    |> Map.add (2,2) 9
    |> Map.add (2,5) 3
    |> Map.add (2,7) 2
    |> Map.add (2,9) 6
    |> Map.add (3,3) 2
    |> Map.add (3,5) 6
    |> Map.add (3,9) 9

    |> Map.add (4,1) 2
    |> Map.add (4,3) 8
    |> Map.add (4,5) 4
    |> Map.add (4,6) 6
    |> Map.add (4,7) 5
    |> Map.add (4,9) 7
    |> Map.add (5,1) 6
    |> Map.add (5,9) 2
    |> Map.add (6,1) 1
    |> Map.add (6,3) 5
    |> Map.add (6,4) 9
    |> Map.add (6,5) 2
    |> Map.add (6,7) 8
    |> Map.add (6,9) 3

    |> Map.add (7,1) 3
    |> Map.add (7,5) 8
    |> Map.add (7,7) 9
    |> Map.add (8,1) 9
    |> Map.add (8,3) 1
    |> Map.add (8,5) 7
    |> Map.add (8,8) 5
    |> Map.add (9,1) 4
    |> Map.add (9,2) 2
    |> Map.add (9,3) 6
    |> Map.add (9,6) 9;;
//5
let sps =
    Map.empty
    |> Map.add (1,2) 3
    |> Map.add (1,3) 4
    |> Map.add (1,5) 7
    |> Map.add (2,2) 7
    |> Map.add (2,6) 8
    |> Map.add (2,7) 4
    |> Map.add (2,8) 3
    |> Map.add (2,9) 1
    |> Map.add (3,1) 1
    |> Map.add (3,5) 6
    |> Map.add (3,6) 4

    |> Map.add (4,3) 5
    |> Map.add (4,4) 9
    |> Map.add (4,5) 1
    |> Map.add (4,8) 8
    |> Map.add (5,1) 7
    |> Map.add (5,3) 2
    |> Map.add (5,7) 1
    |> Map.add (5,9) 6
    |> Map.add (6,2) 8
    |> Map.add (6,5) 4
    |> Map.add (6,6) 2
    |> Map.add (6,7) 9

    |> Map.add (7,4) 7
    |> Map.add (7,5) 5
    |> Map.add (7,9) 2
    |> Map.add (8,1) 9
    |> Map.add (8,2) 5
    |> Map.add (8,3) 7
    |> Map.add (8,4) 8
    |> Map.add (8,8) 6
    |> Map.add (9,5) 3
    |> Map.add (9,7) 7
    |> Map.add (9,8) 1;;
//6
let sps =
    Map.empty
    |> Map.add (1,1) 7
    |> Map.add (1,3) 9
    |> Map.add (1,8) 2
    |> Map.add (2,2) 3
    |> Map.add (2,3) 4
    |> Map.add (2,4) 5
    |> Map.add (2,8) 9
    |> Map.add (2,9) 1
    |> Map.add (3,1) 5
    |> Map.add (3,4) 1
    |> Map.add (3,5) 7

    |> Map.add (4,2) 6
    |> Map.add (4,4) 7
    |> Map.add (4,5) 2
    |> Map.add (4,7) 1
    |> Map.add (4,8) 4
    |> Map.add (4,9) 9
    |> Map.add (5,1) 1
    |> Map.add (5,9) 2
    |> Map.add (6,1) 4
    |> Map.add (6,2) 9
    |> Map.add (6,3) 2
    |> Map.add (6,5) 1
    |> Map.add (6,6) 6
    |> Map.add (6,8) 5

    |> Map.add (7,5) 8
    |> Map.add (7,6) 3
    |> Map.add (7,9) 4
    |> Map.add (8,1) 6
    |> Map.add (8,2) 7
    |> Map.add (8,6) 1
    |> Map.add (8,7) 9
    |> Map.add (8,8) 3
    |> Map.add (9,2) 4
    |> Map.add (9,7) 2
    |> Map.add (9,9) 8;;
//7
let sps =
    Map.empty
    |> Map.add (1,1) 2
    |> Map.add (1,2) 5
    |> Map.add (1,6) 4
    |> Map.add (1,7) 8
    |> Map.add (1,9) 3
    |> Map.add (2,2) 9
    |> Map.add (2,4) 1
    |> Map.add (3,2) 8
    |> Map.add (3,3) 7
    |> Map.add (3,6) 9
    |> Map.add (3,9) 6

    |> Map.add (4,4) 8
    |> Map.add (4,5) 4
    |> Map.add (4,7) 9
    |> Map.add (4,8) 1
    |> Map.add (4,9) 2
    |> Map.add (5,1) 8
    |> Map.add (5,5) 3
    |> Map.add (5,9) 5
    |> Map.add (6,1) 7
    |> Map.add (6,2) 1
    |> Map.add (6,3) 9
    |> Map.add (6,5) 2
    |> Map.add (6,6) 6

    |> Map.add (7,1) 6
    |> Map.add (7,4) 4
    |> Map.add (7,7) 5
    |> Map.add (7,8) 3
    |> Map.add (8,6) 3
    |> Map.add (8,8) 8
    |> Map.add (9,1) 1
    |> Map.add (9,3) 8
    |> Map.add (9,4) 2
    |> Map.add (9,8) 6
    |> Map.add (9,9) 9;;
//8
let sps =
    Map.empty
    |> Map.add (1,1) 2
    |> Map.add (1,3) 4
    |> Map.add (1,5) 7
    |> Map.add (1,6) 6
    |> Map.add (1,7) 5
    |> Map.add (2,1) 8
    |> Map.add (2,3) 1
    |> Map.add (2,4) 2
    |> Map.add (2,6) 3
    |> Map.add (2,7) 7
    |> Map.add (2,9) 6
    |> Map.add (3,3) 7
    |> Map.add (3,4) 8
    |> Map.add (3,7) 4

    |> Map.add (4,1) 7
    |> Map.add (4,3) 2
    |> Map.add (4,4) 3
    |> Map.add (4,5) 1
    |> Map.add (6,5) 8
    |> Map.add (6,6) 4
    |> Map.add (6,7) 3
    |> Map.add (6,9) 2

    |> Map.add (7,3) 8
    |> Map.add (7,6) 1
    |> Map.add (7,7) 6
    |> Map.add (8,1) 5
    |> Map.add (8,3) 6
    |> Map.add (8,4) 9
    |> Map.add (8,6) 7
    |> Map.add (8,7) 1
    |> Map.add (8,9) 3
    |> Map.add (9,3) 9
    |> Map.add (9,4) 6
    |> Map.add (9,5) 3
    |> Map.add (9,7) 2
    |> Map.add (9,9) 5;;
//9
let sps =
    Map.empty
    |> Map.add (1,1) 7
    |> Map.add (1,4) 4
    |> Map.add (1,5) 5
    |> Map.add (1,6) 1
    |> Map.add (1,7) 8
    |> Map.add (1,8) 6
    |> Map.add (2,1) 5
    |> Map.add (2,4) 8
    |> Map.add (2,5) 9
    |> Map.add (2,7) 1
    |> Map.add (2,8) 3
    |> Map.add (3,3) 4
    |> Map.add (3,6) 6

    |> Map.add (4,2) 4
    |> Map.add (4,3) 5
    |> Map.add (4,5) 7
    |> Map.add (4,6) 3
    |> Map.add (5,4) 2
    |> Map.add (5,6) 8
    |> Map.add (6,4) 5
    |> Map.add (6,5) 6
    |> Map.add (6,7) 3
    |> Map.add (6,8) 4

    |> Map.add (7,4) 6
    |> Map.add (7,7) 7
    |> Map.add (8,2) 6
    |> Map.add (8,3) 2
    |> Map.add (8,5) 1
    |> Map.add (8,6) 5
    |> Map.add (8,9) 9
    |> Map.add (9,2) 1
    |> Map.add (9,3) 7
    |> Map.add (9,4) 9
    |> Map.add (9,5) 3
    |> Map.add (9,6) 4
    |> Map.add (9,9) 5;;
//10
let sps =
    Map.empty
    |> Map.add (1,1) 1
    |> Map.add (1,2) 2
    |> Map.add (1,6) 6
    |> Map.add (2,2) 4
    |> Map.add (2,4) 8
    |> Map.add (2,6) 7
    |> Map.add (2,8) 2
    |> Map.add (2,9) 1
    |> Map.add (3,1) 5
    |> Map.add (3,3) 7
    |> Map.add (3,5) 1
    |> Map.add (3,6) 2
    |> Map.add (3,8) 6

    |> Map.add (4,2) 6
    |> Map.add (4,3) 4
    |> Map.add (4,4) 9
    |> Map.add (5,3) 5
    |> Map.add (5,4) 6
    |> Map.add (5,6) 1
    |> Map.add (5,7) 3
    |> Map.add (6,6) 3
    |> Map.add (6,7) 6
    |> Map.add (6,8) 8

    |> Map.add (7,2) 9
    |> Map.add (7,4) 7
    |> Map.add (7,5) 6
    |> Map.add (7,7) 8
    |> Map.add (7,9) 3
    |> Map.add (8,1) 7
    |> Map.add (8,2) 3
    |> Map.add (8,4) 2
    |> Map.add (8,6) 9
    |> Map.add (8,8) 4
    |> Map.add (9,4) 1
    |> Map.add (9,8) 7
    |> Map.add (9,9) 2;;
//11
let sps =
    Map.empty
    |> Map.add (1,3) 9
    |> Map.add (1,5) 6
    |> Map.add (1,6) 8
    |> Map.add (2,1) 6
    |> Map.add (2,2) 3
    |> Map.add (2,4) 5
    |> Map.add (2,5) 2
    |> Map.add (2,6) 7
    |> Map.add (3,2) 8
    |> Map.add (3,6) 9
    |> Map.add (3,7) 6
    |> Map.add (3,9) 4

    |> Map.add (4,2) 9
    |> Map.add (4,5) 4
    |> Map.add (4,7) 8
    |> Map.add (4,8) 7
    |> Map.add (4,9) 6
    |> Map.add (5,2) 7
    |> Map.add (5,8) 4
    |> Map.add (6,1) 4
    |> Map.add (6,2) 5
    |> Map.add (6,3) 2
    |> Map.add (6,5) 7
    |> Map.add (6,8) 9

    |> Map.add (7,1) 2
    |> Map.add (7,3) 3
    |> Map.add (7,4) 7
    |> Map.add (7,8) 1
    |> Map.add (8,4) 6
    |> Map.add (8,5) 9
    |> Map.add (8,6) 2
    |> Map.add (8,8) 3
    |> Map.add (8,9) 7
    |> Map.add (9,4) 1
    |> Map.add (9,5) 5
    |> Map.add (9,7) 2;;
//12
let sps =
    Map.empty
    |> Map.add (1,5) 8
    |> Map.add (1,6) 3
    |> Map.add (1,7) 5
    |> Map.add (2,1) 6
    |> Map.add (2,6) 4
    |> Map.add (2,7) 8
    |> Map.add (2,8) 1
    |> Map.add (2,9) 7
    |> Map.add (3,3) 5
    |> Map.add (3,4) 7
    |> Map.add (3,8) 2

    |> Map.add (4,1) 8
    |> Map.add (4,3) 3
    |> Map.add (4,6) 1
    |> Map.add (4,7) 6
    |> Map.add (4,8) 7
    |> Map.add (4,9) 9
    |> Map.add (5,5) 3
    |> Map.add (6,1) 1
    |> Map.add (6,2) 2
    |> Map.add (6,3) 9
    |> Map.add (6,4) 6
    |> Map.add (6,7) 3
    |> Map.add (6,9) 8

    |> Map.add (7,2) 4
    |> Map.add (7,6) 5
    |> Map.add (7,7) 9
    |> Map.add (8,1) 5
    |> Map.add (8,2) 9
    |> Map.add (8,3) 7
    |> Map.add (8,4) 8
    |> Map.add (8,9) 4
    |> Map.add (9,3) 1
    |> Map.add (9,4) 3
    |> Map.add (9,5) 4;;
//13
let sps =
    Map.empty
    |> Map.add (1,1) 6
    |> Map.add (1,6) 1
    |> Map.add (1,7) 5
    |> Map.add (2,1) 8
    |> Map.add (2,2) 7
    |> Map.add (2,3) 5
    |> Map.add (2,6) 9
    |> Map.add (2,8) 6
    |> Map.add (3,1) 9
    |> Map.add (3,2) 1
    |> Map.add (3,7) 8
    |> Map.add (3,9) 4

    |> Map.add (4,1) 4
    |> Map.add (4,3) 7
    |> Map.add (4,5) 1
    |> Map.add (4,8) 5
    |> Map.add (5,1) 2
    |> Map.add (5,4) 3
    |> Map.add (5,6) 5
    |> Map.add (5,9) 8
    |> Map.add (6,2) 5
    |> Map.add (6,5) 2
    |> Map.add (6,7) 6
    |> Map.add (6,9) 1

    |> Map.add (7,1) 5
    |> Map.add (7,3) 3
    |> Map.add (7,8) 2
    |> Map.add (7,9) 6
    |> Map.add (8,2) 2
    |> Map.add (8,4) 9
    |> Map.add (8,7) 4
    |> Map.add (8,8) 8
    |> Map.add (8,9) 7
    |> Map.add (9,3) 9
    |> Map.add (9,4) 6
    |> Map.add (9,9) 5;;
//14
let sps =
    Map.empty
    |> Map.add (1,4) 8
    |> Map.add (1,8) 9
    |> Map.add (1,9) 1
    |> Map.add (2,1) 5
    |> Map.add (2,3) 4
    |> Map.add (2,4) 7
    |> Map.add (2,5) 1
    |> Map.add (3,1) 8
    |> Map.add (3,3) 7
    |> Map.add (3,6) 9
    |> Map.add (3,7) 3
    |> Map.add (3,8) 5

    |> Map.add (4,1) 6
    |> Map.add (4,2) 7
    |> Map.add (4,3) 1
    |> Map.add (4,5) 4
    |> Map.add (5,3) 3
    |> Map.add (5,4) 1
    |> Map.add (5,6) 5
    |> Map.add (5,7) 6
    |> Map.add (6,5) 2
    |> Map.add (6,7) 4
    |> Map.add (6,8) 1
    |> Map.add (6,9) 3

    |> Map.add (7,2) 6
    |> Map.add (7,3) 5
    |> Map.add (7,4) 9
    |> Map.add (7,7) 1
    |> Map.add (7,9) 7
    |> Map.add (8,5) 3
    |> Map.add (8,6) 1
    |> Map.add (8,7) 9
    |> Map.add (8,9) 6
    |> Map.add (9,1) 1
    |> Map.add (9,2) 3
    |> Map.add (9,6) 6;;
//15
let sps =
    Map.empty
    |> Map.add (1,3) 6
    |> Map.add (2,3) 3
    |> Map.add (2,5) 2
    |> Map.add (2,7) 9
    |> Map.add (2,8) 6
    |> Map.add (3,2) 2
    |> Map.add (3,3) 9
    |> Map.add (3,4) 3
    |> Map.add (3,5) 8
    |> Map.add (3,7) 5

    |> Map.add (4,1) 3
    |> Map.add (4,2) 6
    |> Map.add (4,3) 4
    |> Map.add (4,5) 9
    |> Map.add (4,6) 5
    |> Map.add (4,7) 2
    |> Map.add (5,1) 9
    |> Map.add (5,4) 2
    |> Map.add (5,6) 8
    |> Map.add (5,9) 3
    |> Map.add (6,3) 7
    |> Map.add (6,4) 1
    |> Map.add (6,5) 6
    |> Map.add (6,7) 4
    |> Map.add (6,8) 9
    |> Map.add (6,9) 5

    |> Map.add (7,3) 5
    |> Map.add (7,5) 7
    |> Map.add (7,6) 4
    |> Map.add (7,7) 1
    |> Map.add (7,8) 2
    |> Map.add (8,2) 9
    |> Map.add (8,3) 8
    |> Map.add (8,5) 5
    |> Map.add (8,7) 3
    |> Map.add (9,7) 8;;


(*Medium Tests*)
//1
let sps =
    Map.empty
    |> Map.add (1,5) 3
    |> Map.add (1,7) 8
    |> Map.add (1,8) 9
    |> Map.add (2,2) 5
    |> Map.add (2,4) 4
    |> Map.add (2,7) 3
    |> Map.add (2,9) 7
    |> Map.add (3,6) 6

    |> Map.add (4,2) 6
    |> Map.add (4,3) 5
    |> Map.add (4,5) 8
    |> Map.add (4,7) 7
    |> Map.add (4,9) 2
    |> Map.add (5,2) 1
    |> Map.add (5,4) 6
    |> Map.add (5,5) 2
    |> Map.add (5,6) 7
    |> Map.add (5,8) 5
    |> Map.add (6,1) 2
    |> Map.add (6,3) 4
    |> Map.add (6,5) 5
    |> Map.add (6,7) 1
    |> Map.add (6,8) 8

    |> Map.add (7,4) 7
    |> Map.add (8,1) 7
    |> Map.add (8,3) 3
    |> Map.add (8,6) 5
    |> Map.add (8,8) 1
    |> Map.add (9,2) 4
    |> Map.add (9,3) 6
    |> Map.add (9,5) 1;;
//2
let sps =
    Map.empty
    |> Map.add (1,1) 4
    |> Map.add (1,2) 8
    |> Map.add (1,3) 2
    |> Map.add (1,4) 9
    |> Map.add (1,7) 6
    |> Map.add (2,1) 5
    |> Map.add (2,4) 8
    |> Map.add (2,6) 3
    |> Map.add (2,7) 1
    |> Map.add (3,4) 6
    |> Map.add (3,8) 9

    |> Map.add (4,3) 6
    |> Map.add (4,8) 8
    |> Map.add (4,9) 5
    |> Map.add (5,2) 5
    |> Map.add (5,8) 6
    |> Map.add (6,1) 2
    |> Map.add (6,2) 7
    |> Map.add (6,7) 4

    |> Map.add (7,2) 9
    |> Map.add (7,6) 1
    |> Map.add (8,3) 5
    |> Map.add (8,4) 3
    |> Map.add (8,6) 8
    |> Map.add (8,9) 4
    |> Map.add (9,3) 7
    |> Map.add (9,6) 2
    |> Map.add (9,7) 5
    |> Map.add (9,8) 1
    |> Map.add (9,9) 6;;
//3
let sps =
    Map.empty
    |> Map.add (1,1) 9
    |> Map.add (1,3) 5
    |> Map.add (1,5) 1
    |> Map.add (2,6) 5
    |> Map.add (3,2) 7
    |> Map.add (3,3) 4
    |> Map.add (3,4) 6
    |> Map.add (3,7) 5
    |> Map.add (3,9) 2

    |> Map.add (4,3) 2
    |> Map.add (4,4) 8
    |> Map.add (4,5) 9
    |> Map.add (4,7) 3
    |> Map.add (4,9) 4
    |> Map.add (5,4) 4
    |> Map.add (5,5) 6
    |> Map.add (5,6) 3
    |> Map.add (6,1) 4
    |> Map.add (6,3) 9
    |> Map.add (6,5) 5
    |> Map.add (6,6) 1
    |> Map.add (6,7) 7

    |> Map.add (7,1) 2
    |> Map.add (7,3) 7
    |> Map.add (7,6) 8
    |> Map.add (7,7) 1
    |> Map.add (7,8) 9
    |> Map.add (8,4) 1
    |> Map.add (9,5) 4
    |> Map.add (9,7) 2
    |> Map.add (9,9) 7;;
//4
let sps =
    Map.empty
    |> Map.add (1,2) 1
    |> Map.add (1,4) 3
    |> Map.add (1,5) 2
    |> Map.add (1,8) 4
    |> Map.add (1,9) 9
    |> Map.add (2,4) 8
    |> Map.add (2,6) 9
    |> Map.add (3,6) 5
    |> Map.add (3,8) 8

    |> Map.add (4,1) 6
    |> Map.add (4,4) 2
    |> Map.add (4,7) 8
    |> Map.add (4,8) 9
    |> Map.add (5,1) 8
    |> Map.add (5,3) 4
    |> Map.add (5,7) 7
    |> Map.add (5,9) 1
    |> Map.add (6,2) 9
    |> Map.add (6,3) 1
    |> Map.add (6,6) 8
    |> Map.add (6,9) 6

    |> Map.add (7,2) 5
    |> Map.add (7,4) 1
    |> Map.add (8,4) 5
    |> Map.add (8,6) 2
    |> Map.add (9,1) 7
    |> Map.add (9,2) 3
    |> Map.add (9,5) 8
    |> Map.add (9,6) 4
    |> Map.add (9,8) 2;;
//5
let sps =
    Map.empty
    |> Map.add (1,3) 9
    |> Map.add (1,4) 2
    |> Map.add (1,5) 7
    |> Map.add (1,7) 3
    |> Map.add (1,8) 8
    |> Map.add (2,2) 8
    |> Map.add (2,9) 7
    |> Map.add (3,5) 9
    |> Map.add (3,6) 8
    |> Map.add (3,8) 1
    |> Map.add (3,9) 2

    |> Map.add (4,2) 2
    |> Map.add (4,3) 7
    |> Map.add (5,2) 3
    |> Map.add (5,4) 5
    |> Map.add (5,5) 8
    |> Map.add (5,6) 1
    |> Map.add (5,8) 2
    |> Map.add (6,7) 8
    |> Map.add (6,8) 3

    |> Map.add (7,1) 6
    |> Map.add (7,2) 7
    |> Map.add (7,4) 8
    |> Map.add (7,5) 4
    |> Map.add (8,1) 4
    |> Map.add (8,8) 7
    |> Map.add (9,2) 9
    |> Map.add (9,3) 1
    |> Map.add (9,5) 2
    |> Map.add (9,6) 7
    |> Map.add (9,7) 4;;
//6
let sps =
    Map.empty
    |> Map.add (1,1) 2
    |> Map.add (1,3) 4
    |> Map.add (1,4) 6
    |> Map.add (1,5) 7
    |> Map.add (1,7) 8
    |> Map.add (2,2) 5
    |> Map.add (2,7) 3
    |> Map.add (3,1) 8
    |> Map.add (3,2) 1
    |> Map.add (3,5) 2
    |> Map.add (3,6) 5
    |> Map.add (3,9) 7

    |> Map.add (4,6) 9
    |> Map.add (4,9) 3
    |> Map.add (5,3) 2
    |> Map.add (5,5) 6
    |> Map.add (5,7) 9
    |> Map.add (6,1) 3
    |> Map.add (6,4) 8

    |> Map.add (7,1) 1
    |> Map.add (7,4) 2
    |> Map.add (7,5) 8
    |> Map.add (7,8) 3
    |> Map.add (7,9) 9
    |> Map.add (8,3) 8
    |> Map.add (8,8) 1
    |> Map.add (9,3) 5
    |> Map.add (9,5) 1
    |> Map.add (9,6) 6
    |> Map.add (9,7) 7
    |> Map.add (9,9) 2;;
//7
let sps =
    Map.empty
    |> Map.add (1,2) 4
    |> Map.add (1,4) 3
    |> Map.add (1,7) 8
    |> Map.add (1,8) 9
    |> Map.add (2,3) 9
    |> Map.add (2,5) 4
    |> Map.add (2,7) 7
    |> Map.add (2,9) 5
    |> Map.add (3,4) 1

    |> Map.add (4,6) 4
    |> Map.add (4,7) 5
    |> Map.add (4,9) 8
    |> Map.add (5,1) 4
    |> Map.add (5,2) 9
    |> Map.add (5,8) 1
    |> Map.add (5,9) 7
    |> Map.add (6,1) 6
    |> Map.add (6,3) 5
    |> Map.add (6,4) 7

    |> Map.add (7,6) 3
    |> Map.add (8,1) 2
    |> Map.add (8,3) 7
    |> Map.add (8,5) 5
    |> Map.add (8,7) 3
    |> Map.add (9,2) 5
    |> Map.add (9,3) 6
    |> Map.add (9,6) 1
    |> Map.add (9,8) 7;;
//8
let sps =
    Map.empty
    |> Map.add (1,1) 3
    |> Map.add (1,2) 9
    |> Map.add (1,4) 8
    |> Map.add (1,5) 4
    |> Map.add (2,2) 6
    |> Map.add (2,3) 2
    |> Map.add (2,4) 5
    |> Map.add (2,6) 7
    |> Map.add (2,8) 4
    |> Map.add (3,7) 7

    |> Map.add (4,1) 7
    |> Map.add (4,6) 4
    |> Map.add (4,7) 3
    |> Map.add (5,2) 2
    |> Map.add (5,3) 8
    |> Map.add (5,7) 4
    |> Map.add (5,8) 1
    |> Map.add (6,3) 4
    |> Map.add (6,4) 7
    |> Map.add (6,9) 8

    |> Map.add (7,3) 3
    |> Map.add (8,2) 4
    |> Map.add (8,4) 1
    |> Map.add (8,6) 8
    |> Map.add (8,7) 9
    |> Map.add (8,8) 5
    |> Map.add (9,5) 6
    |> Map.add (9,6) 9
    |> Map.add (9,8) 7
    |> Map.add (9,9) 4;;
//9
let sps =
    Map.empty
    |> Map.add (1,1) 3
    |> Map.add (1,4) 2
    |> Map.add (1,8) 1
    |> Map.add (2,2) 2
    |> Map.add (2,3) 9
    |> Map.add (2,4) 4
    |> Map.add (3,4) 9
    |> Map.add (3,5) 8
    |> Map.add (3,9) 7

    |> Map.add (4,2) 5
    |> Map.add (4,3) 4
    |> Map.add (4,5) 3
    |> Map.add (4,9) 1
    |> Map.add (5,1) 6
    |> Map.add (5,4) 1
    |> Map.add (5,5) 9
    |> Map.add (5,6) 8
    |> Map.add (5,9) 3
    |> Map.add (6,1) 9
    |> Map.add (6,5) 4
    |> Map.add (6,7) 7
    |> Map.add (6,8) 6

    |> Map.add (7,1) 4
    |> Map.add (7,5) 7
    |> Map.add (7,6) 9
    |> Map.add (8,6) 1
    |> Map.add (8,7) 3
    |> Map.add (8,8) 7
    |> Map.add (9,2) 1
    |> Map.add (9,6) 4
    |> Map.add (9,9) 5;;
//10
let sps =
    Map.empty
    |> Map.add (1,1) 2
    |> Map.add (1,3) 6
    |> Map.add (1,4) 1
    |> Map.add (1,7) 5
    |> Map.add (2,1) 8
    |> Map.add (2,4) 4
    |> Map.add (2,7) 9
    |> Map.add (3,3) 5
    |> Map.add (3,6) 2
    |> Map.add (3,9) 6

    |> Map.add (4,1) 4
    |> Map.add (4,6) 3
    |> Map.add (4,7) 2
    |> Map.add (5,3) 3
    |> Map.add (5,5) 8
    |> Map.add (5,7) 1
    |> Map.add (6,3) 1
    |> Map.add (6,4) 5
    |> Map.add (6,9) 7

    |> Map.add (7,1) 6
    |> Map.add (7,4) 9
    |> Map.add (7,7) 4
    |> Map.add (8,3) 4
    |> Map.add (8,6) 8
    |> Map.add (8,9) 5
    |> Map.add (9,3) 9
    |> Map.add (9,6) 4
    |> Map.add (9,7) 7
    |> Map.add (9,9) 2;;
//11
let sps =
    Map.empty
    |> Map.add (1,4) 1
    |> Map.add (1,5) 2
    |> Map.add (1,6) 7
    |> Map.add (1,8) 8
    |> Map.add (2,1) 4
    |> Map.add (2,3) 1
    |> Map.add (2,4) 8
    |> Map.add (2,8) 5
    |> Map.add (3,4) 5
    |> Map.add (3,6) 6
    |> Map.add (3,9) 3

    |> Map.add (4,2) 2
    |> Map.add (4,5) 7
    |> Map.add (4,7) 8
    |> Map.add (5,2) 4
    |> Map.add (5,4) 2
    |> Map.add (5,6) 3
    |> Map.add (5,8) 6
    |> Map.add (6,3) 7
    |> Map.add (6,5) 9
    |> Map.add (6,8) 4

    |> Map.add (7,1) 7
    |> Map.add (7,4) 3
    |> Map.add (7,6) 2
    |> Map.add (8,2) 3
    |> Map.add (8,6) 8
    |> Map.add (8,7) 6
    |> Map.add (8,9) 5
    |> Map.add (9,2) 5
    |> Map.add (9,4) 7
    |> Map.add (9,5) 6
    |> Map.add (9,6) 4;;
//12
let sps =
    Map.empty
    |> Map.add (1,8) 5
    |> Map.add (1,9) 7
    |> Map.add (2,2) 3
    |> Map.add (2,4) 1
    |> Map.add (2,7) 8
    |> Map.add (2,8) 4
    |> Map.add (3,3) 5
    |> Map.add (3,4) 3
    |> Map.add (3,6) 9
    |> Map.add (3,7) 6

    |> Map.add (4,2) 6
    |> Map.add (4,7) 9
    |> Map.add (5,1) 1
    |> Map.add (5,3) 8
    |> Map.add (5,4) 7
    |> Map.add (5,5) 9
    |> Map.add (5,6) 6
    |> Map.add (5,7) 2
    |> Map.add (5,9) 4
    |> Map.add (6,3) 3
    |> Map.add (6,8) 8

    |> Map.add (7,3) 7
    |> Map.add (7,4) 4
    |> Map.add (7,6) 3
    |> Map.add (7,7) 5
    |> Map.add (8,2) 4
    |> Map.add (8,3) 9
    |> Map.add (8,6) 2
    |> Map.add (8,8) 6
    |> Map.add (9,1) 3
    |> Map.add (9,2) 2;;
//13
let sps =
    Map.empty
    |> Map.add (1,3) 3
    |> Map.add (1,6) 7
    |> Map.add (1,7) 5
    |> Map.add (1,9) 1
    |> Map.add (2,2) 7
    |> Map.add (2,3) 2
    |> Map.add (2,5) 4
    |> Map.add (3,1) 8
    |> Map.add (3,2) 1
    |> Map.add (3,7) 9

    |> Map.add (4,4) 7
    |> Map.add (4,5) 1
    |> Map.add (5,3) 1
    |> Map.add (5,4) 9
    |> Map.add (5,5) 2
    |> Map.add (5,6) 4
    |> Map.add (5,7) 3
    |> Map.add (6,5) 6
    |> Map.add (6,6) 8

    |> Map.add (7,3) 9
    |> Map.add (7,8) 5
    |> Map.add (7,9) 3
    |> Map.add (8,5) 7
    |> Map.add (8,7) 2
    |> Map.add (8,8) 6
    |> Map.add (9,1) 1
    |> Map.add (9,3) 4
    |> Map.add (9,4) 6
    |> Map.add (9,7) 7;;
//14
let sps =
    Map.empty
    |> Map.add (1,2) 9
    |> Map.add (1,3) 6
    |> Map.add (1,5) 5
    |> Map.add (1,9) 2
    |> Map.add (2,2) 1
    |> Map.add (2,5) 9
    |> Map.add (2,6) 2
    |> Map.add (2,7) 3
    |> Map.add (3,2) 2
    |> Map.add (3,5) 7
    |> Map.add (3,6) 1

    |> Map.add (4,1) 1
    |> Map.add (4,2) 6
    |> Map.add (4,6) 3
    |> Map.add (4,8) 4
    |> Map.add (5,2) 7
    |> Map.add (5,8) 6
    |> Map.add (6,2) 8
    |> Map.add (6,4) 1
    |> Map.add (6,8) 3
    |> Map.add (6,9) 5

    |> Map.add (7,4) 8
    |> Map.add (7,5) 3
    |> Map.add (7,8) 2
    |> Map.add (8,3) 7
    |> Map.add (8,4) 5
    |> Map.add (8,5) 2
    |> Map.add (8,8) 9
    |> Map.add (9,1) 2
    |> Map.add (9,5) 1
    |> Map.add (9,7) 6
    |> Map.add (9,8) 8;;
//15
let sps =
    Map.empty
    |> Map.add (1,5) 2
    |> Map.add (1,8) 1
    |> Map.add (1,9) 5
    |> Map.add (2,6) 3
    |> Map.add (3,2) 2
    |> Map.add (3,4) 4
    |> Map.add (3,7) 3
    |> Map.add (3,9) 9

    |> Map.add (4,1) 2
    |> Map.add (4,2) 7
    |> Map.add (4,5) 4
    |> Map.add (4,7) 8
    |> Map.add (4,9) 1
    |> Map.add (5,2) 4
    |> Map.add (5,4) 3
    |> Map.add (5,5) 8
    |> Map.add (5,6) 5
    |> Map.add (5,8) 2
    |> Map.add (6,1) 3
    |> Map.add (6,3) 8
    |> Map.add (6,5) 7
    |> Map.add (6,8) 5
    |> Map.add (6,9) 4

    |> Map.add (7,1) 9
    |> Map.add (7,3) 3
    |> Map.add (7,6) 1
    |> Map.add (7,8) 4
    |> Map.add (8,4) 5
    |> Map.add (9,1) 7
    |> Map.add (9,2) 6
    |> Map.add (9,5) 9;;


(*Hard Tests*)
//1
let sps =
    Map.empty
    |> Map.add (1,5) 5
    |> Map.add (1,7) 6
    |> Map.add (2,1) 3
    |> Map.add (2,3) 9
    |> Map.add (2,4) 2
    |> Map.add (2,8) 5
    |> Map.add (3,2) 5
    |> Map.add (3,5) 8

    |> Map.add (4,1) 1
    |> Map.add (4,7) 8
    |> Map.add (4,9) 9
    |> Map.add (5,2) 9
    |> Map.add (5,4) 7
    |> Map.add (5,5) 2
    |> Map.add (5,6) 8
    |> Map.add (5,8) 6
    |> Map.add (6,1) 8
    |> Map.add (6,3) 5
    |> Map.add (6,9) 4

    |> Map.add (7,5) 3
    |> Map.add (7,8) 2
    |> Map.add (8,2) 6
    |> Map.add (8,6) 2
    |> Map.add (8,7) 3
    |> Map.add (8,9) 8
    |> Map.add (9,3) 1
    |> Map.add (9,5) 6;;
//2
let sps =
    Map.empty
    |> Map.add (1,3) 9
    |> Map.add (1,5) 4
    |> Map.add (1,9) 3
    |> Map.add (2,1) 1
    |> Map.add (2,4) 7
    |> Map.add (2,9) 6
    |> Map.add (3,3) 8
    |> Map.add (3,5) 9
    |> Map.add (3,8) 2
    |> Map.add (3,9) 1

    |> Map.add (4,2) 9
    |> Map.add (4,3) 6
    |> Map.add (5,1) 8
    |> Map.add (5,4) 3
    |> Map.add (5,6) 7
    |> Map.add (5,9) 4
    |> Map.add (6,7) 2
    |> Map.add (6,8) 1

    |> Map.add (7,1) 7
    |> Map.add (7,2) 4
    |> Map.add (7,5) 2
    |> Map.add (7,7) 3
    |> Map.add (8,1) 6
    |> Map.add (8,6) 9
    |> Map.add (8,9) 2
    |> Map.add (9,1) 9
    |> Map.add (9,5) 7
    |> Map.add (9,7) 8;;
//3
let sps =
    Map.empty
    |> Map.add (1,5) 1
    |> Map.add (1,7) 9
    |> Map.add (2,1) 3
    |> Map.add (2,4) 6
    |> Map.add (2,5) 8
    |> Map.add (3,6) 7
    |> Map.add (3,7) 1
    |> Map.add (3,8) 8

    |> Map.add (4,1) 2
    |> Map.add (4,4) 9
    |> Map.add (4,7) 6
    |> Map.add (4,8) 5
    |> Map.add (5,2) 5
    |> Map.add (5,3) 6
    |> Map.add (5,7) 2
    |> Map.add (5,8) 1
    |> Map.add (6,2) 4
    |> Map.add (6,3) 7
    |> Map.add (6,6) 5
    |> Map.add (6,9) 8

    |> Map.add (7,2) 3
    |> Map.add (7,3) 4
    |> Map.add (7,4) 1
    |> Map.add (8,5) 9
    |> Map.add (8,6) 3
    |> Map.add (8,9) 5
    |> Map.add (9,3) 2
    |> Map.add (9,5) 5;;
//4
let sps =
    Map.empty
    |> Map.add (1,3) 4
    |> Map.add (1,4) 2
    |> Map.add (2,1) 1
    |> Map.add (2,2) 2
    |> Map.add (2,9) 7
    |> Map.add (3,4) 1
    |> Map.add (3,5) 6
    |> Map.add (3,7) 4
    |> Map.add (3,8) 9

    |> Map.add (4,4) 8
    |> Map.add (4,5) 9
    |> Map.add (4,8) 7
    |> Map.add (5,1) 4
    |> Map.add (5,3) 9
    |> Map.add (5,7) 3
    |> Map.add (5,9) 8
    |> Map.add (6,2) 3
    |> Map.add (6,5) 5
    |> Map.add (6,6) 4

    |> Map.add (7,2) 6
    |> Map.add (7,3) 2
    |> Map.add (7,5) 8
    |> Map.add (7,6) 5
    |> Map.add (8,1) 5
    |> Map.add (8,8) 2
    |> Map.add (8,9) 3
    |> Map.add (9,6) 1
    |> Map.add (9,7) 7;;
//5
let sps =
    Map.empty
    |> Map.add (1,2) 7
    |> Map.add (1,5) 8
    |> Map.add (1,6) 3
    |> Map.add (1,8) 5
    |> Map.add (1,9) 9
    |> Map.add (2,2) 1
    |> Map.add (2,4) 7
    |> Map.add (3,3) 3

    |> Map.add (4,1) 5
    |> Map.add (4,4) 3
    |> Map.add (4,7) 8
    |> Map.add (4,8) 2
    |> Map.add (5,2) 3
    |> Map.add (5,3) 7
    |> Map.add (5,7) 9
    |> Map.add (5,8) 6
    |> Map.add (6,2) 8
    |> Map.add (6,3) 6
    |> Map.add (6,6) 1
    |> Map.add (6,9) 7

    |> Map.add (7,7) 5
    |> Map.add (8,6) 4
    |> Map.add (8,8) 7
    |> Map.add (9,1) 7
    |> Map.add (9,2) 4
    |> Map.add (9,4) 5
    |> Map.add (9,5) 6
    |> Map.add (9,8) 8;;
//6
let sps =
    Map.empty
    |> Map.add (1,1) 9
    |> Map.add (1,2) 5
    |> Map.add (1,4) 6
    |> Map.add (2,2) 8
    |> Map.add (2,4) 9
    |> Map.add (2,8) 5
    |> Map.add (3,4) 7
    |> Map.add (3,6) 4
    |> Map.add (3,7) 2

    |> Map.add (4,3) 5
    |> Map.add (4,7) 6
    |> Map.add (4,8) 8
    |> Map.add (5,3) 4
    |> Map.add (5,5) 1
    |> Map.add (5,7) 9
    |> Map.add (6,2) 1
    |> Map.add (6,3) 6
    |> Map.add (6,7) 7

    |> Map.add (7,3) 9
    |> Map.add (7,4) 1
    |> Map.add (7,6) 7
    |> Map.add (8,2) 4
    |> Map.add (8,6) 5
    |> Map.add (8,8) 7
    |> Map.add (9,6) 9
    |> Map.add (9,8) 2
    |> Map.add (9,9) 4;;
//7
let sps =
    Map.empty
    |> Map.add (1,1) 1
    |> Map.add (1,5) 8
    |> Map.add (1,6) 6
    |> Map.add (1,8) 5
    |> Map.add (2,3) 5
    |> Map.add (2,7) 3
    |> Map.add (2,9) 8
    |> Map.add (3,5) 1
    |> Map.add (3,9) 7

    |> Map.add (4,1) 9
    |> Map.add (4,4) 6
    |> Map.add (4,7) 7
    |> Map.add (5,3) 3
    |> Map.add (5,7) 6
    |> Map.add (6,3) 8
    |> Map.add (6,6) 4
    |> Map.add (6,9) 2

    |> Map.add (7,1) 8
    |> Map.add (7,5) 5
    |> Map.add (8,1) 2
    |> Map.add (8,3) 4
    |> Map.add (8,7) 8
    |> Map.add (9,2) 7
    |> Map.add (9,4) 9
    |> Map.add (9,5) 4
    |> Map.add (9,9) 1;;
//8
let sps =
    Map.empty
    |> Map.add (1,5) 6
    |> Map.add (1,6) 5
    |> Map.add (1,7) 9
    |> Map.add (1,8) 4
    |> Map.add (1,9) 1
    |> Map.add (3,2) 5
    |> Map.add (3,4) 3
    |> Map.add (3,8) 2

    |> Map.add (4,1) 5
    |> Map.add (4,5) 1
    |> Map.add (4,6) 2
    |> Map.add (4,9) 3
    |> Map.add (5,3) 2
    |> Map.add (5,5) 3
    |> Map.add (5,7) 8
    |> Map.add (6,1) 6
    |> Map.add (6,4) 4
    |> Map.add (6,5) 8
    |> Map.add (6,9) 5

    |> Map.add (7,2) 9
    |> Map.add (7,6) 1
    |> Map.add (7,8) 8
    |> Map.add (9,1) 3
    |> Map.add (9,2) 2
    |> Map.add (9,3) 8
    |> Map.add (9,4) 6
    |> Map.add (9,5) 9;;
//9
let sps =
    Map.empty
    |> Map.add (1,7) 9
    |> Map.add (1,9) 2
    |> Map.add (2,1) 8
    |> Map.add (2,6) 9
    |> Map.add (2,8) 6
    |> Map.add (3,2) 7
    |> Map.add (3,4) 3
    |> Map.add (3,6) 8
    |> Map.add (3,7) 5

    |> Map.add (4,1) 1
    |> Map.add (4,2) 4
    |> Map.add (4,4) 6
    |> Map.add (5,2) 6
    |> Map.add (5,8) 3
    |> Map.add (6,6) 4
    |> Map.add (6,8) 2
    |> Map.add (6,9) 7

    |> Map.add (7,3) 9
    |> Map.add (7,4) 5
    |> Map.add (7,6) 6
    |> Map.add (7,8) 1
    |> Map.add (8,2) 1
    |> Map.add (8,4) 4
    |> Map.add (8,9) 9
    |> Map.add (9,1) 5
    |> Map.add (9,3) 4;;
//10
let sps =
    Map.empty
    |> Map.add (1,1) 3
    |> Map.add (1,6) 9
    |> Map.add (2,6) 3
    |> Map.add (2,7) 4
    |> Map.add (2,9) 2
    |> Map.add (3,1) 9
    |> Map.add (3,2) 5
    |> Map.add (3,3) 2
    |> Map.add (3,5) 7
    |> Map.add (3,8) 3

    |> Map.add (4,5) 1
    |> Map.add (4,8) 6
    |> Map.add (5,1) 6
    |> Map.add (5,3) 7
    |> Map.add (5,7) 1
    |> Map.add (5,9) 3
    |> Map.add (6,2) 1
    |> Map.add (6,5) 2

    |> Map.add (7,2) 9
    |> Map.add (7,5) 4
    |> Map.add (7,7) 6
    |> Map.add (7,8) 5
    |> Map.add (7,9) 1
    |> Map.add (8,1) 4
    |> Map.add (8,3) 6
    |> Map.add (8,4) 5
    |> Map.add (9,4) 6
    |> Map.add (9,9) 7;;
//11
let sps =
    Map.empty
    |> Map.add (1,2) 8
    |> Map.add (1,3) 9
    |> Map.add (1,5) 4
    |> Map.add (1,6) 2
    |> Map.add (1,7) 5
    |> Map.add (2,2) 1
    |> Map.add (2,3) 3
    |> Map.add (3,4) 8
    |> Map.add (3,8) 2

    |> Map.add (4,1) 7
    |> Map.add (4,4) 6
    |> Map.add (4,7) 8
    |> Map.add (5,2) 4
    |> Map.add (5,8) 3
    |> Map.add (6,3) 8
    |> Map.add (6,6) 5
    |> Map.add (6,9) 1

    |> Map.add (7,2) 2
    |> Map.add (7,6) 9
    |> Map.add (8,7) 9
    |> Map.add (8,8) 5
    |> Map.add (9,3) 1
    |> Map.add (9,4) 4
    |> Map.add (9,5) 6
    |> Map.add (9,7) 3
    |> Map.add (9,8) 8;;
//12
let sps =
    Map.empty
    |> Map.add (1,2) 8
    |> Map.add (1,4) 4
    |> Map.add (1,5) 3
    |> Map.add (1,8) 6
    |> Map.add (2,6) 9
    |> Map.add (2,8) 7
    |> Map.add (2,9) 4
    |> Map.add (3,5) 7
    |> Map.add (3,7) 2

    |> Map.add (4,1) 5
    |> Map.add (4,6) 8
    |> Map.add (4,8) 4
    |> Map.add (5,1) 7
    |> Map.add (5,2) 1
    |> Map.add (5,8) 5
    |> Map.add (5,9) 3
    |> Map.add (6,2) 4
    |> Map.add (6,4) 3
    |> Map.add (6,9) 6

    |> Map.add (7,3) 1
    |> Map.add (7,5) 2
    |> Map.add (8,1) 4
    |> Map.add (8,2) 5
    |> Map.add (8,4) 9
    |> Map.add (9,2) 6
    |> Map.add (9,5) 1
    |> Map.add (9,6) 7
    |> Map.add (9,8) 2;;
//13
let sps =
    Map.empty
    |> Map.add (1,2) 2
    |> Map.add (1,5) 8
    |> Map.add (1,8) 1
    |> Map.add (2,1) 5
    |> Map.add (2,6) 4
    |> Map.add (3,1) 3
    |> Map.add (3,4) 7
    |> Map.add (3,7) 9

    |> Map.add (4,2) 6
    |> Map.add (4,4) 3
    |> Map.add (4,8) 4
    |> Map.add (4,9) 7
    |> Map.add (5,4) 5
    |> Map.add (5,6) 7
    |> Map.add (6,1) 9
    |> Map.add (6,2) 4
    |> Map.add (6,6) 1
    |> Map.add (6,8) 3

    |> Map.add (7,3) 2
    |> Map.add (7,6) 8
    |> Map.add (7,9) 5
    |> Map.add (8,4) 1
    |> Map.add (8,9) 8
    |> Map.add (9,2) 5
    |> Map.add (9,5) 7
    |> Map.add (9,8) 6;;
//14
let sps =
    Map.empty
    |> Map.add (1,5) 5
    |> Map.add (1,7) 7
    |> Map.add (2,2) 9
    |> Map.add (2,6) 2
    |> Map.add (2,7) 4
    |> Map.add (2,8) 5
    |> Map.add (3,1) 8
    |> Map.add (3,7) 2

    |> Map.add (4,4) 8
    |> Map.add (4,5) 9
    |> Map.add (4,8) 2
    |> Map.add (5,1) 7
    |> Map.add (5,4) 1
    |> Map.add (5,6) 4
    |> Map.add (5,9) 5
    |> Map.add (6,2) 3
    |> Map.add (6,5) 6
    |> Map.add (6,6) 5

    |> Map.add (7,3) 1
    |> Map.add (7,9) 9
    |> Map.add (8,2) 5
    |> Map.add (8,3) 8
    |> Map.add (8,4) 2
    |> Map.add (8,8) 7
    |> Map.add (9,3) 4
    |> Map.add (9,5) 7;;
//15
let sps =
    Map.empty
    |> Map.add (1,6) 9
    |> Map.add (1,7) 5
    |> Map.add (1,8) 7
    |> Map.add (2,1) 3
    |> Map.add (2,2) 5
    |> Map.add (2,3) 6
    |> Map.add (2,5) 8
    |> Map.add (2,9) 9
    |> Map.add (3,3) 9
    |> Map.add (3,6) 6

    |> Map.add (4,5) 1
    |> Map.add (4,9) 2
    |> Map.add (5,2) 8
    |> Map.add (5,3) 2
    |> Map.add (5,7) 9
    |> Map.add (5,8) 1
    |> Map.add (6,1) 1
    |> Map.add (6,5) 5

    |> Map.add (7,4) 2
    |> Map.add (7,7) 8
    |> Map.add (8,1) 6
    |> Map.add (8,5) 7
    |> Map.add (8,7) 1
    |> Map.add (8,8) 2
    |> Map.add (8,9) 3
    |> Map.add (9,2) 2
    |> Map.add (9,3) 7
    |> Map.add (9,4) 3;;


(*Evil Tests*)
//1
let sps =
    Map.empty
    |> Map.add (1,1) 8
    |> Map.add (1,4) 7
    |> Map.add (1,9) 4
    |> Map.add (2,4) 1
    |> Map.add (2,8) 3
    |> Map.add (3,5) 3
    |> Map.add (3,7) 8
    |> Map.add (3,9) 1

    |> Map.add (4,2) 7
    |> Map.add (4,6) 5
    |> Map.add (4,7) 1
    |> Map.add (5,1) 5
    |> Map.add (5,3) 8
    |> Map.add (5,7) 6
    |> Map.add (5,9) 3
    |> Map.add (6,3) 2
    |> Map.add (6,4) 6
    |> Map.add (6,8) 7

    |> Map.add (7,1) 1
    |> Map.add (7,3) 6
    |> Map.add (7,5) 4
    |> Map.add (8,2) 9
    |> Map.add (8,6) 2
    |> Map.add (9,1) 2
    |> Map.add (9,6) 9
    |> Map.add (9,9) 8;;
//2
let sps =
    Map.empty
    |> Map.add (1,7) 1
    |> Map.add (2,2) 1
    |> Map.add (2,5) 6
    |> Map.add (2,6) 8
    |> Map.add (2,9) 3
    |> Map.add (3,2) 6
    |> Map.add (3,4) 2

    |> Map.add (4,2) 5
    |> Map.add (4,3) 4
    |> Map.add (4,5) 9
    |> Map.add (4,9) 2
    |> Map.add (5,1) 1
    |> Map.add (5,3) 7
    |> Map.add (5,7) 4
    |> Map.add (5,9) 6
    |> Map.add (6,1) 3
    |> Map.add (6,5) 8
    |> Map.add (6,7) 5
    |> Map.add (6,8) 9

    |> Map.add (7,6) 5
    |> Map.add (7,8) 4
    |> Map.add (8,1) 6
    |> Map.add (8,4) 1
    |> Map.add (8,5) 3
    |> Map.add (8,8) 5
    |> Map.add (9,3) 9;;
//3
let sps =
    Map.empty
    |> Map.add (1,1) 1
    |> Map.add (1,2) 6
    |> Map.add (1,5) 4
    |> Map.add (2,1) 9
    |> Map.add (2,3) 5
    |> Map.add (2,6) 2
    |> Map.add (2,9) 1
    |> Map.add (3,5) 7
    |> Map.add (3,7) 2

    |> Map.add (4,1) 7
    |> Map.add (4,4) 5
    |> Map.add (4,8) 1
    |> Map.add (5,1) 6
    |> Map.add (5,9) 9
    |> Map.add (6,2) 9
    |> Map.add (6,6) 4
    |> Map.add (6,9) 3

    |> Map.add (7,3) 9
    |> Map.add (7,5) 6
    |> Map.add (8,1) 5
    |> Map.add (8,4) 1
    |> Map.add (8,7) 3
    |> Map.add (8,9) 6
    |> Map.add (9,5) 5
    |> Map.add (9,8) 8
    |> Map.add (9,9) 4;;
//4
let sps =
    Map.empty
    |> Map.add (1,2) 9
    |> Map.add (2,1) 3
    |> Map.add (2,2) 6
    |> Map.add (2,5) 8
    |> Map.add (2,6) 1
    |> Map.add (3,1) 5
    |> Map.add (3,3) 8
    |> Map.add (3,6) 4

    |> Map.add (4,2) 7
    |> Map.add (4,5) 4
    |> Map.add (4,7) 9
    |> Map.add (5,3) 2
    |> Map.add (5,4) 9
    |> Map.add (5,6) 7
    |> Map.add (5,7) 5
    |> Map.add (6,3) 5
    |> Map.add (6,5) 1
    |> Map.add (6,8) 8

    |> Map.add (7,4) 4
    |> Map.add (7,7) 6
    |> Map.add (7,9) 7
    |> Map.add (8,4) 5
    |> Map.add (8,5) 7
    |> Map.add (8,8) 1
    |> Map.add (8,9) 4
    |> Map.add (9,8) 3;;
//5
let sps =
    Map.empty
    |> Map.add (1,2) 9
    |> Map.add (1,6) 1
    |> Map.add (1,9) 6
    |> Map.add (2,2) 3
    |> Map.add (2,5) 6
    |> Map.add (2,7) 5
    |> Map.add (3,3) 6
    |> Map.add (3,5) 8
    |> Map.add (3,9) 7

    |> Map.add (4,1) 2
    |> Map.add (4,2) 8
    |> Map.add (5,1) 1
    |> Map.add (5,4) 8
    |> Map.add (5,6) 2
    |> Map.add (5,9) 5
    |> Map.add (6,8) 2
    |> Map.add (6,9) 3

    |> Map.add (7,1) 3
    |> Map.add (7,5) 1
    |> Map.add (7,7) 7
    |> Map.add (8,3) 7
    |> Map.add (8,5) 5
    |> Map.add (8,8) 1
    |> Map.add (9,1) 4
    |> Map.add (9,4) 9
    |> Map.add (9,8) 5;;
//6
let sps =
    Map.empty
    |> Map.add (1,2) 5
    |> Map.add (1,5) 7
    |> Map.add (2,2) 3
    |> Map.add (2,3) 6
    |> Map.add (2,7) 9
    |> Map.add (3,3) 7
    |> Map.add (3,6) 4

    |> Map.add (4,2) 2
    |> Map.add (4,5) 3
    |> Map.add (4,6) 7
    |> Map.add (4,9) 8
    |> Map.add (5,4) 9
    |> Map.add (5,6) 5
    |> Map.add (6,1) 8
    |> Map.add (6,4) 1
    |> Map.add (6,5) 4
    |> Map.add (6,8) 7

    |> Map.add (7,4) 7
    |> Map.add (7,7) 1
    |> Map.add (8,3) 9
    |> Map.add (8,7) 2
    |> Map.add (8,8) 5
    |> Map.add (9,5) 6
    |> Map.add (9,8) 3;;
//7
let sps =
    Map.empty
    |> Map.add (1,3) 7
    |> Map.add (1,4) 5
    |> Map.add (1,7) 1
    |> Map.add (1,8) 2
    |> Map.add (2,1) 1
    |> Map.add (2,3) 4
    |> Map.add (2,6) 8
    |> Map.add (3,1) 6
    |> Map.add (3,5) 9
    |> Map.add (3,8) 3

    |> Map.add (4,6) 1
    |> Map.add (4,7) 4
    |> Map.add (5,1) 2
    |> Map.add (5,9) 7
    |> Map.add (6,3) 9
    |> Map.add (6,4) 7

    |> Map.add (7,2) 2
    |> Map.add (7,5) 1
    |> Map.add (7,9) 5
    |> Map.add (8,4) 4
    |> Map.add (8,7) 8
    |> Map.add (8,9) 6
    |> Map.add (9,2) 7
    |> Map.add (9,3) 5
    |> Map.add (9,6) 6
    |> Map.add (9,7) 2;;
//8
let sps =
    Map.empty
    |> Map.add (1,3) 8
    |> Map.add (1,6) 3
    |> Map.add (1,9) 7
    |> Map.add (2,3) 1
    |> Map.add (2,4) 2
    |> Map.add (2,5) 9
    |> Map.add (2,9) 3
    |> Map.add (3,6) 6

    |> Map.add (4,1) 8
    |> Map.add (4,8) 3
    |> Map.add (4,9) 2
    |> Map.add (5,4) 4
    |> Map.add (5,6) 2
    |> Map.add (6,1) 9
    |> Map.add (6,2) 2
    |> Map.add (6,9) 5

    |> Map.add (7,4) 9
    |> Map.add (8,1) 2
    |> Map.add (8,5) 1
    |> Map.add (8,6) 7
    |> Map.add (8,7) 5
    |> Map.add (9,1) 6
    |> Map.add (9,4) 5
    |> Map.add (9,7) 8;;
//9
let sps =
    Map.empty
    |> Map.add (1,1) 1
    |> Map.add (1,3) 4
    |> Map.add (1,5) 3
    |> Map.add (2,4) 8
    |> Map.add (2,5) 4
    |> Map.add (2,8) 9
    |> Map.add (3,7) 5
    |> Map.add (3,8) 1

    |> Map.add (4,1) 4
    |> Map.add (4,3) 7
    |> Map.add (5,2) 1
    |> Map.add (5,4) 6
    |> Map.add (5,6) 9
    |> Map.add (5,8) 4
    |> Map.add (6,7) 2
    |> Map.add (6,9) 7

    |> Map.add (7,2) 7
    |> Map.add (7,3) 8
    |> Map.add (8,2) 6
    |> Map.add (8,5) 8
    |> Map.add (8,6) 3
    |> Map.add (9,5) 2
    |> Map.add (9,7) 6
    |> Map.add (9,9) 1;;
//10
let sps =
    Map.empty
    |> Map.add (1,1) 3
    |> Map.add (1,3) 8
    |> Map.add (1,7) 7
    |> Map.add (2,2) 6
    |> Map.add (2,5) 1
    |> Map.add (2,7) 9
    |> Map.add (3,2) 5
    |> Map.add (3,4) 8

    |> Map.add (4,4) 6
    |> Map.add (4,5) 9
    |> Map.add (4,7) 2
    |> Map.add (5,2) 1
    |> Map.add (5,4) 2
    |> Map.add (5,6) 7
    |> Map.add (5,8) 3
    |> Map.add (6,3) 9
    |> Map.add (6,5) 4
    |> Map.add (6,6) 1

    |> Map.add (7,6) 4
    |> Map.add (7,8) 8
    |> Map.add (8,3) 3
    |> Map.add (8,5) 5
    |> Map.add (8,8) 9
    |> Map.add (9,3) 7
    |> Map.add (9,7) 6
    |> Map.add (9,9) 5;;
//11
let sps =
    Map.empty
    |> Map.add (1,4) 2
    |> Map.add (1,5) 6
    |> Map.add (1,9) 8
    |> Map.add (2,2) 7
    |> Map.add (2,3) 4
    |> Map.add (3,1) 2
    |> Map.add (3,2) 3
    |> Map.add (3,8) 9

    |> Map.add (4,2) 9
    |> Map.add (4,4) 3
    |> Map.add (4,5) 8
    |> Map.add (4,9) 2
    |> Map.add (5,4) 4
    |> Map.add (5,6) 7
    |> Map.add (6,1) 7
    |> Map.add (6,5) 1
    |> Map.add (6,6) 6
    |> Map.add (6,8) 4

    |> Map.add (7,2) 8
    |> Map.add (7,8) 3
    |> Map.add (7,9) 7
    |> Map.add (8,7) 9
    |> Map.add (8,8) 6
    |> Map.add (9,1) 3
    |> Map.add (9,5) 9
    |> Map.add (9,6) 2;;
//12
let sps =
    Map.empty
    |> Map.add (1,1) 5
    |> Map.add (1,4) 4
    |> Map.add (1,7) 1
    |> Map.add (2,2) 1
    |> Map.add (2,5) 9
    |> Map.add (2,9) 6
    |> Map.add (3,2) 8
    |> Map.add (3,4) 6
    |> Map.add (3,7) 3

    |> Map.add (4,4) 3
    |> Map.add (4,7) 6
    |> Map.add (5,2) 9
    |> Map.add (5,5) 4
    |> Map.add (5,8) 2
    |> Map.add (6,3) 2
    |> Map.add (6,6) 8

    |> Map.add (7,3) 3
    |> Map.add (7,6) 1
    |> Map.add (7,8) 8
    |> Map.add (8,1) 4
    |> Map.add (8,5) 7
    |> Map.add (8,8) 3
    |> Map.add (9,3) 7
    |> Map.add (9,6) 4
    |> Map.add (9,9) 5;;
//13
let sps =
    Map.empty
    |> Map.add (1,2) 2
    |> Map.add (1,6) 7
    |> Map.add (1,8) 5
    |> Map.add (2,5) 5
    |> Map.add (2,7) 4
    |> Map.add (3,3) 3
    |> Map.add (3,6) 4
    |> Map.add (3,7) 2

    |> Map.add (4,3) 4
    |> Map.add (4,8) 6
    |> Map.add (5,2) 5
    |> Map.add (5,3) 9
    |> Map.add (5,5) 6
    |> Map.add (5,7) 1
    |> Map.add (5,8) 4
    |> Map.add (6,2) 1
    |> Map.add (6,7) 7

    |> Map.add (7,3) 1
    |> Map.add (7,4) 8
    |> Map.add (7,7) 9
    |> Map.add (8,3) 6
    |> Map.add (8,5) 3
    |> Map.add (9,2) 7
    |> Map.add (9,4) 4
    |> Map.add (9,8) 1;;
//14
let sps =
    Map.empty
    |> Map.add (1,1) 3
    |> Map.add (1,4) 6
    |> Map.add (1,6) 2
    |> Map.add (1,7) 1
    |> Map.add (2,1) 6
    |> Map.add (2,3) 5
    |> Map.add (2,6) 9
    |> Map.add (2,9) 8
    |> Map.add (3,3) 7

    |> Map.add (4,3) 6
    |> Map.add (4,5) 4
    |> Map.add (4,6) 5
    |> Map.add (5,2) 1
    |> Map.add (5,8) 8
    |> Map.add (6,4) 8
    |> Map.add (6,5) 2
    |> Map.add (6,7) 9

    |> Map.add (7,7) 3
    |> Map.add (8,1) 9
    |> Map.add (8,4) 4
    |> Map.add (8,7) 5
    |> Map.add (8,9) 7
    |> Map.add (9,3) 2
    |> Map.add (9,4) 5
    |> Map.add (9,6) 3
    |> Map.add (9,9) 4;;
//15
let sps =
    Map.empty
    |> Map.add (1,7) 2
    |> Map.add (1,8) 8
    |> Map.add (2,4) 3
    |> Map.add (2,5) 5
    |> Map.add (3,1) 9
    |> Map.add (3,2) 7
    |> Map.add (3,3) 5
    |> Map.add (3,7) 1

    |> Map.add (4,1) 4
    |> Map.add (4,2) 3
    |> Map.add (4,5) 9
    |> Map.add (4,7) 6
    |> Map.add (5,5) 7
    |> Map.add (6,3) 7
    |> Map.add (6,5) 2
    |> Map.add (6,8) 4
    |> Map.add (6,9) 8

    |> Map.add (7,3) 1
    |> Map.add (7,7) 7
    |> Map.add (7,8) 6
    |> Map.add (7,9) 3
    |> Map.add (8,5) 1
    |> Map.add (8,6) 7
    |> Map.add (9,2) 5
    |> Map.add (9,3) 8;;

let sps =
    Map.empty
    |> Map.add (1,1) 0
    |> Map.add (1,2) 0
    |> Map.add (1,3) 0
    |> Map.add (1,4) 0
    |> Map.add (1,5) 0
    |> Map.add (1,6) 0
    |> Map.add (1,7) 0
    |> Map.add (1,8) 0
    |> Map.add (1,9) 0
    |> Map.add (2,1) 0
    |> Map.add (2,2) 0
    |> Map.add (2,3) 0
    |> Map.add (2,4) 0
    |> Map.add (2,5) 0
    |> Map.add (2,6) 0
    |> Map.add (2,7) 0
    |> Map.add (2,8) 0
    |> Map.add (2,9) 0
    |> Map.add (3,1) 0
    |> Map.add (3,2) 0
    |> Map.add (3,3) 0
    |> Map.add (3,4) 0
    |> Map.add (3,5) 0
    |> Map.add (3,6) 0
    |> Map.add (3,7) 0
    |> Map.add (3,8) 0
    |> Map.add (3,9) 0

    |> Map.add (4,1) 0
    |> Map.add (4,2) 0
    |> Map.add (4,3) 0
    |> Map.add (4,4) 0
    |> Map.add (4,5) 0
    |> Map.add (4,6) 0
    |> Map.add (4,7) 0
    |> Map.add (4,8) 0
    |> Map.add (4,9) 0
    |> Map.add (5,1) 0
    |> Map.add (5,2) 0
    |> Map.add (5,3) 0
    |> Map.add (5,4) 0
    |> Map.add (5,5) 0
    |> Map.add (5,6) 0
    |> Map.add (5,7) 0
    |> Map.add (5,8) 0
    |> Map.add (5,9) 0
    |> Map.add (6,1) 0
    |> Map.add (6,2) 0
    |> Map.add (6,3) 0
    |> Map.add (6,4) 0
    |> Map.add (6,5) 0
    |> Map.add (6,6) 0
    |> Map.add (6,7) 0
    |> Map.add (6,8) 0
    |> Map.add (6,9) 0

    |> Map.add (7,1) 0
    |> Map.add (7,2) 0
    |> Map.add (7,3) 0
    |> Map.add (7,4) 0
    |> Map.add (7,5) 0
    |> Map.add (7,6) 0
    |> Map.add (7,7) 0
    |> Map.add (7,8) 0
    |> Map.add (7,9) 0
    |> Map.add (8,1) 0
    |> Map.add (8,2) 0
    |> Map.add (8,3) 0
    |> Map.add (8,4) 0
    |> Map.add (8,5) 0
    |> Map.add (8,6) 0
    |> Map.add (8,7) 0
    |> Map.add (8,8) 0
    |> Map.add (8,9) 0
    |> Map.add (9,1) 0
    |> Map.add (9,2) 0
    |> Map.add (9,3) 0
    |> Map.add (9,4) 0
    |> Map.add (9,5) 0
    |> Map.add (9,6) 0
    |> Map.add (9,7) 0
    |> Map.add (9,8) 0
    |> Map.add (9,9) 0;;