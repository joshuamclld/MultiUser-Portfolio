# Multi-User Portfolio System

## About the Project

The Multi-User Portfolio System is a web application designed to help professionals showcase their career achievements. Built with ASP.NET Core MVC, it allows users to easily manage and display their skills, projects, education, and work experience.

The application features a secure Admin Dashboard, giving users full control over their content without needing to write code. You can add new skills, update project details, and manage your professional timeline effortlessly.

Technically, the project uses a clean MVC architecture with SQLite and Entity Framework Core for data management. It is fully responsive, ensuring your portfolio looks great on desktops, tablets, and mobile devices. Secure login and registration are handled by ASP.NET Core Identity.

## Key Features

*   **Dynamic Portfolio Management**: Real-time updates to portfolio content without redeployment.
*   **Admin Dashboard**: Centralized control panel for managing all site data.
*   **Secure Authentication**: Built on ASP.NET Core Identity for secure login and registration.
*   **Skill Management**: Create, edit, and delete technical skills with proficiency levels.
*   **Project Showcase**: Dedicated section to display projects with descriptions and images.
*   **Experience & Education Timelines**: Chronological display of professional and academic history.
*   **Responsive Design**: Optimized for mobile, tablet, and desktop viewing.

## Technologies Used

*   **Framework**: ASP.NET Core MVC
*   **Language**: C#
*   **Database**: SQLite
*   **ORM**: Entity Framework Core
*   **Frontend**: HTML5, CSS3, Bootstrap, JavaScript

## Getting Started

To run this project locally, follow these steps:

1.  **Clone the repository**
    ```bash
    git clone https://github.com/joshuamclld/MultiUser-Portfolio
    ```

2.  **Navigate to the project directory**
    ```bash
    cd MultiUser_Portfolio
    ```

3.  **Add Migration**
    ```bash
    dotnet ef migrations add InitialCreate
    ```

4.  **Update the Database**
    Apply the Entity Framework migrations to set up the SQLite database.
    ```bash
    dotnet ef database update
    ```

5.  **Run the Application**
    ```bash
    dotnet run
    ```

6.  **Open in Browser**
    Navigate to the URL shown in your terminal (typically `https://localhost:5001` or similar).
