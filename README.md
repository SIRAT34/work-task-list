# WorkTaskList

WorkTaskList is a simple Windows task management application developed with C# and .NET.
The project is designed with a clean and layered architecture to allow future expansion,
including potential Android support.

## Features
- Add new tasks
- Delete tasks
- Mark tasks as completed or pending
- Persistent data storage using JSON
- User-friendly textbox placeholder behavior
- Visual task status:
    - Completed tasks are displayed in green
    - Pending tasks are displayed in red

## Technologies Used
- C#
- .NET 8
- Windows Forms (WinForms)
- Git & GitHub
- JSON (System.Text.Json)

## Project Structure
```text
WorkTaskList
├ Models → Task model definitions
├ Services → Business logic and data handling
├ Data → JSON data storage
└ UI → Windows Forms interface
```

## Architecture
The application separates business logic from the user interface.
This design allows the core logic (Models and Services) to be reused
in other platforms such as Android in the future.

## Screenshots
(After developing the new features, screenshots will be added.)

## Future Improvements
- Task editing functionality
- Search and filtering
- More functional UI
- Dark Mode
- Retrieving and uploading the tasklist file
- Android version using .NET MAUI
- In the distant future, user account system
