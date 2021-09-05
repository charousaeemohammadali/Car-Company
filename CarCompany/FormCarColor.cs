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
    public partial class FormCarColor : Form
    {
        CarColor Model = null;
        public bool IsChanged { get; private set; }
        public FormCarColor(CarColor PModel)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
                if (Model == null)
                {
                    MyMessageBox.ShowSelectionError();
                    return;
                }
                DbCommon.Context.CarColors.Remove(Model);
                DbCommon.Save();
                ShowCarColors();
                ClearText();
                MyMessageBox.ShowSuccess();
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void GridColor_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1)
                return;
            int id = Convert.ToInt32(GridColor[1, e.RowIndex].Value);

            Model = DbCommon.Context.CarColors.SingleOrDefault(P => P.ID == id);
            if (Model != null)
            {
                txtCarColorName.Text = Model.CarColorName;


                GridCar.AutoGenerateColumns = false;
                GridCar.DataSource = Model.Cars.Where(p => p.ID != -1).Select(P => new {
                    P.CarBrand.CarBrandName,
                    P.CarModel.CarModelName,
                    P.CarProductionYear,
                    P.CarPrice
                }).ToList();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtCarColorName.Text.Trim() == "")
            {
                MyMessageBox.ShowValidationError();
                return;
            }

            if (Model == null)
            {
                Model = new CarColor();
                DbCommon.Context.CarColors.Add(Model);
            }
            Model.CarColorName = txtCarColorName.Text.Trim();
            DbCommon.Save();
           
            ShowCarColors();
            ClearText();
            IsChanged = true;
            MyMessageBox.ShowSuccess();
        }

        private void ShowCarColors()
        {
            GridColor.AutoGenerateColumns = false;
            GridColor.DataSource = DbCommon.Context.CarColors.Where(p => p.ID != -1).ToList();
        }

        private void ClearText()
        {
            txtCarColorName.Text = "";
            txtCarColorName.Focus();
            Model = null;
        }

        private void FormCarColor_Load(object sender, EventArgs e)
        {
            ShowCarColors();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridColor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
