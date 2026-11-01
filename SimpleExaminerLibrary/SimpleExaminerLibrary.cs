namespace SimpleExaminerLibrary
{
    public class SimpleExaminerLibrary
    {
        SimpleExaminerLibrary(string language) 
        {
            switch (language) 
            {
                case "Chinese":
                    Chinese();
                    break;
                default:
                    break;
            }
        }

        void Chinese()
        {

        }
    }
}
