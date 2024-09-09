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
    git clone https://github.com/yourusername/yourrepository.git
    ```

2. Navigate to the project directory:
    ```bash
    cd WpfAppTest
    ```

3. Restore the dependencies:
    ```bash
    dotnet restore
    ```

4. Update the `appsettings.json` file with your SQL Server connection string.

5. Build and run the application:
    ```bash
    dotnet build
    dotnet run
    ```

## Usage

1. **Run the application**: Launch the application from Visual Studio or using `dotnet run`.

2. **View System Information**: Upon launch, the application will display system information at the top of the window.

3. **Add Users**:
    - Enter the user's first name, last name, and phone number into the respective fields.
    - Click the "Submit" button to add the user to the list.

4. **View Users**: The `DataGrid` will display the list of users with their first name, last name, and phone number.

## Screenshots

![System Information](./screenshots/system_info.png)
*Display of system information*

![User DataGrid](./screenshots/user_datagrid.png)
*User DataGrid displaying the list of users*

## Contributing

Contributions are welcome! Please follow these steps:
1. Fork the repository.
2. Create a new branch for your changes.
3. Make your changes and commit them.
4. Push your branch to GitHub.
5. Open a pull request and describe your changes.

For more details, please refer to the [CONTRIBUTING.md](./CONTRIBUTING.md) file.

## License

This project is licensed under the MIT License - see the [LICENSE](./LICENSE) file for details.
