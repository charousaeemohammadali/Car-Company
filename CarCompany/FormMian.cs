using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarCompany.Model;

namespace CarCompany
{
    public partial class FormMian : Form
    {
        public FormMian()
        {
            InitializeComponent();
        }

        private void ShowFormListAgent_Click(object sender, EventArgs e)
        {
            FormListAgent formListAgent = new FormListAgent();
            formListAgent.ShowDialog();
        }

        private void ShowFormTypeagent_Click(object sender, EventArgs e)
        {
            FormAgentType formAgentType = new FormAgentType(null);
            formAgentType.ShowDialog();
        }

        private void ShowFormListCar_Click(object sender, EventArgs e)
        {
            FormListCar formListCar = new FormListCar();
            formListCar.ShowDialog();
        }

        private void ShowCarColor_Click(object sender, EventArgs e)
        {
            FormCarColor formCarColor = new FormCarColor(null);
            formCarColor.ShowDialog();
        }

        private void ShowFormCarBrand(object sender, EventArgs e)
        {
            FormCarBrand formCarBrand = new FormCarBrand(null);
            formCarBrand.ShowDialog();
        }

        private void ShowFormCarBrand_Click(object sender, EventArgs e)
        {
            FormCarBrand formCarBrand = new FormCarBrand(null);
            formCarBrand.ShowDialog();
        }

        private void ShowFormIGallery_Click(object sender, EventArgs e)
        {
            FormInternalGallery formInternalGallery = new FormInternalGallery();
            formInternalGallery.ShowDialog();
        }

        private void ShowFormFGallery_Click(object sender, EventArgs e)
        {
            FormForeignGallery formForeignGallery = new FormForeignGallery(null);
            formForeignGallery.ShowDialog();
        }

        private void FormListBuy_Click(object sender, EventArgs e)
        {
            FormListBuy listbuy = new FormListBuy();
            listbuy.ShowDialog();
        }

        private void FormMian_Load(object sender, EventArgs e)
        {

        }
    }
}
