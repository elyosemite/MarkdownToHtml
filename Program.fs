open System
open Markdown

let parseLine (line: string): MarkdownElement option =
    if line.StartsWith("# ") then
        Some (Heading (1, line.Substring(2).Trim()))
    elif line.StartsWith("## ") then
        Some (Heading (2, line.Substring(3).Trim()))
    elif line.StartsWith("**") && line.EndsWith("**") then
        Some (Bold (line.Substring(2, line.Length - 4).Trim()))
    elif line.StartsWith("*") && line.EndsWith("*") then
        Some (Italic (line.Substring(1, line.Length - 2).Trim()))
    elif line.StartsWith("~~") && line.EndsWith("~~") then
        Some (Strikethrough (line.Substring(2, line.Length - 4).Trim()))
    elif not (String.IsNullOrWhiteSpace(line)) then
        Some (Paragraph (line.Trim()))
    else
        None

[<EntryPoint>]
let main argv = 

printfn "Hello from F#"
