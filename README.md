# 🛠️ UniFix Desktop - University Maintenance System

![C#](https://img.shields.io/badge/Language-C%23-blue)
![.NET](https://img.shields.io/badge/Framework-.NET%209.0-purple)
![WinForms](https://img.shields.io/badge/UI-WinForms-blueviolet)
![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)
![License](https://img.shields.io/badge/License-MIT-yellow.svg)

UniFix Desktop is a robust, role-based management application built with **C# and .NET**. It streamlines university infrastructure maintenance by connecting students and teachers directly with specialized technical staff through a centralized, secure desktop portal.

---

## 📸 Screenshots

### 🔑 Authentication & Identity
| Login Interface |
| :---: |
| <img src="https://github.com/yonasleykun27/UniFix-University-Problem-Reporting-System/blob/main/Img/FormLogin.png?raw=true" width="400"> |

### 🛡️ Admin Control Center
| Global Task Management | User Database & Governance |
| :---: | :---: |
| <img src="https://github.com/yonasleykun27/UniFix-University-Problem-Reporting-System/blob/main/Img/FormAdminDashboard.png?raw=true" width="400"> | <img src="https://github.com/yonasleykun27/UniFix-University-Problem-Reporting-System/blob/main/Img/FormAdminDashboard1.png?raw=true" width="400"> |

### 👨‍🎓 Role Dashboards
| Student Reporting | Teacher Workspace | Staff (Solver) Tasks |
| :---: | :---: | :---: |
| <img src="https://github.com/yonasleykun27/UniFix-University-Problem-Reporting-System/blob/main/Img/FormStudentDashboard.png?raw=true" width="250"> | <img src="https://github.com/yonasleykun27/UniFix-University-Problem-Reporting-System/blob/main/Img/FormTeacherDashboard.png?raw=true" width="250"> | <img src="https://github.com/yonasleykun27/UniFix-University-Problem-Reporting-System/blob/main/Img/FormSolverDashboard.png?raw=true" width="250"> |

---

## ✨ Key Features

### 👤 Multi-Role Architecture
- **Admin Portal:** Complete system governance. Register staff members, assign tasks based on specialized categories, issue warnings, ban users, and view comprehensive global history.
- **Student Dashboard:** Dynamic reporting forms for Dormitories, Cafeterias, and Social issues. Includes a built-in "Warning" tracker (0-3 scale) to promote responsible usage.
- **Teacher Workspace:** Specialized reporting modules for academic environments, specifically tailored for Teaching Materials and Classroom Management.
- **Staff (Solver) Interface:** Automatic task filtering. Staff members only see issues relevant to their specific Job Title (e.g., the ICT Manager sees only Technology issues).

### 🛠️ Technical Highlights
- **Live Search & Filtering:** High-performance real-time data filtering implemented using **LINQ** queries for near-instant results.
- **Smart Task Mapping:** Automated routing logic that matches report categories to specific specialized managers.
- **Modern UI/UX:** A consistent "Dark Navy" theme powered by a custom `UIHelper` class, providing a professional look across all forms.
- **RESTful Integration:** Asynchronous communication with a backend API using `Newtonsoft.Json` for data serialization.

---

## 🧠 System Logic: Category Mapping
UniFix utilizes an intelligent routing system to ensure issues reach the right person instantly:

1. **Category Detection:** When a report is submitted (e.g., "Dormitory"), the system flags the specific department.
2. **Manager Routing:** The Admin uses the **Assign** logic to route the task to the designated Job Title (e.g., `Staff Dormitory Manager`).
3. **Task Isolation:** The Solver dashboard fetches only reports where `AssignedTo == CurrentUser.JobTitle`.

---

## 🚀 Tech Stack

- **Frontend:** Windows Forms (WinForms)
- **Framework:** .NET 9.0 (Desktop)
- **Language:** C# 13
- **Data Handling:** LINQ (Language Integrated Query)
- **JSON Serialization:** Newtonsoft.Json
- **Architecture:** Client-Server via REST API

---

## 📂 Project Structure

```text
├── UniFix.Desktop/          # UI Layer (WinForms)
│   ├── Forms/               # Dashboard, Login, AddStaff, etc.
│   ├── ApiClient.cs         # API Communication Engine
│   ├── UIHelper.cs          # Theme & Styling Engine
│   └── Program.cs           # Application Entry Point
├── UniFix.Data/             # Shared Data Models
│   ├── User.cs              # User Entity Model
│   └── Report.cs            # Maintenance Report Model
├── UniFix.Api/              # Backend API Layer
└── UniFix.sln               # Visual Studio Solution File
