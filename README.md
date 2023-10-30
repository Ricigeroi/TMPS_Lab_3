# TMPS_Lab_3: Design Patterns in Library System

This repository demonstrates the implementation of various design patterns in a library system.

## Patterns Demonstrated:

1. **Bridge Pattern**: This pattern decouples an abstraction from its implementation so that the two can vary independently. In this context, the `Book` class acts as an abstraction with two concrete implementations: `PhysicalBook` and `EBook`. [View Code](https://github.com/Ricigeroi/TMPS_Lab_3/blob/master/TMPS_Lab_3/Book.cs)

2. **Adapter Pattern**: Adapts a third-party e-book format to be compatible with our library system. The `EBookAdapter` class adapts the `ThirdPartyEBook` class to be compatible with our library system. [View Code](https://github.com/Ricigeroi/TMPS_Lab_3/blob/master/TMPS_Lab_3/EBookAdapter.cs)

3. **Composite Pattern**: Allows individual objects and compositions of objects to be treated uniformly. The `BookCollection` class demonstrates this pattern by treating a collection of books as a single entity. [View Code](https://github.com/Ricigeroi/TMPS_Lab_3/blob/master/TMPS_Lab_3/BookCollection.cs)

4. **Proxy Pattern**: Provides a surrogate or placeholder for another object to control access to it. The `EBookProxy` class controls access to the `EBook` class. [View Code](https://github.com/Ricigeroi/TMPS_Lab_3/blob/master/TMPS_Lab_3/EBookProxy.cs)

5. **Decorator Pattern**: Allows for adding new functionalities to an object dynamically. The `AbstractBookDecorator` class acts as a base decorator, with concrete decorators like `SummaryDecorator` and `ReviewDecorator` adding additional functionalities like summaries and reviews to a book. [View Code](https://github.com/Ricigeroi/TMPS_Lab_3/blob/master/TMPS_Lab_3/AbstractBookDecorator.cs)

## Usage:

The `Program.cs` file demonstrates the usage of all the above patterns in a library system context. [View Code](https://github.com/Ricigeroi/TMPS_Lab_3/blob/master/TMPS_Lab_3/Program.cs)
