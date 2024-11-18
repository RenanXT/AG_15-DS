using static AG_15_DS.Class1;

namespace AG_15_DS
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Class1.cadastro dados = new Class1.cadastro
            {
                DESCRICAO = ent_descricao.Text,
                INICIO = dtpk_inicio.Date,
                FINAL = dtpk_fim.Date,
                QUANTIDADE = (int)stp_participantes.Value,
                LOCALIZACAO = ent_localizacao.Text

            };
            await Navigation.PushAsync(new ValorTotal()
            { BindingContext = dados });
        }
    }

}
