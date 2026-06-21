# EduNex

**EduNex — Smart Class Management System** (Windows Forms, C#)

A desktop application for managing teachers, students, attendance, fees, exams, notifications, and classes.

---

## Overview

- **Tech Stack:** .NET Windows Forms, MySQL/MariaDB, C#
- **Architecture:** 3-tier (UI, Data Access, Models)
- **Database:** Consolidated schema in `edunex_schema.sql` with 7 tables and sample data

---

## Repository Structure

```
C:\Users\Rusiru\Desktop\Edu Nex\
├── Forms/                          # WinForms UI
│   ├── MainForm.cs                 # Main dashboard
│   ├── StudentForm.cs              # Student management
│   ├── AttendanceForm.cs           # Attendance tracking
│   ├── FeeForm.cs                  # Fee management
│   ├── ExamForm.cs                 # Exam results
│   ├── NotificationForm.cs         # Notifications
│   ├── TeacherRegistrationForm.cs  # Teacher registration
│   └── ...
├── Models/                         # Data models
│   ├── Teacher.cs
│   ├── Student.cs
│   ├── Attendance.cs
│   ├── ClassFee.cs
│   ├── ExamResult.cs
│   ├── Notification.cs
│   └── Class.cs
├── DatabaseHelper.cs               # Data access layer
├── Program.cs                      # Entry point
├── Form1.cs                        # Login form
├── edunex_schema.sql               # Database schema
└── README.md                       # This file
```

---

## Prerequisites

- **Visual Studio:** 2022, 2026, or compatible
- **.NET:** Version matching project target
- **MySQL/MariaDB:** XAMPP (recommended) or standalone server
- **NuGet:** MySql.Data (Connector/NET)

---

## Quick Start (XAMPP)

### 1. Start MySQL

- Open XAMPP Control Panel → Start **Apache** and **MySQL**

### 2. Import Database Schema

**Option A: phpMyAdmin (GUI)**
1. Open http://localhost/phpmyadmin
2. Click **Import** → Choose File → select `edunex_schema.sql` → **Go**

**Option B: CLI (PowerShell)**
```powershell
& 'C:\xampp\mysql\bin\mysql.exe' -u root < "C:\Users\Rusiru\Desktop\Edu Nex\edunex_schema.sql"
```
(If you have a root password, add `-p` flag and enter it when prompted.)

### 3. Verify Database Connection

Open `DatabaseHelper.cs` and confirm the connection string:
```csharp
private static string _connectionString = "Server=localhost;Database=EduNex;User Id=root;Password=;";
```
Update if your MySQL root password is different.

### 4. Run the App

1. Open solution in Visual Studio
2. Restore NuGet packages
3. Build and run (F5)
4. Log in with admin credentials (see **Admin Account** below)

---

## Database Schema

The schema creates these tables:

| Table | Purpose |
|-------|---------|
| **Teachers** | Teacher accounts and profiles (includes admin) |
| **Students** | Student information, enrollment, fees |
| **Classes** | Class definitions, schedules, teacher assignments |
| **Attendance** | Attendance records per student per date |
| **ClassFees** | Fee billing and payment tracking |
| **ExamResults** | Exam scores and grades |
| **Notifications** | Alerts to parents/guardians |

Foreign keys use `ON DELETE CASCADE` or `ON DELETE SET NULL` for integrity.

---

## Admin Account

**Seeded admin user:**
- **Email:** `admin@edunex.com`
- **Password:** `admin123`
- **Class:** `All` (can manage all classes)

⚠️ **Security:** Passwords are stored as plaintext. Before production, implement password hashing (BCrypt).

---

## Sample Data Included

- **Teachers:** 6 (1 admin, 5 regular teachers)
- **Students:** 10 (distributed across classes 8-11th grade)
- **Classes:** 5 (10-A, 10-B, 9-A, 9-B, 11-A)
- **Attendance:** 5 sample records
- **Fees:** 5 sample billing records
- **Exams:** 5 sample results
- **Notifications:** 5 sample messages

---

## Code Organization

### DatabaseHelper.cs
Central data access layer. Methods for CRUD operations on each table:
- `GetTeacherByEmail(email)` — Teacher login
- `AddStudent(student)` — Insert student
- `GetAllStudents()` — List active students
- `AddAttendance(attendance)` — Record attendance
- Similar methods for Fees, Exams, Notifications, Classes

### Form1.cs (Login)
- Email validation (regex check with color feedback)
- Password field
- Login/Register/Clear buttons

### MainForm.cs (Dashboard)
- Menu to access Student, Attendance, Fee, Exam, Notification, Class forms
- Teacher/admin session tracking

---

## Troubleshooting

| Issue | Solution |
|-------|----------|
| "Unknown database 'EduNex'" | Run `edunex_schema.sql` again or create database manually |
| "Connection refused" | Verify MySQL service is running; check `Get-Service "MySQL80"` |
| "Access denied for user 'root'" | Check password in `DatabaseHelper.cs` matches your MySQL root password |
| App won't start | Restore NuGet packages; verify .NET SDK version |
