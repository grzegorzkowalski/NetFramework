#### Task 1

Start Visual Studio and create new Web Forms App. Look at the files generated and tell what's purpose of each file. Explain the "code behind" model. Print "Hello, ASP.NET" from the C# code and from the aspx code. 

To display "Hello, ASP.NET" from both the ASPX page and the C# code-behind, follow these instructions:

From C# Code (Code-Behind):
Open Default.aspx.cs.
Add the following method to the page class:
```
protected void Page_Load(object sender, EventArgs e)
{
    Response.Write("Hello, ASP.NET from Code-behind!");
}
```

From ASPX Code:
Open Default.aspx.
Add the following line anywhere within the <body> tag:
```
<% Response.Write("Hello, ASP.NET from ASPX!"); %>
```

#### Task 2

Create a simple `aspx` page that enters a name and prints "Hello" + name in the page. Use a TextBox + Button + Label.

In <yourPageName>.aspx
Open the <yourPageName>.aspx file and modify the content inside the <form> tag as follows:

```
<form id="form1" runat="server">
    <div>
        Enter your name: <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        <asp:Button ID="ButtonGreet" runat="server" Text="Greet Me!" OnClick="ButtonGreet_Click" />
        <asp:Label ID="LabelGreeting" runat="server"></asp:Label>
    </div>
</form>
```

In <yourPageName>.aspx.cs
Open <yourPageName>.aspx.cs and add the following method to handle the button's Click event:
```
protected void ButtonGreet_Click(object sender, EventArgs e)
{
    string name = TextBoxName.Text;  // Gets the text from the TextBox
    LabelGreeting.Text = "Hello " + name;  // Sets the text of the Label
}

```

#### Task 3 - Lifecycle
Check all the events in the page execution lifecycle using appropriate methods or event handlers.

Create a new Web Forms page named Lifecycle.aspx.
Add event handlers for all lifecycle events in the code-behind (Lifecycle.aspx.cs). Here are the common lifecycle events:
Page_PreInit
Page_Init
Page_InitComplete
Page_PreLoad
Page_Load
Page_LoadComplete
Page_PreRender
Page_PreRenderComplete
Page_Unload (Note: You cannot use Response.Write in this event because the response stream is closed)
Example for one event:
```
protected void Page_Load(object sender, EventArgs e)
{
    Response.Write("Page Load event fired<br/>");
}

```

#### Task 4 - Students and Courses

Make a simple Web form for registration of students and courses. The form should accept first name, last name, faculty number, university (drop-down list), specialty (drop-down list) and a list of courses (multi-select list) and display them on submit. Use the appropriate Web server controls. After submission you should display summary of the entered information as formatted HTML. Use dynamically generated tags `(<h1>, <p>, …)`.

Create a new Web Form (StudentRegistration.aspx).
Design the form using ASP.NET server controls:
TextBox for first name, last name, and faculty number.
DropDownList for university and specialty (pre-populate items either statically in ASPX or dynamically in code-behind).
ListBox for courses (set SelectionMode="Multiple").
Button for submission.
Label or Literal for displaying results.
Handle the Button click event to capture the data and display it:
```html
protected void SubmitButton_Click(object sender, EventArgs e)
{
    string summary = $"<h1>Registration Summary</h1><p>Name: {txtFirstName.Text} {txtLastName.Text}</p>";
    summary += $"<p>University: {ddlUniversity.SelectedItem.Text}</p>";
    summary += $"<p>Specialty: {ddlSpecialty.SelectedItem.Text}</p>";
    summary += "<p>Courses Selected:</p><ul>";
    foreach (ListItem item in lstCourses.Items)
    {
        if (item.Selected)
            summary += $"<li>{item.Text}</li>";
    }
    summary += "</ul>";

    lblSummary.Text = summary;
}

```

#### Task 5 - Web Calculator

Make a simple Web Calculator. The calculator should support the operations like addition, subtraction, multiplication, division and square root. Validation is essential!

![img.png](img.png)
Create a new Web Form (Calculator.aspx).
Design the UI with TextBox for input, DropDownList for selecting the operation, Button for calculating, and Label for displaying the result.
Implement the calculation logic in the Button click event:
```html
protected void btnCalculate_Click(object sender, EventArgs e)
{
    double result = 0;
    double num = double.Parse(txtNumber.Text);

    switch (ddlOperation.SelectedItem.Value)
    {
        case "Add": result = num + 10; break;
        case "Subtract": result = num - 10; break;
        case "Multiply": result = num * 10; break;
        case "Divide": result = num / 10; break;
        case "Sqrt": result = Math.Sqrt(num); break;
    }

    lblResult.Text = $"Result: {result}";
}

```

#### Task 6 - User Portal

1. Implement a simple Web Forms application using master pages. 
2. The application should be like a user profile – separate pages for Personal Info, Friends, Additional Info, etc. + Sidebar for navigation.

#### Task 7 - Validation Controls 
1. Create a form to register users with fields for preferred user name, password, repeat password, first name, last name, age, email, local address, phone and an “I accept” option.
1. All fields are required.
1. Valid age is between 18 and 81.
1. Display error messages in a ValidationSummary.
1. Use a regular expression for the email and phone fields.
1. Separate the fields in groups and validate them using Validation Groups. The Validation Groups should be at least three – Logon Info, Personal Info, Address Info.
1. Add a radio button to choose the gender (male / female). If the user is male, dynamically display a list of check boxes for choosing his favourite cars (e.g. BMW, Toyota, etc.). If the user is female display a drop-down list to allow her select her favourite coffee (e.g. Lavazza, New Brazil, etc.). Note that selecting a coffee is optional for the female users. Implement this by server PostBacks.
1. Implement the previous with client-side JavaScript.

Create a new Web Form (Register.aspx).
Use ASP.NET Validation Controls to enforce input rules: RequiredFieldValidator, RangeValidator, RegularExpressionValidator, ValidationSummary.
Dynamically show/hide controls based on gender selection using server-side logic in the RadioButton SelectedIndexChanged event and client-side JavaScript for immediate interaction.

#### Task 8 

1. Implement a Web Forms application using nested master pages.
2. It should be a Web site of international company.
3. You should have master layout page and few different nested master pages for each country and few content pages in different language, for each country.
4. Define "Home", "About" and "Contacts" pages for each country using its master page.

#### Working with database

##### Integrating Sakila Database with MSSQL and ASP.NET Web Forms

1. This guide provides step-by-step instructions on how to set up the Sakila database in MSSQL and integrate it into an ASP.NET Web Forms application for practice with database operations.

#### Step 1: Download the Sakila Database for MSSQL

##### Navigate to the GitHub Repository
- Visit [jOOQ's Sakila GitHub repository](https://github.com/jOOQ/sakila/tree/main/sql-server-sakila-db) for the SQL Server version of the Sakila database.

##### Download the SQL Scripts
- Download the scripts necessary for creating the database schema and populating it with data.

#### Step 2: Import the Database into SQL Server

##### Open SQL Server Management Studio (SSMS)
- Connect to your SQL Server instance where you want to add the Sakila database.

##### Create a New Database
- Right-click on the Databases folder in the Object Explorer and choose "New Database...".
- Name your database, e.g., `Sakila`.

##### Run the SQL Scripts
- Open the downloaded SQL script files with SSMS or another SQL editor.
- Execute the schema creation script followed by the data population script in the Sakila database you just created [https://github.com/jOOQ/sakila/blob/main/sql-server-sakila-db/sql-server-sakila-schema.sql](https://github.com/jOOQ/sakila/blob/main/sql-server-sakila-db/sql-server-sakila-schema.sql).
- Insert data to database [https://github.com/jOOQ/sakila/blob/main/sql-server-sakila-db/sql-server-sakila-insert-data.sql](https://github.com/jOOQ/sakila/blob/main/sql-server-sakila-db/sql-server-sakila-insert-data.sql).

##### Step 3: Configure Your ASP.NET Web Forms Project

##### Set Up a New ASP.NET Web Forms Project
- In Visual Studio, create a new project using the "ASP.NET Web Application (.NET Framework)" template and select the Web Forms template.

##### Add a Connection String
- Open the `Web.config` file in your Web Forms project.
- Add a connection string that points to the Sakila database on your SQL Server:
    ```xml
    <connectionStrings>
        <add name="SakilaConnectionString" 
             connectionString="Data Source=YourServerName;Initial Catalog=Sakila;Integrated Security=True" 
             providerName="System.Data.SqlClient" />
    </connectionStrings>
    ```
- Replace `YourServerName` with the name of your SQL Server instance.
np.:
```xml
"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=sakila;Integrated Security=True;Connect Timeout=30;Encrypt=False;
```

#### Step 4: Use the Database in Your Web Forms Application

##### Create Data Access Layer (DAL)
- You can create classes or use Entity Framework to interact with the database.
- For manual SQL commands, use `SqlConnection`, `SqlCommand`, and other ADO.NET classes.

##### Example of Fetching Data
- In any of your Web Forms (e.g., `ListActors.aspx`), you can use the following code to fetch data:

    ```csharp
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindActors();
        }
    }

    private void BindActors()
    {
        using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM actor", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridViewActors.DataSource = dt;
            GridViewActors.DataBind();
        }
    }
    ```

### Databinding

```
private DataTable GetData(string query)
{
    // Define the connection string (Assuming it's stored in the Web.config)
    string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

    // Create a new DataTable
    DataTable dt = new DataTable();

    // Use SqlConnection to connect to the database
    using (SqlConnection con = new SqlConnection(connectionString))
    {
        // Open the database connection
        con.Open();

        // Create a SqlCommand to execute the SQL query
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            // Use SqlDataAdapter to fill the DataTable
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                sda.Fill(dt);
            }
        }
    }

    // Return the filled DataTable
    return dt;
}
```

#### Task 1: Displaying Actors Using a Repeater
Control: Repeater

Description: Display a list of actors from the actor table using a Repeater control.

ASP.NET Code:
```
<asp:Repeater ID="RepeaterActors" runat="server">
    <ItemTemplate>
        <div>
            <strong>Name:</strong> <%# Eval("first_name") %> <%# Eval("last_name") %><br/>
        </div>
    </ItemTemplate>
</asp:Repeater>
```
Code-behind (C#):
```
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        RepeaterActors.DataSource = GetData("SELECT first_name, last_name FROM actor");
        RepeaterActors.DataBind();
    }
}

private DataTable GetData(string query)
{
    string connectionString = ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ToString();
    using (SqlConnection con = new SqlConnection(connectionString))
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt;
            }
        }
    }
}
```

#### Task 2: Selecting a Film Category Using DropDownList
Control: DropDownList

Description: Use a DropDownList to select a film category from the category table.

ASP.NET Code:
```
<asp:DropDownList ID="DropDownListCategories" runat="server" DataTextField="name" DataValueField="category_id" AutoPostBack="True" OnSelectedIndexChanged="DropDownListCategories_SelectedIndexChanged">
</asp:DropDownList>
```

Code-behind (C#):
```
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        DropDownListCategories.DataSource = GetData("SELECT category_id, name FROM category");
        DropDownListCategories.DataBind();
    }
}

protected void DropDownListCategories_SelectedIndexChanged(object sender, EventArgs e)
{
    // Optionally perform actions upon selecting a category
}
```

#### Task 3: Displaying Actor Details Using `DetailsView`
Control: DetailsView

Description: Display detailed information about an actor from the actor table using a `DetailsView`.
ASP.NET Code:
```
<asp:DetailsView ID="DetailsViewActor" runat="server" AutoGenerateRows="True">
</asp:DetailsView>
```

Code-behind (C#):
```
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        DetailsViewActor.DataSource = GetData("SELECT * FROM actor WHERE actor_id = 1");
        DetailsViewActor.DataBind();
    }
}
```

#### Task 4: Listing Films Using ListView
Control: ListView

Description: Use a ListView to display a list of films along with options to edit.
ASP.NET Code:
```
<asp:ListView ID="ListViewFilms" runat="server" DataKeyNames="film_id">
    <ItemTemplate>
        <div>
            <strong>Title:</strong> <%# Eval("title") %><br/>
            <strong>Description:</strong> <%# Eval("description") %>
        </div>
    </ItemTemplate>
</asp:ListView>
```

Code-behind (C#):
```
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        ListViewFilms.DataSource = GetData("SELECT film_id, title, description FROM film");
        ListViewFilms.DataBind();
    }
}

```

### CRUD Operations in ASP.NET Web Forms 4.7.2 with Sakila Database

These exercises are designed to enhance your skills in implementing CRUD operations in ASP.NET Web Forms using the Sakila database. This database is a commonly used sample database for learning SQL and database techniques.

#### Task 1: Display List of Actors

**Objective**: Create a web form that lists all actors from the Sakila database's `actor` table.

##### Steps:

1. **Create a new Web Form** named `ListActors.aspx`.
2. Add a `GridView` to `ListActors.aspx`:

```aspx
<asp:GridView ID="GridViewActors" runat="server" AutoGenerateColumns="True"></asp:GridView>
```

3. In the code-behind (`ListActors.aspx.cs`), use ADO.NET to fetch actor data and bind it to the GridView:

```csharp
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        BindActors();
    }
}

private void BindActors()
{
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM actor", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridViewActors.DataSource = dt;
        GridViewActors.DataBind();
    }
}
```

#### Task 2: Add a New Actor

**Objective**: Create a form to add new actors to the database.

##### Steps:

1. **Create a new Web Form** named `AddActor.aspx`.
2. Add text boxes for first name and last name, and a submit button:

```aspx
First Name: <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br>
Last Name: <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br>
<asp:Button ID="btnAddActor" runat="server" Text="Add Actor" OnClick="btnAddActor_Click" />
```

3. Implement the `btnAddActor_Click` event in `AddActor.aspx.cs`:

```csharp
protected void btnAddActor_Click(object sender, EventArgs e)
{
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("INSERT INTO actor (first_name, last_name) VALUES (@FirstName, @LastName)", con);
        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
        cmd.ExecuteNonQuery();
    }

    Response.Redirect("ListActors.aspx"); // Redirect to view the list of actors
}
```

#### Task 3: Edit Actor Details

**Objective**: Allow users to update an actor's details.

##### Steps:

1. **Modify `ListActors.aspx`** to include Edit and Delete buttons in the GridView:

    ```aspx
    <Columns>
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
    ```
   
```
<asp:GridView ID="GridViewActors" runat="server" AutoGenerateColumns="False" OnRowEditing="GridViewActors_RowEditing" OnRowDeleting="GridViewActors_RowDeleting" OnRowUpdating="GridViewActors_RowUpdating" OnRowCancelingEdit="GridViewActors_RowCancelingEdit">
    <Columns>
        <asp:BoundField DataField="ActorID" HeaderText="Actor ID" InsertVisible="False" ReadOnly="True" SortExpression="ActorID" />
        <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
        <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
        
        <!-- Command Fields for Edit and Delete -->
        <asp:CommandField ShowEditButton="True" ShowCancelButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
</asp:GridView>

```

2. Implement the `RowEditing` and `RowUpdating` events for the GridView:

```csharp
protected void GridViewActors_RowEditing(object sender, GridViewEditEventArgs e)
{
    GridViewActors.EditIndex = e.NewEditIndex;
    BindActors();
}

protected youGridViewActors_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
    // Fetch new values from the GridView and update the database
    // Similar to the btnAddActor_Click logic but using UPDATE SQL command
}
```

#### Task 4: Delete an Actor

**Objective**: Enable deletion of actors from the database through the web interface.

##### Steps:

1. **Use the `RowDeleting` event** in `ListActors.aspx` to handle actor deletion:

```csharp
protected void GridViewActors_RowDeleting(object sender, GridViewDeleteEventArgs e)
{
     int id = Convert.ToInt32(((String)GridViewActors.Rows[e.RowIndex].Cells[0].Text));
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("DELETE FROM actor WHERE actor_id = @ActorId", con);
        cmd.Parameters.AddWithValue("@ActorId", actorId);
        cmd.ExecuteNonQuery();
    }

    BindActors();
}
```

#### Task 5: List Movies
**Objective**: Display a list of movies from the `film` table in the Sakila database.

##### Steps:
1. **Create a new Web Form** named `ListMovies.aspx`.
1. Add a `GridView` to `ListMovies.aspx`:
```aspx
<asp:GridView ID="GridViewMovies" runat="server" AutoGenerateColumns="True"></asp:GridView>
```
1. In the code-behind (ListMovies.aspx.cs), write code to fetch movie data and bind it to the GridView:
```c#
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        BindMovies();
    }
}

private void BindMovies()
{
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM film", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridViewMovies.DataSource = dt;
        GridViewMovies.DataBind();
    }
}
```

#### Task 6: Add a New Movie
Objective: Provide a form to add new movies to the database.
#### Steps:
1. Create a new Web Form named `AddMovie.aspx`.
1. Add appropriate input fields and a submit button:
```aspx
<form id="formAddMovie" runat="server">
    Title: <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br>
    Description: <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox><br>
    Release Year: <asp:TextBox ID="txtReleaseYear" runat="server"></asp:TextBox><br>
    <asp:Button ID="btnAddMovie" runat="server" Text="Add Movie" OnClick="btnAddMovie_Click" />
</form>
```
1. Implement the btnAddMovie_Click event in `AddMovie.aspx.cs`:
```
protected void btnAddMovie_Click(object sender, EventArgs e)
{
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("INSERT INTO film (title, description, release_year) VALUES (@Title, @Description, @ReleaseYear)", con);
        cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
        cmd.Parameters.AddWithValue("@ReleaseYear", txtReleaseYear.Text);
        cmd.ExecuteNonQuery();
    }
    Response.Redirect("ListMovies.aspx"); // Redirect to list movies page
}
```

#### Task 7: Edit Movie Details
Objective: Allow users to update movie details.
##### Steps:
1. Modify `ListMovies.aspx` to include functionality for editing movie records:
```
<Columns>
    <asp:CommandField ShowEditButton="True" />
</Columns>
```
1. In `ListMovies.aspx.cs`, implement the RowEditing and RowUpdating events:
```
protected void GridViewMovies_RowEditing(object sender, GridViewEditEventArgs e)
{
    GridViewMovies.EditIndex = e.NewEditIndex;
    BindMovies();
}

protected void GridViewMovies_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
    // Fetch data from the form, update the database
    // Implement database update logic similar to AddMovie
}
```

#### Task 8: Delete a Movie
Objective: Enable users to delete movies directly from the ListMovies.aspx page using a Delete button in the GridView.
##### Steps:
1. Add Delete functionality to `ListMovies.aspx`:
```
<Columns>
    <asp:CommandField ShowDeleteButton="True" />
</Columns>
```
1. Implement the RowDeleting event in `ListMovies.aspx.cs`:
```
protected void GridViewMovies_RowDeleting(object sender, GridViewDeleteEventArgs e)
{
    int filmId = Convert.ToInt32(GridViewMovies.DataKeys[e.RowIndex].Value);
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("DELETE FROM film WHERE film_id = @FilmId", con);
        cmd.Parameters.AddWithValue("@FilmId", filmId);
        cmd.ExecuteNonQuery();
    }

    BindMovies();
}
```

#### Task 9: List Categories
Objective: Display a list of categories from the category table.
##### Steps:
1. Create a new Web Form named `ListCategories.aspx`.
1. Add a GridView to `ListCategories.aspx`:
```
<asp:GridView ID="GridViewCategories" runat="server" AutoGenerateColumns="True"></asp:GridView>
```
1. In the code-behind (`ListCategories.aspx.cs`), implement code to fetch and display category data:
```
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        BindCategories();
    }
}

private void BindCategories()
{
    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("SELECT * FROM category", con);
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        sda.Fill(dt);
        GridViewCategories.DataSource = dt;
        GridViewCategories.DataBind();
    }
}
```

#### Task 10: Edit Categories
Objective: Provide functionality to edit and update categories.
##### Steps:
1. Add editing functionality to `ListCategories.aspx`:
```
<Columns>
    <asp:CommandField ShowEditButton="True" />
</Columns>
```
1. Implement the RowEditing and RowUpdating events in `ListCategories.aspx.cs`:
```
protected void GridViewCategories_RowEditing(object sender, GridViewEditEventArgs e)
{
    GridViewCategories.EditIndex = e.NewEditIndex;
    BindCategories();
}

protected void GridViewCategories_RowUpdating(object sender, GridViewUpdateEventArgs e)
{
    int categoryId = Convert.ToInt32(GridViewCategories.DataKeys[e.RowIndex].Value);
    string categoryName = ((TextBox)GridViewCategories.Rows[e.RowIndex].FindControl("txtName")).Text;

    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SakilaConnectionString"].ConnectionString))
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("UPDATE category SET name = @Name WHERE category_id = @CategoryId", con);
        cmd.Parameters.AddWithValue("@Name", categoryName);
        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
        cmd.ExecuteNonQuery();
    }

    GridViewCategories.EditIndex = -1;
    BindCategories();
}
```

#### Workshop continue

1. Add Web Forms project to book library project `Library.Web`.
1. Implement a simple Web Forms application for managing the books in the library.

##### Step 2: Design the Login Web Form

###### Add a New Web Form for Login

- Right-click on the `Library.Web` project.
- Choose Add → New Item → Web Form and name it `Login.aspx`.

###### Design the Form

Add the following controls to `Login.aspx` for user inputs and submission:

```aspx
    <form id="form1" runat="server">
        <div>
            <h2>Login</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:TextBox ID="txtUsername" runat="server" placeholder="Username"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
```

###### Implement the Authentication Logic

1. Add Server-Side Logic in Login.aspx.cs
1. Implement the logic to validate user credentials:
1. Open the `Login.aspx.cs` file.
1. Add the following code to the `btnLogin_Click` event handler:
```csharp
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (FormsAuthentication.Authenticate(username, password))
            { 
                FormsAuthentication.RedirectFromLoginPage("Default.aspx", true);
            }
            else
            {
                lblMessage.Text = "Invalid username or password.";
            }
        }
```
###### Add configuration in `web.config`

1. In `system.web` add:

```
	  <authentication mode="Forms">
		  <forms loginUrl="Login.aspx" defaultUrl="Default.aspx" timeout="60">
			  <credentials passwordFormat="Clear">
				  <user name="Admin" password="password" />
			  </credentials>
		  </forms>
	  </authentication>
	  <authorization>
		  <deny users="?" />
	  </authorization>
```

2. After `system.web` add:
```
  <location path="Login.aspx">
	<system.web>
		<authorization>
			<allow users="?" />
		</authorization>
	</system.web>
  </location>
```

###### Design Web Forms for Each Command

###### Overview

For each command in your console app (`add`, `delete`, `list`, `change`, `add an order`, `list of orders`), you will create a corresponding web form.

###### Create Web Forms

- **AddWebForm.aspx**: Form to add a new book.
- **DeleteWebForm.aspx**: Form to delete a book.
- **ListWebForm.aspx**: Page to list all books.
- **ChangeWebForm.aspx**: Form to update the stock of a book.
- **AddOrderWebForm.aspx**: Form to add a new order.
- **ListOrdersWebForm.aspx**: Page to list all orders.

###### Form Design

Each form should include relevant input fields, labels, and buttons. For instance, `AddWebForm.aspx` might look like this:

```aspx
<form id="form1" runat="server">
    <asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label>
    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
    <asp:Button ID="btnAdd" runat="server" Text="Add Book" OnClick="btnAdd_Click" />
</form>
```

1. Implement Logic for Web Forms
Handle User Input
For each form, you will need to write backend C# code in the *.aspx.cs file to handle the button clicks and other events, mimicking the console logic.

```csharp
protected void btnAdd_Click(object sender, EventArgs e)
{
    var title = txtTitle.Text;
    // Code to add the book to the database
}
```

1. Check do you have authentication cookie after login.
2. Delete cookie and refresh page. Check what will happen.

###### Navigation and Menu
1. Create a Main Menu
Use a Master Page or a navigation menu on your main page (Default.aspx) to link to each of the command forms.
```aspx
<ul>
    <li><a href="AddWebForm.aspx">Add a Book</a></li>
    <li><a href="ListWebForm.aspx">List All Books</a></li>
    <!-- Additional links for other forms -->
</ul>
```

###### AddBook.aspx

```html
<form id="formAddBook" runat="server">
    <fieldset>
        <legend>Add New Book</legend>
        Title: <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br>
        Author: <asp:TextBox ID="txtAuthor" runat="server"></asp:TextBox><br>
        Publication Year: <asp:TextBox ID="txtPublicationYear" runat="server"></asp:TextBox><br>
        ISBN: <asp:TextBox ID="txtISBN" runat="server"></asp:TextBox><br>
        Products Available: <asp:TextBox ID="txtProductsAvailable" runat="server"></asp:TextBox><br>
        Price: <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br>
        <asp:Button ID="btnAddBook" runat="server" Text="Add Book" OnClick="btnAddBook_Click" />
    </fieldset>
</form>
```

###### AddBook.aspx.cs

```csharp
protected void btnAddBook_Click(object sender, EventArgs e)
{
    Book newBook = new Book
    {
        Title = txtTitle.Text,
        Author = txtAuthor.Text,
        PublicationYear = Convert.ToInt32(txtPublicationYear.Text),
        ISBN = txtISBN.Text,
        ProductsAvailable = Convert.ToInt32(txtProductsAvailable.Text),
        Price = Convert.ToDecimal(txtPrice.Text)
    };
    _repository.Insert(newBook);
    // Optionally redirect or show success message
}
```

###### RemoveBook.aspx

```html

<form id="formRemoveBook" runat="server">
    <fieldset>
        <legend>Remove Book</legend>
        Title: <asp:TextBox ID="txtTitleToRemove" runat="server"></asp:TextBox><br>
        <asp:Button ID="btnRemoveBook" runat="server" Text="Remove Book" OnClick="btnRemoveBook_Click" />
    </fieldset>
</form>
```

###### RemoveBook.aspx.cs

```csharp
protected void btnRemoveBook_Click(object sender, EventArgs e)
{
    _repository.RemoveByTitle(txtTitleToRemove.Text);
    // Optionally redirect or show success message
}
```

###### ListBooks.aspx

```html
<form id="formListBooks" runat="server">
	<fieldset>
		<legend>List All Books</legend>
		<asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False">
			<Columns>
				<asp:BoundField DataField="Title" HeaderText="Title" />
				<asp:BoundField DataField="Author" HeaderText="Author" />
				<asp:BoundField DataField="PublicationYear" HeaderText="Publication Year" />
				<asp:BoundField DataField="ISBN" HeaderText="ISBN" />
				<asp:BoundField DataField="ProductsAvailable" HeaderText="Products Available" />
				<asp:BoundField DataField="Price" HeaderText="Price" />
			</Columns>
		</asp:GridView>
	</fieldset>
</form>
```

###### ListBooks.aspx.cs

```csharp
protected void Page_Load(object sender, EventArgs e)
{
	gvBooks.DataSource = _repository.GetAll();
	gvBooks.DataBind();
}
```

###### ChangeState.aspx

```html
<form id="formChangeState" runat="server">
	<fieldset>
		<legend>Change Book State</legend>
		Title: <asp:TextBox ID="txtTitleToChange" runat="server"></asp:TextBox><br>
		New Products Available: <asp:TextBox ID="txtNewProductsAvailable" runat="server"></asp:TextBox><br>
		<asp:Button ID="btnChangeState" runat="server" Text="Change State" OnClick="btnChangeState_Click" />
	</fieldset>
</form>
```

###### ChangeState.aspx.cs

```csharp
protected void btnUpdateStock_Click(object sender, EventArgs e)
{
    _repository.ChangeState(txtTitleToUpdate.Text, Convert.ToInt32(txtNewStock.Text));
    // Optionally redirect or show success message
}
```

###### Create PlaceOrder.aspx

```html
<form id="formPlaceOrder" runat="server">
    <asp:DropDownList ID="ddlBooks" runat="server"></asp:DropDownList>
    Quantity: <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
    <asp:Button ID="btnAddToOrder" runat="server" Text="Add to Order" OnClick="btnAddToOrder_Click" />
    <asp:Button ID="btnFinalizeOrder" runat="server" Text="Finalize Order" OnClick="btnFinalizeOrder_Click" />
</form>
```

###### PlaceOrder.aspx.cs

```csharp
protected List<BookOrdered> TempOrderList = new List<BookOrdered>();

protected void btnAddToOrder_Click(object sender, EventArgs e)
{
    int bookId = Convert.ToInt32(ddlBooks.SelectedValue);
    int quantity = Convert.ToInt32(txtQuantity.Text);
    TempOrderList.Add(new BookOrdered(bookId, quantity));
}

protected void btnFinalizeOrder_Click(object sender, EventArgs e)
{
    Order newOrder = new Order();
    newOrder.BooksOrderedList.AddRange(TempOrderList);
    _repository.Insert(newOrder);
    TempOrderList.Clear();
    // Redirect or show success message
}
```

###### ListOrders.aspx

```html
<asp:GridView ID="GridViewOrders" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Date" HeaderText="Date" />
        <asp:TemplateField HeaderText="Books Ordered">
            <ItemTemplate>
                <%# GetBooksOrdered(((Order)Container.DataItem).BooksOrderedList) %>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
```

###### ListOrders.aspx.cs

```csharp
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        GridViewOrders.DataSource = _repository.GetAll();
        GridViewOrders.DataBind();
    }
}

protected string GetBooksOrdered(List<BookOrdered> booksOrdered)
{
    string display = "";
    foreach (var book in booksOrdered)
    {
        display += $"ID: {book.BookId} - Quantity: {book.NumberOrdered}<br/>";
    }
    return display;
}
```

###### Add database operations to the BooksRepository class
1. To adapt the BooksRepository class in the Library.Persistence namespace to use ADO.NET and interact with an MSSQL database instead of a static list, you need to implement database operations such as inserting, deleting, and querying books via SQL commands. Here's how you can change your repository class to use ADO.NET.
1. Add a Connection String to the Web.config File
```
<connectionStrings>
    <add name="YourConnectionStringName" connectionString="Data Source=ServerName;Initial Catalog=DatabaseName;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```

1. Modify Database Access Code:
- Replace the static list operations with SQL queries as shown in the BooksRepository example above.
- Handle Data Binding in Web Forms:
- Utilize the BooksRepository methods to fetch data and bind it to controls like GridView in your ASP.NET Web Forms pages.

###### Updated BooksRepository Using ADO.NET

```csharp
using Library.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Library.Persistence
{
    public class BooksRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

        public void Insert(Book book)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Books (Title, Author, PublicationYear, ISBN, ProductsAvailable, Price) VALUES (@Title, @Author, @PublicationYear, @ISBN, @ProductsAvailable, @Price)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", book.Title);
                    command.Parameters.AddWithValue("@Author", book.Author);
                    command.Parameters.AddWithValue("@PublicationYear", book.PublicationYear);
                    command.Parameters.AddWithValue("@ISBN", book.ISBN);
                    command.Parameters.AddWithValue("@ProductsAvailable", book.ProductsAvailable);
                    command.Parameters.AddWithValue("@Price", book.Price);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void RemoveByTitle(string title)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Books WHERE Title = @Title";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Title", title);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Book> GetAll()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Books";
                using (SqlCommand command = new SqlCommand(sql, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        books.Add(new Book
                        {
                            Title = reader["Title"].ToString(),
                            Author = reader["Author"].ToString(),
                            PublicationYear = Convert.ToInt32(reader["PublicationYear"]),
                            ISBN = reader["ISBN"].ToString(),
                            ProductsAvailable = Convert.ToInt32(reader["ProductsAvailable"]),
                            Price = Convert.ToDecimal(reader["Price"])
                        });
                    }
                }
            }
            return books;
        }

        public void ChangeState(string title, int stateChange)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE Books SET ProductsAvailable = ProductsAvailable + @StateChange WHERE Title = @Title";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@StateChange", stateChange);
                    command.Parameters.AddWithValue("@Title", title);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
```
###### Add Cache

1. To add caching to the ListBooks.aspx page in your ASP.NET Web Forms application, you can utilize the ASP.NET Cache object to store the list of books fetched from the _repository.GetAll() method. This approach reduces unnecessary database calls, especially if the book data does not change frequently, thus improving the page's performance.

###### Step 1: Modify Page_Load to Use Cache
You need to modify the Page_Load method to check if the data is already in the cache and use it if available. If not, retrieve the data from the repository, store it in the cache, and then bind it to the GridView. Here's how you can implement it:
```
protected void Page_Load(object sender, EventArgs e)
{
    if (!IsPostBack)
    {
        // Attempt to retrieve the books data from the cache
        var books = Cache["BooksData"] as List<Book>;  // Assume 'Book' is the class for the data

        // Check if the cache is empty
        if (books == null)
        {
            books = _repository.GetAll();  // Fetch the data from the repository
            // Store the data in cache; expire it after 30 minutes
            Cache.Insert("BooksData", books, null, DateTime.Now.AddMinutes(30), System.Web.Caching.Cache.NoSlidingExpiration);
        }

        gvBooks.DataSource = books;
        gvBooks.DataBind();
    }
}
```

Explanation of Cache Usage:
- Cache Retrieval: Cache["BooksData"] attempts to retrieve the list of books from the cache.
- Cache Initialization: If the cache is empty (books == null), the data is fetched from the repository.
- Cache Insertion: The data is then stored in the cache using Cache.Insert. Here, an absolute expiration time of 30 minutes is set, which means the cached data will be removed after 30 minutes regardless of activity.
- Data Binding: Finally, the GridView gvBooks is bound to the data source, whether it was retrieved from the cache or just fetched from the repository.
