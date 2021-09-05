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
    public partial class FormListAgent : Form
    {
        Agent SelectedAgent = null;
        public FormListAgent()
        {
            InitializeComponent();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            FormAgent f = new FormAgent(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowAgents();
            }
        }

        private void ShowAgents()
        {
            GridAgents.AutoGenerateColumns = false;
            var FirstName = txtFirstName.Text.Trim();
            var LastName = txtLastName.Text.Trim();
            var NationalCode = txtNationalCode.ConvertToInt64();
            var _list = DbCommon.Context.Agents.Where(P => P.AgentFirstName.Contains(FirstName)
            && P.ID!=-1 && P.AgentLastName.Contains(LastName) && 
            (P.NationalCode == NationalCode || NationalCode == 0)).Select(P => new {
                P.AgentAddress,
                P.AgentTel,
                P.AgentType.AgentTypeName,
                P.EMail,
                GenderName = P.Gender ? "مرد" : "زن",
                P.NationalCode,
                AgentFullName = P.AgentFirstName + " " + P.AgentLastName,P.ID
            }).ToList().Select(p => new
            {
                p.AgentFullName,
                p.GenderName,
                p.AgentTel,
                p.EMail,
                p.NationalCode,
                p.AgentTypeName,
               p.AgentAddress,
                p.ID
            }).ToList();

            GridAgents.DataSource = _list.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (SelectedAgent == null)
            {
                MyMessageBox.ShowSelectionError();
                return;
            }
            FormAgent f = new FormAgent(SelectedAgent);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowAgents();
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (SelectedAgent == null)
            {
                MyMessageBox.ShowSelectionError();
                return;
            }
            if (!MyMessageBox.ShowConfirm())
                return;

            DbCommon.Context.Agents.Remove(SelectedAgent);
            DbCommon.Save();
            ShowAgents();
            MyMessageBox.ShowSuccess();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowAgents();
        }

        private void GridAgents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int id = Convert.ToInt32(GridAgents[7, e.RowIndex].Value);

            SelectedAgent = DbCommon.Context.Agents.SingleOrDefault(p=>p.ID==id);
        }

        private void FormListAgent_Load(object sender, EventArgs e)
        {
            ShowAgents();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
