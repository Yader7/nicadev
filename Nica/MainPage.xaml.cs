namespace Nica
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        

       

        private void Boards_Clicked(object sender, EventArgs e)
        {

        }

        private async void Create_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new create());
        }
    }
}