# MarkdownToHtml

A Markdown to HTML parser written in **F#** using Microsoft's .NET SDK.

## Overview

MarkdownToHtml is a lightweight parser that converts Markdown syntax into HTML. Built with functional programming principles in F#, it provides a simple and extensible way to parse and render Markdown elements.

## Features

- **Heading Support**: Convert Markdown headings (H1, H2, etc.) to HTML
- **Text Formatting**: Support for bold, italic, and strikethrough text
- **Paragraphs**: Parse standard text paragraphs
- **Functional Design**: Built with F# discriminated unions for type-safe element handling

## Supported Markdown Elements

| Markdown | HTML | Example |
|----------|------|---------|
| `# Heading` | `<h1>Heading</h1>` | `# My Title` |
| `## Heading` | `<h2>Heading</h2>` | `## Subtitle` |
| `**bold**` | `<strong>bold</strong>` | `**important text**` |
| `*italic*` | `<em>italic</em>` | `*emphasized text*` |
| `~~strikethrough~~` | `<s>strikethrough</s>` | `~~old text~~` |
| Regular text | `<p>text</p>` | `This is a paragraph` |

## Project Structure

```
MarkdownToHtml/
├── Markdown.fs       # Core module with MarkdownElement type definitions
├── Program.fs        # Entry point with parsing logic
├── MarkdownToHtml.fsproj  # Project configuration
└── README.md         # This file
```

## Building

### Prerequisites
- .NET 10.0 SDK or later

### Build the Project
```bash
dotnet build
```

### Run the Application
```bash
dotnet run
```

## Dependencies

- **Microsoft.NET.Sdk**: .NET 10.0 runtime

## Code Example

The core parsing logic is in `Program.fs`:

```fsharp
let parseLine (line: string): MarkdownElement option =
    if line.StartsWith("# ") then
        Some (Heading (1, line.Substring(2).Trim()))
    elif line.StartsWith("## ") then
        Some (Heading (2, line.Substring(3).Trim()))
    elif line.StartsWith("**") && line.EndsWith("**") then
        Some (Bold (line.Substring(2, line.Length - 4).Trim()))
    // ... more patterns
```

## Technology Stack

- **Language**: F# (Functional-first .NET language)
- **Framework**: .NET 10.0
- **Type System**: F# Discriminated Unions for safe element representation

## Future Enhancements

- List support (ordered and unordered)
- Code block parsing
- Link and image support
- Table rendering
- Block quote handling
- HTML output rendering

## License

This project is open source and available under the MIT License.

## Author

Created as a Markdown parsing exploration in F#.
