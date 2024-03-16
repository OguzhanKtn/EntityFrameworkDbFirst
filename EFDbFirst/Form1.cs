using EFDbFirst.Models;

namespace EFDbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtMax.Text);
            int min = Convert.ToInt32(txtMin.Text);

            NorthwndContext context = new NorthwndContext();
            List<Product> products = context.Products.Where(x => x.UnitPrice > min && x.UnitPrice < max).ToList();

            dataGridView1.DataSource = products;
        }
    }
}
