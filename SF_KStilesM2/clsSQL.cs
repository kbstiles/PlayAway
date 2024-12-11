using Dapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SF_KStilesM2
{
    /// <summary>
    /// Class that handles all SQL related work
    /// </summary>
    internal class clsSQL
    {
        //Variables
        private static DataTable _dtFormTable = new DataTable(),
            _dtInventoryTable = new DataTable(),
            _dtSearchedInventoryTable = new DataTable(),
            _dtManagersTable = new DataTable(),
            _dtCustomersTable = new DataTable(),
            _dtSearchedCustomersTable = new DataTable(),
            _dtSalesTable = new DataTable();

        private static IDbConnection _cntDatabase;

        public static bool imgBool = false;

        
        public static string appDataConPath = "Data Source=" + Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PlayAwayDatabase.db") + ";Version=3;",
            localConPath = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        //getters and setters for Data Tables
        public static DataTable DTFormTable
        {
            get { return _dtFormTable; }
            set { _dtFormTable = value; }
        }

        public static DataTable DTInventoryTable
        {
            get { return _dtInventoryTable; }
            set { _dtInventoryTable = value; }
        }

        public static DataTable DTSearchInventoryTable
        {
            get { return _dtSearchedInventoryTable; }
            set { _dtSearchedInventoryTable = value; }
        }

        public static DataTable DTManagersTable
        {
            get { return _dtManagersTable; }
            set { _dtManagersTable = value; }
        }

        public static DataTable DTCustomersTable
        {
            get { return _dtCustomersTable; }
            set { _dtCustomersTable = value; }
        }

        public static DataTable DTSearchedCustomersTable
        {
            get { return _dtSearchedCustomersTable; }
            set { _dtSearchedCustomersTable = value; }
        }

        public static DataTable DTSalesTable
        {
            get { return _dtSalesTable; }
            set { _dtSalesTable = value; }
        }

        /// <summary>
        /// Tests the type of connection available to the database and opens the connection.
        /// </summary>
        public static void OpenDatabase()
        {
            //trys to use online connection path
            try
            {
                //Variables
                //sets IDbConnection to online path
                _cntDatabase = new SQLiteConnection(appDataConPath);

                _cntDatabase.Open();

                string query = "SELECT * FROM Position;";

                //data reader executes string query
                IDataReader _drInventory = SqlMapper.ExecuteReader(_cntDatabase, query);

                
                _drInventory.Dispose();
            }
            //if fails then uses local path
            catch (Exception)
            {
                //sets IDbConnection to local path
                _cntDatabase = new SQLiteConnection(localConPath);

                _cntDatabase.Open();
            }
        }

        /// <summary>
        /// Closes the connection to the database.
        /// </summary>
        public static void CloseDatabase()
        {
            _cntDatabase.Close();
        }

        /// <summary>
        /// Variable based select method, selects data from tables using the variables given by the user.
        /// </summary>
        /// <param name="tables">SQL Tables used</param>
        /// <param name="join">Determines if a join should be used</param>
        /// <param name="keys">Keys used</param>
        /// <example>
        /// <code>
        /// string[] tables = { "Logon" },
        /// keys = { };
        /// clsSQL.DatabaseCommand(tables, false, keys);
        /// </code>
        /// </example>
        public static void DatabaseCommand(string[] tables, bool join, string[] keys)
        {
            try
            {
                //Variables
                string query = "SELECT * FROM " + tables[0];

                //if join is true, adds joins to string query
                if (join)
                {
                    query += " JOIN ";
                    for (int i = 1; i < tables.Length; i++)
                    {
                        query += tables[i] + " ON " + tables[i] + "." + keys[i] + " = " + tables[i + 1] + "." + keys[i];
                    }
                }

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //loads data reader results to Data Table
                _dtFormTable.Load(_drForm);

                _drForm.Dispose();
            
            }
            catch (Exception ex)
            {                
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs inventory data from SQL Database and puts results into Data Table which is then linked to a Binding Source.
        /// </summary>
        public static void InventoryData() 
        {
            try
            {
                //Variables
                string query = "SELECT * FROM Inventory;";

                //data reader executes string query
                IDataReader _drInventory = SqlMapper.ExecuteReader(_cntDatabase, query);

                //clears and reinitializes data table
                _dtInventoryTable.Rows.Clear();
                _dtInventoryTable = new DataTable();

                //loads data reader results to data table
                _dtInventoryTable.Load(_drInventory);

                //sets data table as Data Source for Binding Source to be used for the Data Grid Views
                Program._bsItems.DataSource = null;
                Program._bsItems.DataSource = _dtInventoryTable;

                _drInventory.Dispose();               
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());          
            }
        }

        /// <summary>
        /// Grabs category data from SQL Database and puts results into observable collection.
        /// </summary>
        public static void CategoryData()
        {
            try
            {
                //Variables
                string query = "SELECT * FROM Categories;";

                //data reader executes string query
                IDataReader _drCategories = SqlMapper.ExecuteReader(_cntDatabase, query);

                //While Data Reader has rows
                while (_drCategories.Read())
                {
                    string[] ldb = { "", "", "" };
                    for (int i = 0; i < _drCategories.FieldCount - 1; i++)
                    {
                        ldb[i] = _drCategories.GetValue(i).ToString();
                    }

                    //Add row to observable collection
                    Program.categoryList.Add(new clsCategory(
                        Convert.ToInt32(ldb[0]),
                        ldb[1],
                        ldb[2]
                        )
                    );
                }

                _drCategories.Dispose();           
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs discount data from SQL Database and puts results into observable collection.
        /// </summary>
        public static void DiscountData()
        {
            try
            {
                //Variables
                string query = "SELECT * FROM Discounts;";

                //data reader executes string query
                IDataReader _drDiscounts = SqlMapper.ExecuteReader(_cntDatabase, query);

                //clears discountList
                Program.discountList.Clear();

                //while data reader has rows
                while (_drDiscounts.Read())
                {
                    string[] ldb = { "", "", "", "", "", "", "", "", "", "", "" };

                    int? inventoryID = null;

                    decimal? discountPercentage = null,
                        discountDollarAmount = null;

                    string startDate = null;

                    bool? Disabled = null;

                    ////Data Type Corrections
                    for (int i = 0; i < _drDiscounts.FieldCount; i++)
                    {
                        if (i != 8 && i != 9)
                        {
                            ldb[i] = _drDiscounts.GetValue(i).ToString();
                        }
                        else if (i == 8)
                        {
                            if (!string.IsNullOrEmpty(_drDiscounts.GetValue(i).ToString()))
                            {
                                ldb[i] = _drDiscounts.GetString(i);
                            }
                        }
                        else
                        {
                            ldb[i] = _drDiscounts.GetString(i);
                        }
                    }

                    if (!string.IsNullOrEmpty(ldb[4]))
                    {
                        inventoryID = Convert.ToInt32(ldb[4]);
                    }

                    if (!string.IsNullOrEmpty(ldb[6]))
                    {
                        discountPercentage = Convert.ToDecimal(ldb[6]);
                    }

                    if (!string.IsNullOrEmpty(ldb[7]))
                    {
                        discountDollarAmount = Convert.ToDecimal(ldb[7]);
                    }

                    if (!string.IsNullOrEmpty(ldb[8]))
                    {
                        startDate = ldb[8];
                    }

                    if (!string.IsNullOrEmpty(ldb[10]))
                    {
                        if (ldb[10].Equals("1"))
                        {
                            ldb[10] = "true";
                        }
                        else
                        {
                            ldb[10] = "false";
                        }
                        Disabled = Boolean.Parse(ldb[10]);
                    }

                    string dateTime;
                    dateTime = ldb[9];

                    //add row to observable collection
                    Program.discountList.Add(new clsDiscount(
                        Convert.ToInt32(ldb[0]),
                        ldb[1],
                        ldb[2],
                        Convert.ToInt32(ldb[3]),
                        inventoryID,
                        Convert.ToInt32(ldb[5]),
                        discountPercentage,
                        discountDollarAmount,
                        startDate,
                        dateTime,
                        Disabled
                        )
                    );
                }

                _drDiscounts.Dispose();              
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs manager data from SQL Database and puts results into Data Table which is then linked to a Binding Source.
        /// </summary>
        public static void ManagerData()
        {
            try
            {
                //Variables                
                string query = "SELECT * FROM Person WHERE PositionID = 1002;";

                //data reader executes string query
                IDataReader _drManagers = SqlMapper.ExecuteReader(_cntDatabase, query);

                //clears and reinitializes data table
                _dtManagersTable.Rows.Clear();
                _dtManagersTable = new DataTable();

                //loads data reader results into data table
                _dtManagersTable.Load(_drManagers);

                //connects data table to data source of Binding source
                Program._bsManagers.DataSource = null;
                Program._bsManagers.DataSource = _dtManagersTable;

                
                _drManagers.Dispose();             
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs customer data from SQL Database and puts results into Data Table which is then linked to a Binding Source.
        /// </summary>
        public static void CustomerData()
        {
            try
            {
                //Variables                
                string query = "SELECT * FROM Person WHERE PositionID = 1001;";

                //data reader executes string query
                IDataReader _drCustomers = SqlMapper.ExecuteReader(_cntDatabase, query);

                //clears and reinitializes data table
                _dtCustomersTable.Rows.Clear();
                _dtCustomersTable = new DataTable();

                //loads data reader results into data table
                _dtCustomersTable.Load(_drCustomers);

                //sets data table as Data Source for Binding Source to be used for the Data Grid Views
                Program._bsCustomers.DataSource = null;
                Program._bsCustomers.DataSource = _dtCustomersTable;

                
                _drCustomers.Dispose();          
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs sales data from SQL Database based on given parameters and puts results into Data Table which is then linked to a Binding Source.
        /// </summary>
        /// <param name="startDate">Start of user selected date range</param>
        /// <param name="endDate">End of user selected date range</param>
        /// <param name="customer">Customer ID</param>
        /// <param name="allOrders">Determines if orders are date specified</param>
        /// <example>
        /// <code>
        /// clsSQL.SalesData("2024-03-12", "2024-05-21", 12, false);
        /// </code>
        /// </example>
        public static void SalesData(string startDate, string endDate, int customer, bool allOrders)
        {
            try
            {           
                _dtSalesTable.Reset();

                //Variables
                string query = "DROP TABLE IF EXISTS SalesHolder; \n" +
                                "DROP TABLE IF EXISTS Sales; \n" +
                                "CREATE TEMPORARY TABLE SalesHolder AS SELECT IIF(OrderDetails.DiscountID IS NOT NULL, (SELECT DiscountLevel FROM Discounts WHERE DiscountID = OrderDetails.DiscountID), NULL) AS DiscountLevel, IIF(OrderDetails.DiscountID IS NOT NULL, (SELECT InventoryID FROM Discounts WHERE DiscountID = OrderDetails.DiscountID), NULL) AS DiscountInventoryID, IIF(OrderDetails.DiscountID IS NOT NULL, (SELECT DiscountType FROM Discounts WHERE DiscountID = OrderDetails.DiscountID), NULL) AS DiscountType, IIF(OrderDetails.DiscountID IS NOT NULL, (SELECT DiscountPercentage FROM Discounts WHERE DiscountID = OrderDetails.DiscountID), NULL) AS DiscountPercentage, IIF(OrderDetails.DiscountID IS NOT NULL, (SELECT DiscountDollarAmount FROM Discounts WHERE DiscountID = OrderDetails.DiscountID), NULL) AS DiscountDollarAmount, OrderDetails.DiscountID AS DiscountID, Inventory.RetailPrice AS RetailPrice, OrderDetails.OrderID AS OrderID, Orders.PersonID AS PersonID, Person.NameFirst || ' ' || Person.NameLast AS PersonName, Orders.OrderDate AS OrderDate, SUBSTRING(Orders.CC_Number, 16, 19) AS CC_Number, OrderDetails.InventoryID AS InventoryID, Inventory.ItemName AS ItemName, OrderDetails.Quantity AS Quantity FROM OrderDetails JOIN Orders ON OrderDetails.OrderID = Orders.OrderID JOIN Inventory ON OrderDetails.InventoryID = Inventory.InventoryID JOIN Person ON Orders.PersonID = Person.PersonID WHERE CC_Number != '' AND CC_Number IS NOT NULL; \n" +
                                "CREATE TEMPORARY TABLE Sales AS SELECT OrderID, PersonID, PersonName, OrderDate, CC_Number, InventoryID, ItemName, Quantity, IIF(DiscountID IS NOT NULL, IIF(DiscountLevel != 1, IIF(DiscountType != 1, CAST(ROUND(((RetailPrice * Quantity) - ((RetailPrice * Quantity) * DiscountPercentage)) + (((RetailPrice * Quantity) - ((RetailPrice * Quantity) * DiscountPercentage)) * .0825), 2) AS DECIMAL(18, 2)), CAST(ROUND(((RetailPrice * Quantity) - DiscountDollarAmount) + (((RetailPrice * Quantity) - DiscountDollarAmount) * .0825), 2) AS DECIMAL(18, 2))), IIF(DiscountType != 1, IIF(DiscountInventoryID IS NOT NULL, CAST(ROUND(((RetailPrice * Quantity) - ((RetailPrice * Quantity) * DiscountPercentage)) + (((RetailPrice * Quantity) - ((RetailPrice * Quantity) * DiscountPercentage)) * .0825), 2) AS DECIMAL(18, 2)), CAST(ROUND((RetailPrice * Quantity) + ((RetailPrice * Quantity) * .0825), 2) AS DECIMAL(18, 2))), IIF(DiscountInventoryID IS NOT NULL, CAST(ROUND(((RetailPrice * Quantity) - DiscountDollarAmount) + (((RetailPrice * Quantity) - DiscountDollarAmount) * .0825), 2) AS DECIMAL(18, 2)), CAST(ROUND((RetailPrice * Quantity) + ((RetailPrice * Quantity) * .0825), 2) AS DECIMAL(18, 2))))), CAST(ROUND((RetailPrice * Quantity) + ((RetailPrice * Quantity) * .0825), 2) AS DECIMAL(18, 2))) AS RowTotal FROM SalesHolder; \n" +
                                "SELECT * FROM Sales ";

                //Query Edits
                //if user wants specific date range
                if (allOrders == false)
                {
                    //updates query with specific date range statement
                    query += "WHERE (OrderDate >= '" + startDate + "' AND OrderDate <= '" + endDate + "')";
                }

                //if user wants customer and date specific data
                if (customer != 0 && allOrders == false)
                {
                    //updates query with AND clause
                    query += " AND ";
                }
                //else if user wants only customer specific data
                else if (customer != 0 && allOrders)
                {
                    //updates query with WHERE clause
                    query += "WHERE ";
                }
                
                //continuation of customer specific data
                if (customer != 0)
                {
                    //updates query with customer specific statement
                    query += "PersonID = " + customer;
                }

                //finishes query
                query += ";";

                //data reader executes string query
                IDataReader _drSales = SqlMapper.ExecuteReader(_cntDatabase, query);

                //clears and reinitializes data table
                _dtSalesTable.Rows.Clear();
                _dtSalesTable = new DataTable();

                //loads data reader results into data table
                _dtSalesTable.Load(_drSales);

                //sets data table as Data Source for Binding Source to be used for the Data Grid Views
                Program._bsSales.DataSource = null;
                Program._bsSales.DataSource = _dtSalesTable;

                _drSales.Dispose();              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs person data from SQL Database based on username and password then adds results to inputList.
        /// </summary>
        /// <param name="username">Given username</param>
        /// <param name="password">Given password</param>
        /// <param name="inputList">Holds results of query</param>
        /// <example>
        /// <code>
        /// clsSQL.UserLogin("user", "password", inputList);
        /// </code>
        /// </example>
        public static void UserLogin(string username, string password, List<string> inputList)
        {
            try
            {
                //Variables
                string query = "SELECT PersonID, Person.NameFirst || ' ' || Person.NameLast AS PersonName, PositionID, PersonDeleted FROM Person WHERE PersonID = (SELECT PersonID FROM Logon WHERE LogonName = '" + username.ToUpper() + "' AND Password = '" + password + "');";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //if data reader has rows
                if (_drForm.Read())
                {
                    //add row to list
                    inputList.Add(_drForm["PersonID"].ToString());
                    inputList.Add(_drForm["PersonName"].ToString());
                    inputList.Add(_drForm["PositionID"].ToString());
                    inputList.Add(_drForm["PersonDeleted"].ToString());
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs question prompts from SQL Database and adds them to QuestionSet ComboBoxes.
        /// </summary>
        /// <param name="firstQuestionSet">Will hold security questions</param>
        /// <param name="secondQuestionSet">Will hold security questions</param>
        /// <param name="thirdQuestionSet">Will hold security questions</param>
        /// <example>
        /// <code>
        /// clsSQL.PopulateAllQuestions(cbxFirstChallengeQuestion, cbxSecondChallengeQuestion, cbxThirdChallengeQuestion);
        /// </code>
        /// </example>
        public static void PopulateAllQuestions(ComboBox firstQuestionSet, ComboBox secondQuestionSet, ComboBox thirdQuestionSet)
        {
            try
            {
                //Variables
                List<string> questions = new List<string>();

                string query = "SELECT QuestionPrompt FROM SecurityQuestions;";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //while data reader has rows
                while (_drForm.Read())
                {
                    //add question prompts to questions list
                    questions.Add(_drForm["QuestionPrompt"].ToString());
                }

                _drForm.Dispose();

                //for each question in questions list
                foreach (string question in questions)
                {
                    //add question to parameterized ComboBoxes
                    firstQuestionSet.Items.Add(question);
                    secondQuestionSet.Items.Add(question);
                    thirdQuestionSet.Items.Add(question);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Creates an account using the given parameters, inserting them into the SQL Database.
        /// </summary>
        /// <param name="title">Holds inputted title</param>
        /// <param name="firstName">Holds inputted first name</param>
        /// <param name="middleName">Holds inputted middle name</param>
        /// <param name="lastName">Holds inputted last name</param>
        /// <param name="suffix">Holds inputted suffix</param>
        /// <param name="address1">Holds first line of inputted address</param>
        /// <param name="address2">Holds second line of inputted address</param>
        /// <param name="address3">Holds third line of inputted address</param>
        /// <param name="city">Holds inputted city</param>
        /// <param name="zipCode">Holds inputted zipcode</param>
        /// <param name="state">Holds inputted state</param>
        /// <param name="email">Holds inputted email</param>
        /// <param name="phonePrimary">Holds inputted primary phone number</param>
        /// <param name="phoneSecondary">Holds inputted secondary phone number</param>
        /// <param name="image">Holds inputted account image</param>
        /// <param name="positionID">Holds accounts position type</param>
        /// <param name="username">Holds inputted username</param>
        /// <param name="password">Holds inputted password</param>
        /// <param name="firstChallengeQuestionIndex">Holds inputted challenge question index</param>
        /// <param name="firstChallengeAnswer">Holds inputted challenge answer</param>
        /// <param name="secondChallengeQuestionIndex">Holds inputted challenge question index</param>
        /// <param name="secondChallengeAnswer">Holds inputted challenge answer</param>
        /// <param name="thirdChallengeQuestionIndex">Holds inputted challenge question index</param>
        /// <param name="thirdChallengeAnswer">Holds inputted challenge answer</param>
        /// <param name="positionTitle">Holds account position title</param>
        public static void CreateAccount(
            string title,
            string firstName,
            string middleName,
            string lastName,
            string suffix,
            string address1,
            string address2,
            string address3,
            string city,
            string zipCode,
            string state,
            string email,
            string phonePrimary,
            string phoneSecondary,
            string image,
            int positionID,
            string username,
            string password,
            int firstChallengeQuestionIndex,
            string firstChallengeAnswer,
            int secondChallengeQuestionIndex,
            string secondChallengeAnswer,
            int thirdChallengeQuestionIndex,
            string thirdChallengeAnswer,
            string positionTitle)
        {
            try
            {
                //Variables                
                string query = "INSERT INTO Person(Title, NameFirst, NameMiddle, NameLast, Suffix, Address1, Address2, Address3, City, ZipCode, State, Email, PhonePrimary, PhoneSecondary, Image, PositionID) VALUES (@Title, '" + firstName + "', @MName, '" + lastName + "', @Suffix, '" + address1 + "', @Address2, @Address3, '" + city + "', '" + zipCode + "', '" + state.ToUpper() + "', @Email, @Phone1, @Phone2, @Image, " + positionID + "); INSERT INTO Logon (PersonID, LogonName, Password, FirstChallengeQuestion, FirstChallengeAnswer, SecondChallengeQuestion, SecondChallengeAnswer, ThirdChallengeQuestion, ThirdChallengeAnswer, PositionTitle) VALUES ((SELECT PersonID FROM Person ORDER BY PersonID DESC LIMIT 1), '" + username.ToUpper() + "', '" + password + "', " + firstChallengeQuestionIndex + ", '" + firstChallengeAnswer.ToUpper() + "', " + secondChallengeQuestionIndex + ", '" + secondChallengeAnswer.ToUpper() + "', " + thirdChallengeQuestionIndex + ", '" + thirdChallengeAnswer.ToUpper() + "', '" + positionTitle + "');";

                var dictionary = new Dictionary<string, object>();

                ////Parameter Editing
                if (title.Equals("null"))
                {
                    dictionary.Add("@Title", null);
                }
                else
                {
                    dictionary.Add("@Title", title);
                }

                if (middleName.Equals("null"))
                {
                    dictionary.Add("@MName", null);
                }
                else
                {
                    dictionary.Add("@MName", middleName);
                }

                if (suffix.Equals("null"))
                {
                    dictionary.Add("@Suffix", null);
                }
                else
                {
                    dictionary.Add("@Suffix", suffix);
                }

                if (email.Equals("null"))
                {
                    dictionary.Add("@Email", null);
                }
                else
                {
                    dictionary.Add("@Email", email);
                }

                if (phonePrimary.Equals("null"))
                {
                    dictionary.Add("@Phone1", null);
                }
                else
                {
                    dictionary.Add("@Phone1", phonePrimary);
                }

                if (phoneSecondary.Equals("null"))
                {
                    dictionary.Add("@Phone2", null);
                }
                else
                {
                    dictionary.Add("@Phone2", phoneSecondary);
                }

                if (image.Equals("null"))
                {
                    dictionary.Add("@Image", null);
                }
                else
                {
                    dictionary.Add("@Image", clsImage.ImageToByteArray(image));
                }

                if (address2.Equals("null"))
                {
                    dictionary.Add("@Address2", null);
                }
                else
                {
                    dictionary.Add("@Address2", address2);
                }

                if (address3.Equals("null"))
                {
                    dictionary.Add("@Address3", null);
                }
                else
                {
                    dictionary.Add("@Addres3", address3);
                }

                var parameters = new DynamicParameters(dictionary);

                //executes string query with given parameters
                _cntDatabase.Execute(query, parameters);

                //Clears and Refills specified tables based on new account position
                if (positionID == 1001)
                {
                    _dtCustomersTable.Reset();
                    CustomerData();
                }
                else
                {
                    _dtManagersTable.Reset();
                    ManagerData();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Populates the users security questions into a textbox given their username.
        /// </summary>
        /// <param name="username">Holds the accounts username</param>
        /// <param name="firstQuestion">Holds the accounts first security question</param>
        /// <param name="secondQuestion">Holds the accounts second security question</param>
        /// <param name="thirdQuestion">Holds the accounts third security question</param>
        /// <example>
        /// <code>
        /// clsSQL.PopulateUserQuestions(tbxUsername.Text, tbxFirstChallengeQuestion, tbxSecondChallengeQuestion, tbxThirdChallengeQuestion)
        /// </code>
        /// </example>
        public static void PopulateUserQuestions(string username, TextBox firstQuestion, TextBox secondQuestion, TextBox thirdQuestion)
        {
            try
            {
                //Variables
                List<string> questions = new List<string>();

                string query = "SELECT 1 AS ChoiceNumber, QuestionPrompt FROM SecurityQuestions WHERE QuestionID = (SELECT FirstChallengeQuestion FROM Logon WHERE LogonName = '" + username.ToUpper() + "') UNION SELECT 2, QuestionPrompt FROM SecurityQuestions WHERE QuestionID = (SELECT SecondChallengeQuestion FROM Logon WHERE LogonName = '" + username.ToUpper() + "') UNION SELECT 3, QuestionPrompt FROM SecurityQuestions WHERE QuestionID = (SELECT ThirdChallengeQuestion FROM Logon WHERE LogonName = '" + username.ToUpper() + "');";

                //data reader executs string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //while data reader has rows
                while (_drForm.Read())
                {
                    //add question prompt to questions list
                    questions.Add(_drForm["QuestionPrompt"].ToString());
                }

                firstQuestion.Text = questions[0];
                secondQuestion.Text = questions[1];
                thirdQuestion.Text = questions[2];

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs the security answers of a user from the database given the username.
        /// </summary>
        /// <param name="username">Holds the accounts username</param>
        /// <param name="answers">Holds the accounts security answers</param>
        /// <example>
        /// <code>
        /// List&lt;string&gt; answers = new List&lt;string&gt;();
        /// clsSQL.GetAnswers(username.Text, answers);
        /// </code>
        /// </example>
        public static void GetAnswers(string username, List<string> answers)
        {
            try
            {
                //Variables
                string query = "SELECT 1 AS AnswerNumber, FirstChallengeAnswer AS Answer FROM Logon WHERE LogonName = '" + username.ToUpper() + "' UNION SELECT 2, SecondChallengeAnswer FROM Logon WHERE LogonName = '" + username.ToUpper() + "' UNION SELECT 3, ThirdChallengeAnswer FROM Logon WHERE LogonName = '" + username.ToUpper() + "';";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //while data reader has rows
                while (_drForm.Read())
                {
                    //adds row data to answers
                    answers.Add(_drForm["Answer"].ToString());
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Resets users password given the username.
        /// </summary>
        /// <param name="username">Holds the accounts username</param>
        /// <param name="password">Holds the accounts new password</param>
        /// <example>
        /// <code>
        /// clsSQL.ResetPassword(tbxUsername.Text, tbxResetPassword.Text);
        /// </code>
        /// </example>
        public static void ResetPassword(string username, string password)
        {
            try
            {
                //Variables
                string query = "UPDATE Logon SET Password = '" + password + "' WHERE LogonName = '" + username.ToUpper() + "';";

                _cntDatabase.Execute(query);

                Console.WriteLine("Password successfully reset");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Gets ID based on parameters.
        /// </summary>
        /// <param name="max">Determines if MAX is being used in query</param>
        /// <param name="column">Holds column name</param>
        /// <param name="table">Holds table name</param>
        /// <param name="where">Determines if WHERE is being used in query</param>
        /// <param name="personID">Holds personID</param>
        /// <returns>The found ID</returns>
        /// <example>
        /// <code>
        /// clsSQL.GetID(true, "OrderID", "Orders", false, null)
        /// </code>
        /// </example>
        public static int GetID(bool max, string column, string table, bool where, int? personID)
        {
            //Variables
            int ID = 0;

            try
            {
                //Variables
                string query;

                //Query Edits
                if (max)
                {
                    query = "SELECT MAX(" + column + ") as " + column + " FROM " + table;
                }
                else
                {
                    query = "SELECT " + column + " FROM " + table;
                }

                if (where)
                {
                    query += " WHERE PersonID = " + Convert.ToInt32(personID);
                }

                query += ";";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //if data reader has rows
                if (_drForm.Read())
                {
                    //adds row data to ID
                    ID = Convert.ToInt32(_drForm.GetValue(0));
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }

            return ID;
        }

        /// <summary>
        /// Gets ID based on parameters.
        /// </summary>
        /// <param name="max">Determines if MAX is being used in query</param>
        /// <param name="column">Holds column name</param>
        /// <param name="table">Holds table name</param>
        /// <param name="where">Determines if WHERE is being used in query</param>
        /// <param name="orderID">Used to determine specific order</param>
        /// <param name="inventoryID">Used to determine specific item</param>
        /// <returns>The found ID</returns>
        /// <example>
        /// <code>
        /// clsSQL.GetID(false, "OrderDetailsID", "OrderDetails", true, orderDetail.GetOrderID(), orderDetail.GetInventoryID())
        /// </code>
        /// </example>
        public static int GetID(bool max, string column, string table, bool where, int? orderID, int? inventoryID)
        {
            //Variables
            int ID = 0;

            try
            {
                //Variables
                string query;

                //Query Edits
                if (max)
                {
                    query = "SELECT MAX(" + column + ") as " + column + " FROM " + table;
                }
                else
                {
                    query = "SELECT " + column + " FROM " + table;
                }

                if (where)
                {
                    query += " WHERE OrderID = " + Convert.ToInt32(orderID) + " AND InventoryID = " + Convert.ToInt32(inventoryID);
                }

                query += ";";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //if data reader has rows
                if (_drForm.Read())
                {
                    //add row data to ID
                    ID = Convert.ToInt32(_drForm.GetValue(0));
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }

            return ID;
        }

        /// <summary>
        /// Creates an order and inserts it into the SQL Database.
        /// </summary>
        /// <param name="order">Holds entire order</param>
        /// <example>
        /// <code>
        /// order = new clsOrders(Convert.ToInt32(Program.loggedInUserInfo[0]), null, "", "", "");
        /// clsSQL.CreateOrder(order);
        /// </code>
        /// </example>
        public static void CreateOrder(clsOrders order)
        {
            try
            {
                //Variables
                string orderDate = DateTime.Today.ToString("yyyy-MM-dd");

                string query = "INSERT INTO Orders(DiscountID, PersonID, EmployeeID, OrderDate, CC_Number, ExpDate, CCV) VALUES(@DiscountID, " + Convert.ToInt64(order.GetPersonID()) + ", @EmployeeID, '" + orderDate + "', '" + order.GetCCNum() + "', '" + order.GetExpDate() + "', '" + order.GetCCV() + "');";

                var dictionary = new Dictionary<string, object>
                    {
                        { "@DiscountID", null }
                    };

                //Query Edits
                if (order.GetEmployeeID() == null)
                {
                    dictionary.Add("@EmployeeID", null);
                }
                else
                {
                    dictionary.Add("@EmployeeID", order.GetEmployeeID());
                }

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Creates order details and inserts it into SQL Database.
        /// </summary>
        /// <param name="orderID">Used to determine specific order</param>
        /// <param name="inventoryID">Used to determine specific item</param>
        /// <param name="quantity">Holds orders quantity</param>
        /// <example>
        /// <code>
        /// clsSQL.CreateOrderDetails(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(row.Field&lt;Int64&gt;("InventoryID")), Convert.ToInt32(cbxQuantity.SelectedItem));
        /// </code>
        /// </example>
        public static void CreateOrderDetails(int orderID, int inventoryID, int quantity)
        {
            try
            {
                //Variables
                string query = "INSERT INTO OrderDetails(OrderID, InventoryID, DiscountID, Quantity) VALUES(@OrderID, @InventoryID, @DiscountID, @Quantity);";

                var dictionary = new Dictionary<string, object>
                    {
                        { "@OrderID", orderID },
                        { "@InventoryID", inventoryID},
                        { "@DiscountID", null },
                        { "@Quantity", quantity }
                    };

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Fills input list with users cart items based on personID.
        /// </summary>
        /// <param name="personID">Used to determine specific customer</param>
        /// <param name="inputList">List that holds cart items</param>
        /// <example>
        /// <code>
        /// clsSQL.FillCart(Convert.ToInt32(Program.loggedInUserInfo[0]), frmShop.orderDetailsList);
        /// </code>
        /// </example>
        public static void FillCart(int personID, ObservableCollection<clsOrderDetails> inputList)
        {
            try
            {
                //Variables
                clsOrderDetails orderDetails;                

                string query = "SELECT OrderDetails.OrderID, OrderDetails.InventoryID, Inventory.ItemName, Inventory.RetailPrice, OrderDetails.Quantity FROM OrderDetails JOIN Inventory ON OrderDetails.InventoryID = Inventory.InventoryID JOIN Orders ON OrderDetails.OrderID = Orders.OrderID WHERE (CC_Number IS NULL or CC_Number = '') AND PersonID = " + personID + ";";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                inputList.Clear();

                //while data reader has rows
                while (_drForm.Read())
                {
                    //creates orderDetail
                    orderDetails = new clsOrderDetails(
                        Convert.ToInt32(_drForm["OrderID"]),
                        Convert.ToInt32(_drForm["InventoryID"]),
                        _drForm["ItemName"].ToString(),
                        Convert.ToDecimal(_drForm["RetailPrice"]),
                        Convert.ToInt32(_drForm["Quantity"])
                    );

                    //add new orderDetail to inputList
                    inputList.Add(orderDetails);
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds to existing cart item in OrderDetails table.
        /// </summary>
        /// <param name="orderDetailsID">Used to determine specific order details</param>
        /// <param name="quantity">Holds new quantity of item</param>
        /// <example>
        /// <code>
        /// clsSQL.AddToCartItemQuantity(clsSQL.GetID(false, "OrderDetailsID", "OrderDetails", true, orderDetail.GetOrderID(), orderDetail.GetInventoryID()), itemQuantity);
        /// </code>
        /// </example>
        public static void AddToCartItemQuantity(int orderDetailsID, int quantity)
        {
            try
            {
                //Variables
                string query = "UPDATE OrderDetails SET Quantity = (Quantity + " + quantity + ") WHERE OrderDetailsID = " + orderDetailsID + ";";

                _cntDatabase.Execute(query);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Updates cart item quantity based on orderID and inventoryID.
        /// </summary>
        /// <param name="orderID">Used to determine specific order</param>
        /// <param name="inventoryID">Used to determine specific item</param>
        /// <param name="quantity">Holds updated quantity</param>
        /// <example>
        /// <code>
        /// clsSQL.UpdateCartItemQuantity(frmShop.orderDetailsList[cartIndex].GetOrderID(), frmShop.orderDetailsList[cartIndex].GetInventoryID(), Convert.ToInt32(cbxQuantity.Text));
        /// </code>
        /// </example>
        public static void UpdateCartItemQuantity(int orderID, int inventoryID, int quantity)
        {
            try
            {
                //Variables
                string query = "UPDATE OrderDetails SET Quantity = " + quantity + " WHERE OrderID = " + orderID + " AND InventoryID = " + inventoryID + ";";

                _cntDatabase.Execute(query);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Removes item from customer cart.
        /// </summary>
        /// <param name="orderID">Used to determine specific order</param>
        /// <param name="inventoryID">Used to determine item</param>
        /// <param name="cartQuantity">Used to determine items quantity</param>
        /// <example>
        /// <code>
        /// clsSQL.RemoveCartItem(frmShop.orderDetailsList[cartIndex].GetOrderID(), frmShop.orderDetailsList[cartIndex].GetInventoryID(), frmShop.orderDetailsList.Count);
        /// </code>
        /// </example>
        public static void RemoveCartItem(int orderID, int inventoryID, int cartQuantity)
        {
            try
            {
                //Variables
                string query = "DELETE FROM OrderDetails WHERE OrderID = " + orderID + " AND InventoryID = " + inventoryID + ";";

                _cntDatabase.Execute(query);

                if (cartQuantity == 1)
                {
                    query = "DELETE FROM Orders WHERE OrderID = " + orderID + ";";

                    _cntDatabase.Execute(query);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Clears customer cart.
        /// </summary>
        /// <param name="orderID">Used to determine specific order</param>
        /// <example>
        /// <code>
        /// clsSQL.ClearCart(frmShop.orderDetailsList[0].GetOrderID());
        /// </code>
        /// </example>
        public static void ClearCart(int orderID)
        {
            try
            {
                //Variables
                string query;

                query = "DELETE FROM OrderDetails WHERE OrderID = " + orderID + ";";

                _cntDatabase.Execute(query);

                query = "DELETE FROM Orders WHERE OrderID = " + orderID + ";";

                _cntDatabase.Execute(query);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds discount to customer order.
        /// </summary>
        /// <param name="orderID">Used to determine specific order</param>
        /// <param name="discountID">Used to determine specific discount</param>
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// Adds new discount
        /// <code>
        /// clsSQL.AddDiscountID(frmShop.orderDetailsList[0].GetOrderID(), usedDiscount.discountID);
        /// </code>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Adds null for discount
        /// <code>
        /// clsSQL.AddDiscountID(frmShop.orderDetailsList[0].GetOrderID(), null);
        /// </code>
        /// </description>
        /// </item>
        /// </list>
        /// </example>
        public static void AddDiscountID(int orderID, int? discountID)
        {
            try
            {
                //Variables
                string query = "UPDATE OrderDetails SET DiscountID = @DiscountID WHERE OrderID = " + orderID + ";\n" +
                    "UPDATE Orders SET DiscountID = @DiscountID WHERE OrderID = " + orderID + ";";

                var dictionary = new Dictionary<string, object>();

                //Query Edits
                if (discountID == null)
                {
                    dictionary.Add("@DiscountID", null);
                }
                else
                {
                    dictionary.Add("@DiscountID", discountID);
                }

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds employeeID to customer order.
        /// </summary>
        /// <param name="orderID">Used to determine specific order</param>
        /// <param name="employeeID">Holds employeeID to be added to order</param>
        /// <example>
        /// <code>
        /// clsSQL.AddEmployeeID(clsSQL.GetID(true, "OrderID", "Orders", false, null), Convert.ToInt32(Program.loggedInUserInfo[0]));
        /// </code>
        /// </example>
        public static void AddEmployeeID(int orderID, int employeeID)
        {
            try
            {
                //Variables
                string query = "UPDATE Orders SET EmployeeID = " + employeeID + " WHERE OrderID = " + orderID + ";";

                _cntDatabase.Execute(query);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds customer payment info to order.
        /// </summary>
        /// <param name="orderID">Used to determine customer order</param>
        /// <param name="ccNum">Holds user inputted credit card number</param>
        /// <param name="CCV">Holds user inputted CCV</param>
        /// <param name="expirationDate">Holds user inputted credit card expiration date</param>
        /// <example>
        /// <code>
        /// clsSQL.FinalizeOrderInfo(orderID, CCNum, tbxCCV.Text, tbxExpiration.Text);
        /// </code>
        /// </example>
        public static void FinalizeOrderInfo(int orderID, string ccNum, string CCV, string expirationDate)
        {
            try
            {
                //Variables
                string orderDate = DateTime.Today.ToString("yyyy-MM-dd");

                string query = "UPDATE Orders SET CC_Number = '" + ccNum + "', CCV = '" + CCV + "', ExpDate = '" + expirationDate + "' WHERE OrderID = " + orderID + ";";

                _cntDatabase.Execute(query);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds cart item info to order details.
        /// </summary>
        /// <param name="inventoryID">Used to determine customer item</param>
        /// <param name="quantity">Used to determine item quantity</param>
        /// <example>
        /// <code>
        /// clsSQL.FinalizeOrderDetailsInfo(orderDetail.GetInventoryID(), orderDetail.GetQuantity());
        /// </code>
        /// </example>
        public static void FinalizeOrderDetailsInfo(int inventoryID, int quantity)
        {
            try
            {
                //Variables
                string query = "UPDATE Inventory SET Quantity = (SELECT Quantity FROM Inventory WHERE(InventoryID = " + inventoryID + ")) - " + quantity + " WHERE InventoryID = " + inventoryID + ";";

                _cntDatabase.Execute(query);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Grabs user info from SQL Database.
        /// </summary>
        /// <param name="personID">Used to determine specific person</param>
        /// <param name="inputList">Used to hold customer info results</param>
        /// <example>
        /// <code>
        /// clsSQL.UserInfo(Convert.ToInt32(chosenCustomer.Field&lt;Int64&gt;("PersonID")), Program.loggedInPOSCustomerInfo);
        /// </code>
        /// </example>
        public static void UserInfo(int personID, List<string> inputList)
        {
            try
            {
                //Variables
                string query = "SELECT PersonID, Person.NameFirst || ' ' || Person.NameLast AS PersonName, PositionID, PersonDeleted FROM Person WHERE PersonID = " + personID + ";";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //if data reader has rows
                if (_drForm.Read())
                {
                    //for each column in row
                    for (int i = 0; i < _drForm.FieldCount; i++)
                    {
                        //add to inputList
                        inputList.Add(_drForm.GetValue(i).ToString());
                    }
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Searches inventory table based on parameters given.
        /// </summary>
        /// <param name="searchBool">Used to determine if search is used</param>
        /// <param name="categoryBool">Used to determine if category is used</param>
        /// <param name="priceBool">Used to determine if price range is used</param>
        /// <param name="search">Holds user inputted search</param>
        /// <param name="categoryID">Used to determine specific category</param>
        /// <param name="lowerPrice">Used to determine lower price range</param>
        /// <param name="upperPrice">Used to determine higher price range</param>
        /// <example>
        /// <code>
        /// clsSQL.SearchInventoryData(searchBool, categoryBool, priceBool, tbxSearch.Text, categoryID, lowerPrice, upperPrice);
        /// </code>
        /// </example>
        public static void SearchInventoryData(bool searchBool, bool categoryBool, bool priceBool, string search, int categoryID, decimal lowerPrice, decimal upperPrice)
        {
            try
            {
                //Variables
                string query = "SELECT * FROM Inventory WHERE ";

                //Query Edits
                if (searchBool)
                {
                    query += "ItemName LIKE '%" + search + "%'";
                    if (categoryBool || priceBool)
                    {
                        query += " AND ";
                    }
                }
                if (categoryBool)
                {
                    query += "CategoryID = " + categoryID;
                    if (priceBool)
                    {
                        query += " AND ";
                    }
                }
                if (priceBool)
                {
                    query += "(RetailPrice BETWEEN " + lowerPrice + " AND " + upperPrice + ")";
                }

                //clears and reinitializes data table
                _dtSearchedInventoryTable.Rows.Clear();
                _dtSearchedInventoryTable = new DataTable();

                //data reader executes string query
                IDataReader executeReader = SqlMapper.ExecuteReader(_cntDatabase, query);

                //loads data reader results to data table
                _dtSearchedInventoryTable.Load(executeReader);

                //sets data table as Data Source for Binding Source to be used for the Data Grid Views
                Program._bsSearchedItems.DataSource = null;
                Program._bsSearchedItems.DataSource = _dtSearchedInventoryTable;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Gets categoryID from Categories table.
        /// </summary>
        /// <param name="categoryName">Used to determine category</param>
        /// <returns>The found categoryID</returns>
        /// <example>
        /// <code>
        /// GetCategoryID(categoryName)
        /// </code>
        /// </example>
        public static int GetCategoryID(string categoryName)
        {
            //Variables
            int categoryID = 0;

            try
            {
                //Variables
                string query = "SELECT CategoryID FROM Categories WHERE CategoryName = '" + categoryName + "';";

                //data reader executes string query
                IDataReader _drForm = SqlMapper.ExecuteReader(_cntDatabase, query);

                //if data reader has rows
                if (_drForm.Read())
                {
                    //add row data to categoryID
                    categoryID = Convert.ToInt32(_drForm.GetValue(0));
                }

                _drForm.Dispose();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }

            return categoryID;
        }

        /// <summary>
        /// Adds item to Inventory table of SQL Database.
        /// </summary>
        /// <param name="itemName">Holds user inputted item name</param>
        /// <param name="itemDescription">Holds user inputted item description</param>
        /// <param name="categoryName">Holds user inputted category</param>
        /// <param name="retailPrice">Holds user inputted retail price</param>
        /// <param name="cost">Holds user inputted cost</param>
        /// <param name="quantity">Holds user inputted quantity of item</param>
        /// <param name="restockThreshold">Holds user inputted restock threshold</param>
        /// <param name="itemImage">Holds user inputted item image</param>
        /// <example>
        /// <code>
        /// clsSQL.AddItem(tbxAddItemNameActual.Text, tbxAddItemDescriptionActual.Text, cbxCategories.SelectedItem.ToString(), Convert.ToDecimal(tbxAddRetailPriceActual.Text), Convert.ToDecimal(tbxAddCostActual.Text), Convert.ToInt32(tbxAddQuantityActual.Text), Convert.ToInt32(tbxAddRestockThresholdActual.Text), fileName);
        /// </code>
        /// </example>
        public static void AddItem(string itemName, string itemDescription, string categoryName, decimal retailPrice, decimal cost, int quantity, int restockThreshold, string itemImage)
        {
            try
            {
                //Variables
                string query = "INSERT INTO Inventory (ItemName, ItemDescription, CategoryID, RetailPrice, Cost, Quantity, RestockThreshold, ItemImage, Discontinued) VALUES ('" + itemName + "', '" + itemDescription + "', " + GetCategoryID(categoryName) + ", " + retailPrice + ", " + cost + ", " + quantity + ", " + restockThreshold + ", @ItemImage, NULL);";

                var dictionary = new Dictionary<string, object>();

                //Query Edits
                if (itemImage.Equals("null"))
                {
                    dictionary.Add("@ItemImage", null);
                }
                else
                {
                    dictionary.Add("@ItemImage", clsImage.ImageToByteArray(itemImage));
                }

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);

                //Resets and updates data table
                _dtInventoryTable.Reset();
                InventoryData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Modifies user selected item in SQL Database.
        /// </summary>
        /// <param name="inventoryID">Determines user selected item</param>
        /// <param name="itemNameBool">Determines if item name was changed</param>
        /// <param name="itemDescriptionBool">Determines if item description was changed</param>
        /// <param name="retailPriceBool">Determines if retail price was changed</param>
        /// <param name="quantityBool">Determines if item quantity was changed</param>
        /// <param name="restockThresholdBool">Determines if restock threshold was changed</param>
        /// <param name="imageBool">Determines if item image was changed</param>
        /// <param name="itemName">Holds new user inputted item name</param>
        /// <param name="itemDescription">Holds new user inputted item description</param>
        /// <param name="retailPrice">Holds new user inputted retail price</param>
        /// <param name="quantity">Holds new user inputted quantity</param>
        /// <param name="restockThreshold">Holds new user inputted restock threshold</param>
        /// <param name="imagePath">Holds new user inputted image path</param>
        /// <example>
        /// <code>
        /// clsSQL.ModifyItem(Convert.ToInt32(row["InventoryID"].ToString()), itemNameChangedBool, itemDescriptionChangedBool, retailPriceChangedBool, quantityChangedBool, restockThresholdChangedBool, imageChangedBool, tbxEditItemNameActual.Text, tbxEditDescriptionActual.Text, tbxEditRetailPriceActual.Text, tbxEditQuantityActual.Text, tbxEditRestockThresholdActual.Text, fileName);
        /// </code>
        /// </example>
        public static void ModifyItem(int inventoryID, bool itemNameBool, bool itemDescriptionBool, bool retailPriceBool, bool quantityBool, bool restockThresholdBool, bool imageBool, string itemName, string itemDescription, string retailPrice, string quantity, string restockThreshold, string imagePath)
        {
            try
            {
                //Variables
                string query = "UPDATE Inventory SET ";

                var dictionary = new Dictionary<string, object>();

                //Query Edits
                if (!imagePath.Equals("null"))
                {
                    imagePath = System.IO.Path.GetFullPath(imagePath);
                }

                if (itemNameBool)
                {
                    query += "ItemName = '" + itemName + "'";
                    if (itemDescriptionBool || retailPriceBool || quantityBool || restockThresholdBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (itemDescriptionBool)
                {
                    query += "ItemDescription = '" + itemDescription + "'";
                    if (retailPriceBool || quantityBool || restockThresholdBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (retailPriceBool)
                {
                    query += "RetailPrice = " + Convert.ToDecimal(retailPrice);
                    if (quantityBool || restockThresholdBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (quantityBool)
                {
                    query += "Quantity = " + Convert.ToInt32(quantity);
                    if (restockThresholdBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (restockThresholdBool)
                {
                    query += "RestockThreshold = " + Convert.ToInt32(restockThreshold);
                    if (imageBool)
                    {
                        query += ", ";
                    }
                }
                if (imageBool)
                {
                    query += "ItemImage = @ItemImage";
                }

                query += " WHERE InventoryID = " + inventoryID + ";";

                if (imageBool)
                {
                    dictionary.Add("@ItemImage", clsImage.ImageToByteArray(imagePath));
                }

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);

                //Resets and updates data table
                _dtInventoryTable.Reset();
                InventoryData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Removes selected item from SQL Database.
        /// </summary>
        /// <param name="inventoryID">Used to determine inventory item</param>
        /// <example>
        /// <code>
        /// clsSQL.RemoveItem(Convert.ToInt32(row["InventoryID"].ToString()));
        /// </code>
        /// </example>
        public static void RemoveItem(int inventoryID)
        {
            try
            {
                //Variables
                string query = "UPDATE Inventory SET ";

                query += "Discontinued = 1";

                query += " WHERE InventoryID = " + inventoryID;

                _cntDatabase.Execute(query);

                //Resets and updates data table
                _dtInventoryTable.Reset();
                InventoryData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Used to modify existing user in the SQL Database.
        /// </summary>
        /// <param name="personID">Used to determine user</param>
        /// <param name="titleBool">Determines if accounts title was changed</param>
        /// <param name="firstNameBool">Determines if accounts first name was changed</param>
        /// <param name="middleNameBool">Determines if accounts middle name was changed</param>
        /// <param name="lastNameBool">Determines if accounts last name was changed</param>
        /// <param name="suffixBool">Determines if accounts suffix was changed</param>
        /// <param name="addressBool">Determines if accounts address was changed</param>
        /// <param name="cityBool">Determines if accounts city was changed</param>
        /// <param name="zipcodeBool">Determines if accounts zipcode was changed</param>
        /// <param name="stateBool">Determines if accounts state was changed</param>
        /// <param name="emailBool">Determines if accounts email was changed</param>
        /// <param name="phonePrimaryBool">Determines if accounts primary phone number was changed</param>
        /// <param name="phoneSecondaryBool">Determines if accounts secondary phone number was changed</param>
        /// <param name="imageBool">Determines if accounts image was changed</param>
        /// <param name="title">Holds new user inputted title</param>
        /// <param name="firstName">Holds new user inputted first name</param>
        /// <param name="middleName">Holds new user inputted middle name</param>
        /// <param name="lastName">Holds new user inputted last name</param>
        /// <param name="suffix">Holds new user inputted suffix</param>
        /// <param name="address1">Holds new user inputted first line of address</param>
        /// <param name="address2">Holds new user inputted second line of address</param>
        /// <param name="address3">Holds new user inputted third line of address</param>
        /// <param name="city">Holds new user inputted city</param>
        /// <param name="zipcode">Holds new user inputted zipcode</param>
        /// <param name="state">Holds new user inputted state</param>
        /// <param name="email">Holds new user inputted email</param>
        /// <param name="phonePrimary">Holds new user inputted primary phone number</param>
        /// <param name="phoneSecondary">Holds new user inputted secondary phone number</param>
        /// <param name="imagePath">Holds new user inputted image path</param>
        /// <param name="personType">Determines account type</param>
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// Modifies customer
        /// <code>
        /// clsSQL.ModifyPerson(
        ///     Convert.ToInt32(row["PersonID"].ToString()),
        ///     editTitleChangedBool,
        ///     editFirstNameChangedBool,
        ///     editMiddleNameChangedBool,
        ///     editLastNameChangedBool,
        ///     editSuffixChangedBool,
        ///     editAddressChangedBool,
        ///     editCityChangedBool,
        ///     editZipcodeChangedBool,
        ///     editStateChangedBool,
        ///     editEmailChangedBool,
        ///     editPhonePrimaryChangedBool,
        ///     editPhoneSecondaryChangedBool,
        ///     editImageChangedBool,
        ///     tbxEditTitleActual.Text,
        ///     tbxEditFirstNameActual.Text,
        ///     tbxEditMiddleNameActual.Text,
        ///     tbxEditLastNameActual.Text,
        ///     tbxEditSuffixActual.Text,
        ///     addresses[0],
        ///     addresses[1],
        ///     addresses[2],
        ///     tbxEditCityActual.Text,
        ///     tbxEditZipcodeActual.Text,
        ///     tbxEditStateActual.Text,
        ///     tbxEditEmailActual.Text,
        ///     tbxEditPhonePrimaryActual.Text,
        ///     tbxEditPhoneSecondaryActual.Text,
        ///     fileName,
        ///     0
        /// );
        /// </code>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Modifies manager
        /// <code>
        /// clsSQL.ModifyPerson(
        ///     Convert.ToInt32(chosenRow["PersonID"].ToString()), 
        ///     editTitleChangedBool, 
        ///     editFirstNameChangedBool, 
        ///     editMiddleNameChangedBool, 
        ///     editLastNameChangedBool, 
        ///     editSuffixChangedBool, 
        ///     editAddressChangedBool, 
        ///     editCityChangedBool, 
        ///     editZipcodeChangedBool, 
        ///     editStateChangedBool, 
        ///     editEmailChangedBool, 
        ///     editPhonePrimaryChangedBool,
        ///     editPhoneSecondaryChangedBool, 
        ///     editImageChangedBool, 
        ///     tbxEditTitleActual.Text, 
        ///     tbxEditFirstNameActual.Text, 
        ///     tbxEditMiddleNameActual.Text, 
        ///     tbxEditLastNameActual.Text,
        ///     tbxEditSuffixActual.Text, 
        ///     addresses[0],
        ///     addresses[1], 
        ///     addresses[2],
        ///     tbxEditCityActual.Text, 
        ///     tbxEditZipcodeActual.Text, 
        ///     tbxEditStateActual.Text, 
        ///     tbxEditEmailActual.Text,
        ///     tbxEditPhonePrimaryActual.Text, 
        ///     tbxEditPhoneSecondaryActual.Text, 
        ///     fileName,
        ///     1
        /// );
        /// </code>
        /// </description>
        /// </item>
        /// </list>
        /// </example>
        public static void ModifyPerson(int personID, bool titleBool, bool firstNameBool, bool middleNameBool, bool lastNameBool, bool suffixBool, bool addressBool, bool cityBool, bool zipcodeBool, bool stateBool, bool emailBool, bool phonePrimaryBool, bool phoneSecondaryBool, bool imageBool, string title, string firstName, string middleName, string lastName, string suffix, string address1, string address2, string address3, string city, string zipcode, string state, string email, string phonePrimary, string phoneSecondary, string imagePath, int personType)
        {
            try
            {
                //Variables
                string query = "UPDATE Person SET ";

                var dictionary = new Dictionary<string, object>();

                //Query Edits
                if (!imagePath.Equals("null"))
                {
                    imagePath = System.IO.Path.GetFullPath(imagePath);
                }

                if (titleBool)
                {
                    query += "Title = '" + title + "'";
                    if (firstNameBool || middleNameBool || lastNameBool || suffixBool || addressBool || cityBool || zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (firstNameBool)
                {
                    query += "NameFirst = '" + firstName + "'";
                    if (middleNameBool || lastNameBool || suffixBool || addressBool || cityBool || zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (middleNameBool)
                {
                    query += "NameMiddle = '" + middleName + "'";
                    if (lastNameBool || suffixBool || addressBool || cityBool || zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (lastNameBool)
                {
                    query += "NameLast = '" + lastName + "'";
                    if (suffixBool || addressBool || cityBool || zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (suffixBool)
                {
                    query += "Suffix = '" + suffix + "'";
                    if (addressBool || cityBool || zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (addressBool)
                {
                    query += "Address1 = '" + address1 + "', Address2 = '" + address2 + "', Address3 = '" + address3 + "'";
                    if (cityBool || zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (cityBool)
                {
                    query += "City = '" + city + "'";
                    if (zipcodeBool || stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (zipcodeBool)
                {
                    query += "Zipcode = '" + zipcode + "'";
                    if (stateBool || emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (stateBool)
                {
                    query += "State = '" + state + "'";
                    if (emailBool || phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (emailBool)
                {
                    query += "Email = '" + email + "'";
                    if (phonePrimaryBool || phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (phonePrimaryBool)
                {
                    query += "PhonePrimary = '" + phonePrimary + "'";
                    if (phoneSecondaryBool || imageBool)
                    {
                        query += ", ";
                    }
                }
                if (phoneSecondaryBool)
                {
                    query += "PhoneSecondary = '" + phoneSecondary + "'";
                    if (imageBool)
                    {
                        query += ", ";
                    }
                }

                if (imageBool)
                {
                    query += "Image = @Image";
                }

                query += " WHERE PersonID = " + personID + ";";

                if (imageBool)
                {
                    dictionary.Add("@Image", clsImage.ImageToByteArray(imagePath));
                }

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);

                //resets and updates data table based on account type
                if (personType == 0)
                {
                    _dtCustomersTable.Reset();
                    CustomerData();
                }
                else
                {
                    _dtManagersTable.Reset();
                    ManagerData();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Removes account from SQL Database.
        /// </summary>
        /// <param name="personID">Used to determine specific account</param>
        /// <param name="personType">Used to determine account type</param>
        /// <example>
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// Removes customer
        /// <code>
        /// clsSQL.RemovePerson(Convert.ToInt32(row["PersonID"].ToString()), 0);
        /// </code>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Removes manager
        /// <code>
        /// clsSQL.RemovePerson(Convert.ToInt32(chosenRow["PersonID"].ToString()), 1);
        /// </code>
        /// </description>
        /// </item>
        /// </list>
        /// </example>
        public static void RemovePerson(int personID, int personType)
        {
            try
            {
                //Variables
                string query = "UPDATE Person SET ";

                query += "PersonDeleted = 1";

                query += " WHERE PersonID = " + personID;

                _cntDatabase.Execute(query);

                //reset and updates data table based on account type
                if (personType == 0)
                {
                    _dtCustomersTable.Reset();
                    CustomerData();
                }
                else
                {
                    _dtManagersTable.Reset();
                    ManagerData();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Searches through customers based on user input.
        /// </summary>
        /// <param name="searchText">Holds user inputted search info</param>
        /// <example>
        /// <code>
        /// clsSQL.SearchCustomerData(tbxSearch.Text);
        /// </code>
        /// </example>
        public static void SearchCustomerData(string searchText)
        {
            try
            {
                //Variables
                string query = "SELECT * FROM Person WHERE ";

                //Query Edits
                if (searchText.All(char.IsDigit))
                {
                    int search = Convert.ToInt32(searchText);
                    query += "PersonID = " + search + " OR PhonePrimary LIKE '%" + searchText + "%' OR PhoneSecondary LIKE '%" + searchText + "%'";

                }
                else
                {
                    query += "Title LIKE '%" + searchText + "%' OR NameFirst LIKE '%" + searchText + "%' OR NameMiddle LIKE '%" + searchText + "%' OR NameLast LIKE '%" + searchText + "%' OR Suffix LIKE '%" + searchText + "%' OR Address1 LIKE '%" + searchText + "%' OR Address2 LIKE '%" + searchText + "%' OR Address3 LIKE '%" + searchText + "%' OR City LIKE '%" + searchText + "%' OR Zipcode LIKE '%" + searchText + "%' OR State LIKE '%" + searchText + "%' OR Email LIKE '%" + searchText + "%'";
                }

                query += ";";

                //clears and reinitializes data table
                _dtSearchedCustomersTable.Rows.Clear();
                _dtSearchedCustomersTable = new DataTable();

                //data reader executes string query
                IDataReader executeReader = SqlMapper.ExecuteReader(_cntDatabase, query);

                //loads data reader results to data table
                _dtSearchedCustomersTable.Load(executeReader);

                //sets data table as Data Source for Binding Source to be used for the Data Grid Views
                Program._bsSearchedCustomers.DataSource = null;
                Program._bsSearchedCustomers.DataSource = _dtSearchedCustomersTable;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Adds new discount code to SQL Database.
        /// </summary>
        /// <param name="discountCode">Holds user inputted discount code</param>
        /// <param name="discountDescription">Holds user inputted discount description</param>
        /// <param name="discountLevel">Holds user inputted discount level</param>
        /// <param name="inventoryID">Holds user inputted item specific link</param>
        /// <param name="discountType">Holds user inputted discount type</param>
        /// <param name="discountPercentage">Holds user inputted discount percentage</param>
        /// <param name="discountDollarAmount">Holds user inputted discount dollar amount</param>
        /// <param name="startDate">Holds user inputted discount start date</param>
        /// <param name="expirationDate">Holds user inputted discount expiration date</param>
        /// <param name="Disabled">Determines if discount is disabled</param>
        /// <example>
        /// <code>
        /// clsSQL.AddCode(
        ///     tbxAddDiscountCodeActual.Text, 
        ///     tbxAddDescriptionActual.Text, 
        ///     cbxAddDiscountLevelActual.SelectedIndex, 
        ///     tbxAddInventoryIDActual.Text, 
        ///     cbxAddDiscountTypeActual.SelectedIndex,
        ///     tbxAddDiscountPercentageActual.Text, 
        ///     tbxAddDiscountDollarAmountActual.Text, 
        ///     dtpAddStartDateActual.Value.ToString("yyyy-MM-dd"), 
        ///     dtpAddExpirationDateActual.Value.ToString("yyyy-MM-dd"), 
        ///     chbxAddDisabledActual.Checked
        /// );
        /// </code>
        /// </example>
        public static void AddCode(string discountCode, string discountDescription, int discountLevel, string inventoryID, int discountType, string discountPercentage, string discountDollarAmount, string startDate, string expirationDate, bool Disabled)
        {
            try
            {
                //Variables
                string query = "INSERT INTO Discounts (DiscountCode, Description, DiscountLevel, InventoryID, DiscountType, DiscountPercentage, DiscountDollarAmount, StartDate, ExpirationDate, Disabled) VALUES ('" + discountCode + "', '" + discountDescription + "', " + discountLevel + ", @InventoryID, " + discountType + ", @DiscountPercentage, @DiscountDollarAmount, '" + startDate + "', '" + expirationDate + "', @Disabled);";

                var dictionary = new Dictionary<string, object>();

                //Query Edits
                if (string.IsNullOrEmpty(inventoryID))
                {
                    dictionary.Add("@InventoryID", null);
                }
                else
                {
                    dictionary.Add("@InventoryID", Convert.ToInt32(inventoryID));
                }

                if (string.IsNullOrEmpty(discountPercentage))
                {
                    dictionary.Add("@DiscountPercentage", null);
                }
                else
                {
                    //reformatting of percentage
                    if (discountPercentage.Length == 1)
                    {
                        discountPercentage = ".0" + discountPercentage;
                    }
                    else if (discountPercentage.Length == 2)
                    {
                        discountPercentage = "." + discountPercentage;
                    }
                    else if (discountPercentage.Length == 3)
                    {
                        discountPercentage = discountPercentage[0] + "." + discountPercentage[1] + discountPercentage[2];
                    }
                    dictionary.Add("@DiscountPercentage", discountPercentage);
                }

                if (string.IsNullOrEmpty(discountDollarAmount))
                {
                    dictionary.Add("@DiscountDollarAmount", null);
                }
                else
                {
                    dictionary.Add("@DiscountDollarAmount", discountDollarAmount);
                }

                if (Disabled == false)
                {
                    dictionary.Add("@Disabled", 0);
                }
                else
                {
                    dictionary.Add("@Disabled", 1);
                }

                var parameters = new DynamicParameters(dictionary);

                _cntDatabase.Execute(query, parameters);

                //clears and updates observable collection
                Program.discountList.Clear();
                DiscountData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Modifies selected discount.
        /// </summary>
        /// <param name="discountID">Used to determine specific discount code</param>
        /// <param name="discountCode">Holds new user inputted discount code</param>
        /// <param name="discountCodeChanged">Determines if discount code was changed</param>
        /// <param name="Description">Holds new user inputted discount description</param>
        /// <param name="descriptionChanged">Determines if discount description was changed</param>
        /// <param name="discountLevel">Holds new user inputted discount level</param>
        /// <param name="discountLevelChanged">Determines if discount level was changed</param>
        /// <param name="inventoryID">Holds new user inputted inventory link</param>
        /// <param name="inventoryIDChanged">Determines if inventory link was changed</param>
        /// <param name="discountType">Holds new discount type</param>
        /// <param name="discountTypeChanged">Determines if discount type was changed</param>
        /// <param name="discountPercentage">Holds new user inputted discount percentage</param>
        /// <param name="discountPercentageChanged">Determines if discount percentage was changed</param>
        /// <param name="discountDollarAmount">Holds new user inputted discount dollar amount</param>
        /// <param name="discountDollarAmountChanged">Determines if discount dollar amount was changed</param>
        /// <param name="startDate">Holds new user inputted discount start date</param>
        /// <param name="startDateChanged">Determines if discount start date was changed</param>
        /// <param name="startDateNulled">Determines if discount start date is now null</param>
        /// <param name="expirationDate">Holds new user inputted discount expiration date</param>
        /// <param name="expirationDateChanged">Determines if discount expiration date was changed</param>
        /// <param name="Disabled">Holds new user inputted discount disabled factor</param>
        /// <param name="disabledChanged">Determines if discount disable factor was changed</param>
        /// <example>
        /// <code>
        /// clsSQL.ModifyCode(
        ///     chosenCode.discountID,
        ///     tbxEditDiscountCodeActual.Text,
        ///     editDiscountCodeChangedBool,
        ///     tbxEditDescriptionActual.Text,
        ///     editDescriptionChangedBool,
        ///     cbxEditDiscountLevelActual.SelectedIndex,
        ///     editDiscountLevelChangedBool,
        ///     tbxEditInventoryIDActual.Text,
        ///     editInventoryIDChangedBool,
        ///     cbxEditDiscountTypeActual.SelectedIndex,
        ///     editDiscountTypeChangedBool,
        ///     tbxEditDiscountPercentageActual.Text,
        ///     editDiscountPercentageChangedBool,
        ///     tbxEditDiscountDollarAmountActual.Text,
        ///     editDiscountDollarAmountChangedBool,
        ///     dtpEditStartDateActual.Value.ToShortDateString(),
        ///     editStartDateChangedBool,
        ///     editStartDateNulled,
        ///     dtpEditExpirationDateActual.Value.ToShortDateString(),
        ///     editExpirationDateChangedBool,
        ///     chbxEditDisabledActual.Checked,
        ///     editDisabledChangedBool
        /// );
        /// </code>
        /// </example>
        public static void ModifyCode(int discountID, string discountCode, bool discountCodeChanged, string Description, bool descriptionChanged, int discountLevel, bool discountLevelChanged, string inventoryID, bool inventoryIDChanged, int discountType, bool discountTypeChanged, string discountPercentage, bool discountPercentageChanged, string discountDollarAmount, bool discountDollarAmountChanged, string startDate, bool startDateChanged, bool startDateNulled, string expirationDate, bool expirationDateChanged, bool Disabled, bool disabledChanged)
        {
            try
            {
                //Variables
                string query = "UPDATE Discounts SET ";

                //Query Edits
                if (discountCodeChanged)
                {
                    query += "DiscountCode = '" + discountCode + "'";
                    if (descriptionChanged || discountLevelChanged || inventoryIDChanged || discountTypeChanged || discountPercentageChanged || discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                    {
                        query += ", ";
                    }
                }
                if (descriptionChanged)
                {
                    query += "Description = '" + Description + "'";
                    if (discountLevelChanged || inventoryIDChanged || discountTypeChanged || discountPercentageChanged || discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                    {
                        query += ", ";
                    }
                }
                if (discountLevelChanged)
                {
                    query += "DiscountLevel = " + discountLevel;
                    if (inventoryIDChanged || discountTypeChanged || discountPercentageChanged || discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                    {
                        query += ", ";
                    }
                }
                if (inventoryIDChanged)
                {
                    if (discountLevel == 0)
                    {
                        query += "InventoryID = null";
                        if (discountTypeChanged || discountPercentageChanged || discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }
                    else if (discountLevel == 1)
                    {
                        query += "InventoryID = " + Convert.ToInt32(inventoryID);
                        if (discountTypeChanged || discountPercentageChanged || discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }

                }
                if (discountTypeChanged)
                {
                    query += "DiscountType = " + discountType;
                    if (discountPercentageChanged || discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                    {
                        query += ", ";
                    }
                }
                if (discountPercentageChanged)
                {
                    //refactoring of percentage
                    if (discountType == 0)
                    {
                        if (discountPercentage.Length == 1)
                        {
                            discountPercentage = ".0" + discountPercentage;
                        }
                        else if (discountPercentage.Length == 2)
                        {
                            discountPercentage = "." + discountPercentage;
                        }
                        else if (discountPercentage.Length == 3)
                        {
                            discountPercentage = discountPercentage[0] + "." + discountPercentage[1] + discountPercentage[2];
                        }

                        query += "DiscountPercentage = " + Convert.ToDecimal(discountPercentage);
                        if (discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }
                    else if (discountType == 1)
                    {
                        query += "DiscountPercentage = null";
                        if (discountDollarAmountChanged || startDateChanged || expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }

                }
                if (discountDollarAmountChanged)
                {
                    if (discountType == 0)
                    {
                        query += "DiscountDollarAmount = null";
                        if (startDateChanged || expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }
                    else if (discountType == 1)
                    {
                        query += "DiscountDollarAmount = " + Convert.ToDecimal(discountDollarAmount);
                        if (startDateChanged || expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }

                }
                if (startDateChanged)
                {
                    if (startDateNulled == false)
                    {
                        query += "StartDate = CAST('" + startDate + "' as date)";
                        if (expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }
                    else if (startDateNulled)
                    {
                        query += "StartDate = null";
                        if (expirationDateChanged || disabledChanged)
                        {
                            query += ", ";
                        }
                    }
                }
                if (expirationDateChanged)
                {
                    query += "ExpirationDate = CAST('" + expirationDate + "' as date)";
                    if (disabledChanged)
                    {
                        query += ", ";
                    }
                }
                if (disabledChanged)
                {
                    query += "Disabled = " + Disabled;
                }

                query += " WHERE DiscountID = " + discountID;

                _cntDatabase.Execute(query);

                //clears and updates observable collection
                Program.discountList.Clear();
                DiscountData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Removes discount code from SQL Database.
        /// </summary>
        /// <param name="discountID">Used to determine specific discount code</param>
        /// <example>
        /// <code>
        /// clsSQL.RemoveCode(chosenCode.discountID);
        /// </code>
        /// </example>
        public static void RemoveCode(int discountID)
        {
            try
            {
                //Variables
                string query = "UPDATE Discounts SET ";

                query += "Disabled = 1";

                query += " WHERE DiscountID = " + discountID;

                _cntDatabase.Execute(query);

                //clears and updates observable collection
                Program.discountList.Clear();
                DiscountData();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }
    }
}