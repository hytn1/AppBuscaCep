using AppBuscaCep.Models;
using AppBuscaCep.Services;

namespace AppBuscaCep
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
            try
            {
                Endereco dados_endereco = await DataService.GetEnderecoByCep(txt_cep.Text);

                BindingContext = dados_endereco;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                List<Bairro> arr_bairros = await DataService.GetBairrosByIdCidade(4874);

                //Endereco dados_endereco = await DataService.GetEnderecoByCep(txt_cep.Text);

                //BindingContext = dados_endereco;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }

        }
    }
}
