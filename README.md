# User Management - ASP.NET Core 8 MVC + ADO.NET

This is a simple User Management application built with **ASP.NET Core 8 MVC**, using **ADO.NET** to interact with a **SQL Server database**. It supports:

- Creating new users
- Viewing a list of users
- Showing user status as Active or Inactive
- Sidebar layout with basic navigation

---

## 📸 UI Preview

- Sidebar on the left
- "Create New User" button at the top-right
- User list displayed in a table

---

## 🛠️ Technologies Used

- ASP.NET Core 8.0 MVC
- ADO.NET (raw SQL with `SqlConnection`)
- SQL Server (LocalDB / Express / full version)
- Bootstrap 4 (for basic styling)

---

## 🗃️ Database Setup

### 1. Create Database

```sql
CREATE DATABASE UserManagementDb;
GO
USE UserManagementDb;
