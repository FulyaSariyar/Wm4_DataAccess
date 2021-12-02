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
            //lstProducts.DisplayMember = "ProductName"; //Partial class sayesinde bunu yazmaya biliyoruz.


            cmbCategory.DataSource = _dbContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";

            cmbSupplier.DataSource = _dbContext.Suppliers.ToList();
            cmbSupplier.DisplayMember = "SupplierName";
        }
       
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
        private Product _selectedProduct;
        private Category _selectedCategory;
        private Supplier _selectedSupplier;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
                _selectedCategory = (Category)cmbCategory.SelectedItem;
            else _selectedCategory = null;
            if (cmbSupplier.SelectedItem != null)
                _selectedSupplier = null;

            var yeni = new Product()
            {
                UnitPrice = nUnitPrice.Value,
                ProductName = txtProductName.Text,
                Discontinued = cbDiscontuned.Checked,
                CategoryId = _selectedCategory == null ? null : _selectedCategory.CategoryId,
                SupplierId = _selectedSupplier?.SupplierId //ustekinin kisayol yazim sekli.
            };

            try
            {
                _dbContext.Products.Add(yeni);
                _dbContext.SaveChanges();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
                _dbContext = new NorthwindContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (cmbCategory.SelectedItem != null)
            //    _selectedCategory = (Category)cmbCategory.SelectedItem;
            //else _selectedCategory = null;
            //if (cmbSupplier.SelectedItem != null)
            //    _selectedSupplier = null;
            //try
            //{
            //    var product = _dbContext.Products.Find(_selectedProduct.ProductId);
            //    _dbContext.Products.Remove(product);

            //    _dbContext.SaveChanges();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    _dbContext = new NorthwindContext();
            //}
            //finally
            //{
            //    ListeyiDoldur();
            //} //ORDER DETAILS KONTROLU KULLANILMADAN.
            var product = _dbContext.Products
                .Include(x => x.OrderDetails)
                .FirstOrDefault(x=>x.ProductId==_selectedProduct.ProductId);


            if (product == null) return;
            if (product.OrderDetails.Count > 0)
            {
                MessageBox.Show($"{product.ProductName} isimli ürün siparişlerde kullanıldığından silemezsiniz!");
                    return;
            }
            var dialogResult = MessageBox.Show($"{product.ProductName} isimli ürünü silmek istiyor musunuz?", "Ürün silme",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    _dbContext.Products.Remove(product);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _dbContext= new NorthwindContext();
                    
                }
                finally
                {
                    ListeyiDoldur();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_selectedProduct == null) return;

            if (cmbCategory.SelectedItem != null)
                _selectedCategory = (Category)cmbCategory.SelectedItem;
            else
                _selectedCategory = null;
            if (cmbSupplier.SelectedItem != null)
                _selectedSupplier = cmbSupplier.SelectedItem as Supplier;
            else
                _selectedSupplier = null;

            try
            {
                var product = _dbContext.Products.First(x => x.ProductId == _selectedProduct.ProductId); //Find Id ile calisir.
                product.ProductName = txtProductName.Text;
                product.UnitPrice = nUnitPrice.Value;
                product.Discontinued = cbDiscontuned.Checked;
                product.SupplierId = _selectedSupplier?.SupplierId;
                product.CategoryId = _selectedCategory?.CategoryId;

                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                _dbContext = new NorthwindContext();
            }
            finally
            {
                ListeyiDoldur();
            }
        }
    }
}
