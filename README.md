# Blazor User Form Exercise

# Overview
This project demonstrates a reusable Blazor form component that collects user information such as Name, Address, Age, and Email.  

The goal of this implementation is to keep the component clean, reusable, and easy to integrate into different pages while following standard Blazor practices.

---

## What I Built
In this project, I created:
- A reusable **UserForm component**
- A **parent page** that uses the component
- A simple **mock service** for async email validation

The form supports validation, async submission, and proper separation of concerns between the UI and business logic.

---

## Key Features
- Reusable component (`UserForm.razor`)
- Parent-child communication using `EventCallback`
- Validation using `DataAnnotations`
- Async email uniqueness check (mocked)
- Prevention of duplicate submissions
- Supports both Create and Edit scenarios
- One input field (Name) implemented **without `@bind`** as required

---

## Project Structure
Here’s how the project is organized:

- `/Components/UserForm.razor`  
  - Contains the reusable form UI and handles user input  

- `/Pages/UserFormDemo.razor`  
  - Demonstrates how the component is used  

- `/Models/UserModel.cs`  
  - Defines the data structure and validation rules  

- `/Services/EmailService.cs`  
  - Mock service for async email validation  

---

## How to Run the Project
You can run the project locally by following these steps:

1. Clone the repository: git clone https://github.com/JohnKylle29/blazor-userform-exercise.git
2. Open the solution in Visual Studio
3. Run the project
4. Navigate to:

---

## Notes and Assumptions
- Email validation is simulated using a mock service (no database required)
- The form uses **interactive rendering** to ensure proper validation and data binding behavior
- The focus of this solution is on clarity, structure, and maintainability rather than over-engineering

---

## Final Thoughts
I focused on keeping the implementation simple and aligned with the requirements.  
The component is reusable, easy to understand, and can be extended further if needed.

---

## Additional Notes
- Developed using Visual Studio 2026
- The email uniqueness check is mocked
- Use `test@gmail.com` to simulate a duplicate email scenario
