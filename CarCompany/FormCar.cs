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
    public partial class FormCar : Form
    {
        Car Model = null;
        public bool IsChanged { get; private set; }
        public FormCar(Car PModel)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void AddFGallery_Click(object sender, EventArgs e)
        {
            FormForeignGallery f = new FormForeignGallery(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowForeignGalleries();
            }
        }

        private void AddIGallery_Click(object sender, EventArgs e)
        {
            FormInternalGallery f = new FormInternalGallery(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowInternalGalleries();
            }
        }

        private void AddColor_Click(object sender, EventArgs e)
        {
            FormCarColor f = new FormCarColor(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowCarColor();
            }
        }

        private void AddModel_Click(object sender, EventArgs e)
        {
            FormCarModel f = new FormCarModel(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowCarModel();
            }
        }

        private void AddBrand_Click(object sender, EventArgs e)
        {
            FormCarBrand f = new FormCarBrand(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowCarBrand();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text.Trim() == "" || ComboModel.SelectedIndex == -1 || ComboIGallery.SelectedIndex == -1 || ComboColor.SelectedIndex == -1)
            {
                MyMessageBox.ShowValidationError();
                return;
            }
            if (Model == null)
            {
                Model = new Car();
                DbCommon.Context.Cars.Add(Model);
            }

            Model.CarPrice = txtPrice.ConvertToInt64();
            Model.CarProductionYear = txtPYear.Text.Trim();
            Model.ColorID = ComboColor.GetValue();
            Model.ModelID = ComboModel.GetValue();
            Model.BrandID = ComboBrand.GetValue();
            Model.ForeignGalleryID = ComboFGallery.GetValue();
            Model.InternalGalleryID = ComboIGallery.GetValue();
            DbCommon.Save();
            IsChanged = true;

            MyMessageBox.ShowSuccess();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCar_Load(object sender, EventArgs e)
        {
            ShowForeignGalleries();
            ShowInternalGalleries();
            ShowCarColor();
            ShowCarModel();
            ShowCarBrand();

            if (Model != null)
            {
                ShowOriginalInformation();
            }
        }

        private void ShowOriginalInformation()
        {
            ComboColor.SelectedValue = Model.ColorID;
            txtPrice.Text = Model.CarPrice.ToString();
            txtPYear.Text = Model.CarProductionYear;
            ComboBrand.SelectedValue = Model.BrandID;
            ComboFGallery.SelectedValue = Model.ForeignGalleryID;
            ComboIGallery.SelectedValue = Model.InternalGalleryID;
            ComboModel.SelectedValue = Model.ModelID;

        }

        private void ShowCarBrand()
        {
            ComboBrand.DataSource = DbCommon.Context.CarBrands.Where(P => P.ID != -1).ToList();
            ComboBrand.DisplayMember = "CarBrandName";
            ComboBrand.ValueMember = "ID";
            ComboBrand.SelectedIndex = -1;
        }

        private void ShowCarModel()
        {
            ComboModel.DataSource = DbCommon.Context.CarModels.Where(P => P.ID != -1).ToList();
            ComboModel.DisplayMember = "CarModelName";
            ComboModel.ValueMember = "ID";
            ComboModel.SelectedIndex = -1;
        }

        private void ShowInternalGalleries()
        {
            ComboIGallery.DataSource = DbCommon.Context.InternalGalleries.Where(P => P.ID != -1).ToList();
            ComboIGallery.DisplayMember = "InternalName";
            ComboIGallery.ValueMember = "ID";
            ComboIGallery.SelectedIndex = -1;
        }

        private void ShowCarColor()
        {
            ComboColor.DataSource = DbCommon.Context.CarColors.Where(P => P.ID != -1).ToList();
            ComboColor.DisplayMember = "CarColorName";
            ComboColor.ValueMember = "ID";
            ComboColor.SelectedIndex = -1;
        }

        private void ShowForeignGalleries()
        {
            ComboFGallery.DataSource = DbCommon.Context.ForeignGalleries.Where(P => P.ID != -1).ToList();
            ComboFGallery.DisplayMember = "ForeignName";
            ComboFGallery.ValueMember = "ID";
            ComboFGallery.SelectedIndex = -1;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void ComboFGallery_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
