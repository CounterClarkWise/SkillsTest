using SkillsTest.GlobalVariables;
using SkillsTest.GlobalVariables.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsTest
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Functions
        private void Reset()
        {
            MainVar.InitialString = "";
            MainVar.ConvertedString = "";
            MainVar.Strategy = "";

            cbStrategy.Text = "Ascending";
            lblResultValue.Text = "";
            tbString.Text = "";
            tbString.Focus();
        }

        private void Sort()
        {
            //NOTE: cb was set to dropdownlist so the user cannot type in the combobox
            if(cbStrategy.Text != "")//Validation for proceeding without strategy
            {
                MainVar.InitialString = tbString.Text.Trim();
                MainVar.ConvertedString = Logic.SortString(MainVar.InitialString, MainVar.Strategy);
                lblResultValue.Text = MainVar.ConvertedString;
            }
            else
            {
                MessageBox.Show(MainMessages.NoStrategyErrorText, MainMessages.NoStrategyErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbStrategy.Focus();
            }

            //Validation for re-typing in textbox
            //tbString.Text = "";
            //MainVar.InitialString = "";
        }
        #endregion
        #region Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //validation if cb is changed and tb is empty
            if (tbString.Text != "")
            {
                if (keyData == Keys.Enter)
                {
                    Sort();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Sort();
        }

        private void cbStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainVar.Strategy = cbStrategy.Text;
            Sort();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MainMessages.ResetText, MainMessages.ResetCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Reset();
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(MainMessages.ExitText, MainMessages.ExitCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            tbString.Focus();
        }
    }
}
