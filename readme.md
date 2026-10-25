
.NET solution to connecting PostgreSQL, implementing CRUD operations, testing the API       

Project Architecture :   

                  CLIENT
             Browser / Postman
                    |
                    | HTTP Request
                    v
          ASP.NET Core Web API
                    |
                    v
               Controller
                    |
                    v
             Entity Framework
                    |
                    v
                Npgsql
          PostgreSQL Provider
                    |
                    v
             PostgreSQL DB
              DotnetPgDemoDB