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
    public partial class FormListCar : Form
    {
        Car SelectedCar = null;
        public FormListCar()
        {
            InitializeComponent();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            FormCar f = new FormCar(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowCars();
            }
        }

        private void ShowCars()
        {
            GridCars.AutoGenerateColumns = false;
            var Price = txtPrice.ConvertToInt64();
            var CarModeliD = ComboModel.GetValue();
            var IGalleryID = ComboIGallery.GetValue();
            var _list = DbCommon.Context.Cars.Where(P => P.ModelID == CarModeliD || CarModeliD == -1 && P.InternalGalleryID == IGalleryID || IGalleryID == -1 && P.ID != -1 && P.CarPrice == Price || Price == 0).Select(P => new
            {
                P.CarPrice,
                P.CarModel.CarModelName,
                P.CarColor.CarColorName,
                P.CarBrand.CarBrandName,
                P.ForeignGallery.ForeignName,
                P.InternalGallery.InternalName,
                P.CarProductionYear,
                P.ID
            }).ToList();
            GridCars.DataSource = _list.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedCar == null)
            {
                MyMessageBox.ShowSelectionError();
                return;
            }
            FormCar f = new FormCar(SelectedCar);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowCars();
            }
        }

        private void GridCars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridCars[7, e.RowIndex].Value);
            SelectedCar = DbCommon.Context.Cars.Find(id);
        }

        private void ShowInternalGalleriesInComboCarIGallery()
        {
            ComboIGallery.DataSource = DbCommon.Context.InternalGalleries.Where(P => P.ID != -1).ToList();
            ComboIGallery.DisplayMember = "InternalName";
            ComboIGallery.ValueMember = "ID";
      
        }

        private void ShowCarModelsInComboModel()
        {
            ComboModel.DataSource = DbCommon.Context.CarModels.Where(P => P.ID != -1).ToList();
            ComboModel.DisplayMember = "CarModelName";
            ComboModel.ValueMember = "ID";
           
        }

        private void FormListCar_Load_1(object sender, EventArgs e)
        {
            ShowCarModelsInComboModel();
            ShowInternalGalleriesInComboCarIGallery();
            ShowCars();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(SelectedCar==null)
            {
                MyMessageBox.ShowSelectionError();
                return;
            }
            if (!MyMessageBox.ShowConfirm())
                return;
            DbCommon.Context.Cars.Remove(SelectedCar);
            DbCommon.Save();
            ShowCars();
            MyMessageBox.ShowSuccess();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowCars();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
