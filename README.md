# Animal Shelter

## About
Animal Shelter is a ASP.NET Core web application that serves as a platform for managing and presenting information about animals in a shelter. It allows users to browse a variety of animal types, listing them alphabetically and sorting them by the oldest date of admittance. The application also offers a search feature that enables users to filter animals based on breed or name. If a user clicks on a specific animal, they are presented with the animal's corresponding profile that includes essential details such as the animal's name, breed, type, and date of admittance.

## Application Setup

1. Clone this repo.
2. Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory called `AnimalShelter`. 
3. Within the production directory `AnimalShelter`, create a new file entitled `appsettings.json`.
4. Within `appsettings.json`, enter the following code:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database={DATABASE};uid={USERNAME};pwd={PASSWORD};",
      "TestConnection": "Server=localhost;Port=3306;database={DATABASE_TEST};uid=root;pwd=epicodus;"
  }
}
```
  > Be sure to replace the `{DATABASE}`, `{DATABASE_TEST}`,`{USERNAME}` and `{PASSWORD}` fields with your own relevant information. Do not include the curly brackets.
5. In the production directory, you can enter the following command `dotnet watch run`.
  > This command will start the project in development mode with a watcher.

![AnimalSQL.jpg](https://github.com/jeremyjosol/oct32023_AnimalShelter/blob/main/AnimalSQL.jpg?raw=true)