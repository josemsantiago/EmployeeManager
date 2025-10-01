# EmployeeManager

A Windows Forms application built with .NET Framework and C# for managing employee information, including hourly and salaried employees with benefits tracking.

## Features

- Add and manage employee records
- Support for two employee types:
  - Hourly employees (hourly wage calculation)
  - Salaried employees (annual salary)
- Benefits management system
- Data persistence with serialization
- User-friendly Windows Forms interface

## Technology Stack

- .NET Framework 4.7.2
- C# Windows Forms
- Object-oriented design with inheritance

## Requirements

- Windows OS
- .NET Framework 4.7.2 or higher
- Visual Studio 2015 or later (for development)

## How to Run

1. Open the solution file `SantiagoEchevarria_CourseProject_Part2.sln` in Visual Studio
2. Build the solution (F6)
3. Run the application (F5)

## Project Structure

- `Employee.cs` - Abstract base class for all employees
- `Hourly.cs` - Hourly employee implementation
- `Salary.cs` - Salaried employee implementation
- `Benefits.cs` - Benefits management
- `MainForm.cs` - Main application window
- `InputForm.cs` - Input form for adding employees

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details. 
