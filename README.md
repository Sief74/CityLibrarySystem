--Library Management System (Console Application)--
1-Overview
A fully functional Library Management System built using C# (Console App) that simulates real-world library operations including member management, book tracking, borrowing, returning, and fine calculation.
The system is designed using strong Object-Oriented Programming principles and focuses on business logic rather than UI or database integration.
2-Branch Information
Branch ID,Name and Location ,Address,Phone Number,Working Hours (Open / Close),Branch Manager,Total Members,Total Book Copies
3-User & Member Management
Display all system users (Library staff + Members) /Each user includes: ID, Name, ,Phone ,Salary (for staff) ,Hire Date
Member profiles include:Join Date ,Transaction status/Borrow 
4-Book Management
View all available book copies only
Each book copy includes: Title , Category (e.g. Clean Code) , Condition (Good / Damaged)
View all book copies (available + borrowed)
5-Borrowing System
elect a member by ID,Display available books,Choose a specific book copy,
Update system state dynamically:(Book availability decreases/ Transaction is recorded)
6-Return System
Return a borrowed book by Book Copy ID , System validates: (Return date /Due date (14 days limit))
Automatically calculates: (Late return fines /Return status)
7-Borrowing History
Full history per member: Borrow Date,Due Date,Return Date,Status (Returned / Late),Fine applied or not
8-Register New Member
Add new members dynamically ,Auto-generated Member ID ,Member becomes immediately eligible to borrow books

--NOTES--
--Core Concepts Applied--
Object-Oriented Programming (OOP)
1-Encapsulation 2-Inheritance 3-Polymorphism 4-Abstraction
Business Logic Implementation
Data Validation
State Management without Database

--Technical Notes
No database is used (in-memory data simulation)
System behaves like a real backend service
Designed to be easily extendable to: Entity Framework Core && ASP.NET Core Web API

--How to Run
1-Open the project in Visual Studio
2-Run the application
3-Use the console menu to navigate features

--Future Improvements
1-Integrate SQL Server using EF Core
2-Build RESTful APIs with ASP.NET Core
3-Add Authentication & Authorization

--Author--
GitHub:https://github.com/Sief74
