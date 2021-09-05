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
    public partial class FormInternalGallery : Form
    {
        InternalGallery Model = null;
        public bool IsChanged { get; private set; }
        public FormInternalGallery(InternalGallery PModel=null)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (txtInternalName.Text.Trim() == "")
            {
                MyMessageBox.ShowValidationError();
                return;
            }

            if (Model == null)
            {

                Model = new InternalGallery();
                DbCommon.Context.InternalGalleries.Add(Model);

            }
            Model.InternalName = txtInternalName.Text.Trim();
            Model.InternalAddress = txtAddress.Text.Trim();
            Model.InternalTel = txtTel.ConvertToInt64();
            DbCommon.Save();
            ShowInternalGalleries();
         
            IsChanged = true;
            MyMessageBox.ShowSuccess();
            ClearText();

        }

        private void ShowInternalGalleries()
        {
            GridInternalGallery.AutoGenerateColumns = false;
            GridInternalGallery.DataSource = DbCommon.Context.InternalGalleries.Where(p => p.ID != -1).ToList();
        }

        private void ClearText()
        {
            txtAddress.Text = txtInternalName.Text = txtTel.Text = "";
            txtInternalName.Focus();
            Model = null;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
        
                if (Model == null)
                {
                    MyMessageBox.ShowSelectionError();
                    return;
                }

                DbCommon.Context.InternalGalleries.Remove(Model);
                DbCommon.Save();
                ShowInternalGalleries();
                Model = null;
                MyMessageBox.ShowSuccess();

        }

        private void GridInternalGallery_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridInternalGallery[3, e.RowIndex].Value);

            Model = DbCommon.Context.InternalGalleries.Find(id);
            if (Model != null)
            {
                txtInternalName.Text = Model.InternalName;
                txtAddress.Text = Model.InternalAddress;
                txtTel.Text = Model.InternalTel.ToString();

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

        private void FormInternalGallery_Load(object sender, EventArgs e)
        {
            ShowInternalGalleries();
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
    }
}
