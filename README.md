# C# OOP Lessons

This repository contains small C# console applications for practicing Object-Oriented Programming (OOP) concepts.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- A C#-compatible editor or IDE, such as Visual Studio, Visual Studio Code with the C# Dev Kit, or JetBrains Rider (optional)
- A terminal for the commands below

The lesson projects target `net10.0`.

## Run a lesson

From the repository root, run:

```bash
dotnet run --project ./Lesson01/Lesson01.csproj
```

To build a lesson without running it:

```bash
dotnet build ./Lesson01/Lesson01.csproj
```

## Lessons

| Lesson folder | Topic | What to practice | Run command |
| --- | --- | --- | --- |
| [Lesson01](Lesson01/) | Classes and objects | Creating a `Student` class, setting properties, and calling its `Introduce` method | `dotnet run --project ./Lesson01/Lesson01.csproj` |

## Lesson details

### Lesson01

The `Student` class demonstrates:

- A class with instance fields
- Creating multiple objects
- Assigning values to object properties
- Calling an object method
- Printing formatted text with `Console.WriteLine`

The program creates three `Student` objects and prints an introduction for each one.