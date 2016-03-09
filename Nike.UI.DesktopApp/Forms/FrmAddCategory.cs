using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nike.BusinessLayer.BL;
using Nike.DataLayer.Models;

namespace Nike.UI.DesktopApp.Forms
{
    public partial class FrmAddCategory : Form
    {
        public FrmAddCategory()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = txtCategoryName.Text;
            category.Description = txtDescription.Text;

            CategoryManager.AddCategory(category);

            MessageBox.Show("Kategori başarıyla eklendi");
        }
    }
}
