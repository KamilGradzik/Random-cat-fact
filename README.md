# Random-cat-fact

## Description

`Small applcation developed for Netwise company's recruitment task purposes.`

`The purpose of the application is to retrieve a random fact about cats from an external API and then append that fact to the end of a text file. Additionally, a frontend application has been implemented to display the retrieved fact and fulfill the Backend application's purpose on click of the button.`


## Tech Stack

### Frontend

- `React.JS`
- `SCSS`
- `TypeScript`

### Backend

- `.NET 9.0`
- `C#`


## Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `GET` | `/api/cat-fact/fact` | `Gets single random cat fact from external API.` |


## Getting Started

### Prerequisites

Make sure you have installed:

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)

### Running the Application

The project consists of two parts: **Backend** and **Frontend**.

#### 1. Start the Backend

Open a terminal in the project root and run:

```bash
cd Backend
dotnet run
```

The .NET Web API will start on the configured local URL.

#### 2. Start the Frontend

Open another terminal and run:

```bash
cd Frontend
npm install
npm run dev
```

The React application will start on the local development server.
Open the URL displayed in the terminal to access the application.


## Credits

- <a target="_blank" href="https://icon-icons.com/authors/878-community">Cat Icon by Community.</a>
- <a target="_blank" href="https://www.pexels.com/pl-pl/zdjecie/kot-wasy-fotografia-zwierzecia-zwierze-domowe-10856738/">Cat Photo by Owen Mao.</a>
- <a target="_blank" href="https://www.pexels.com/pl-pl/zdjecie/kot-fotografia-zwierzecia-zwierze-domowe-koci-11642744/">Cat Photo by Owen Mao.</a>
