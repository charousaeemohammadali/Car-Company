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
    public partial class FormAgentType : Form
    {
        AgentType Model = null;
        public bool IsChanged { get; private set; }
        public FormAgentType(AgentType PModel)
        {
            InitializeComponent();
            IsChanged = false;
            Model = PModel;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtAgentTypeName.Text.Trim() == "")
            {
                MyMessageBox.ShowValidationError();
                return;
            }
            if (Model == null)
            {
                Model = new AgentType();
                DbCommon.Context.AgentTypes.Add(Model);
            }
            Model.AgentTypeName = txtAgentTypeName.Text.Trim();
            DbCommon.Save();
            ShowAgentTypes();
            ClearText();
            MyMessageBox.ShowSuccess();
           
        }

        private void ClearText()
        {
            txtAgentTypeName.Text = "";
            txtAgentTypeName.Focus();
            Model = null;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void FormAgentType_Load(object sender, EventArgs e)
        {
            ShowAgentTypes();
        }

        private void ShowAgentTypes()
        {
            GridAgentType.AutoGenerateColumns = false;
            GridAgentType.DataSource = DbCommon.Context.AgentTypes.Where(P => P.ID != -1).ToList();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
           
                if (Model == null)
                {
                    MyMessageBox.ShowSelectionError();
                    return;
                }

                DbCommon.Context.AgentTypes.Remove(Model);
                DbCommon.Save();
                ShowAgentTypes();
                ClearText();
                MyMessageBox.ShowSuccess();
            
        }

        private void GridAgentType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            int id = Convert.ToInt32(GridAgentType[1, e.RowIndex].Value);

            Model = DbCommon.Context.AgentTypes.Find(id);
            if (Model != null)
            {
                txtAgentTypeName.Text = Model.AgentTypeName;

                GridAgents.AutoGenerateColumns = false;
                GridAgents.DataSource = Model.Agents.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
