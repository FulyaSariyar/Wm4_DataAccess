using Microsoft.EntityFrameworkCore;
using North_DbFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace North_DbFirst
{
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }
        private NorthwindContext _dbContext = new NorthwindContext();
        private void UrunForm_Load(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }
       private void  ListeyiDoldur()
        {
            lstProducts.DataSource = _dbContext.Products
                .Include(x=>x.Category)
                .Include(x=>x.Supplier)
                .ToList();
            lstProducts.DisplayMember = "ProductName";


            cmbCategory.DataSource = _dbContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";

            cmbSupplier.DataSource = _dbContext.Suppliers.ToList();
            cmbSupplier.DisplayMember = "SupplierName";
        }
        private Product _selectedProduct;
        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems == null) return;
            _selectedProduct = (Product)lstProducts.SelectedItem;

            txtProductName.Text = _selectedProduct.ProductName;
            nUnitPrice.Value= _selectedProduct.UnitPrice.GetValueOrDefault();
            cbDiscontuned.Checked = _selectedProduct.Discontinued;

            cmbCategory.SelectedItem = _selectedProduct.Category;
            cmbSupplier.SelectedItem=_selectedProduct.Supplier;

        }
       
    }
}
