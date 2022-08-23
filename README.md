# Employee Badge Maker

## Table of Contents

- [Description](#description)
- [User Story](#user-story)
- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)

## Description

A console app built with C# that creates employee security badges for a company.

## User Story

As a user looking for an efficient way to create employee security badges, I would like an application that allows me to input an employee name, ID, and photo link, and uses the information to generate a completely formatted employee badge that I can access as a PNG file.

## Features

Users are prompted by the command line to input information that is generated into an employee badge.
![Video demonstration of creating a badge](assets/employee-badge-maker-demo-1.gif)

Users can create multiple employee badges at once. A CSV file is generated containing all employee information.
![Video demonstration of creating multiple badges](assets/employee-badge-maker-demo-2.gif)

Users can also choose to fetch employee data from an API. This API returns random employee data and is to demonstrate the application's ability to import a set of data and generate many employee badges at once.
![Video demonstration of fetching employee data from an API](assets/employee-badge-maker-demo-3.gif)

## Technologies

- C#
- .NET

## Installation

1. Clone the repo using `git clone`
2. Navigate to the root directory of the application in the terminal
3. Run `dotnet run` in the command line to launch the application
