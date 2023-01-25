namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_MouseHover(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.OrangeRed;
        }

        private void btnTopla_MouseLeave(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.White;
        }

        private void btnCikart_MouseHover(object sender, EventArgs e)
        {
            btnCikart.BackColor= Color.OrangeRed;
        }

        private void btnCikart_MouseLeave(object sender, EventArgs e)
        {
            btnCikart.BackColor=Color.White;
        }

        private void btnCarp_MouseHover(object sender, EventArgs e)
        {
            btnCarp.BackColor= Color.OrangeRed;
        }

        private void btnCarp_MouseLeave(object sender, EventArgs e)
        {
            btnCarp.BackColor=Color.White;
        }

        private void btnBol_MouseHover(object sender, EventArgs e)
        {
            btnBol.BackColor= Color.OrangeRed;
        }

        private void btnBol_MouseLeave(object sender, EventArgs e)
        {
            btnBol.BackColor = Color.White;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (int.Parse(txtSayi1.Text) + int.Parse(txtSayi2.Text)).ToString();
            lblMesaj.Text = "Ýþleminiz gerçekleþtirildi!";
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (int.Parse(txtSayi1.Text) - int.Parse(txtSayi2.Text)).ToString();
            lblMesaj.Text = "Ýþleminiz gerçekleþtirildi!";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = (int.Parse(txtSayi1.Text) * int.Parse(txtSayi2.Text)).ToString();
            lblMesaj.Text = "Ýþleminiz gerçekleþtirildi!";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(txtSayi2.Text) != 0 || !string.IsNullOrEmpty(txtSayi2.Text))
                {
                    lblSonuc.Text = (int.Parse(txtSayi1.Text) / int.Parse(txtSayi2.Text)).ToString();
                    lblMesaj.Text = "Ýþleminiz gerçekleþtirildi!";
            }
            }
            catch (DivideByZeroException)
            {
                lblMesaj.Text = "Bölen sayý 0 veya boþ olamaz!\nLütfen ikinci sayýyý yeniden giriniz...";
            }
              
        }
    }
}