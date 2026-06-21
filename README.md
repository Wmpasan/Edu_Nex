# EduNex

EduNex — Smart Class Management System (Windows Forms, C#)

Summary
- Desktop application built with .NET (WinForms) to manage teachers, students, attendance, fees, exams, notifications and classes.
- Uses MySQL / MariaDB for persistence. SQL schema file: `database_schema.sql` (root of repo).

Quick links
- Main code: `DatabaseHelper.cs`, `Program.cs`, `Form1.cs`, `Forms/` folder
- Models: `Models/` (Teacher, Student, Attendance, ClassFee, ExamResult, Notification, Class)
- Database schema: `database_schema.sql`
- Setup guide: `SETUP_GUIDE.md`

Prerequisites (developer)
- Microsoft Visual Studio Community 2026 (18.6.3) or compatible
- .NET runtime/SDK used by the project (project targets .NET for Windows)
- MySQL or MariaDB (XAMPP recommended for local dev)
- MySql.Data (Connector/NET) NuGet package (used by DatabaseHelper)

Getting started (run locally)
1. Start MySQL/MariaDB (XAMPP: start Apache and MySQL, then open phpMyAdmin at http://localhost/phpmyadmin).
2. Import the database schema:
   - Open `database_schema.sql` and execute in phpMyAdmin (Import) or run:
	 ```powershell
	 mysql -u root -p < "C:\Users\Rusiru\Desktop\Edu Nex\database_schema.sql"
	 ```
   - Default XAMPP MySQL user: `root` with empty password unless you set one.
3. Update connection string in `DatabaseHelper.cs` if required:
   ```csharp
   private static string _connectionString = "Server=localhost;Database=EduNex;User Id=root;Password=;";
   ```
4. Open solution in Visual Studio, restore NuGet packages, build and run (F5).

Admin account
- The schema inserts a sample admin account:
  - Email: `admin@example.com`
  - Password: `admin123`
- NOTE: Passwords are stored as plaintext in the current code/schema. See `README-DEV.md` for recommended changes (password hashing).

Project structure (high level)
- Forms/ — WinForms UI code (MainForm, AttendanceForm, StudentForm, FeeForm, ExamForm, NotificationForm, TeacherRegistrationForm, etc.)
- Models/ — POCO classes (Teacher, Student, Attendance, ClassFee, ExamResult, Notification, Class)
- DatabaseHelper.cs — central data access layer using MySql.Data
- database_schema.sql — schema and sample data
- SETUP_GUIDE.md — step-by-step setup instructions

Notes & recommendations
- Add a .gitignore to exclude build artifacts (bin/, obj/, .vs/). This repo currently tracks build outputs; consider cleaning and removing them from git history.
- Migrate plaintext passwords to secure hashing (BCrypt) and update registration/login logic in `DatabaseHelper.cs` and `TeacherRegistrationForm.cs`.
- Make DatabaseHelper null-safe when reading nullable DB columns (use DBNull checks).

If you want, I can:
- add a .gitignore and remove tracked build artifacts
- implement password hashing and update login/registration code
- create a developer README with more detailed notes

---
Generated on: 2026-06-21
