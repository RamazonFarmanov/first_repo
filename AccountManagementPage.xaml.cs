using Shell_App.Models.ViewModels;

namespace Shell_App;

public partial class AccountManagementPage : ContentPage
{
	private readonly UserRepository _userRepository;
	public UserModelView userMV;
	public AccountManagementPage(UserRepository userRepository)
	{
		InitializeComponent();
		_userRepository = userRepository;
		userMV = new UserModelView(_userRepository);
		BindingContext = userMV;
	}
}