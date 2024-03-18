using EFDbFirst.Models;

namespace EFDbFirst
{
    public partial class FrmFilterProduct : Form
    {
        public FrmFilterProduct()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int max = Convert.ToInt32(txtMax.Text);
            int min = Convert.ToInt32(txtMin.Text);

            NorthwndContext context = new NorthwndContext();
            List<Product> products = context.Products.Where(x => x.UnitPrice > min && x.UnitPrice < max).
                OrderBy(x => x.UnitPrice).ToList();

            dataGridView1.DataSource = products;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            NorthwndContext db = new NorthwndContext();
            Product product = db.Products.FirstOrDefault(x => x.ProductId == id);

            if (product != null)
            {
                txtName.Text = product.ProductName;
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtStock.Text = product.UnitsInStock.ToString();
            }
        }

        void LoadSuppliers()
        {
            NorthwndContext db = new NorthwndContext();
            List<Product> products = db.Products.ToList();
            dataGridView1.DataSource = products;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            NorthwndContext db = new NorthwndContext();
            Product product = db.Products.FirstOrDefault(x => x.ProductId == id);


            product.ProductName = txtName.Text;
            product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            if (short.Parse(txtStock.Text) > 0 && short.Parse(txtStock.Text) < 100)
            {
                product.UnitsInStock = short.Parse(txtStock.Text);
                db.SaveChanges();
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Stock amount must between 0 and 100 !");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}
