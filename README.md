# Restaurant ASP.NET Core MVC Project

## Overview

This project is a web application developed using ASP.NET Core MVC to showcase a restaurant's menu. The site allows users to explore different dishes, view their details, and make reservations.

## Prerequisites

- [ASP.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (or any code editor of your choice)

## How to Run the Project

1. Clone this repository to your local machine.

    ```bash
    git clone https://github.com/your-username/restaurant-aspnet-core.git
    ```

2. Open the project in Visual Studio or Visual Studio Code.

3. Configure the database connection string in the `appsettings.json` file with your settings.

4. Run the application.

5. Go to [http://localhost:5000](http://localhost:5000) in your browser to see the site.

## Project Structure

- **Models**: Contains model classes for entities such as `Category` and `Discover`.
- **Views**: Contains Razor files (.cshtml) for the site views.
- **Controllers**: Contains MVC controllers, for example, `HomeController` and `DiscoverController`.
- **wwwroot**: Contains static files such as CSS stylesheets, JavaScript scripts, etc.
- **Program.cs**: Application startup configurations.

## Customization

1. Modify the `Category` and `Discover` models in the `Models` folder to reflect the data for your restaurant.

2. Customize the views in the `Views` folder to add restaurant-specific details.

3. Add images and customize styles in the `wwwroot` folder.

## Contributing

If you would like to contribute to this project, feel free to submit pull requests.

## Authors

- [Marong Kalilou](https://github.com/kalilou-marong)

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
