using HomeWork7.DataAccess;
using HomeWork7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            showProducts();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            var add = new AddProductForm();
            add.Show();
        }
        private void showProducts()
        {
            using (var context = new StockContext())
            {
                productDataGridView.DataSource = context.Products.ToList();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            showProducts();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.RowCount == 0)
            {
                MessageBox.Show("Нечего удалять");
            }
            else
            {
                string productName = productDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                using (var context = new StockContext())
                {
                    Product product = context.Products.Where(p => p.Name == productName).FirstOrDefault();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                showProducts();
            }
        }
        private void productDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string productName = productDataGridView.SelectedRows[0].Cells[0].Value.ToString();

            using (var context = new StockContext())
            {
                Product product = context.Products.Where(p => p.Name == productName).FirstOrDefault();
                var edit = new EditProductForm(product);
                edit.Show();
            }            
        }
    }
}
