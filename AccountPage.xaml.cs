namespace Shell_App;

public partial class AccountPage : ContentPage
{
	public AccountPage()
	{
        InitializeComponent();
	}
	public void OnEnterButtonClicked(object sender, EventArgs e)
	{
		string authorized_pg = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\r\n             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\r\n             x:Class=\"Shell_App.AccountPage\"\r\n             Title=\"AccountPage\">\r\n    <VerticalStackLayout x:Name=\"accountPage\" Padding=\"20\">\r\n        <Grid HeightRequest=\"400\">\r\n            <Grid.RowDefinitions>\r\n                <RowDefinition Height=\"0.7*\"/>\r\n                <RowDefinition Height=\"0.1*\"/>\r\n                <RowDefinition Height=\"0.1*\"/>\r\n                <RowDefinition Height=\"0.1*\"/>\r\n            </Grid.RowDefinitions>\r\n            <Grid.ColumnDefinitions>\r\n                <ColumnDefinition Width=\"0.5*\"/>\r\n                <ColumnDefinition Width=\"0.5*\"/>\r\n            </Grid.ColumnDefinitions>\r\n            <Image Source=\"account_icon.png\" HorizontalOptions=\"Center\" Grid.Column=\"0\" Grid.ColumnSpan=\"2\"/>\r\n            <Label Text=\"Name:\" HorizontalOptions=\"Center\" Grid.Column=\"0\" Grid.Row=\"1\" FontSize=\"20\"/>\r\n            <Label Text=\"*name*\" HorizontalOptions=\"Center\" Grid.Column=\"1\" Grid.Row=\"1\"/>\r\n            <Label Text=\"Password:\" HorizontalOptions=\"Center\" Grid.Column=\"0\" Grid.Row=\"2\" FontSize=\"20\"/>\r\n            <Label Text=\"*password*\" HorizontalOptions=\"Center\" Grid.Column=\"1\" Grid.Row=\"2\"/>\r\n            <Label Text=\"Status:\" HorizontalOptions=\"Center\" Grid.Column=\"0\" Grid.Row=\"3\" FontSize=\"20\"/>\r\n            <Label Text=\"*status*\" HorizontalOptions=\"Center\" Grid.Column=\"1\" Grid.Row=\"3\"/>\r\n        </Grid>\r\n        <Button Text=\"Exit from Account\" Clicked=\"OnExitButtonClicked\"/>\r\n    </VerticalStackLayout>\r\n</ContentPage>";
		this.LoadFromXaml(authorized_pg);
		
	}
	public void OnExitButtonClicked(object sender, EventArgs e)
	{
		string unauthorized_pg = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\r\n             xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\r\n             x:Class=\"Shell_App.AccountPage\"\r\n             Title=\"AccountPage\">\r\n    <VerticalStackLayout x:Name=\"accountPage\" Padding=\"20\">\r\n        <Grid HeightRequest=\"200\" RowSpacing=\"5\">\r\n            <Grid.ColumnDefinitions>\r\n                <ColumnDefinition Width=\".9*\"/>\r\n                <ColumnDefinition Width=\".1*\"/>\r\n            </Grid.ColumnDefinitions>\r\n            <Grid.RowDefinitions>\r\n                <RowDefinition Height=\"0.25*\"/>\r\n                <RowDefinition Height=\"0.25*\"/>\r\n                <RowDefinition Height=\"0.25*\"/>\r\n                <RowDefinition Height=\"0.25*\"/>\r\n            </Grid.RowDefinitions>\r\n            <Entry x:Name=\"nameEntry\" Placeholder=\"Name\"  Grid.Row=\"0\" Grid.Column=\"0\" Grid.ColumnSpan=\"2\"/>\r\n            <Entry x:Name=\"passEntry\" Placeholder=\"Password\"  Grid.Row=\"1\" Grid.Column=\"0\"/>\r\n            <CheckBox x:Name=\"isAdmin\" Grid.Row=\"1\" Grid.Column=\"1\"/>\r\n            <Button Text=\"Enter\" Grid.Row=\"2\" Grid.Column=\"0\" Grid.ColumnSpan=\"2\" Clicked=\"OnEnterButtonClicked\"/>\r\n            <Button Text=\"Register\" Grid.Row=\"3\" Grid.Column=\"0\" Grid.ColumnSpan=\"2\" Clicked=\"OnRegisterButtonClicked\"/>\r\n        </Grid>\r\n    </VerticalStackLayout>\r\n</ContentPage>";
		this.LoadFromXaml(unauthorized_pg);
    }
	public void OnRegisterButtonClicked(object sender, EventArgs e)
	{

	}
}