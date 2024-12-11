namespace SF_KStilesM2
{
    /// <summary>
    /// Class that handles the creation of orders to be used throughout the program.
    /// </summary>
    public class clsOrders
    {
        int orderID,
            personID;

        int? discountID,
            employeeID;

        string ccNum,
            expDate,
            ccv;

        public void SetOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public int GetPersonID()
        {
            return personID;
        }

        public void SetPersonID(int personID)
        {
            this.personID = personID;
        }

        public int? GetEmployeeID()
        {
            return employeeID;
        }

        public void SetEmployeeID(int? employeeID)
        {
            this.employeeID = employeeID;
        }

        public string GetCCNum()
        {
            return ccNum;
        }

        public void SetCCNum(string ccNum)
        {
            this.ccNum = ccNum;
        }

        public string GetExpDate()
        {
            return expDate;
        }

        public void SetExpDate(string expDate)
        {
            this.expDate = expDate;
        }

        public string GetCCV()
        {
            return ccv;
        }

        public void SetCCV(string ccv)
        {
            this.ccv = ccv;
        }

        public clsOrders(int personID, int? employeeID, string ccNum, string expDate, string ccv)
        {
            SetPersonID(personID);
            SetEmployeeID(employeeID);
            SetCCNum(ccNum);
            SetExpDate(expDate);
            SetCCV(ccv);
        }
    }
}
