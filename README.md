# CRUDMVC Project

A simple **CRUD (Create, Read, Update, Delete)** web application built with **ASP.NET Core MVC** and **Entity Framework Core** using **SQL Server** as the database.  
This project demonstrates the fundamentals of MVC architecture, database integration, and performing basic operations on data.

---

## 🚀 Features
- Add new employees  
- View employee list  
- Update employee details  
- Delete employees  
- Validations and error handling  

---

## 🛠️ Tech Stack
- **C#** – Core programming language  
- **ASP.NET Core MVC** – Application framework  
- **Entity Framework Core** – ORM for database operations  
- **SQL Server** – Database  
- **Bootstrap** – For basic UI styling 

---

## ⚙️ Setup Instructions

### 1. Clone the Repository
```bash
https://github.com/Shisir2278/CRUDMVCPROJECT1.git
cd CRUDMVCPROJECT1
```

### 2. Configure the Database

1. Open the **`appsettings.json`** file in the project.  
2. Update the connection string with your **SQL Server name**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=CrudMVC;Trusted_Connection=True;MultipleActiveResultSets=true"
},
```
