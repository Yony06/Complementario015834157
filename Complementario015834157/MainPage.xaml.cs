namespace Complementario015834157
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //Aquí vamos a obtener los números ingresados
            string num1 = NumberEntry1.Text;
            string num2 = NumberEntry2.Text;
            string num3 = NumberEntry3.Text;
            string num4 = NumberEntry4.Text;

            // Aqui vamos a alidar la entrada de los numeros que sean numeros reales o que en algun entry no se haya puesto algun numero
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num2) || string.IsNullOrEmpty(num3) || string.IsNullOrEmpty(num4))
            {
                // al no tener de algun entry nos enviara el mensaje que tenemos que ingresar los cuatros numeros
                ResultLabel.Text = "Por favor, ingrese los cuatro números.";
                return;
            }

            // Sera el encargado de invertir el orden de los números ingresados
            string[] numbers = new string[] { num1, num2, num3, num4 };
            Array.Reverse(numbers);

            //Nos mostrara en un label los resultados de los numeros invertidos
            ResultLabel.Text = $"Números invertidos: {string.Join(", ", numbers)}";
        }
    }
    }


