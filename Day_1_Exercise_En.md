## Tasks

### First program - warm-up

#### Task 1
Create a new console type project.

#### Task 2
Create the following code:
```csharp
Console.WriteLine("Enter your name:");
var name = Console.ReadLine();
Console.WriteLine("Hello " + name);
```
1. Run the project, a console window will appear.

#### Task 3

Create the following code:
```csharp
int result = 5 + 9
```
1. Run the project.
1. If the startup fails, find and fix the error. You can see the errors in the `Error List` window.

#### Task 4

Write a program that calculates the volume of a sphere of radius `r`. 
The value of the radius `r` is entered from the keyboard. 
The program should assume that the radius `r` and `volume` variables are of the `double` type.
For these variables, the format for displaying them on the screen with an accuracy of two decimal places should be adopted. 

#### Task 5 

Write a program that checks for three numbers a,b,c entered from the keyboard whether they form a Pythagorean triangle.

### Operators

#### Task 1

1. Create 6 variables.
1. Each variable should store an appropriate data type selected by you based on the description.
1. The values can be any.
* A variable named `number` that stores an integer.
* A variable called `money` storing a floating-point number (float).
* A variable named `text` that holds the text.
* A variable named `isLogged` holding a logical value.
* A variable named `myChar` holding a single character.
* A variable called `price` storing a floating-point number with the highest precision (decimal).

After declaring all variables, display them in the console.

#### Task 2

1. Create a variable called `myAge` of type `string` with the value `Age: `.
1. Create a variable called `wifeAge` of type `int` with the value `18`.
1. Create a variable called `result` and assign to it the result of adding the `myAge` and `wifeAge` variables.
1. Display the `result` variable in the console.
5. Any conclusions?

#### Task 3

1. Create 3 `bool` variables with the following names and values:
    1. `isTrue` with the value `true`.
    1. `isFalse` with the value `false`.
    1. `isReallyTrue` with the value `true`.
1. Create 3 more variables with the following names and assign the results of operations on logical variables to them:
    1. `and` should contain the result of `isTrue` AND `isFalse`.
    1. `or` should contain the result of `isTrue` OR `isReallyTrue`.
    1. `negative` should contain the negation result of `isFalse`.
1. Display the `and, or and negative` variables in the console.

#### Task 4

1. Create two variables named `a`, `b` and assign the values `5, 12` to them.
1. Create variables named `add`, `sub`, `div`, `mul`, `mod` and assign to them the result of adding, subtracting, dividing, multiplying and modulo the variables `a` and `b`.
1. Display the variables `add`, `sub`, `div`, `mul`, `mod` in the console.

#### Task 5

1. Create three `string` variables named `a`, `b` and `c`.
1. Assign the text `Ala `, `ma `, `kota.` to the variables.
1. Create a 4th variable called `result` and assign the result of the operation `a + b + c` to it.
1. Display the `result` variable in the console.
1. Write your observations about the result in a comment.


### Control statements and loops

#### Task 1

1. Create two `int` variables named `n1` and `n2`. Assign the numbers `10` and `20` to them.
1. Using the `if` statement, check the values of these variables and print in the console which of the numbers is greater or whether they are equal.
1. The text should be displayed according to the formula `n1 is greater than n2` or `n1 is equal to n2`.

#### Task 2

1. Create a loop that prints `C#` 10 times to the console.
1. Solve the task using a `for` loop and a `while` loop.
1. In total, the word `C#` should appear 20 times in the console.


#### Task 3

1. Create a variable called `n`, which will be initialized with the value `10`.
1. Then write in the console whether the number is even or not, for numbers from `0` to `n`.
Pattern:
```
0 - Even
1 - Odd
2 - Even
e.t.c...
```

How to check if a number is even? Hint: `modulo`.

#### Task 4

1. Create a variable called `n` that will contain the value 5.
1. Then write a script that will print the following diagram to the console.

Scheme for `n = 5`.
```
*
* *
* * *
* * * *
* * * * *
```

Scheme for `n = 3`.
```
*
* *
* * *
```

#### Task 5

1. Create a variable `exam` that will contain a value from 0 to 100.
1. The `exam` variable stores the exam results.
1. Create code that will display the test grade in the console based on the `exam` variable, according to the diagram below.
    * 0 - 39 points - `Unsatisfactory Rating`
    * 40 - 54 points - `Acceptable Grade`
    * 55 - 69 points - `Satisfactory Rating`
    * 70 - 84 points - `Good Rating`
    * 85 - 98 points - `Very Good Rating`
    * 99 - 100 points - `Excellent Rating`
1. If the value of `exam` is less than `0` or greater than `100`, display the message: `Value out of range`.

Example: For point with the value `57`, the console should display `Satisfactory`.

#### Task 6

Write a program that sums odd numbers from 1 to 100 using the for statement.


#### Task 7

Write a program that uses the for statement to find the largest and smallest number from the set of `n` randomly selected integers from 0 to 99 (in the problem n = 5)
and calculates the average of all drawn numbers.

#### Task 8

Write a program that displays the multiplication table for numbers from 1 to 100 (i.e. 10 x 10) using a double for loop.

#### Task 9

Write a program that displays uppercase letters of the alphabet from A to Z and Z to A using a while loop.

### Collections

#### Task 1

1. Create a four-element `string` array called `colors`.
1. Complete the table with any color names.
1. Display the first color from the array in the console using the formula `My first color is: blue`.
1. Display the last color from the array in the console according to the formula `My last color is: red`.

#### Task 2

1. Create an array of any 10 numbers.
1. Then write the text `Number: 13` 10 times in the console using the `for`, `foreach` and `while` loops, where `13` will be the next number from the array.

Pattern
```csharp
Number: 0
Number: 1
```


#### Task 3

1. Create a four-element `List<string>` named `fruits`.
1. Complete the table with any fruit names using the add method.
1. Display all fruits in the console according to the pattern `Tomato, Apple, Carrot`. There must be a comma and a space between the fruit names.
4. Use the `Revome and RemoveAt` methods to remove the first and last element of the list.
5. View all list items.


#### Task 4

Using the ArrayList() collection property, write a program that adds six numbers to a collection of this type and then sorts them. 
Once this is done, the operation should be done remove the second item from the list, add a new item to the list and re-sort.


## Workshop

#### Task 1: Become familiar with Visual Studio

1. Create a new solution called Library
2. In the solution, create a Library.ConsoleApp project of type console application
3. In the solution, create a Library.Domain project of type ClassLib
4. In the solution, create a Library.Persistence project of type ClassLib
5. In the Library.Persistence project, add a reference to the Library.Domain project
6. In the Library.ConsoleApp project, add a reference to the Library.Domain and Library.Persistence projects
7. In the Library.Domain project, create a book class, you can copy it from the code below
```csharp
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public int ProductsAvailable { get; set; }
        public decimal Price { get; set; }
        
        public Book() {}

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
```
8. In the Library.Persistence project, create a BooksRepository class, for now it can be an empty class
9. In the Library.ConsoleApp project in the Program.cs file, create an object of the previously created classes
```csharp
Book book = new Book(/*fill the parameters*/);
BooksRepository repository = new BooksRepository();
```
10. Compile the project to check for errors.
11. *Create the Presentation walkthrough directory
12. *Move the Library.ConsoleApp project to the Presentation directory
13. *Create the Logic walkthrough directory
14. *Move the Library.Domain and Library.Persistence projects to the Logic directory


#### Task 2: Conditional Statements / Debugging

1. Open the Program.cs file in the Library.ConsoleApp project
2. Using the console API, get the user's login and password
```csharp
string text = Console.ReadLine();
```
3. If the login is `Admin` and the password is `password`, write `Access Granted` on the console
4. Otherwise print `Access Denied`
5. Use the F9 button (or click in the left column of the editor) to mark the place with an if so that the program execution stops.
6. I run the Library.ConsoleApp project in Debug mode
7. Use the F10 button to go through the program flow


#### Task 3: Creating a menu in the console application / Control loops 

1. Open the Program.cs file from Library.ConsoleApp
2. Then use the loop to read subsequent lines of text entered by the user
3. The loop is supposed to finish its task when the user types the command `exit`
4. The loop should wait until the user enters the command
5. Inside the loop, check what command the user has entered according to the table below:
   - add -> It should print the text: "trying to add a book"
   - delete -> It should print the text: "trying to delete book"
   - list -> It should print the text: "trying to list all books"
   - change -> It should print the text: "trying to change the stock of books"
   - add an order -> It should print the text: "trying to add a new order"
   - list of orders -> It should print the text: "trying to list all orders"
6. Use the `Console.Clear()` command so that after entering the command, the console screen will only display the application menu
7. Use the `Console.WriteLine` command to display possible commands for the user to enter
8. *If the user enters an unsupported command, the application should display information that the given command is not supported
9. *After each command, the application should display the following text: `Press AnyKey` and suspend program execution until the key is pressed