open System
open Markdown

let parseLine (line: string): MarkdownElement option =
    if line.StartsWith("# ") then
        Some (Heading (1, line.Substring(2).Trim()))
    elif line.StartsWith("## ") then
        Some (Heading (2, line.Substring(3).Trim()))
    elif line.StartsWith("### ") then
        Some (Heading (3, line.Substring(4).Trim()))
    elif String.IsNullOrWhiteSpace(line) then
        None
    else
        None

let parseMarkdown (lines: string list): MarkdownElement list =
    lines
    |> List.choose parseLine

let renderHtml (element: MarkdownElement): string =
    match element with
    | Paragraph text -> sprintf "<p>%s</p>" text
    | Heading (level, text) -> sprintf "<h%d>%s</h%d>" level text level
    | Bold text -> sprintf "<strong>%s</strong>" text
    | Italic text -> sprintf "<em>%s</em>" text
    | Strikethrough text -> sprintf "<del>%s</del>" text

[<EntryPoint>]
let main argv = 

printfn "Hello from F#"
