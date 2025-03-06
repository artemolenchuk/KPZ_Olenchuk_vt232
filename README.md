**Принцип DRY:**  
Принцип DRY полягає в тому, щоб уникати дублювання коду.  
Наприкладі мого коду, я уникаю повторення логіки створюючи базовий [клас Animal](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Animal.cs), який використовується для створення різних типів тварин. Або [клас Elephant](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Elephant.cs)   не містить повторення коду, а просто наслідує від Animal.  

**Принцип KISS:**  
Принцип KISS полягає в тому, щоб зберігати код простим і зрозумілим.  
В своєму коді я використовую прості класи та інтерфейси.  
Наприклад методи такі як [Eat](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/f56616e6de3fd8b649ed7cd842b167ff4ad38890/program/Zoo/Models/Animal.cs#L27) та [Work](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/f56616e6de3fd8b649ed7cd842b167ff4ad38890/program/Zoo/Models/Zookeeper.cs#L10), виконують одну просту задачу і не містять складних конструкцій.    

**Принцип SOLID:**  
      Принципи SOLID це набір з п'яти принципів для об'єктно-орієнтованого програмування, ось як ці принципи були застосовані.  
      **S** – Single Responsibility Principle, Кожен клас має лише одну відповідальність.   
      Наприклад клас [Zookeeper](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Zookeeper.cs) відповідає тільки за роботу з тваринами, а [Veterinarian](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Veterinarian.cs) — за лікування тварин.  
      
      **O** – Open/Closed Principle, Класи мають бути відкритими для розширення, але закритими для змін.   
      Я використовую наслідування для розширення функціональності без зміни базового класу, один з  прикладів є [клас Lion](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Lion.cs)
      
      **L** – Liskov Substitution Principle. підкласи повинні замінювати базові класи без порушення коректності програми.   
      В моєму випадку явикористовую підкласи [клас Lion](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Lion.cs), [клас Elephant](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Elephant.cs), [Zookeeper](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Models/Zookeeper.cs), і всі вони коректно замінюють базові класи.  
      
      **I** – Interface Segregation Principle, інтерфейси повинні бути спеціалізованими та не змушувати класи реалізовувати методи, які вони не використовують.   
      Я використовую інтерфейси, такі як [IAnimal](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IAnimal.cs), [IEmployee](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IEmployee.cs), [IEnclosure](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IEnclosure.cs), вони є спеціалізовані і не містять зайвих методів.  
      
      **D** – Dependency Inversion Principle, залежності мають бути інжектовані в класи, а не створюватися всередині них.   
      У моєму коді це можна побачити у використанні інтерфейсів та передачі залежностей через конструктори. Приклад є в класі [ZooInventory](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Services/ZooInventory.cs)

**Принцип YAGNI:**  
Принцип YAGNI закликає не додавати функціональність, яка не є необхідною на даний момент.   
В своєму коді я не створюю зайвих класів або методів, які не потрібно для зоопарку, всі класи та методи виконують лише основні завдання: управління тваринами, працівниками, їжею і загорожами.  

**Принцип Composition Over Inheritance:**  
Принцип полягає в тому, щоб використовувати композицію (створення складних об'єктів з інших об'єктів) замість наслідування, коли це можливо.   
Клас [ZooInventory](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Services/ZooInventory.cs) використовує композицію, зберігаючи тварин, працівників, їжу і загорожі в своїх списках, замість того щоб робити великі ієрархії класів.

**Принцип Program to Interfaces not Implementations:**  
Принцип програмування до інтерфейсів, означає, що ви повинні працювати з інтерфейсами, а не з конкретними класами.     
В моєму коді багато методів працюють з інтерфейсами (наприклад, [IAnimal](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IAnimal.cs), [IEmployee](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IEmployee.cs), [IEnclosure](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IEnclosure.cs), [IFood](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/lab1/program/Zoo/Interfaces/IFood.cs)), а не з конкретними класами.  

**Принцип Fail Fast:**    
Принцип "Fail Fast" закликає програму швидко повідомляти про помилки, щоб їх можна було швидше виявити.     
Реалізація даного принципу є в багатьох клас, наприклад [тут](https://github.com/artemolenchuk/KPZ_Olenchuk_vt232/blob/f56616e6de3fd8b649ed7cd842b167ff4ad38890/program/Zoo/Services/ZooInventory.cs#L14)  
