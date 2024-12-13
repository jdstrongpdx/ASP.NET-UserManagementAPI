# User Management API Requirements

## General Project Requirements
- **Framework**: Use ASP.NET Core to develop the API.
- **Project Naming**: Name the project `UserManagementAPI`.

---

## Core API Functionality
1. **CRUD Operations**:
   - **GET**:
     - Retrieve a list of all users.
     - Retrieve a specific user by ID.
   - **POST**:
     - Add a new user record.
   - **PUT**:
     - Update an existing user's details.
   - **DELETE**:
     - Remove a user by ID.

2. **Data Validation**:
   - Ensure all user input is validated (e.g., no empty fields, valid email formats).

3. **Error Handling**:
   - Implement robust error handling for:
     - Invalid input data.
     - Failed database lookups.
     - General application errors.

4. **Performance Optimization**:
   - Ensure the **GET /users** endpoint handles large datasets efficiently.

---

## Middleware Implementation
1. **Logging Middleware**:
   - Log the following for all incoming requests and outgoing responses:
     - HTTP method (e.g., GET, POST).
     - Request path.
     - Response status code.

2. **Error-Handling Middleware**:
   - Catch all unhandled exceptions.
   - Return consistent JSON error responses:
     - Example: `{ "error": "Internal server error." }`.

3. **Middleware Configuration**:
   - Configure the middleware pipeline in the following order:
     1. Error-handling middleware.
     3. Logging middleware.

---

## Testing Requirements
1. **CRUD Endpoint Testing**:
   - Use Postman or a similar tool to test all API endpoints for expected behavior.
2. **Middleware Testing**:
   - Test logging middleware by sending requests and verifying logs.
   - Test error-handling middleware by simulating exceptions.

---

## Security and Compliance
1. **Standardized Responses**:
   - Ensure all endpoints follow a consistent error-response format.
2. **Auditing**:
   - Maintain comprehensive logs of all incoming requests and outgoing responses.

---

## Performance and Scalability
1. **Query Optimization**:
   - Optimize database queries to minimize response times.
2. **Scalability**:
   - Design the API to handle high request volumes efficiently.

---

## Deliverables
1. A fully functional `UserManagementAPI` project.
2. Documentation on:
   - API usage (endpoints, payloads, responses).
   - Middleware functionality.
   - Known issues or limitations (if any).
3. Logs demonstrating middleware functionality during testing.