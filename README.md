# EmployeeManager

![C#](https://img.shields.io/badge/C%23-239120?logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?logo=.net)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-0078D6?logo=windows)
![License](https://img.shields.io/badge/license-MIT-blue)
![Status](https://img.shields.io/badge/status-active-success)

A Windows Forms application built with .NET Framework and C# for managing employee information, including hourly and salaried employees with benefits tracking.

## Screenshots

> **Note:** Screenshots will be added soon. For now, follow the installation instructions below to see the application in action.

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

## Prerequisites

### Runtime Requirements
- **Windows OS**: Windows 7 or higher
- **.NET Framework**: 4.7.2 or higher ([Download](https://dotnet.microsoft.com/download/dotnet-framework))

### Development Requirements
- **Visual Studio**: 2015 or later (2019 or 2022 recommended)
- **Git**: For cloning the repository

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

## Troubleshooting

### Common Issues

**Issue:** Application won't start - "Could not load file or assembly"

**Solution:** Ensure .NET Framework 4.7.2 or higher is installed. Download from [Microsoft](https://dotnet.microsoft.com/download/dotnet-framework).

---

**Issue:** "Access to the path is denied" when saving employee data

**Solution:** Run Visual Studio as Administrator or ensure the application has write permissions to its directory.

---

**Issue:** Build fails with missing references

**Solution:** Right-click the solution in Visual Studio and select "Restore NuGet Packages", then rebuild.

---

**Issue:** Form controls not displaying correctly

**Solution:** Check that Windows Forms Designer is properly loaded. Try closing and reopening the form designer.

For additional help, please open an issue in the repository issue tracker.

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add YourFeature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

### Coding Standards
- Follow C# naming conventions
- Use meaningful variable and method names
- Add XML documentation comments for public members
- Ensure code compiles without warnings
- Test all features before submitting PR

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact & Support

- **Author**: Jose Santiago Echevarria
- **Issues**: Please report bugs and feature requests via the repository issue tracker
- **Educational Context**: This project was developed as a course assignment demonstrating OOP principles in C# 
