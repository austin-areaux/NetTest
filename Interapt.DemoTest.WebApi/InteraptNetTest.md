# Interapt .Net Test Project

Below will list the requirements to complete the test.
## Getting Started
The project has 3 layers (Controller, Business, and Data Layers). There is an additional Business Objects project with the shared 'Person' Object.
At the end the project should be fully wired up to return all people, and a person by their ID. I have included (and already wired up) the sqlite file in the project (People.db).
## Requirements
- Using Dependency Injection, build the layers to pass the data from the data layer up to the controller layer. This must be done using all 3 layers. Data should flow like the following: DataLayer -> BusinessLayer -> ControllerLayer. 
- In the business layer for the GetPerson method, you will need to replace the persons 'GivenName' with your own after pulling the data. 
- In the data layer, you will need to wire up the Db Context in the PersonDataObject using dependency injection. 
- The final product should return the following
    - 10 entries (9 prefilled, and 1 that was added from an add endpoint, if there are more from testing, that's fine) from the get endpoint
    - 1 Entry, with your first name in the 'GivenName' property regardless of the id passed
    - The ability to add a new entry to the database
