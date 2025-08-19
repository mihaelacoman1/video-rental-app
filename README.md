## Video Rental App

Windows Forms desktop application for managing video (VHS/DVD) rentals, developed in C#.

## Overview

This project provides a simple and intuitive Windows Forms interface to handle the process of renting and returning videos. It is designed as a study project to practice desktop app development in C#.

## Features (current / planned)

- Browse available videos
- Rent a video (select, confirm, update status)
- Return a video
- Manage customers (add, view, rental history)
- Basic fee and late return penalty calculation (if implemented)

## Tech Stack

-C# (.NET Framework / .NET Core depending on target)

-Windows Forms for the user interface
- Optional: local data storage (files, XML, or database – depending on code implementation)

## Installation & Run

Clone the repository:
```bash
git clone https://github.com/mihaelacoman1/video-rental-app
cd video-rental-app
```

- Open the solution file VideoRentalApp.sln in Visual Studio.
- Make sure the required .NET version is installed.
- Run the project in Debug or Release mode – the Windows Forms UI should appear.
- Project Structure (approx.)
- VideoRentalApp/ → Main source code (C# forms & classes)
- packages/ → Dependencies (if included)
- VideoRentalApp.sln → Visual Studio solution file

## Future Improvements

 Persistent data storage (JSON, SQLite, or a small database)
  
Enhanced customer and rental management (due dates, penalties, reports)

UI improvements (movie posters, search, filters)

Statistics and rental reports
