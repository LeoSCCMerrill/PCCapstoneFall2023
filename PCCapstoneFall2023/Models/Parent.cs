namespace PCCapstoneFall2023.Models
{
    public class Parent
    { 
        public int StudentID { get; set; }
        public int ParentID { get; set; }

        public Parent(int studentID, int parentID)
        {
            StudentID = studentID;
            ParentID = parentID;
        }
    }
}
