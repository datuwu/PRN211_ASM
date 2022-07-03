using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository.Interface;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product Product { get; set; }
        public frmProductDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text == null || txtProductName.Text == null || txtCategory.Text == null || txtWeight.Text == null || txtPrice.Text == null || txtUnitsInStock.Text == null)
                {
                    MessageBox.Show("Please Check All Fields (must not be null, empty)", InsertOrUpdate == false ? "Add a new Member" : "Update a Member");
                }
                else
                {
                    var product = new Product
                    {
                        ProductId = int.Parse(txtProductID.Text),
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtPrice.Text),
                        UnitsInStock = int.Parse(txtUnitsInStock.Text),
                        CategoryId = int.Parse(txtCategory.Text),
                    };
                    if (InsertOrUpdate == false)
                    {
                        ProductRepository.AddNew(product);
                    }
                    else
                    {
                        ProductRepository.Update(product);
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a Product" : "Update a Product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)//Update --> Show Product Info
            {
                txtProductID.Text = Product.ProductId.ToString();
                txtProductName.Text = Product.ProductName.ToString();
                txtCategory.Text = Product.CategoryId.ToString();
                txtWeight.Text = Product.Weight.ToString();
                txtPrice.Text = Product.UnitPrice.ToString();
                txtUnitsInStock.Text = Product.UnitsInStock.ToString();
            }
        }
    }
}
