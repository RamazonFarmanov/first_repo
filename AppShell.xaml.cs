namespace Shell_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("user_info_page", typeof(UserInfoPage));
        }
    }
}