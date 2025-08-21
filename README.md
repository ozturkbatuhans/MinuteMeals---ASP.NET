# MinuteMeals---ASP.NET

**MinuteMeals** is an ASP.NET Core MVC web application built as part of a programming assignment.  
The goal of the project is to create a recipe website where users can browse and view quick and easy recipes using an **in-memory database**.  

---

##  Project Description

A client requested a simple recipe website that can display **10 recipes**.  
No advanced recipe management is required — only browsing and viewing details.  

The project demonstrates:
- ASP.NET Core MVC fundamentals  
- Entity Framework Core with an **InMemory database**  
- Proper use of **Dependency Injection**  
- Bootstrap styling and responsive design  
- Usage of **Partial Views** for component-based UI  

---

##  Features

### Home Page
- Displays a list of all recipes (at least 10 pre-seeded at startup).  
- Only the **name** and **cooking time** are shown.  
- Each recipe is displayed using a **partial view**.  
- Clicking a recipe navigates to its detail page.  

### Recipe Details
- Shows the recipe’s **name**, **cooking time**, **ingredients**, and **steps**.  
- Uses routing with `asp-route-id` to fetch details dynamically.  
- Includes a link to return to the home page.  

### Recipe Management Page
- Accessible via a separate **"Recipes"** menu option.  
- Displays a **Bootstrap-styled table** with recipe names and cooking times.  
- Each table row is rendered using a **partial view**.  

---

## 🛠 Technologies Used

- **.NET 8.0**  
- **ASP.NET Core MVC**  
- **Entity Framework Core (InMemory provider)**  
- **Bootstrap 5** (for responsive design)  
- **Razor Views & Partial Views**  

---

##  Project Structure

    MinuteMeals/
    │
    ├── Controllers/             # Contains HomeController, RecipesController, ManageController
    ├── Data/                    # RecipeDbContext (InMemory DB + seed data)
    ├── Models/                  # Recipe.cs (model), ErrorViewModel.cs
    ├── Views/
    │   ├── Shared/              # Layout and partial views
    │   ├── Home/                # Home and Privacy pages
    │   ├── Recipes/             # Index (list), Details (details view)
    │   └── Manage/              # Index (management list)
    │
    ├── wwwroot/                 # Static files (CSS, JS, Bootstrap)
    ├── Program.cs               # Application entry point and service configuration
    ├── appsettings.json         # Configuration file
    └── MinuteMeals.csproj       # Project file

------------------------------------------------------------------------

##  Getting Started

### Prerequisites

-   [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Running the Application

Clone the repository:

``` bash
git clone [repository-url]
cd MinuteMeals
```

Run the application:

``` bash
dotnet run
```

Navigate to the URL shown in the console output, e.g.:\
 <https://localhost:7127>

------------------------------------------------------------------------

##  Assignment Requirements Checklist

✔️ Model with required properties\
✔️ At least 10 seeded recipes in the database\
✔️ Home page with list of recipes (using partial view)\
✔️ Detail page with name, time, ingredients, and steps\
✔️ Navigation via `asp-route-id`\
✔️ Back navigation to home page\
✔️ Recipe management page with Bootstrap-styled table\
✔️ Partial views for rendering list items

------------------------------------------------------------------------

##  Contributing

This project was created for educational purposes.\
Pull requests are welcome, but for major changes, please open an issue
first.

------------------------------------------------------------------------



