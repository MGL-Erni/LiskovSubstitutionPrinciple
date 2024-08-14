namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Admin admin = new Admin("totallyNotAHacker5342");
            Employee employee = new Employee("joeSchmoe");
            DoSomething(admin);
            DoSomething(employee);
        }

        public static void DoSomething(User user)
        {
            user.LogIn();
            if (user is IAdmin)
            {
                ((IAdmin)user).AccessAdmin();
            }
            user.LogOut();
        }
    }
}

