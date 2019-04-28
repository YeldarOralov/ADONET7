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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.TextLength == 0 || priceMaskedTextBox.TextLength == 0)
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
            else
            {
                using (var context = new StockContext())
                {
                    context.Products.Add(new Product { Name = nameTextBox.Text, Price = Convert.ToInt32(priceMaskedTextBox.Text) });
                    context.SaveChanges();
                }
                Form.ActiveForm.Close();
            }
        }
    }
}
