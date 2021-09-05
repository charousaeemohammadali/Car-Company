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
    public partial class FormForeignGallery : Form
    {
        ForeignGallery Model=null;
        public bool IsChanged { get; private set; }
        public FormForeignGallery(ForeignGallery PModel)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtForeignName.Text.Trim() == "")
            {
                MyMessageBox.ShowValidationError();
                return;
            }

            if (Model == null)
            {
                Model = new ForeignGallery();
                DbCommon.Context.ForeignGalleries.Add(Model);
            }
            Model.ForeignName = txtForeignName.Text.Trim();
            Model.ForeignAddress = txtAddress.Text.Trim();
            Model.ForeignTel = txtTel.ConvertToInt64();
            DbCommon.Save();
            ShowForeignGalleries();
            ClearText();
            IsChanged = true;
            MyMessageBox.ShowSuccess();
          

        }

        private void ShowForeignGalleries()
        {
            GridForeignGallery.AutoGenerateColumns = false;
            GridForeignGallery.DataSource = DbCommon.Context.ForeignGalleries.Where(p => p.ID != -1).ToList();
        }

        private void ClearText()
        {

            txtAddress.Text = txtForeignName.Text = txtTel.Text = "";
            txtForeignName.Focus();
            Model = null;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
           
                if (Model == null)
                {
                    MyMessageBox.ShowSelectionError();
                    return;
                }


                DbCommon.Context.ForeignGalleries.Remove(Model);
                DbCommon.Save();
                ShowForeignGalleries();
                Model = null;
                MyMessageBox.ShowSuccess();
           

        }

        private void GridForeignGallery_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int id = Convert.ToInt32(GridForeignGallery[3, e.RowIndex].Value);

            Model = DbCommon.Context.ForeignGalleries.SingleOrDefault(P => P.ID == id);
            if (Model != null)
            {
                txtForeignName.Text = Model.ForeignName;
                txtAddress.Text = Model.ForeignAddress;
                txtTel.Text = Model.ForeignTel.ToString();

                GridCars.AutoGenerateColumns = false;
                GridCars.DataSource = Model.Cars.Where(p => p.ID != -1).Select(P => new {
                    P.CarBrand.CarBrandName,
                    P.CarColor.CarColorName,
                    P.CarModel.CarModelName,
                    P.CarProductionYear,
                    P.CarPrice
                }).ToList();

            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void FormForeignGallery_Load(object sender, EventArgs e)
        {
            ShowForeignGalleries();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTel.MaxLength = 11;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void GridCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
