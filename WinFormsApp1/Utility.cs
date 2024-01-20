using QLBH.Models;

namespace QLBH
{
    public static class Utility
    {
        static public string ImagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\Products\";
        internal static Employee employee;

        static public bool IsOpeningForm(string formname)
        {
            foreach (Form f in Application.OpenForms)
                if (f.Name == formname)
                    return true;
            return false;
        }

        
    }
}
