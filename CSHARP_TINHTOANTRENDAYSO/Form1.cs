namespace CSharp_TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int soBD = Convert.ToInt32(txtBD.Text);
            int soKT = Convert.ToInt32(txtKT.Text);

            int tong = 0;
            int tich = 1;
            int tongsochan = 0;
            int tongsole = 0;

            for (int i = soBD; i <= soKT; i++)
            {


                tong += i;
                tich *= i;

                if (i % 2 == 0)
                {
                    tongsochan += i;
                }
                else
                {
                    tongsole += i;

                }

                txtTong.Text = tong.ToString();
                txtTich.Text = tich.ToString();
                txtTongChan.Text = tongsochan.ToString();
                txtTongLe.Text = tongsole.ToString();

            }
        }
    }
}
