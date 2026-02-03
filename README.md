# Zoo Console App

Simple console application in C# for managing a zoo (keepers & animals).

## Demo

![Zoo App Demo](docs/preview.gif)

## Features
- Add / Remove / Update ZooKeepers
- Add / Remove / Update Animals
- Generic selector helper `SelectItem<T>` for unified numeric selection
- Delegate-based actions (`Func<ZooKeeper,IAnimal,string>`) for feed/inspect
- Interactive console menu

## Tech
- C# (.NET 6 or 7)
- LINQ, Generics, Delegates

## Run locally
1. Clone: `git clone https://github.com/erntTt94/zoo-console-app.git`
2. Open terminal in repo folder
3. Build: `dotnet build`
4. Run in terminal: `dotnet run`  Or open in Visual Studio / VS Code and run the project.

## Project structure
- `Program.cs` — main menu
- `DataStructures` — models & factories (Zoo, ZooKeeper, AnimalFactory, etc.)
- `Operations` - operations (Update, Delete, etc.)
- `Utilities` - helper functions
- `README.md`, `LICENSE`, `.gitignore`

## Notes
- `IAnimal` contains `Age { get; set; }` and `IsHealthy { get; set; }` to support updates.
- `SelectItem<T>` is a generic helper used everywhere to avoid repetition.

## License
MIT
