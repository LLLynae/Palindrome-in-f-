// For more information see https://aka.ms/fsharp-console-apps


let isPalindrome =
    printfn "Hi! I will find out if your word is a palindrome or not."
    printfn "Please enter your word."
    //Prompts user to enter word

    let userString = System.Console.ReadLine() |> string
    //Console entry for user's string
    let stringReverse = System.String(Array.rev (userString.ToCharArray()))
    //Uses Array.rev to reverse through user's string, reading it backwards
    //ToCharArray makes string into array of characters so it can be revversed

    if userString = stringReverse then
        printfn "True! Your word is a palindrome."
    else printfn "False! Your Word is not a palindrome."
    //if statement check for if the word is the same forwards and backwards
   
    
    
        

        
            