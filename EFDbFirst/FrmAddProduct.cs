using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirst
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }
        NorthwndContext db = new NorthwndContext();
        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            
            List<Category> categories = db.Categories.ToList();

            cmbCategories.DataSource = categories;
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.CategoryId = (int) cmbCategories.SelectedValue;
            product.ProductName = txtName.Text;
            product.UnitsInStock = short.Parse(txtStock.Text);
            product.UnitPrice = decimal.Parse(txtUnitPrice.Text);

            db.Products.Add(product);
            db.SaveChanges();

            MessageBox.Show("Product added succesfully !");
        }

    
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
