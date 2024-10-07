namespace HDD_OnThi_07_10_Cau2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx_tSize.Items.Add("Ít hơn 20 người");
            cbx_tSize.Items.Add("Nhiều hơn 20 người");
            cbx_tSize.SelectedIndex = 0;
        }
        List<Manager> mnger = new List<Manager>();
        private void btn_them1_Click(object sender, EventArgs e)
        {
            
            double luongthuclanh = Convert.ToDouble(txt_lcBan1.Text);
            if (cbx_tSize.Text == "Nhiều hơn 20 người")
            {
                luongthuclanh = Convert.ToDouble(txt_lcBan1.Text) * 1.2;
            }
            else
            {
                luongthuclanh = Convert.ToDouble(txt_lcBan1.Text) * 1.1;
            }
            Manager mnager = new Manager(txt_ten1.Text, txt_mNV1.Text, txt_cVu1.Text, luongthuclanh, cbx_tSize.Text);
            mnger.Add(mnager);
        }
    }
}
