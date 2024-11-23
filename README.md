# ChronoSync Overview
ChronoSync is a **Desktop App** that deals with automating synchronization tasks—whether it's data fetching, updating, or maintaining consistent states across various parts of the system at specific time intervals.

# ChronoSync Application Architecture

This document provides an overview of the application architecture for the **ChronoSync** application, following the **Onion Architecture** pattern. It describes the layers and their responsibilities within the application.

## Architecture Overview

The **ChronoSync** application is structured using Onion Architecture to ensure separation of concerns, scalability, and maintainability. The layers are designed to depend on each other in a specific way, ensuring that the core domain logic is decoupled from external concerns like UI and databases.

### Layer Structure

```plaintext
ChronoSync/
│
├── Application/                       # Application layer - Business services and interfaces
│   ├── Interfaces/                    # Interfaces for services used across the application
│   ├── Models/                        # Data models and DTOs used for communication
│   └── Services/                      # Application services implementing business logic
│   
│
├── Core/                              # Core layer - Domain and business logic
│   ├── Entities/                      # Domain models representing the application's core data
│   ├── Interfaces/                    # Interfaces for services used independent of application
│   ├── Services/                      # Core services implementing core logic
│   └── Utils/                         # Utility functions such as validation, message boxes, conversions, etc.
│       ├── ValidationHelper.cs        # Generic validation logic
│       ├── MessageBoxHelper.cs        # Helper for managing message box popups
│       └── ConversionHelper.cs        # Methods for common data conversions
│        
│
├── Infrastructure/                    # Infrastructure layer - External resources and technologies
│   ├── Services/                      # Implementations of external services (e.g., API calls, database connections)
│   ├── Utilities/                     # Additional utilities required by infrastructure (e.g., logging, network-related)
│   ├── Repositories/                  # Implementations for interacting with the data storage (e.g., MongoDB, SQL)
│   └── Models/                        #  Models for transfer and receiving of data from data storage
│
└── Presentation/                      # Presentation layer - UI components, forms, and controls
    ├── Forms/                         # Windows Forms or UI components
    ├── ViewModels/                    # ViewModel classes that hold data for UI and interact with services
    ├── Controls/                      # Custom controls used in UI
    └── Assets/                        # Storage of Static content (e.g., Images , Gif, Icon) 
        ├── Images/                    # Storing Images and Gif
        └── Icons/                     # Storing icons

```
## Powered By Devnet