### Steps for Displaying a SQL Database Using ADO.NET with .NET Framework  

#### **1. Create a New ASP.NET Web Application Project**
- Go to **File** > **New Project** and select **ASP.NET Web Application (.NET Framework)**.
- Name your project and click **OK**.

---

#### **2. Create a New SQL Database**
- Open **SQL Server Management Studio (SSMS)**.
- Expand the **Databases** folder, right-click it, and select **New Database**.
- Name the database (e.g., `urun`).

---

#### **3. Create a Table in the Database**
- Navigate to your database (`urun`) and expand the **Tables** folder.
- Right-click **Tables** and choose **New Table**.
- Define the columns for your table, setting appropriate data types. 
- Right-click the `Id` column, select **Set Primary Key**, and enable auto-increment:
  - Go to **Column Properties** below.
  - Set **Identity Specification** to **Yes**.

---

#### **4. Add an ADO.NET Entity Data Model in the Project**
- In your project, right-click the **Models** folder and select:
  **Add** > **New Item** > **ADO.NET Entity Data Model**.
- Choose **EF Designer from Database** and click **Next**.
- Click **New Connection**, input your SQL Server Name, and select your database (`urun`).
- Complete the setup to generate a database schema in the project.
- After generation, go to the **Build** menu and select **Rebuild Solution**.

---

#### **5. Create a View for Listing Data**
- Open **HomeController.cs** under the **Controllers** folder.
- Add a new method:
  ```csharp
  public ActionResult Liste()
  {
      return View();
  }
  ```
- Right-click inside the `Liste()` method and select **Add View**.
- Configure the view:
  - **View Name**: `Liste`
  - **Template**: `List`
  - **Model Class**: Select your table class (e.g., `uruntablo`)
  - **Data Context Class**: Select your database context class (e.g., `urunEntities`).
  - Choose `_Layout.cshtml` as the layout page from the shared views folder.
- Click **OK** and **Rebuild Solution** again.

---

#### **6. Add the Model to HomeController.cs**
- Add the following `using` statement at the top of **HomeController.cs**:
  ```csharp
  using WebApp_mvc_DBfirst.Models;
  ```

---

#### **7. Initialize the Database Context**
- Inside the `HomeController` class, add:
  ```csharp
  urunEntities urunliste = new urunEntities();
  ```

---

#### **8. Pass Data to the View**
- Modify the `Liste` method to return a list of items from your table:
  ```csharp
  public ActionResult Liste()
  {
      return View(urunliste.uruntablo.ToList());
  }
  ```

---

#### **9. Update the Layout**
- Open **_Layout.cshtml** in the **Views** folder.
- Add a new menu item to navigate to the `Liste` view:
  ```html
  <li><a href="@Url.Action("Liste", "Home")">Listele</a></li>
  ```

---

#### **10. Run the Project**
- Click the **IIS Express** button or press **F5** to launch the application in your browser (e.g., Google Chrome).
- The `Liste` page should now display the data from your SQL database.

---

By following these steps, you’ll successfully create and display data from a SQL database using ADO.NET in an ASP.NET MVC project. Let me know if you’d like further assistance!
