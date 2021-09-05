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
    public partial class FormListBuy : Form
    {
        Agent SelectedAgent = null;
        Buy SelectedBuy = null;
        CarModel selectedcarmodel = null;
        public FormListBuy()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridMembers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(GridAgents[2, e.RowIndex].Value);

            SelectedAgent = DbCommon.Context.Agents.SingleOrDefault(p => p.ID == id);
            if (SelectedAgent != null)
            {
                ShowBuys();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowAgents();
        }

        private void ShowAgents()
        {
            GridAgents.AutoGenerateColumns = false;
            var firstname = txtFirstName.Text.Trim();
            var lastname = txtLastName.Text.Trim();
            var natioanlcode = txtNationalCode.ConvertToInt64();

            var _list = DbCommon.Context.Agents.Where(p => p.AgentFirstName.Contains(firstname) && p.AgentLastName.Contains(lastname) && (p.NationalCode == natioanlcode || natioanlcode == 0))

                .Select(p => new {
                    FullName = p.AgentFirstName + " " + p.AgentLastName,
                    p.NationalCode,
                    p.ID,

                }).ToList().Select(p => new {
                    p.FullName,
                    p.NationalCode,
                    p.ID,

                }).ToList();

            GridAgents.DataSource = _list.ToList();
        }

        private void FormListBuy_Load(object sender, EventArgs e)
        {
            ShowAgents();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            if (SelectedAgent == null)
            {
                MyMessageBox.ShowSelectionError();
                return;
            }
            FormBuy form = new FormBuy(SelectedAgent, null);
            form.ShowDialog();
            ShowBuys();
        }

        private void ShowBuys()
        {
            GridBuy.AutoGenerateColumns = false;
            GridBuy.DataSource = DbCommon.Context.Buys.Where(p => p.AgentID == SelectedAgent.ID)
                .Select(p => new
                {
                    p.Car.CarModel.CarModelName,
                    p.Count,
                    p.Date
                }).ToList().Select(p => new
                {
                    p.CarModelName,
                    p.Count,
                    p.Date
                }).ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedAgent == null)
            {
                MyMessageBox.ShowCustomError("لطفا موردی را از لیست نمایندگان فروش انتخاب نمایید");
                return;
            }
            if (SelectedBuy == null)
            {
                MyMessageBox.ShowCustomError("لطفا از لیست خریدها موردی را انتخاب نمایید");
                return;
            }

            FormBuy form = new FormBuy(SelectedAgent, SelectedBuy);
            form.ShowDialog();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectedAgent == null)
            {
                MyMessageBox.ShowCustomError("لطفا موردی را از لیست نمایندگان فروش انتخاب نمایید");
                return;
            }
            if (SelectedBuy == null)
            {
                MyMessageBox.ShowCustomError("لطفا از لیست خریدها موردی را انتخاب نمایید");
                return;
            }
            DbCommon.Context.Buys.Remove(SelectedBuy);
            DbCommon.Save();
            ShowBuys();
            MyMessageBox.ShowSuccess();
        }

        private void GridBuy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridBuy[3, e.RowIndex].Value);

            SelectedBuy = DbCommon.Context.Buys.SingleOrDefault(p => p.ID == id);
        }

        private void GridAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
