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
    public partial class FormCarBrand : Form
    {
        CarBrand Model = null;
        public bool IsChanged { get; private set; }
        public FormCarBrand(CarBrand PModel)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (txtCarBrandName.Text.Trim() == "")
            {
                MyMessageBox.ShowValidationError();
                return;
            }

            if (Model == null)
            {
                Model = new CarBrand();
                DbCommon.Context.CarBrands.Add(Model);
            }
            Model.CarBrandName = txtCarBrandName.Text.Trim();
            DbCommon.Save();

            ShowCarBrands();
            ClearText();
            IsChanged = true;
            MyMessageBox.ShowSuccess();
        }

        private void ClearText()
        {
            txtCarBrandName.Text = "";
            txtCarBrandName.Focus();
            Model = null;
        }

        private void ShowCarBrands()
        {
            GridBrand.AutoGenerateColumns = false;
            GridBrand.DataSource = DbCommon.Context.CarBrands.Where(p => p.ID != -1).ToList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
       
                if (Model == null)
                {
                    MyMessageBox.ShowSelectionError();
                    return;
                }
                DbCommon.Context.CarBrands.Remove(Model);
                DbCommon.Save();
                ShowCarBrands();
                ClearText();
                MyMessageBox.ShowSuccess();
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void GridBrand_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int id = Convert.ToInt32(GridBrand[1, e.RowIndex].Value);

            Model = DbCommon.Context.CarBrands.SingleOrDefault(P => P.ID == id);
            if (Model != null)
            {
                txtCarBrandName.Text = Model.CarBrandName;


                GridCar.AutoGenerateColumns = false;
                GridCar.DataSource = Model.Cars.Where(p => p.ID != -1).Select(P => new
                {
                    P.CarModel.CarModelName,
                    P.CarColor.CarColorName,
                    P.CarProductionYear,
                    P.CarPrice
                }).ToList();
            }
        }

        private void FormCarBrand_Load(object sender, EventArgs e)
        {
            ShowCarBrands();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridBrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
