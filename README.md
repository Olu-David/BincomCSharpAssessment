# Bincom C# Developer Trainee Assessment

A C# console application containing solutions to the five programming tasks provided as part of the Bincom .NET C# Developer Trainee preliminary assessment.

## Project Information

- **Language:** C#
- **Application Type:** Console Application
- **IDE:** Visual Studio
- **Framework:** .NET

## Tasks Implemented

### 1. Variables
Declares and displays three variables:
- `name` – string
- `age` – integer
- `isAdmin` – boolean

### 2. Even or Odd
Accepts an integer from the console and determines whether it is even or odd using the modulo (`%`) operator. Includes basic input validation.

### 3. For Loop
Uses a `for` loop to display numbers from 1 to 10.

### 4. Arrays
Creates an integer array containing `2, 4, 6, 8, 10`. Uses `foreach` loops to calculate the sum and display the array elements.

**Expected sum:** `30`

### 5. Methods
Defines a `Greet()` method that accepts a name and displays a personalised greeting.

**Example output:** `Hello, Alice!`

## Getting Started

### Prerequisites
- Visual Studio 2022 or later
- .NET SDK compatible with the project

### Running the Application

1. Clone the repository:

   ```bash
   git clone https://github.com/YOUR-USERNAME/BincomCSharpAssessment.git
   ```

2. Open the project folder in Visual Studio.

3. Open the `.csproj` file or the solution file.

4. Run the application using `Ctrl + F5`.

Alternatively, run it from the terminal:

```bash
dotnet run
```

## Project Structure

```text
BincomCSharpAssessment/
│
├── Program.cs
├── BincomCSharpAssessment.csproj
└── README.md
```

## Testing

The application can be tested by entering different values when prompted in Task 2.

| Input | Expected Result |
|---|---|
| 8 | Even |
| 7 | Odd |
| abc | Invalid input message |

The remaining tasks run automatically when the application starts.

## Author

**David Victor Olusanya**

- GitHub: https://github.com/Olu-David
- LinkedIn: https://www.linkedin.com/in/david-olusanya
