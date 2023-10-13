# Getting Started with Your .NET Project and Describing APIs

This guide will walk you through the process of setting up a .NET project, creating API endpoints, and documenting them.

## Prerequisites

1. **Install the .NET SDK:** Download and install the .NET SDK from the official .NET website: [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet).

2. **Code Editor:** Use a code editor or an Integrated Development Environment (IDE) such as Visual Studio, Visual Studio Code for development.

## Step 1: Clone the .NET Project

1. **Open a Terminal or Command Prompt:**

    ```bash
   git clone https://github.com/sichrisso/dotnet_assessment.git
   ```

2. **Navigate to the Directory:**

   
    ```bash
   cd WebApi
   ```

## Step 2: Build and Run the Project

1. **Build the Project:**

   Build the project using the .NET CLI:

   ```bash
   dotnet build
   ```

2. **Run the Project:**

   Run the project:

   ```bash
   dotnet run
   ```

   Your API should now be running at a URL like `http://localhost:5183`.

## Step 3: Endpoint Description

# Movie Endpoints
    ** Get /api/Movie: To fetch all Movies
    ** Post /api/Movie: To Create Movie 
    ** Get /api/Movie/{search}: To search movie by name
    ** Put /api/Movie/{id}: To update Movie
    ** Delete /api/Movie/{id}: To delete Movie

# Cinema Endpoints
    ** Get /api/Cinema: To fetch all Cinemas
    ** Post /api/Cinema: To Create Cinema 
    ** Put /api/Cinema/{id}: To update Cinema 

