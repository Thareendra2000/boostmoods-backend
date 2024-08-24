# BoostMoods

BoostMoods is a simple backend API designed to deliver a variety of uplifting compliments through a single endpoint.

## Tech Stack

- **Framework**: ASP.NET Core
- **Language**: C#

## Prerequisites

Ensure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

## Setup Instructions

### Clone the Repository

First, clone the repository:

```bash
git clone https://github.com/yourusername/boostmoods.git
cd boostmoods
```

### Install Dependencies

Restore the project dependencies by running:

```bash
dotnet restore
```

### Build the Project

Compile the project using:

```bash
dotnet build
```

### Run the Project

Start the application with:

```bash
dotnet run
```

By default, the API will be available at `http://localhost:5000`.

### Accessing the API

The API exposes a single endpoint:

- **Endpoint**: `GET /compliment`
- **Description**: Retrieves a random compliment.
- **Response**: A string containing a compliment.

#### Example Request

Use a tool like [Postman](https://www.postman.com/) or [cURL](https://curl.se/) to test the endpoint:

```bash
curl http://localhost:5000/compliment
```

---
