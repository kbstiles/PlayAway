namespace SF_KStilesM2
{
    /// <summary>
    /// Class used to hold category data
    /// </summary>
    public class clsCategory
    {
        //Variables
        public string categoryName { get; }
        public string categoryDescription { get; }

        public int categoryID { get; }

        public clsCategory(
            int categoryID,
            string categoryName,
            string categoryDescription
            )
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.categoryDescription = categoryDescription;
        }
    }
}
