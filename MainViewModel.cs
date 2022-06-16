using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1;

public partial class MainViewModel : ObservableObject {

	public MainViewModel () {

		Terms = "By clicking Agree & Join, you agree to the Moby User Agreement and Privacy Policy.";
	}

	[ObservableProperty]
	public string terms;

	[ObservableProperty]
	private string emailAddress;

	[ObservableProperty]
	private string name;

	[ObservableProperty]
	private string password;

	[ObservableProperty]
	private string passwordConfirmation;
}