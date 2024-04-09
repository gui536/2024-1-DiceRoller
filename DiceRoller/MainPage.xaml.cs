namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void RollDiceButton_Clicked(object sender, EventArgs e)
        {
            //Pegar o número que o usuário selecionou
            int selectedSides = Convert.ToInt32(SidesPicker.SelectedItem);

            //Usar esse número como "limitador do método Random"
            //Sortear um número utilizando o método Random
            //Poderia ser assim também
            /*  Random random = new Random();
                int drawnNumber = random.Next(1, selectedSides + 1);            */

            int drawnNumber = new Random().Next(1, selectedSides + 1);
            //Pegar esse resultado e exibir na Label
            ResultLabel.Text = drawnNumber.ToString();
        }
    }

}
