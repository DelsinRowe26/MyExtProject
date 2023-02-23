namespace MyExtProject;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void BtnOne_Click(object sender, EventArgs e)
	{
		imgWall.Source = "serdce.png";
		lbTxt.Text = "You are beautiful!!!";
	}

	private void BtnTwo_Clicked(object sender, EventArgs e)
	{
		imgWall.Source = "txt.png";
		lbTxt.Text = "Text";
	}

	private void BtnThree_Clicked(object sender, EventArgs e)
	{
		imgWall.Source = "logo.png";
		lbTxt.Text = "Logo";
	}
}

