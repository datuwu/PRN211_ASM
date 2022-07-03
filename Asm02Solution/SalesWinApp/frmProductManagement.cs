using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProductManagement : Form
    {
        public bool isAdmin { get; set; } //check if admin
        ProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var members = productRepository.GetProductList();
            List<Product> mem = new List<Product>();

            try
            {
                foreach (var i in members)
                {
                    //The BindingSource omponent is designed to simplify
                    //the process of binding controls to an underlying data source
                    if (cboSearchBy.Items.Contains("id") && i.ProductName.Contains(txtInput.Text))
                    {
                        mem.Add(i);
                    }
                    else if (cboSearchBy.Items.Contains("name") && i.ProductId.ToString().Equals(txtInput.Text))
                    {
                        mem.Add(i);
                    }
                }
                source = new BindingSource();

                source.DataSource = mem;

                txtProductId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitslnStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");


                dgvProduct.DataSource = null;
                dgvProduct.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail frm = new frmProductDetail
            {
                Text = "Add product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member inserted
                source.Position = source.Count - 1;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetProduct();
                productRepository.Remove(member.ProductId);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }
        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                txtCategoryId.Enabled = false;
                txtProductId.Enabled = false;
                txtProductName.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtUnitsInStock.Enabled = false;
                txtWeight.Enabled = false;

                dgvProduct.CellDoubleClick += null;
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frm = new frmProductDetail
            {
                Text = "Update",
                InsertOrUpdate = true,
                Product = GetProduct(),
                ProductRepository = productRepository
            };
            if (frm.ShowDialog()== DialogResult.OK)
            {
                LoadMemberList();
            }

        }

        private void LoadMemberList()
        {
            var mem = productRepository.GetProductList();
            try
            {
                source = new BindingSource();
                source.DataSource = mem.OrderByDescending(member => member.ProductName);
                txtProductId.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategoryId.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtProductId.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategoryId.DataBindings.Add("Text", source, "CategoryId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitslnStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = source;
                if (isAdmin == false)
                {
                    if (mem.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List");
            }
        }

        private void ClearText()
        {
            txtProductId.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtCategoryId.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtWeight.Text = string.Empty;
        }

        private Product GetProduct()
        {
            Product p;
            try
            {
                p = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryId.Text),
                    UnitPrice = int.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    Weight = txtWeight.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return p;
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}

