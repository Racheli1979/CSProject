# README

## C# Project - Cash Register System

### General Description
This project aims to develop a cash register system for a store. The system will allow for the management of products, orders, and promotions, and will provide a management interface for store owners and a checkout interface for cashiers.

### Project Topic
You need to choose the type of store (for example: clothing store or shoe store) and build a cash register with at least five product categories.

#### Example Categories:
- **Clothing Store**: Shirts, Dresses, Pants, Socks, Pajamas
- **Shoe Store**: Men, Women, Children, Sports, Elegant

### General Requirements of the System
#### The store manager can:
- Manage products:
  - View, add, and update products
- Manage orders:
  - Receive notifications for low stock
  - Order missing products
- Manage promotions:
  - View, add, update, or delete promotions

#### The cashier can:
- View the product catalog
- Process transactions for customers
- Manage club members

### Project Stages
1. **Data Access Layer (DAL)**:
   - Create data entities
   - Implement CRUD operations
   - Console user interface

2. **Data Layer Interface and LINQ**:
   - Uniform service contract
   - Update interfaces to use `IEnumerable`

3. **Data Storage in XML**:
   - Additional implementation of the data layer using XML

4. **Layered Model and Logic Layer**:
   - Design patterns such as Singleton and Simple Factory Method

5. **Graphical User Interface**:
   - GUI for both the manager and the cashier

### Data Entities
- **Product**:
  - Unique identifier
  - Name
  - Category
  - Price
  - Stock quantity

- **Customer**:
  - ID number
  - Name
  - Address
  - Phone number

- **Promotion**:
  - Unique identifier
  - Product ID
  - Required quantity
  - Total price
  - Whether the promotion is for all customers or only for club members

### Data Types
- Identifiers (ID) - `int`
- Names, Addresses - `string`
- Product Categories - `enum`
- Quantity - `int`
- Price - `double`
- Date - `DateTime`

### Array Initialization
- Up to 50 products
- Up to 20 promotions
- Up to 100 customers

### Implementation Example
In the `DataSource` class, the system will start with at least 10 products, 5 promotions, and 15 customers.

### How to Run the Project
1. Open the project in Visual Studio.
2. Click the "Start" button to run the application.