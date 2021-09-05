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
    public partial class FormBuy : Form
    {
        Agent SelectedAgent = null;
        Buy Model = null;
        //CarModel selectedcarmodel = null;

        public FormBuy(Agent agent, Buy buy)
        {
            InitializeComponent();
            SelectedAgent = agent;
            Model = buy;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (Model == null)
            {
                Model = new Buy();
                DbCommon.Context.Buys.Add(Model);

            }
            Model.CarID = ComboModel.GetValue();
            Model.Date = txtDate.Text.Trim();
            Model.Count = txtNumDay.ConvertToInt32();
            Model.AgentID = SelectedAgent.ID;
            DbCommon.Save();
            MyMessageBox.ShowSuccess();
            Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBuy_Load(object sender, EventArgs e)
        {
            ShowCarModels();
            showAgentLastNames();
            if (Model != null)
            {
                ShowOriginalInfoirmation();
            }
        }
        private void ShowCarModels()
        {
            ComboModel.DataSource = DbCommon.Context.CarModels.Where(p => p.ID != -1).ToList();
            ComboModel.DisplayMember = "CarModelName";
            ComboModel.ValueMember = "ID";
            ComboModel.SelectedIndex = -1;
        }

        private void showAgentLastNames()
        {
            ComboModel.DataSource = DbCommon.Context.Agents.Where(p => p.ID != -1).ToList();
            ComboModel.DisplayMember = "AgentLastName";
            ComboModel.ValueMember = "ID";
            ComboModel.SelectedIndex = -1;
        }

        private void ShowOriginalInfoirmation()
        {
            txtNumDay.Text = Model.Count.ToString();
            txtDate.Text = Model.Date.ToString();
            ComboModel.SelectedValue = Model.CarID;
            ComboLastName.SelectedValue = Model.AgentID;
        }


        private void ComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboLastName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumDay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
