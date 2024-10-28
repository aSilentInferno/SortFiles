# SortFiles

## Overview
**SortFiles** is a simple, lightweight tool designed to organize large collections of files into subfolders based on file names. This is especially useful for managing folders of game recordings or similar collections, where each file corresponds to a particular game. By automatically sorting files into organized subfolders, SortFiles saves you time and hassle.

---

## Features
- **Automatic Sorting**: Automatically sorts files into subfolders by extracting game names from file names.
- **Customizable Name Parsing**: Extracts game names even if files follow various naming conventions.
- **Error Handling**: Detects and manages potential file conflicts or permission issues.
- **Cross-Platform Compatibility**: Works across different operating systems (Windows, Linux, macOS).

---

## Getting Started

### Prerequisites
- **.NET SDK**: This program is built with C# and requires the .NET SDK to run. You can download it [here](https://dotnet.microsoft.com/download).

### Installation
1. **Clone the repository**:
   ```bash
   git clone https://github.com/aSilentInferno/SortFiles.git
   cd SortFiles
   ```

2. **Build the program**:
   ```bash
   dotnet build
   ```

3. **Run the program**:
   ```bash
   dotnet run --path <path_to_your_files>
   ```

### Usage

To use the program, specify the directory containing the files you want to sort. The program will:
1. Scan each file in the directory.
2. Extract the game name from the file name.
3. Move the file into a subfolder based on the extracted game name.

For example, if files are named `RocketLeague 2023-05-14.mp4`, the program will create a `RocketLeague` folder and move the file into it.

---

## Example

Suppose you have a folder with the following files:
```
RocketLeague 2023-05-14.mp4
RocketLeague 2023-05-15.mp4
Overwatch 2023-06-10.mp4
CSGO 2023-07-01.mp4
```

After running SortFiles, your folder structure would look like this:
```
/RocketLeague
    └── RocketLeague 2023-05-14.mp4
    └── RocketLeague 2023-05-15.mp4
/Overwatch
    └── Overwatch 2023-06-10.mp4
/CSGO
    └── CSGO 2023-07-01.mp4
```

---

## Configuration

### Customizing Game Name Extraction
If your file names follow a different naming pattern, modify the `ExtractGameName` method to fit your format.

---

## Contributing

1. **Fork the repository** and clone it locally.
2. **Create a new branch** for any feature changes.
3. **Submit a pull request** with a description of changes.

---

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.

--- 

## Disclaimer
This program is intended for personal use to help organize files and improve workflow. Please verify the program behavior with test files before using it on critical data.

---

This README now provides a comprehensive overview of the tool, instructions for installation and usage, and example scenarios to guide users.