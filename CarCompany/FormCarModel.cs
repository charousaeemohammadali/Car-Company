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
    public partial class FormCarModel : Form
    {
        CarModel Model = null;
        public bool IsChanged { get; private set; }
        public FormCarModel(CarModel PModel)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtCarModelName.Text.Trim() == "")
            {
                MyMessageBox.ShowValidationError();
                return;
            }

            if (Model == null)
            {
                Model = new CarModel();
                DbCommon.Context.CarModels.Add(Model);
            }
            Model.CarModelName = txtCarModelName.Text.Trim();
            DbCommon.Save();

            ShowCarModels();
            ClearText();
            IsChanged = true;
            MyMessageBox.ShowSuccess();
        }
        private void ClearText()
        {
            txtCarModelName.Text = "";
            txtCarModelName.Focus();
            Model = null;
        }

        private void ShowCarModels()
        {
            GridModel.AutoGenerateColumns = false;
            GridModel.DataSource = DbCommon.Context.CarModels.Where(p => p.ID != -1).ToList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
                if (Model == null)
                {
                    MyMessageBox.ShowSelectionError();
                    return;
                }
                DbCommon.Context.CarModels.Remove(Model);
                DbCommon.Save();
                ShowCarModels();
                ClearText();
                MyMessageBox.ShowSuccess();
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void GridModel_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
                return;
            int id = Convert.ToInt32(GridModel[1, e.RowIndex].Value);

            Model = DbCommon.Context.CarModels.SingleOrDefault(P => P.ID == id);
            if (Model != null)
            {
                txtCarModelName.Text = Model.CarModelName;


                GridCar.AutoGenerateColumns = false;
                GridCar.DataSource = Model.Cars.Where(p => p.ID != -1).Select(P => new {
                    P.CarBrand.CarBrandName,
                    P.CarModel.CarModelName,
                    P.CarProductionYear,
                    P.CarPrice
                }).ToList();
            }
        }

        private void FormCarModel_Load(object sender, EventArgs e)
        {
            ShowCarModels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
