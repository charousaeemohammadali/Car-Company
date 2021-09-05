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
    public partial class FormAgent : Form
    {
        public bool IsChanged { get; private set; }
        Agent Model = null;
        public FormAgent(Agent PModel)
        {
            InitializeComponent();
            Model = PModel;
            IsChanged = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "" || txtNationalCode.Text.Trim() == ""|| ComboGender.SelectedIndex == -1)
            {
                MyMessageBox.ShowValidationError();
                return;
            }

            if (Model==null)
            {
                Model = new Agent();
                DbCommon.Context.Agents.Add(Model);
            }

            Model.AgentFirstName = txtFirstName.Text.Trim();
            Model.AgentLastName = txtLastName.Text.Trim();
            Model.AgentAddress = txtAddress.Text.Trim();
            Model.NationalCode = txtNationalCode.ConvertToInt64();
            Model.EMail = txtEmail.Text.Trim();
            Model.AgentTypeID = ComboAgentType.GetValue();
            Model.Gender = ComboGender.SelectedIndex == 0;
            Model.AgentTel = txtTel.ConvertToInt64();
            DbCommon.Save();
            IsChanged = true;
            MyMessageBox.ShowSuccess();
        }

        private void FormAgent_Load(object sender, EventArgs e)
        {
            ShowAgentTypes();

            if (Model != null)
            {
                ShowOriginalInformation();
            }
        }

        private void ShowOriginalInformation()
        {
            txtAddress.Text = Model.AgentAddress;
            txtFirstName.Text = Model.AgentFirstName;
            txtLastName.Text = Model.AgentLastName;
            txtNationalCode.Text = Model.NationalCode.ToString();
            ComboAgentType.SelectedValue = Model.AgentTypeID;
            ComboGender.SelectedIndex = Model.Gender ? 0 : 1;
            txtEmail.Text = Model.EMail;
            txtTel.Text = Model.AgentTel.ToString();
        }

        private void ShowAgentTypes()
        {
            ComboAgentType.DataSource = DbCommon.Context.AgentTypes.Where(P => P.ID != -1).ToList();
            ComboAgentType.DisplayMember = "AgentTypeName";
            ComboAgentType.ValueMember = "ID";
           
        }

        private void Add_Click(object sender, EventArgs e)
        {
            FormAgentType f = new FormAgentType(null);
            f.ShowDialog();
            if (f.IsChanged)
            {
                ShowAgentTypes();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNationalCode.MaxLength = 11;
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
