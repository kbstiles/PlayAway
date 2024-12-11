using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to validate actions done before committing to SQL Database.
    /// </summary>
    internal class clsValidation
    {
        //Variables
        public static string message = "";

        /// <summary>
        /// Determines if first and last name meet criteria.
        /// </summary>
        /// <param name="firstName">Holds user inputted first name</param>
        /// <param name="lastName">Holds user inputted last name</param>
        /// <returns>Returns true if first and last name are not null or empty, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateName(tbxFirstName, tbxLastName)
        /// </code>
        /// </example>
        public static bool ValidateName(TextBox firstName, TextBox lastName)
        {
            //Variables
            bool isValid = false;

            if (!string.IsNullOrEmpty(firstName.Text) && !string.IsNullOrEmpty(lastName.Text))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if address meets criteria.
        /// </summary>
        /// <param name="address">Holds user inputted address</param>
        /// <returns>Returns true if address is not null or empty and each line is less than 30 characters, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateAddress(tbxAddress.Text)
        /// </code>
        /// </example>
        public static bool ValidateAddress(string address)
        {
            //Variables
            bool isValid = false;

            if (!string.IsNullOrEmpty(address.Trim()))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            //if address contains multiple lines
            if (address.Contains('\n'))
            {
                //for each line in address
                foreach (string shipAddress in address.Split('\n'))
                {
                    //if line has greater length than 30 or is null or empty
                    if (shipAddress.Length > 30 || string.IsNullOrEmpty(shipAddress))
                    {
                        isValid = false;                        
                    }
                }
            }

            return isValid;
        }

        /// <summary>
        /// Determines if city meets criteria.
        /// </summary>
        /// <param name="city">Holds user inputted city</param>
        /// <returns>Returns true if city is not null or empty and doesn't have a digit in it, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCity(tbxCity.Text)
        /// </code>
        /// </example>
        public static bool ValidateCity(string city)
        {
            //Variables
            bool isValid = false;

            //if city is not null or empty and doesn't have a number in it
            if (!string.IsNullOrEmpty(city) && !city.Any(char.IsDigit))
            {
                isValid = true;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if zipcode meets criteria.
        /// </summary>
        /// <param name="zipCode">Holds user inputted zipcode</param>
        /// <returns>Returns true if zipcode is 12345 or 12345-1234 formaat, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateZip(tbxZipCode.Text)
        /// </code>
        /// </example>
        public static bool ValidateZip(string zipCode)
        {
            //Variables
            bool isValid = false;

            //if zipcode is 12345 or 12345-1234 format
            if (Regex.IsMatch(zipCode, @"^[0-9]{5}(?:-[0-9]{4})?$"))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if state meets criteria.
        /// </summary>
        /// <param name="state">Holds user inputted state</param>
        /// <returns>Returns true if state is 2 characters in length and only letters, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateState(tbxState.Text)
        /// </code>
        /// </example>
        public static bool ValidateState(string state)
        {
            //Variables
            bool isValid = false;

            //if state is 2 characters in length and both characters are letters
            if (state.Length == 2 && state.Any(char.IsLetter))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if email meets criteria.
        /// </summary>
        /// <param name="email">Holds user inputted email</param>
        /// <returns>Returns true if email is not null or empty, greater than 7 characters but less than 41 characters, has at least 2 characters before and after each dot and @, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateEmail(tbxEmail.Text)
        /// </code>
        /// </example>
        public static bool ValidateEmail(string email)
        {
            //Variables
            bool isValid = false;

            //if email is not null or empty, greater than 7 characters but less than 41 characters, has at least 2 characters before and after each dot and @
            if (!string.IsNullOrEmpty(email) && email.Length > 7 && email.Length < 41 && Regex.IsMatch(email, @"^[A-Za-z0-9]{2,}(?:\.[A-Za-z0-9]{2,}||_[A-Za-z0-9]{2,})?@[A-Za-z]{2,}\.[A-Za-z]{2,}(?:\.[A-Za-z]{2,})*?$"))
            {
                isValid = true;
            }
            else if (string.IsNullOrEmpty(email))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if phone number meets criteria.
        /// </summary>
        /// <param name="phone">Holds user inputted phone number</param>
        /// <returns>Returns true if phone number is null or empty OR is in 1234567890 format, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidatePhone(tbxPhonePrimary.Text)
        /// </code>
        /// </example>
        public static bool ValidatePhone(string phone)
        {
            //Variables
            bool isValid = false;

            //if phone number is null or empty OR is in 1234567890 format
            if (string.IsNullOrEmpty(phone) || Regex.IsMatch(phone, @"^[0-9]{10}$"))
            {
                isValid = true;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if username meets criteria.
        /// </summary>
        /// <param name="username">Holds user inputted username</param>
        /// <returns>Returns true if username is greater than 7 characters, less than 21 characters, doesn't contain spaces, starts with a letter, overall only has letters and numbers and isn't already in the SQL Database, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateUser(tbxCreateUsername.Text)
        /// </code>
        /// </example>
        public static bool ValidateUser(string username)
        {
            //Variables
            string[] tables = { "Logon" },
                keys = { };
            bool isValid = false;

            clsSQL.DatabaseCommand(tables, false, keys);

            //Holds found username
            DataRow[] foundUser = clsSQL.DTFormTable.Select("LogonName = '" + username.ToUpper() + "'");

            //if username is greater than 7 characters, less than 21 characters, doesn't contain spaces, starts with a letter, overall only has letters and numbers and isn't already in the SQL Database
            if (username.Length > 7 && username.Length < 21 && !username.Contains<char>(' ') && Regex.IsMatch(username, @"^[a-zA-Z][a-zA-Z0-9]*$") && foundUser.Length == 0)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if password meets criteria.
        /// </summary>
        /// <param name="password">Holds user inputted password</param>
        /// <returns>Returns true if password length is greater than 7 characters but less than 21 characters, has at least 3 of the following, an uppercase character, lowercase character, digit, or special character, and doesn't contain any invalid characters, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidatePassword(tbxCreatePassword.Text)
        /// </code>
        /// </example>
        public static bool ValidatePassword(string password)
        {
            //Variables
            bool isValid = false,
                atLeast3 = false,
                hasLength = false,
                hasSpace = false;

            int count = 0;

            string characters = "()!@#$%^&*";

            //determines if password length is valid
            if (password.Length > 7 && password.Length < 21)
            {
                hasLength = true;
            }
            else
            {
                hasLength = false;
            }

            //determines if password has an uppercase character, lowercase character and/or digit
            if (password.Any(char.IsUpper))
            {
                count++;
            }
            if (password.Any(char.IsLower))
            {
                count++;
            }
            if (password.Any(char.IsDigit))
            {
                count++;
            }

            //determines if password has any special characters
            foreach (char character in characters)
            {
                if (password.Contains(character))
                {
                    count++;
                    break;
                }
            }

            //determines if password meets at least 3 creativity criteria
            if (count >= 3)
            {
                atLeast3 = true;
            }
            else
            {
                atLeast3 = false;
            }

            //determines if password contains invalid characters
            if (password.Contains<char>(' ') 
                || password.Contains<char>('=') 
                || password.Contains<char>('+') 
                || password.Contains<char>('\''))
            {
                hasSpace = true;
            }
            else
            {
                hasSpace = false;
            }

            //determines if password meets all validation criteria
            if (hasLength && atLeast3 && hasSpace == false)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;

        }

        /// <summary>
        /// Determines if users security questions selections meet criteria.
        /// </summary>
        /// <param name="firstQuestion">Used to determine users first security question selection</param>
        /// <param name="secondQuestion">Used to determine users second security question selection</param>
        /// <param name="thirdQuestion">Used to determine user third security question selection</param>
        /// <returns>Returns true if users selected a question for each ComboBox and none of the questions are the same, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateQuestions(cbxFirstChallengeQuestion, cbxSecondChallengeQuestion, cbxThirdChallengeQuestion)
        /// </code>
        /// </example>
        public static bool ValidateQuestions(ComboBox firstQuestion, ComboBox secondQuestion, ComboBox thirdQuestion)
        {
            //Variables
            bool isValid = false;

            //determines if each ComboBox has a selected question
            if (firstQuestion.SelectedIndex > -1 && secondQuestion.SelectedIndex > -1 && thirdQuestion.SelectedIndex > -1)
            {
                //makes sure that none of the selected questions are the same
                if (firstQuestion.SelectedIndex != secondQuestion.SelectedIndex 
                    && firstQuestion.SelectedIndex != thirdQuestion.SelectedIndex
                    && secondQuestion.SelectedIndex != firstQuestion.SelectedIndex
                    && secondQuestion.SelectedIndex != thirdQuestion.SelectedIndex
                    && thirdQuestion.SelectedIndex != firstQuestion.SelectedIndex
                    && thirdQuestion.SelectedIndex != secondQuestion.SelectedIndex)
                {
                    isValid = true;
                }
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if users security answers meet criteria.
        /// </summary>
        /// <param name="firstAnswer">Holds users first security answer</param>
        /// <param name="secondAnswer">Holds users second security answer</param>
        /// <param name="thirdAnswer">Holds users third security answer</param>
        /// <returns>Returns true if users security answers are not null or empty and only contain a letter or digit, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateAnswers(tbxFirstChallengeAnswer.Text, tbxSecondChallengeAnswer.Text, tbxThirdChallengeAnswer.Text)
        /// </code>
        /// </example>
        public static bool ValidateAnswers(string firstAnswer, string secondAnswer, string thirdAnswer)
        {
            //Variables
            bool isValid = false;

            //Makes sure that all security questions are not null or empty and contain a letter or number
            if (!string.IsNullOrEmpty(firstAnswer) 
                && !string.IsNullOrEmpty(secondAnswer) 
                && !string.IsNullOrEmpty(thirdAnswer)
                && Regex.IsMatch(firstAnswer, @"^[a-zA-Z0-9]+$") 
                && Regex.IsMatch(secondAnswer, @"^[a-zA-Z0-9]+$")
                && Regex.IsMatch(thirdAnswer, @"^[a-zA-Z0-9]+$"))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if username exists in SQL Database.
        /// </summary>
        /// <param name="username">Holds user inputted username</param>
        /// <returns>Returns true if username exists else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateResetUser(tbxUsername)
        /// </code>
        /// </example>
        public static bool ValidateResetUser(TextBox username)
        {
            //Variables
            bool valid = false;
            string[] tables = { "Logon" },
            keys = { };

            clsSQL.DatabaseCommand(tables, false, keys);

            //Holds found user info
            DataRow[] foundUser = clsSQL.DTFormTable.Select("LogonName = '" + username.Text.ToUpper() + "'");
            
            //makes sure username exists
            if (foundUser.Length != 0)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }

            return valid;
        }

        /// <summary>
        /// Determines if users security answers match the Database security answers.
        /// </summary>
        /// <param name="username">Used to specify account</param>
        /// <param name="firstAnswer">Holds the user inputted first security answer</param>
        /// <param name="secondAnswer">Holds the user inputted second security answer</param>
        /// <param name="thirdAnswer">holds the user inputted third security answer</param>
        /// <returns>Returns true if users answers is the same as database answers, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateResetAnswer(tbxUsername, tbxFirstChallengeAnswer, tbxSecondChallengeAnswer, tbxThirdChallengeAnswer)
        /// </code>
        /// </example>
        public static bool ValidateResetAnswer(TextBox username, TextBox firstAnswer, TextBox secondAnswer, TextBox thirdAnswer)
        {
            //Variables
            bool valid = false;

            List<string> answers = new List<string>();

            //Gets accounts answers from Database
            clsSQL.GetAnswers(username.Text, answers);

            //Compares answers given to Database answers
            if (answers[0].ToString().Equals(firstAnswer.Text.ToUpper()) && answers[1].ToString().Equals(secondAnswer.Text.ToUpper()) && answers[2].ToString().Equals(thirdAnswer.Text.ToUpper()))
            {
                valid = true;
            }

            return valid;
        }

        /// <summary>
        /// Determines if users new password and new password confirmation match.
        /// </summary>
        /// <param name="password">Holds user inputted password</param>
        /// <param name="verify">Holds user inputted password confirmation</param>
        /// <returns>Returns true if users password and password confirmation match, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateMatch(tbxResetPassword.Text, tbxMatchPassword.Text)
        /// </code>
        /// </example>
        public static bool ValidateMatch(string password, string verify)
        {
            //Variables
            bool isValid = false;

            //Determines if new password and password confirmation match
            if (password.Equals(verify))
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if given string is empty.
        /// </summary>
        /// <param name="text">Holds user inputted string</param>
        /// <returns>Returns null if string is empty, else returns string</returns>
        /// <example>
        /// <code>
        /// clsValidation.CheckEmpty(tbxTitle.Text)
        /// </code>
        /// </example>
        public static string CheckEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                text = "null";
            }
            return text;
        }

        /// <summary>
        /// Determines if userQuantity is a valid amount compared to quantityOnHand.
        /// </summary>
        /// <param name="userQuantity">Holds user inputted quantity</param>
        /// <param name="quantityOnHand">Holds database quantity</param>
        /// <returns>Returns true if userQuantity is a valid amount compared to quantityOnHand, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidQuantity(itemQuantity, Convert.ToInt32(row.Field&lt;Int64&gt;("Quantity")))
        /// </code>
        /// </example>
        public static bool ValidQuantity(int userQuantity, int quantityOnHand)
        {
            //Variables
            bool validQuantity;

            if (userQuantity > quantityOnHand)
            {
                validQuantity = false;
            }
            else
            {
                validQuantity = true;
            }

            return validQuantity;
        }

        /// <summary>
        /// Determines if users new item quantity is valid.
        /// </summary>
        /// <param name="userQuantity">Holds users new item quantity</param>
        /// <returns>Returns true if users new item quantity is not null or empty and is greater than 0, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidNewQuantity(cbxQuantity.Text)
        /// </code>
        /// </example>
        public static bool ValidNewQuantity(string userQuantity)
        {
            //Variables
            bool validQuantity;

            //Makes sure user quantity inputted is not null or empty and is greater than 0
            if (string.IsNullOrEmpty(userQuantity) || Convert.ToInt32(userQuantity) < 1)
            {
                validQuantity = false;
            }
            else
            {
                validQuantity = true;
            }

            return validQuantity;
        }

        /// <summary>
        /// Determines if discount code given is valid and updates calculation data.
        /// </summary>
        /// <param name="discountCode">Holds user inputted discount code</param>
        /// <returns>Returns true if discount exists and isn't expired or disabled, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidDiscountCode(tbxDiscountCodeActual.Text)
        /// </code>
        /// </example>
        public static bool ValidDiscountCode(string discountCode)
        {
            //Variables
            DateTime today = DateTime.Today;
            string expDate;
            bool isValid = false,
                isCode = false;


            clsOrderDetails usedOrderDetail = null;

            //runs through discount list
            for (int i = 0; i < Program.discountList.Count; i++)
            {
                expDate = Program.discountList[i].expirationDate;
                //checks if discount is expired
                if (discountCode.Equals(Program.discountList[i].discountCode) && String.Compare(expDate, today.ToString("yyyy-MM-dd")) == 1)
                {
                    //checks if discount is disabled
                    if (Program.discountList[i].Disabled != true)
                    {
                        isCode = true;
                        frmCart.usedDiscount = Program.discountList[i];
                        break;
                    }
                }

            }

            //checks if discount code is valid and updates calculations
            if (isCode)
            {
                if (frmCart.usedDiscount.discountLevel == 0)
                {
                    if (frmCart.usedDiscount.inventoryID == null)
                    {
                        if (frmCart.usedDiscount.discountType == 0)
                        {
                            frmCart.cal.SetDiscountPercentage(frmCart.usedDiscount.discountPercentage);
                        }
                        else if (frmCart.usedDiscount.discountType == 1)
                        {
                            frmCart.cal.SetDiscountDollarAmount(frmCart.usedDiscount.discountDollarAmount);
                        }
                        isValid = true;
                    }
                }
                else if (frmCart.usedDiscount.discountLevel == 1)
                {
                    if (frmCart.usedDiscount.inventoryID != null)
                    {
                        foreach (clsOrderDetails orderDetail in frmShop.orderDetailsList)
                        {
                            if (orderDetail.GetInventoryID() == frmCart.usedDiscount.inventoryID)
                            {
                                usedOrderDetail = orderDetail;
                                break;
                            }
                        }
                        if (frmCart.usedDiscount.discountType == 0)
                        {
                            usedOrderDetail.SetUpdatedPrice(usedOrderDetail.GetOriginalPrice() * Convert.ToDecimal(frmCart.usedDiscount.discountPercentage));
                        }
                        else if (frmCart.usedDiscount.discountType == 1)
                        {
                            usedOrderDetail.SetUpdatedPrice(usedOrderDetail.GetOriginalPrice() - Convert.ToDecimal(frmCart.usedDiscount.discountDollarAmount));
                        }

                        usedOrderDetail.SetDiscountID(frmCart.usedDiscount.discountID);
                        if (usedOrderDetail.GetUpdatedPrice() < 0)
                        {
                            usedOrderDetail.SetUpdatedPrice(0);
                        }
                        isValid = true;
                    }
                }
            }
            return isValid;
        }

        /// <summary>
        /// Determines if ccNum meets criteria.
        /// </summary>
        /// <param name="ccNum">Holds the user inputted credit card number</param>
        /// <returns>Returns true if the credit card number is not null or empty and is 16 digits in length, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCCNum(tbxCCNum.Text)
        /// </code>
        /// </example>
        public static bool ValidateCCNum(string ccNum)
        {
            //Variables
            bool isValid = false;

            //checks if credit card number is not null or empty and is 16 digits in length
            if (!string.IsNullOrEmpty(ccNum) && Regex.IsMatch(ccNum, @"^[0-9]{16}$"))
            {
                isValid = true;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if CCV meets criteria.
        /// </summary>
        /// <param name="ccv">Holds user inputted CCV</param>
        /// <returns>Returns true if CCV is not null or empty and is 3 digits in length</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCCV(tbxCCV.Text
        /// </code>
        /// </example>
        public static bool ValidateCCV(string ccv)
        {
            //Variable
            bool isValid = false;

            //checks if CCV is not null or empty and is 3 digits in length
            if (!string.IsNullOrEmpty(ccv) && Regex.IsMatch(ccv, @"^[0-9]{3}$"))
            {
                isValid = true;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if credit card expiration date meets criteria.
        /// </summary>
        /// <param name="expDate">Holds user inputted expiration date</param>
        /// <returns>Returns true if expiration date is not null or empty, is in MM/yy or MM/yyyy format and expiration date is greater than current date, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateExpDate(tbxExpiration.Text)
        /// </code>
        /// </example>
        public static bool ValidateExpDate(string expDate)
        {
            //Variables
            bool isValid = false;

            DateTime currentDate = DateTime.Today;
            DateTime expirationDate;

            try
            {
                string[] dateSec = expDate.Split('/');

                if (expDate.Length == 5)
                {
                    dateSec[1] = "20" + dateSec[1];
                }

                expirationDate = new DateTime(Int32.Parse(dateSec[1]), Int32.Parse(dateSec[0]), 1);

                //checks that expDate is not null or empty, is in MM/yy or MM/yyyy format and expiration date is greather than current date
                if (!string.IsNullOrEmpty(expDate) && Regex.IsMatch(expDate, @"^[0-9]{2}/[0-9]{2}(?:[0-9]{2})?$") && ((expirationDate.Year == currentDate.Year && expirationDate.Month > currentDate.Month) || expirationDate.Year > currentDate.Year))
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if inventory item name meets criteria.
        /// </summary>
        /// <param name="itemName">Holds user inputted inventory item name</param>
        /// <returns>Returns true if item name is not null or empty and is less than or equal to 100, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateItemName(tbxAddItemNameActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateItemName(string itemName)
        {
            //Variables
            bool isValid = false;

            try
            {
                if (!string.IsNullOrEmpty(itemName) && itemName.Length <= 100)
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if item description meets criteria.
        /// </summary>
        /// <param name="itemDescription">Holds the user inputted item description</param>
        /// <returns>Returns true if item description is not null or empty and is less than or equal to 100000 characters, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateItemDescription(tbxAddItemDescriptionActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateItemDescription(string itemDescription)
        {
            //Variables
            bool isValid = false;

            try
            {
                if (!string.IsNullOrEmpty(itemDescription) && itemDescription.Length <= 100000)
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if item retail price meets criteria.
        /// </summary>
        /// <param name="retailPrice">Holds user inputted retail price</param>
        /// <returns>Returns true if retail price is not null or empty, is in standard US currency format and is less than or equal to 10 characters, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateItemRetailPrice(tbxAddRetailPriceActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateItemRetailPrice(string retailPrice)
        {
            //Variables
            bool isValid = false;

            try
            {
                //checks that retailPrice is not null or empty, is in regular US currency format and is less than or equal to 10 characters
                if (!string.IsNullOrEmpty(retailPrice) && Regex.IsMatch(retailPrice, @"^[0-9]+\.[0-9]{2}$") && retailPrice.Length <= 10)
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if item quantity meets criteria.
        /// </summary>
        /// <param name="quantity">Holds user inputted quantity</param>
        /// <returns>Returns true if item quantity is not null or empty and is only digits, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateItemQuantity(tbxAddQuantityActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateItemQuantity(string quantity)
        {
            //Variables
            bool isValid = false;

            try
            {
                //checks that string is not null or empty and only contains digits
                if (!string.IsNullOrEmpty(quantity) && Regex.IsMatch(quantity, @"^[0-9]+$"))
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if item restock threshold meets criteria.
        /// </summary>
        /// <param name="restockThreshold">Holds user inputted restock threshold</param>
        /// <returns>Returns true if restock threshold is not null or empty and is only digits, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateItemRestockThreshold(tbxAddRestockThresholdActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateItemRestockThreshold(string restockThreshold)
        {
            //Variables
            bool isValid = false;

            try
            {
                //checks that restockThreshold is not null or empty and only contains digits
                if (!string.IsNullOrEmpty(restockThreshold) && Regex.IsMatch(restockThreshold, @"^[0-9]+$"))
                {
                    isValid = true;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if image meets criteria.
        /// </summary>
        /// <param name="imgPath">Holds user inputted image path</param>
        /// <returns>Returns true if image path is able to be converted to binary, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateImage(fileName)
        /// </code>
        /// </example>
        public static bool ValidateImage(string imgPath)
        {
            //Variables
            bool isValid = true;

            try
            {
                //tries to convert image to binary to make sure image is valid
                clsImage.ImageToByteArray(imgPath);
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if discount code meets critera.
        /// </summary>
        /// <param name="discountCode">Holds user inputted discount code</param>
        /// <returns>Returns true if discount code is not null or empty and length is less than or equal to 20 characters, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCodesDiscountCode(tbxAddDiscountCodeActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateCodesDiscountCode(string discountCode)
        {
            //Variables
            bool isValid;

            try
            {
                if (!string.IsNullOrEmpty(discountCode) && discountCode.Length <= 20)
                {
                    isValid = true;
                }
                else 
                { 
                    isValid = false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if discount code description meets criteria.
        /// </summary>
        /// <param name="description">Holds user inputted discount code description</param>
        /// <returns>Returns true if discount code description is not null or empty and is less than or equal to 50 characters in length, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCodesDescription(tbxAddDescriptionActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateCodesDescription(string description)
        {
            //Variables
            bool isValid;

            try
            {
                if (!string.IsNullOrEmpty(description) && description.Length <= 50)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if inventoryID exists to link to discount code.
        /// </summary>
        /// <param name="inventoryID">Holds user inputted inventoryID</param>
        /// <returns>Returns true if inventoryID is not null or empty and exists in the database</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCodesInventoryID(tbxAddInventoryIDActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateCodesInventoryID(string inventoryID)
        {
            //Variables
            bool isValid,
                validID = false;

            DataRow row;

            try
            {
                for (int i = 0; i < clsSQL.DTInventoryTable.Rows.Count; i++)
                {
                    row = clsSQL.DTInventoryTable.Rows[i];
                    if (Convert.ToInt32(inventoryID) == row.Field<int>("InventoryID"))
                    {
                        validID = true;
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(inventoryID) && validID)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if discount code percentage meets criteria.
        /// </summary>
        /// <param name="discountPercentage">Holds user inputted discount code percentage</param>
        /// <returns>Returns true if discount code percentage is not null or empty and length is less than or equal to 3 digits and number is less than or equal to 100, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCodesDiscountPercentage(tbxAddDiscountPercentageActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateCodesDiscountPercentage(string discountPercentage)
        {
            //Variables
            bool isValid;

            try
            {
                //makes sure discountPercentage is not null or empty, has a length of 3 characters or less, only contains digits and is less than or equal to 100
                if (!string.IsNullOrEmpty(discountPercentage) && discountPercentage.Length <= 3 && Regex.IsMatch(discountPercentage, @"^[0-9]{1,3}$") && (Convert.ToInt32(discountPercentage) <= 100))
                {
                    isValid = true;
                }
                else 
                { 
                    isValid = false; 
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if discount code dollar amount meets criteria.
        /// </summary>
        /// <param name="discountDollarAmount">Holds user inputted discount code dollar amount</param>
        /// <returns>Returns true if discount code dollar amount is not null or empty and length is less than or equal to 11 digits and is in US currency format, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCodesDiscountDollarAmount(tbxAddDiscountDollarAmountActual.Text)
        /// </code>
        /// </example>
        public static bool ValidateCodesDiscountDollarAmount(string discountDollarAmount)
        {
            //Variables
            bool isValid;

            try
            {
                //makes sure discountDollarAmount is not null or empty, length is less than or equal to 11 and is in standard US curreny format
                if (!string.IsNullOrEmpty(discountDollarAmount) && discountDollarAmount.Length <= 11 && Regex.IsMatch(discountDollarAmount, @"^[0-9]+\.[0-9]{2}$"))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Determines if discount code expiration date meets criteria
        /// </summary>
        /// <param name="strtDate">Holds user inputted start date</param>
        /// <param name="expDate">Holds user inputted expirationd date</param>
        /// <returns>Returns true if expiration date is greater than both current date and start date, else returns false</returns>
        /// <example>
        /// <code>
        /// clsValidation.ValidateCodesExpirationDate(dtpAddStartDateActual.Value.ToShortDateString(), dtpAddExpirationDateActual.Value.ToShortDateString())
        /// </code>
        /// </example>
        public static bool ValidateCodesExpirationDate(string strtDate, string expDate)
        {
            //Variables
            DateTime currentDate = DateTime.Today;
            DateTime expirationDate;
            DateTime startDate;

            bool isValid;

            try
            {
                //puts dates in yyyy/MM/DD format
                string[] startDateSec = strtDate.Split('/');

                startDate = new DateTime(Int32.Parse(startDateSec[2]), Int32.Parse(startDateSec[0]), Int32.Parse(startDateSec[1]));

                string[] expDateSec = expDate.Split('/');

                expirationDate = new DateTime(Int32.Parse(expDateSec[2]), Int32.Parse(expDateSec[0]), Int32.Parse(expDateSec[1]));

                if (expirationDate > currentDate && expirationDate > startDate)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}