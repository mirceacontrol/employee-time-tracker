#  Employee Time Tracker

A modern backend application for tracking employee hours, work sessions, and holidays.
Built with **.NET**, **Entity Framework Core**, **SQL Server**, and **Docker**.

---

##  Features

* **Employee CRUD API:** Create, read, update, and delete employees.
* **Work session and holiday tracking:** (Controllers/templates ready to add)
* **Swagger UI:** Interactive API docs at `/swagger`
* **SQL Server integration:** Containerized DB, persistent across runs.
* **EF Core migrations:** Easy schema evolution using one-off SDK container.
* **Easy Docker Compose setup:** Run full stack with a single command.

---

##  Tech Stack

* [.NET 8 / 9](https://dotnet.microsoft.com/)
* Entity Framework Core
* SQL Server 2022 (Dockerized)
* Docker & Docker Compose
* Swagger / OpenAPI

---

##  Getting Started

### **1. Clone the repository**

```sh
git clone https://github.com/your-username/employee-time-tracker.git
cd employee-time-tracker
```

### **2. Configure the Database Connection**

Connection string is pre-set for Docker Compose:

```
Server=employee-time-tracker-db,1433;Database=EmployeeTimeTracker;User=sa;Password=Your_password123;Encrypt=False;TrustServerCertificate=True;
```

### **3. Build and Start Services**

```sh
docker-compose up --build
```

### **4. Apply EF Core Migrations**

> One-time setup (after first `docker-compose up`):

```sh
# On Windows CMD:
docker network ls
# (Find your compose network, e.g. employee-time-tracker_default)

docker run --rm -it -v "%cd%":/app -w /app --network employee-time-tracker_default mcr.microsoft.com/dotnet/sdk:8.0 bash

# In the container:
dotnet tool install --global dotnet-ef
export PATH="$PATH:/root/.dotnet/tools"
dotnet ef database update
exit
```

---

##  API Usage

Once running, open [http://localhost:5000/swagger](http://localhost:5000/swagger)
Use the **Swagger UI** to test and explore endpoints.

---

##  Project Structure

* `Controllers/` — API endpoints
* `Models/` — EF Core entities (Employee, WorkSession, Holiday)
* `Data/` — DbContext
* `Dockerfile`, `docker-compose.yml` — Containerization

---

##  Development Workflow

* Add/modify models:
  `dotnet ef migrations add NewMigration`
* Rebuild and apply migrations as above.

---

##  Deployment

Easily deployable to Azure Container Apps, Azure Web App for Containers, or any Docker-compatible host.

---

## Contact

Made by [Mircea](https://github.com/mirceacontrol).

For older university projects, visit [@IgnatiucMircea](https://github.com/IgnatiucMircea).

---