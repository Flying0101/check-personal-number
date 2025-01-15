# Swedish Personal Number Validator
A console application that validates Swedish personal numbers. This application checks if a given personal number follows the correct format and validates it according to Swedish regulations.

## Prerequisites

.NET 9.0 SDK
Docker Desktop (optional, for running via Docker)
Git

## Clone and Run Locally
Option 1: Running with .NET

Clone the repository:

git clone [repository-url]
cd check-personal-number

## Navigate to the Application folder and run:

cd Application
dotnet run
Option 2: Running with Docker

Clone the repository as shown above
Pull the Docker image:

docker pull flying0101/check-personal-number:latest

Run the container:

docker run -it flying0101/check-personal-number:latest

## Running Tests
To run the unit tests:
cd UnitTests
dotnet test


## Input Format
The application accepts Swedish personal numbers in these formats:

YYYYMMDDXXXX


## Validation

Uses the Luhn algorithm for the control digit
The last digit serves as a check digit
The calculation follows the Swedish personal number specifications



## Technical Implementation
The application is built using:

C# 12 features
.NET 9.0 framework
XUnit for unit testing
Docker for containerization
GitHub Actions for CI/CD

## CI/CD Pipeline
The project uses GitHub Actions for:

Building the application
Running automated tests
Building and publishing Docker images
Deploying to Docker Hub