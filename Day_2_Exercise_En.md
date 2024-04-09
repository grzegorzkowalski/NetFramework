#### Task 4: Books Service

1. In the Library.ConsoleApp project, create a `BooksService` class
2. In the `BooksService` class, implement the following methods:
   - AddBook():void -> It should retrieve all data from the user needed to create an instance of the `Book` class
   - RemoveBook():void -> It should get the title of the book to be removed from the user
   - ListBooks():void -> This method should display the text `The list of books will appear here`
   - ChangeState():void -> This method should collect from users the title of the book whose state is to be changed and the state change itself, e.g. -1
To convert a string to an int, use the Convert class
```csharp
Convert.ToInt32(Console.ReadLine());
```
3. Navigate to the `Program.cs` file in the Library.ConsoleApp project
4. Before the loop, create an object of the `BooksService` class
5. Inside the loop, replace the display of texts with a call to the appropriate method from the `BooksService` class object
6. Run the application and check if everything works properly

#### Task 5: Adding a repository

1. Open the `BooksRepository` class located in the Library.Persistence project
2. Create a `readonly List<Book>` field called _database
3. Create a parameterless constructor
4. In the constructor, add some books, you can use for this
    new Book("The Old Man and the Sea", "Ernest Hemingway", 1952, "AAAA", 10, 19.99m),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", 1940, "BBBB", 0, 119.99m),
    new Book("Alice in Wonderland", "C.K. Lewis", 1865, "CCCC", 53, 39.99m),
    new Book("The Chronicles of Narnia", "C.K. Lewis", 1949, "DDDD", 33, 49.99m),
    new Book("Harry Potter", "J.K. Rowling", 1997, "EEEE", 23, 69.99m),
    new Book("Catch-22", "Joseph Heller", 1961, "FFFF", 5, 45.99m),
    new Book("The Doll", "Bolesław Prus", 1889, "GGGG", 7, 76.99m),
    new Book("It", "Stephen King", 1986, "HHHH", 2, 12.99m),
    new Book("The Idiot", "Fyodor Dostoevsky", 1869, "IIII", 89, 25.99m),
    new Book("The Master and Margarita", "Mikhail Bulgakov", 1967, "JJJJ", 41, 36.99m),c below:
```csharp
    new Book("The Old Man and the Sea", "Ernest Hemingway", 1952, "AAAA", 10, 19.99m),
    new Book("For Whom the Bell Tolls", "Ernest Hemingway", 1940, "BBBB", 0, 119.99m),
    new Book("Alice in Wonderland", "C.K. Lewis", 1865, "CCCC", 53, 39.99m),
    new Book("The Chronicles of Narnia", "C.K. Lewis", 1949, "DDDD", 33, 49.99m),
    new Book("Harry Potter", "J.K. Rowling", 1997, "EEEE", 23, 69.99m),
    new Book("Catch-22", "Joseph Heller", 1961, "FFFF", 5, 45.99m),
    new Book("The Doll", "Bolesław Prus", 1889, "GGGG", 7, 76.99m),
    new Book("It", "Stephen King", 1986, "HHHH", 2, 12.99m),
    new Book("The Idiot", "Fyodor Dostoevsky", 1869, "IIII", 89, 25.99m),
    new Book("The Master and Margarita", "Mikhail Bulgakov", 1967, "JJJJ", 41, 36.99m),
```
5. Add the `Insert(Book book): void` method, which will be responsible for adding a new book to the list
6. Add a `GetAll(): List<Book>` method that will return all the books that are in the repository
7. Add the `RemoveByTitle(string title): void` method, which will remove the selected book from the repository. To find the book faster, you can use the following LINQ expression
```csharp
.First(x => x.Title == title)
```
8. Add a `ChangeState(string title, int stateChange)` method that will update the state in the selected title. Use the LINQ expression from the previous exercise.
9. Navigate to the `BooksService` file in the Library.ConsoleApp project
10. Create a constructor in which the only parameter will be an object of the `BooksRepository` class
11. Assign the `BooksRepository` class object to a field in the class called `_repository`
12. Use the `_repository` object in calls to the `BooksService` class methods
13. Go to the `Program.cs` file and before creating the `BooksService` object, create an object of the `BooksRepository` class
14. Pass the `BooksRepository` class object to the `BooksService` class constructor
15. Test whether you can add a new book to the repository

#### Task 6: Orders

1. Open the Library.Domain project
2. Create the BookOrdered class, which should contain:
    - Property BookId of int type
    - Propertis NumberOrdered of type int
3. Create the Order class, which should contain:
    - Property Date of type DateTime
    - propertis BooksOrderedList of type `List<BookOrdered>`
    - A parameterless constructor in whose body the following actions will be performed:
        - Setting Date propertis to `DateTime.Now`
        - Initialize BooksOrderedList with an empty list
    - ToString method (remember to use `override`), which will generate a string of characters in the form
        ```
        Order: Object creation date
        Book: IdKsiazki Count: Number of books ordered
        ```
        you can use string interpolation for this purpose
        ```csharp
            string str = "Test";
            str += $"Test: {SomeVariable} Test2: {SomeVariable}";
        ```
4. Navigate to the Library.Persistence project
5. Create the `OrdersRepository` class
6. Inside the `OrdersRepository` class, create a private `database` field of type List<Order>, which is immediately initialized with an empty list.
7. Inside the `OrdersRepository` class, implement two methods:
    - `Insert(Order order): void` -> calling this method is to add elements to the collection
    - `GetAll(): List<Order>` -> calling this method will return all previously added orders
8. Navigate to the Library.ConsoleApp project
9. Create the `OrderService` class
10. In the `OrderService` class, create a constructor that will accept an object of the `OrdersRepository` class as its parameter
11. In the constructor of the `OrderService` class, assign the `OrderRepository` class object to a private field called `_orderRepository`
12. In the `OrderService` class, implement the `PlaceOrder` method, which will be responsible for the process of placing a new order:
    - Creating an object of the `Order` class,
    - Writing the menu in the form:
    ```
        add - add items to the order
        end - close the order
    ```
    - When entering the `add` command, the program should ask the user for:
        - Book ID
        - Quantity
    - Then create an object of the `BookOrdered` class and add it to the `BooksOrderedList` field from the `order` object
    - Then return to the `add / end` menu to be able to add more than just one item to your order
    - When you enter the `end` command, the program should add the `order` object to the repository
13. In the `OrderService` class, implement the `ListAll` method, which will list all orders downloaded from the repository
14. Navigate to the `Program.cs` file in the Library.ConsoleApp project
15. Create an `OrdersRepository` class object before the main program loop
16. Create an object of the `OrdersService` class, using the previously created object of the `OrdersRepository` class
17. Use the `OrdersService` class object to connect its methods to tasks:
    - add an order
    - list of orders
18. Run the Library.ConsoleApp application in debug mode
19. Test whether adding orders works correctly
20. *Make sure that you cannot add a book to your order that is not in the repository
21. *Make sure that more books cannot be added to the order than are in the repository.

#### Task 7: Generic Types / Interfaces

1. Create a new project of type `Console Application`.
2. Create an IToolKit interface that declares one method: GetTools(): string[]
3. Create an IParts interface that has a single method declaration: GetParts(): string[]
4. Create an IkeaKit class that has one generic parameter called `TContents`
5. For the generic parameter of the IkeaKit class, add constraints to enforce:
    - TContents must implement the IToolKit interface
    - TContents must implement the IParts interface
    - TContents must have a parameterless constructor
6. Inside the IkeaKit class, implement the Title and Color properties
7. Mark property Title and Color as virtual:
    "public virtual string Title { get; set; }"
8. Add the GetInventory method where the loop will list all the tools and parts needed to assemble the set.
    "For this you will need to initialize the TContents object"
9. Create the Chair class
10. Implement the IToolKit and IParts interfaces in the Chair class
    Tools may return: "Screwdriver", "Allen Key"
    Parts can return: "leg", "leg", "leg", "seat", "back", "bag of screws"
11. Implement a class called Adde (name of the Ikea chair)
12. The Adde class should inherit from the `IkeaKit<Chair>` class.
13. In the Adde class, set the proper Title and Color to the appropriate values
    "Adde" and "Cyan"
14. Add the override keyword to the properties of the Adde class
    "public override string Title"
15. Create a sister class, Markus, to the Adde class, only in this class the properties should take the following values: "Markus" and "Orange", respectively
16. Then call the following code in the Main function:
    var chair = new Markus();
chair.GetInventory();

#### Task 8: Encapsulation

1. Open the Book.cs file located in the Library.Domain project
2. Remove the set operator from all properties.
3. For the `ProductsAvailable` property, add the set operator along with the private privacy modifier
4. Add a new method to the Book class that will be responsible for modifying the inventory. Call this method: `ChangeProductsAvailableNumber(int change)`
5. Go to the BooksRepository file in the Library.Persistence project and change the property setting in the ChangeState method to call the method from the Book class
6. Navigate to the Order.cs file in the Library.Domain project
7. In properties, delete the set keyword
8. Navigate to the BookOrdered file in the Library.Domain project
9. Delete the set keyword in propert
10. Create a constructor that must contain two arguments: BookOrdered(int bookId, int numberOrdered)
11. Open the OrderService file located in the Library.ConsoleApp project
12. Change the initialization of the BookOrdered class in the line where the new order item is added so that it is consistent with what was just done.

#### Task 9: Inheritance

1. Go to the Library.Domain project
2. Create an IModel interface that should contain one propertis: int Id { get; set; }
3. Create a BaseModel abstract class that implements the IModel interface
4. Open the Book class
5. Use inheritance so that the Book class inherits from the BaseModel class
6. Open the Order class
7. Use inheritance so that the Order class inherits from the BaseModel class
8. Navigate to the Library.Persistence project
9. Create a BaseRepository class that will have one generic parameter named T
10. Specify that the generic parameter T must implement the IModel interface
11. Create a Database field of type `List<T>` with the visibility scope protected
12. Create a Counter field of type int with the visibility range protected
13. In the BaseRepository class, create methods such as:
    - Insert(T element): void -> The method should first set the element's Id to the next Counter value. And only then insert the item into the list
    - Remove(T element): void -> The method should remove the selected element from the list
    - RemoveById(int id): void -> The method should remove the selected item from the list:
    We can use the RemoveAll method from the list object API and use a lambda expression to clearly specify that we are looking for elements with a given id: "x => x.Id == id"
    - GetAll(): `List<T>` -> The method returns all elements that are in the list
    - virtual GetById(int id): T -> The method should return only a single element found by Id, we can use another auxiliary method from LINQ (SingleOrDefault)
14. Open the BooksRepository file
15. Change the BooksRepository class to inherit from the `BaseRepository<>` class
Book
16. Remove unnecessary methods from the BooksRepository class
17. Open the OrdersRepository file
18. Change the OrdersRepository class to inherit from `BaseRepository<Order>`
19. Remove unnecessary elements from the OrdersRepository class

#### Task 10: Polymorphism

1. Create a new project of the Console Application type
2. Create an abstract class Animal
3. Inside the Animal class, implement:
   - Virtual property Weight of int type
   - Virtual Meal property of the int type
   - A virtual method called Eat
4. Inside the Eat method, write the logic responsible for incrementing the Weight property by the value of the Meal property
5. Create a Human class that will inherit from the Animal class
6. In the Human class, create a parameterless constructor in which you set the values:
    - Weight: 75
    - Meal: 3
7. Create a Cat class that will inherit from the Animal class
8. In the Cat class, create a parameterless constructor in which you set the values:
    - Weight: 5
    - Meal: 1
9. Create a Dog class that will inherit from the Animal class
10. In the Dog class, create a parameterless constructor in which you set the values
    - Weight: 20
    - Meal: 2
11. In the Dog class, override with a virtual method of the Animal class named Eat
12. The logic of the new Eat method in the Dog class should be Weight += Meal / 2;
13. Create an object of the Human class and assign it to a variable of the Animal type
    - Then call the Eat function on it
    - List the Weight property of this object in the console
14. Create an object of the Cat class and assign it to a variable of the Animal type
    - Then call the Eat function on it
    - List the Weight property of this object in the console
15. Create an object of the Dog class and assign it to a variable of the Animal type
    - Then call the Eat function on it
    - List the Weight property of this object in the console

#### Task 11: Application Summary/Refactor

1. Navigate to the Library.ConsoleApp project
2. Create an IHandler interface that contains one Handle():void method
3. Create an ICommand interface that will contain two properties:
    - string Name { get; }
    - string Description { get; }
4. Create a Handler class that will implement the IHandler interface
5. Create a constructor in the Handler class with one parameter. This parameter should be of type Action and called logic
6. Save the passed parameter to a private field in the class named _logic
7. Inside the Handle method, run the previously obtained _logic function (ex: "_logic()")
8. Create a Command class that will implement the ICommand interface
9. The Command class should have a constructor that takes two parameters:
    - stringname
    - string description
10. Create the Processor class
11. The processor class should contain a private field of the Dictionary<ICommand, IHandler> type called "_actions". This field should be initialized immediately with "new Dictionary<ICommand, IHandler>()"
12. The class should have a private static method called "AfterCommand", which should contain the code responsible for displaying the message: "Press any button to continue." And then this method should retrieve any character from the keyboard using "Console.ReadKey"
13. Implement a method in the class called "RegisterNewAction(ICommand, IHandler): void", which should add a new command and a new handler to the dictionary.
14. Implement a method in your class called GetAllCommandsWithDescription(): string
    You can copy the function body:
    var sb = new StringBuilder();

    foreach (var (command, handler) in _actions)
    {
    sb.Append($"{command.Name} - {command.Description} \n");
    }

    return sb.ToString();

    +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    15. Implement the HandlerCommand(string command): void method
16. Go to the Program.cs file
17. After creating the services and repository, create an object of the Processor class
18. Define processor actions using the RegisterNewAction method
    _processor.RegisterNewAction(new Command(), new Handler(() => action))
    (In case of the "exit" command, please run the code Enviroment.Exit(0) )
19. Move the application menu output to a separate static method, call it "DisplayMenu"
20. In the DisplayMenu method, delete the code responsible for displaying command names and their descriptions
21. Use the processor object method to display the application menu
    (Note: you will need to save the processor object as a field of the Program class, or pass this object in the parameters of this function call)
22. Instead of a huge if, call the function _processor.HandleCommand(command) where as command pass the string of characters entered from the user
23. Finally, you can move User Authorization to a separate static function to make the program code a bit cleaner.

#### Task 12: Exceptions

1. Go to the Library.Domain project
2. Open the source code of the Book class
3. For each constructor parameter, write protection:
    - For string parameters, use the `string.IsNullOrWhiteSpace` method
    - For publicationYear, write a condition that checks whether the publication date is greater than 1000 and less than the current year (`DateTime.UtcNow.Year`)
    - For productsAvailable the value should be in the range <0;2000)
    - For Price it should be greater than 0.00m

   Remember to match the type of exception thrown to the type of offense:
    - ArgumentOutOfRangeException
    - ArgumentNullException
4. Add security in the ChangeProductsAvailableNumber method. Remembering that you need to check the inventory after the arithmetic operation.
5. Go to the BookOrdered class
6. Add protection for constructor parameters so that they cannot take values
   smaller than zero
7. Navigate to the Library.ConsoleApp project
8. In the Library.ConsoleApp project, create a `Exceptions` directory
9. In the Exceptions directory, create your own exception `ActionNotSupportedException`, remember to implement 3 constructors
    - ActionNotSupportedException() : base()
    - ActionNotSupportedException(string message) : base(message)
    - ActionNotSupportedException(string message, Exception inner) : base(message, inner)

#### Task 13: Attributes

1. Navigate to the Library.ConsoleApp project
2. Create the Attributes directory
3. Create a Command class that inherits from the System.Attribute class
4. Add the `AttributeUsage(AttributeTargets.Class)` attribute to the Command class
5. Create a constructor for the Command class that has two parameters
    - name: string
    - description: string
6. Create two private fields of type string and names:
    - _name
    - _description
7. Assign the variables entered by the constructor to the class fields implemented in the previous point
8. Create a GetName method that will return the _name field
9. Create a GetDescription method that will return _description

#### Task 14: Reflections

1. Navigate to the Library.ConsoleApp project
2. Create a private field in the Processor class that will contain a <string, IHandler> dictionary called `actions`, initialize this field immediately.
3. Create a parameterless constructor
4. In the constructor, use reflection and LINQ queries to retrieve all types that implement the `IHandler` interface

            var type = typeof(IHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p))
                .Where(p => !p.IsInterface)

5. Use the LINQ `ToDictionary` expression to create a dictionary
6. Define a lambda expression as the dictionary key that will retrieve the Custom attribute (Comand)
   from the given type and then retrieve the name field
7. As the second lambda expression, use the (IHandler)Activator.CreateInstance(Type) class to create an instance
8. Finally, assign the dictionary created this way to the _actions variable
9. In the HandleCommand method, use the Try, Catch, Finally block to handle errors while executing commands
10. Make the previously defined call to the Handle method on the object
11. Get the actions to perform from the action list
12. Add security: If it did not retrieve the action from the list, it should throw an ActionNotSupportedException exception
13. Call the Handle method on the retrieved action
14. In the finally section, call the AfterCommand method
15. Create a Handlers directory
16. Create classes, let each class below implement the IHandler interface
    - AddBookHandler
    - ChangeStateHandler
    - ExitHandler
    - ListBookHandler
    - ListOrderHandler
    - PlaceOrderHandler
    - RemoveBookHandler
17. Go to the Library.Persistence project
18. Create a classic Repositories class
19. In the repositories class, add two static fields

    public static readonly BooksRepository BooksRepository = new BooksRepository();
    public static readonly OrderRepository OrderRepository = new OrderRepository();

20. In each *Handler class, copy the appropriate logic into the Handle method:
    e.g. For the AddBookHandler class, you need to copy the logic from the BooksService class from the AddBook method
21. For the `ExitHandler` handler, set the implementation of the Handle method to `Enviroment.Exit(0)`
22. After adding the logic to each handler, you can delete the BooksService and OrdersService classes
23. You can delete ICommand and Command
24. Go to the Program.cs file
25. Delete references to the Command, BooksService and OrdersService classes
26. Delete all calls to the RegisterNewAction method on the processor object
27. You can delete the RegisterNewAction method in the processor file
28. in the Processor.cs file, in the GetAllCommandsWithDescription method, a LINQ expression that will retrieve the types from the values ​​(_actions.Values) of the dictionary.
29. Then, using reflection, it will receive information from the Command Attribute (name, description)
30. Using the method `.Select((x) => $"{x.Key} - {x.Value}");` will generate arrays of captions in the menu
31. using the method `string.join("\n", methods.ToArray());` will return the application menu


### Chapter 1 - Delegate

#### Excercise 1

1. Create a delegate named `Vat`.
1. The delegate should accept a `decimal` parameter called `amount`.
1. The delegate should return a `decimal` number.
1. Create a `Tax` class with a `AddVat` method, a `Vat` delegate field called `PlusVat`.
1. The method should take a decimal parameter called `amount` and return the type `decimal`.
1. The method should call the `PlusVat` delegate giving it the `amount` parameter and return the delegate result.
1. If the delegate does not point to any function, the method should return the amount specified in the parameter.
1. In the `Main` method, create an object of the `Tax` class.
1. Assign a lambda expression to the delegate of the `Tax` object, which will add up to 23% to the amount from the parameter.
1. Check the operation of the `AddVat` method and display the result in the console.

#### Exercise 2

1. In the `Program` class, create a static delegate of type `Func` with one return type `int` called `Summary`.
1. In the `Main` method, assign four lambda expressions to the delegate that will return different values.
1. Create an `int` variable called `sum` that will sum all the values ​​returned by the functions assigned to the delegate.

#### Exercise 3

1. In the `Program` class, create a static delegate of type `Func` with one return type and one parameter of type `string`.
1. In the `Main` method, assign a lambda expression to the delegate, which will accept any string of characters and return it in reverse order. For example, with the parameter `Amy` they will return `ymA`.
1. Check the delegate's operation with any text and display the result in the console.

#### Exercise 4

1. Create a class called `Counter`.
1. In the class, create a public property called `Current` of type `int` and a private field of the same type called `_current` to which the property will write and from which it will read data.
1. In the class, create a delegate named `NumberChanged` of type `Action` with two parameters of type `int`.
1. The `set` method of the `Current` property should call the `NumberChanged` delegate and pass the previous number and the newly assigned one to it. The delegate should be called after assigning a number to the `_current` field.
1. The `get` method should remain unchanged.
1. In the `Main` method, create an object of the `Counter` class called `counter`, and assign a lambda expression to the delegate of this object, which will display information in the console about changing the value of the `Current` property in the format: `It was: 12, It is : 14`.
1. Change the value in the object several times.

### Chapter 2 - Function

#### Excercise 1

1. In the `Main` method, create a local function called `even`.
1. The function should accept an `int` parameter called `number` and return a `string` type with information whether the number is even or not.
1. Test the function with several different parameters and display the results on the screen.

#### Exercise 2

1. In the `Main` method, create a collection of type `List<string>` called `names` with sample data:
```
Basia
Kate
Sophie
Bruce
Victor
```
1. Get the name starting with the letter `Z` using the `Single` method, which is part of the `Linq` library. The method takes a lambda expression that checks the condition of each object in the collection and returns the one that returns `true`. Display the downloaded name in the console.

---

#### Exercise 2.1

1. Using the `Add` method, expand the list with the name `Zbyszek`.
1. Run the program and see the results.

#### Exercise 2.2

1. Remove names starting with `Z` using the `Remove` method.
1. Run the program and see the results.

#### Exercise 2.3

1. Use the `Clear` method to remove all values ​​from the list.
1. Run the program and see the results.

#### Exercise 3

1. In the `Main` method, create a `Func<int, int>` delegate called `increase`, to which assign a lambda expression that will return the value specified in the parameter increased by two.
1. Test the delegate by passing three different arguments and displaying them in the console.

#### Exercise 4

1. In the `Main` method, create a delegate of type `Func`.
1. The delegate should accept two parameters of type `string` and return type `int`.
1. Assign an anonymous method to the delegate that will compare the lengths of strings and return:
    1. `1` if the first string is longer.
    1. `0` if the strings are equal.
    1. `-1` if the second string is larger.
1. Test the delegate performance on sample data and display the results in the console.

### Chapter 3 - Event

#### Exercise 1

1. Create a class called `Users`.
1. In the class, create a private collection of type `List<string>` called `_users`.
1. Create a `void Add(string login)` method that will accept a `string` parameter called `login`. The `login` parameter should be added to the `_users` list.
1. In the class, create an event called `UserAdded` of type `Action` with one parameter of type `string`.
1. Modify the `Add` method so that it triggers the `UserAdded` event when a user is added. Before calling, check whether the event subscribes to the functions to be called.
1. In the `Main` method, create an object of the `Users` class called `users` and a lambda expression that displays the given argument to the console that subscribes to the `UserAdded` event.
1. Check the operation of the `Add` method.

#### Exercise 1.1

1. In the `Users` class, create a `Remove` method with a `string` parameter called `login`.
1. In the `Users` class, create an `UserRemoved` event of type `Action` with one parameter of type `string`.
1. The `Remove` method should remove the user with the given login from the list and trigger the `UserRemoved` event, passing the deleted login to him.
1. Check the operation of the `UserRemoved` event by subscribing to it with the same lambda expression and removing the user using the `Remove` method.

#### Exercise 2

1. Create a class called `WordBuilder`. The class will allow you to create a word letter by letter.
1. In the class, create a public read-only property of type `StringBuilder` called `Word`.
1. In the class, create the `AddChar` method, which will have one parameter of type `char`.
1. In the class, create an event of type `Func` called `CharAdding` with the following properties.
    1. The return type is `bool`, the value of which will inform whether to add a character to the word being created.
    1. Three parameters to which the following information will be transferred.
        1. The currently stored word.
        1. Length of the current word.
        1. Newly added letter.
1. The `AddChar` method should trigger the `CharAdding` event, to which it will pass appropriate parameters, and the result of triggering the event determines whether another character is added to the word being created.
1. In the `Main` method, create an object of the `WordBuilder` class called `wordBuilder` and assign a lambda expression to the `CharAdding` event, which will add a character to the word if it is an alphanumeric character.
1. Check the `AddChar` method by calling it several times with the following characters: `aa%$4 AD%`.
1. Display the created word with the `Word` property in the console.

### Chapter 4 - Exception

#### Excercise 1

1. In the `Main` method, display a message asking you to enter your age with the text `Enter Age:`.
1. Create an `int` variable called `age`, which should be initialized with the value provided by the user.
1. To convert one type to another you can use the `Convert` class. This is a static class.
1. In the console, display the age multiplied by 2.
1. Check the program operation.
1. Restart the program and enter text instead of a number. The program will throw an unhandled exception and terminate.
1. Run the program in debug mode and see what exception is thrown.
1. Place the exception throwing statement in a try catch block and handle it.
1. The exception should be handled by displaying a message with the information `Age Invalid.`.
1. Check the program operation in debug mode.

#### Exercise 2

1. In the `Main` method, create a `while` loop with the `true` condition.
1. In the loop, display a message saying `Enter Command:`, get the text and if:
    1. It is equal to the word `exit` leave the loop and end the program.
    1. It is equal to the word `div`.
        1. Get two numbers into two variables named `a` and `b`. Before entering numbers, precede them with appropriate messages saying `Enter the First Number:` and `Enter the Second Number:`.
        1. Variables should be of type `int`.
        1. Divide the variables by yourself and display the result in the console.
        1. Run the program and see how the program works when we divide by `0`.
        1. Secure the split operation with a `try catch` block by catching the appropriate type of exception. You can check what type of exception throws a division by zero error by running the program in debug mode.
        1. The exception should be handled by displaying the message `Cannot Divide By Zero.` and closing the program.

#### Exercise 2.1

1. Create another `catch` block with an exception handler in case the retrieved values ​​are incorrectly cast to the `int` type.
1. The exception should be handled by displaying the message `Invalid Data Format.`.

#### Exercise 3

1. In the `Main` method, create a `while` loop with the `true` condition.
1. Before the loop, create a collection of type `List<string>` called `texts`.
1. In the loop, display the message `Enter Command:`, get the text, depending on the text, the program should:
    1. `exit` leave the loop and end the action.
    1. `add` retrieve the text and add it to the list.
    1. `get` get the index number and display the text at the selected index.
1. Protect the program against specifying an index that goes beyond the collection by catching the appropriate type of exception.
1. The exception should be handled by displaying the message `Invalid Index`.

#### Exercise 4

1. Create your own exception called `WrongNameException` along with a constructor that accepts the exception message.
1. Create a class called `User`, with a constructor that will accept one `string` argument called `name`. Assign the parameter to a read-only property called `Name`.
1. In the constructor, check whether the parameter meets the following conditions:
    1. Whether the name and surname consist of at least two words.
    1. Does your name and surname start with capital letters?
1. If one of the conditions is not met, throw an exception with an appropriate message.

### Linq

1. Create a class in your project:
```csharp
public classUser
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public User(int i, string n, int a)
    {
        ID = i;
        Name = n;
        Age = a;
    }
}
```
1. In the `Main` method, create a list of objects of the `User` class called `list`.
1. The list should include the following items.
```csharp
var list = new List<User>();
list.Add(new User(1, "Bruce", 40));
list.Add(new User(2, "Clark", 34));
list.Add(new User(3, "Punishment", 22));
list.Add(new User(4, "Hal", 34));
list.Add(new User(5, "Johnathan", 40));
```
1. Download the following elements from the collection and assign them to arbitrary variable names:
    1. First user who is 34 years old.
    1. User with ID 3.
    1. Users who are over 30 years old.
    1. Users who are over 50 years old.
    1. List of all users' names.
    1. Two users, starting from 3.
    1. Users who are 34 and 40 years old.

#### Exercise 2

1. In your project, create a class and an enum type:
```csharp
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductType Type { get; set; }

    public Product(int id, string name, decimal price, ProductType productType)
    {
        ID = id;
        Name = name;
        Price = price;
        Type = productType;
    }
}

public enum ProductType
{
    unknown,
    Electronic,
    Clothes
}
```
1. In the `Main` method, create a list of objects of the `Product` class called `list`.
1. The list should include the following items.
```csharp
var list = new List<Product>();
list.Add(new Product(1, "Pants", 250, ProductType.Clothes));
list.Add(new Product(2, "Shoes", 350, ProductType.Clothes));
list.Add(new Product(3, "TV", 1200, ProductType.Electronic));
list.Add(new Product(4, "Tablet", 3500, ProductType.Electronic));
list.Add(new Product(5, "Laptop", 3200, ProductType.Electronic));
list.Add(new Product(6, "Glass", 5, ProductType.Unknown));
```
1. Download the following elements from the collection and assign them to arbitrary variable names:
    1. Electronic products more expensive than 3000.
    1. All electronic products.
    1. Product with ID 3.
    1. Names of electronic products.
    1. All products that are not electronic.
    1. All products whose names start with `T`.
    1. Prices of all products.

