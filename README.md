# Lab2 — Word Processing Console App (C# / .NET 8)

A C# console application that reads words from a file and performs various 
sorting, filtering, and analysis operations using both manual algorithms 
and LINQ/Lambda expressions.

---

## Features
| Option | Description |
|--------|-------------|
| 1 | Import words from `Words.txt` into a list |
| 2 | Bubble Sort words alphabetically (with timing) |
| 3 | LINQ/Lambda sort words alphabetically (with timing) |
| 4 | Count distinct words |
| 5 | Display the first 10 words |
| 6 | Reverse each word without modifying the original list |
| 7 | Get words ending with **'a'** and display count |
| 8 | Get words starting with **'m'** and display count |
| 9 | Get words longer than 5 characters containing **'s'** |
| X | Exit |

---

## Built with
- C# / .NET 8
- Visual Studio
- LINQ & Lambda expressions
- System.IO for file handling

## How to run
1. Clone the repo
2. Open `Lab2.sln` in Visual Studio
3. Place `Words.txt` in the project root
4. Press **F5** to run

## Concepts practiced
- File I/O with `StreamReader`
- Generic collections `IList<string>`
- Bubble sort algorithm implementation
- LINQ queries and Lambda expressions
- Exception handling
- Side-effect-free method design
