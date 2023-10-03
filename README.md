# Animal Shelter

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