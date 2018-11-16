﻿//The Frame Project 

open System
open System.IO
open Parser
open FrameInterpreter
open FrameParser

[<EntryPoint>]
let main argv =

    if Array.length argv <> 1 then 
        printf "Usage: dotnet run filename.fr\nTry something like \"HeadText(\\\"HelloWorld\\\")\"\n"
        exit 1

    let content = argv.[0]

    let body = go content
     
    if (body <> "Invalid Expression")
    then buildHTML body |> ignore
    else printfn "Invalid Expression"

    0
   
