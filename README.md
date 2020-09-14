# EchoBot_RS
This bot has been created using [Bot Framework](https://dev.botframework.com), it shows how to incorporate simple bot into a Teams application that accepts input from the user and echoes it back with username.

## Prerequisites

- Microsoft Teams is installed and you have an account
- [.NET Core SDK](https://dotnet.microsoft.com/download) version 3.1
- [ngrok](https://ngrok.com/) or equivalent tunnelling solution

## To run this Bot

> Note these instructions are for running the bot on your local machine, the tunnelling solution is required because
the Teams service needs to call into the bot.

1) Clone the repository

    ```bash
    git clone https://github.com/Ramyak-Sanghvi/EchoBot_RS.git
    ```

1) If you are using Visual Studio
   - Launch Visual Studio
   - File -> Open -> Project/Solution
   - Navigate to `EchoBot_RS` folder
   - Select `EchoBot_RS.csproj` file

1) Run ngrok - point to port 3978

    ```bash
    ngrok http -host-header=rewrite 3978
    ```

1) __*This step is specific to Teams.*__
    - **Upload** the `RS (2).zip` to Teams (in the Apps view click "Upload a custom app")

1) Run your bot, either from Visual Studio with `F5` or using `dotnet run` in the appropriate folder.

## Interacting with the bot

You can interact with this bot by sending it a message.
