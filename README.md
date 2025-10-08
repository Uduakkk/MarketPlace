# MarketPlace

A full-stack web application that enables users to **buy and sell products** online.  
Built with **Angular**, **.NET Core**, and **SQLite**, Market Place connects buyers and sellers in a seamless and modern shopping experience.

---

## Project Overview

**Market Place** allows:
- Sellers to list and manage products.
- Buyers to browse, add to cart, order, and review items.
- Both parties to interact securely through an intuitive interface.

---

## Technology Stack

| Layer | Technology | Purpose |
|-------|-------------|----------|
| **Frontend** | [Angular](https://angular.io/) | Dynamic single-page app |
| **Backend** | [ASP.NET Core 8](https://dotnet.microsoft.com/en-us/apps/aspnet) | REST API for business logic |
| **Database** | [SQLite](https://www.sqlite.org/) | Lightweight relational DB |
| **ORM** | [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/) | Database mapping |
| **Styling** | Angular Material / Tailwind CSS | Clean and responsive UI |
| **Version Control** | Git + GitHub |

---

##  System Architecture

```text
          ┌─────────────────────────────┐
          │         FRONTEND            │
          │     (Angular Application)   │
          │─────────────────────────────│
          │  Components / Services / UI │
          └──────────────┬──────────────┘
                         │ REST API Calls
                         ▼
          ┌─────────────────────────────┐
          │          BACKEND            │
          │      (ASP.NET Core API)     │
          │─────────────────────────────│
          │ Controllers → Managers → DB │
          │        (EF Core ORM)        │
          └──────────────┬──────────────┘
                         │
                         ▼
          ┌─────────────────────────────┐
          │          DATABASE            │
          │          (SQLite)            │
          └─────────────────────────────┘
