using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyTreeView
{
    public partial class EmpNode : Form
    {
        public EmpNode()
        {
            InitializeComponent();
        }
        
        #region Local Variables

        private string mNewEmpName;
        private string mNewEmpText;
        private string mNewEmpTag;

        #endregion

        #region Class Properties

        public string NewEmpName
        {
            get
            {
                return mNewEmpName;
            }
            set
            {
                mNewEmpName = value;
            }
        }

        public string NewEmpText
        {
            get
            {
                return mNewEmpText;
            }
            set
            {
                mNewEmpText = value;
            }
        }

        public string NewEmpTag
        {
            get
            {
                return mNewEmpTag;
            }
            set
            {
                mNewEmpTag = value;
            }
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtNewNodeName.Text != string.Empty)
            {
                NewEmpName = txtNewNodeName.Text;
            }
            else
            {
                MessageBox.Show("Name the node.");
                return;
            }

            if (txtNewNodeText.Text != string.Empty)
            {
                NewEmpText = txtNewNodeText.Text;
            }
            else
            {
                MessageBox.Show("Provide the new node's text");
                return;
            }

            if (txtTag.Text != string.Empty)
            {
                NewEmpTag = txtTag.Text;
            }
            else
            {
                MessageBox.Show("Provide the new node's text");
                return;
            }

            this.Close();
        }

    }
}
