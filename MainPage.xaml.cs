namespace Shell_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        public async void ToAutomobilesPage(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//cars_page/automobiles_page");
        }
    }
}