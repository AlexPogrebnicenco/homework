#  Speaker Registration Refactoring (HomeworkProject)

This is a console application that refactors the original `Speaker` class from [this GitHub repo](https://github.com/mustafadagdelen/dirty-code-for-clean-code-sample/blob/master/BusinessLayer/Speaker.cs) using Clean Code and SOLID principles.

---

##  Task Summary

> Refactor the `Speaker` class to follow Clean Code and SOLID principles, without changing its external behavior.  
> Keep other classes like `Session` minimal and only to make the app compile.

---

##  What Code Smells Were Found?

- Large method (`Register`) doing too much
- Too many responsibilities in one place (validation, business logic, DB)
- Hardcoded values (email domains, employers, fees)
- Tight coupling (no abstractions or interfaces)
- Poor exception handling
- Magic numbers and deep nesting

---

##  Problems With Original Code

- Violates SRP (Single Responsibility Principle)
- Hard to test and maintain
- Impossible to reuse logic separately
- Business logic mixed with data access

---

##  Refactoring Techniques Used

- Extracted classes: `SpeakerValidator`, `SessionApprovalService`, `RegistrationFeeCalculator`
- Introduced interfaces: `ISpeakerValidator`, `IRepository`
- Used Dependency Injection
- Replaced magic numbers with centralized logic
- Introduced custom exceptions

---

##  SOLID Principles Applied

| Principle | How It's Used |
|----------|----------------|
| **S**: Single Responsibility | Each class has one role |
| **O**: Open/Closed           | Easy to add new validation rules |
| **L**: Liskov Substitution   | Interfaces support substitution |
| **I**: Interface Segregation | Separate concerns via interfaces |
| **D**: Dependency Inversion  | Depends on abstractions, not implementations |

---

##  Project Structure

```
HomeworkProject/
├── Models/
│   ├── Speaker.cs
│   ├── Session.cs
│   └── WebBrowser.cs
├── Services/
│   ├── SpeakerValidator.cs
│   ├── SessionApprovalService.cs
│   └── RegistrationFeeCalculator.cs
├── Interfaces/
│   ├── IRepository.cs
│   └── ISpeakerValidator.cs
├── Exceptions/
│   ├── NoSessionApprovedException.cs
│   └── SpeakerRequirementsNotMetException.cs
├── Program.cs
```



---

##  How to Run

- Open in Visual Studio
- Press `Ctrl + F5` to run

Expected output:
 Speaker registered with ID: 123
 Registration fee: 50$

 
---

##  Author

Refactored by: **Alexandru Pogrebnicenco**  
Amdaris Internship, 2025
