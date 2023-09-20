# SOLID Principles


* Single Responsibility Principle (SRP): This principle states that a 
class should have only one reason to change. In other words, a class 
should have only one responsibility or job. 
To apply SRP, identify the different responsibilities of your class and
separate them into different classes if needed.

* Open/Closed Principle (OCP): This principle suggests that software 
entities (classes, modules, functions, etc.) should be open for extension 
but closed for modification. This means you can add new functionality 
without changing existing code. To follow OCP, design your code in a 
way that you can add new features by extending existing classes or 
adding new classes, rather than modifying existing ones.

* Liskov Substitution Principle (LSP): The LSP states that objects of a 
derived class should be able to replace objects of the base class without 
affecting the correctness of the program. In simpler terms, subclasses 
should be substitutable for their base classes without causing unexpected 
behavior. To adhere to LSP, make sure that your subclasses maintain the 
expected behavior of the base class.

* Interface Segregation Principle (ISP): This principle suggests that 
clients (classes that use interfaces) should not be forced to depend 
on interfaces they don't use. In other words, keep interfaces focused 
on a specific set of behaviors so that clients only need to implement 
what's relevant to them. To apply ISP, create smaller, more specialized 
interfaces instead of large, general-purpose ones.

* Dependency Inversion Principle (DIP): DIP states that high-level 
modules should not depend on low-level modules; both should depend on 
abstractions. It also emphasizes that abstractions should not depend on 
details; details should depend on abstractions. To follow DIP, use 
interfaces or abstract classes to define contracts between components 
and make sure your code relies on abstractions rather than concrete 
implementations.

