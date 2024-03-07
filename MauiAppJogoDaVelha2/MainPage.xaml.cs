namespace MauiAppJogoDaVelha2
{
    public partial class MainPage : ContentPage
    {
        string vez = "O";

        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;

            disparador.IsEnabled = false;

            if(vez == "O") {
                disparador.Text = "O";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "O";
            }

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }
            else if (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns", "O X ganhou", "Fechar");
            }else if(btn10.Text == "X" ^ btn10.Text == "O" && btn11.Text == "X" ^ btn11.Text == "O" && btn12.Text == "X" ^ btn12.Text == "O" && btn20.Text == "X" ^ btn20.Text == "O" && btn21.Text == "X" ^ btn21.Text == "O" && btn22.Text == "X" ^ btn22.Text == "O" && btn30.Text == "X" ^ btn30.Text == "O" && btn31.Text == "X" ^ btn31.Text == "O" && btn32.Text == "X" ^ btn32.Text == "O") {
                DisplayAlert("Vixi", "Deu velha", "Fechar");
            }
            //O

            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
            else if (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns", "O O ganhou", "Fechar");
            }
        }

        
    }

}
