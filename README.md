# ChronoSync Overview
ChronoSync is a **Desktop App** that deals with automating synchronization tasks—whether it's data fetching, updating, or maintaining consistent states across various parts of the system at specific time intervals.

# ChronoSync Application Architecture

This document provides an overview of the application architecture for the **ChronoSync** application, following the **Onion Architecture** pattern. It describes the layers and their responsibilities within the application.

## Architecture Overview

The **ChronoSync** application is structured using Onion Architecture to ensure separation of concerns, scalability, and maintainability. The layers are designed to depend on each other in a specific way, ensuring that the core domain logic is decoupled from external concerns like UI and databases.

## Facade Design Pattern

The **Facade Design Pattern** is used in the **Application Layer** to simplify interactions with complex subsystems.The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. This simplifies the client’s interaction with the system by hiding its complexity.

### Layer Structure

```plaintext
ChronoSync/
│
├── Application/                       # Application layer - Acts as the bridge between the Presentation Layer and the Core Layer. It contains the application's business rules and coordinates workflows between the core domain and external systems.
│   ├── Interfaces/                    # Contracts for services used across the application
│   ├── Models/                        # Data Transfer Objects (DTOs) used to carry data between layers.
│   └── Services/                      # Implements workflows, using the domain logic and infrastructure services.
│   
│
├── Core/                              # Core layer - Represents the heart of the application. This layer contains domain logic, independent of UI, database, or external services. The Core Layer is the foundation upon which all other layers depend.
│   ├── Entities/                      # Core domain models representing the business logic and data (e.g., User, Order).
│   ├── Interfaces/                    # Define contracts for services required by the domain logic, which are implemented in the Infrastructure Layer.
│   ├── Services/                      # Implements domain-specific logic and rules.
│   └── Utils/                         # Contains common utilities like validation, message box helpers, or data converters.
│       ├── ValidationHelper.cs        # Generic validation logic
│       ├── MessageBoxHelper.cs        # Helper for managing message box popups
│       └── ConversionHelper.cs        # Methods for common data conversions
│        
│
├── Infrastructure/                    # Infrastructure layer - Contains implementations for external dependencies such as databases, APIs, and file systems.This layer implements the contracts defined in the Core Layer.
│   ├── Services/                      # Implementations of external services (e.g., API calls, database connections)
│   ├── Utilities/                     # Additional utilities required by infrastructure (e.g., logging, network-related)
│   ├── Repositories/                  # Handles database interactions using implementations of core interfaces.
│   └── Models/                        # Models for transferring data between the database or APIs and the application.
│
└── Presentation/                      # Presentation layer - outermost layer, responsible for interacting with users ,Keeps the UI logic separate from the business logic.
    ├── ViewModels/                    # ViewModel classes that hold data for UI and handles the communication with the Application Layer
    ├── Globals/                       # Hold Application Wide usage property
    └── Assets/                        # Storage of Static content (e.g., Images , Gif, Icon) 
        ├── Images/                    # Storing Images and Gif
        └── Icons/                     # Storing icons


```
## Flow of Control in the Onion Architecture      
1. UI Interaction:
The user interacts with the Presentation Layer (e.g., clicks a button).
2. Application Logic:
The action triggers a service in the Application Layer, which manages workflows.
3. Domain Logic:
The application service calls domain services or entities in the Core Layer for business logic execution.
4. Infrastructure Interaction:
If needed, the Core Layer calls the Infrastructure Layer (via interfaces) for external operations like database access or API calls.


## Powered By Devnet