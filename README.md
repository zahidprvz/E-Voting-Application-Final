# E-Voting Application



E-Voting is a Windows Desktop based application developed in C# .NET that facilitates electronic voting for elections. It provides a user-friendly interface for voters to cast their votes, an admin panel for managing elections, and features for political parties to participate in elections.

## Table of Contents

- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Admin Panel](#admin-panel)
- [Contributing](#contributing)
- [License](#license)

## Features

1. **Voter Registration**:
   - New voters can register with their details, including name, address, and identification.
   - Existing voters can update their information.

2. **Election Management**:
   - Admins can create new elections, specifying the election name, date, and eligible voters.
   - Admins can view and manage ongoing and upcoming elections.

3. **Party Registration**:
   - Political parties can register by providing their details and symbols.

4. **Campaign Management**:
   - Registered parties can run election campaigns to promote their candidates.

5. **Vote Casting**:
   - Registered voters can cast their votes securely using the online portal during election days.

6. **Election Results**:
   - Election results are calculated and displayed to the public once voting is complete.

## Installation

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/zahiparviz/E-Voting-Application-Final.git
   ```

2. **Set Up Database**:
   - Create a SQL Server database for the application.
   - Update the connection string in `appsettings.json` with your database details.

3. **Build and Run**:
   - Open the project in Visual Studio or your preferred C# IDE.
   - Build and run the application.

## Usage

1. **Voter Registration**:
   - New voters can sign up by providing their information.
   - Existing voters can log in and update their details.

2. **Admin Panel**:
   - Access the admin panel by logging in as an administrator.
   - Create new elections, manage existing ones, and view election results.
   
3. **Party Registration and Campaigning**:
   - Political parties can register and promote their candidates through the party dashboard.

4. **Vote Casting**:
   - Registered voters can log in and cast their votes during the specified election period.

## Admin Panel

Access the admin panel by navigating to `/admin` after starting the application. Use the administrator credentials to log in. 

Admin Credentials:
- Username: zahid
- Password: 1234567

## Contributing

Contributions to the E-Voting application are welcome. If you'd like to contribute:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them with clear, descriptive messages.
4. Push your changes to your fork.
5. Create a pull request to merge your changes into the main repository.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
