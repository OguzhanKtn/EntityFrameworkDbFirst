using EFDbFirst.Models;
using EFDbFirst.Services;
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
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        SupplierService supplierService = new SupplierService();
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = supplierService.GetSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                supplierService.DeleteSupplier(supplierId);

                MessageBox.Show("Supplier deleted successfully !");
                dataGridView1.DataSource = supplierService.GetSuppliers();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            supplier.CompanyName = txtCompanyName.Text;
            supplier.City = txtCity.Text;
            supplierService.UpdateSupplier(supplier);
            dataGridView1.DataSource = supplierService.GetSuppliers();  
        }

        Supplier supplier;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            NorthwndContext context = new NorthwndContext();

            supplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == id);

            if (supplier != null)
            {
                txtCompanyName.Text = supplier.CompanyName;
                txtCity.Text = supplier.City;
            }
        }
    }
}
