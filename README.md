# WPF Application with System Information and User Management

This project is a WPF application built with .NET Core 6 that displays system information (machine name, username, OS version) and allows users to manage a list of users with their first name, last name, and phone number.

## Table of Contents
1. [Features](#features)
2. [Requirements](#requirements)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Screenshots](#screenshots)
6. [Contributing](#contributing)
7. [License](#license)

## Features 
- Displays system information: machine name, username, and OS version.
- Allows users to add new users with first name, last name, and phone number.
- Shows a list of users in a DataGrid.

## Requirements
- .NET Core 6
- MS SQL Server
- Visual Studio 2022 or later

## Installation

1. Clone the repository:
    ```bash
    https://github.com/PratikKharadGophygital/WpfAppTestSolution.git
    ```

2. Navigate to the project directory:
    ```bash
    cd WpfAppTest
    ```

## Usage

1. **Run the application**: Launch the application from Visual Studio or using `dotnet run`.

2. **View System Information**: Upon launch, the application will display system information at the top of the window.

3. **Add Users**:
    - Enter the user's first name, last name, and phone number into the respective fields.
    - Click the "Submit" button to add the user to the list.

4. **View Users**: The `DataGrid` will display the list of users with their first name, last name, and phone number.

## Screenshots

![System Information](./screenshots/pageone.png)
*Display of system information*

![User DataGrid](./screenshots/pagetwo.png)
*User DataGrid displaying the list of users*

