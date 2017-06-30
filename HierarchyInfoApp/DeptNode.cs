using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyTreeView
{
    public partial class DeptNode : Form
    {
        public DeptNode()
        {
            InitializeComponent();
        }

        #region Local Variables

        private string mNewDeptName;
        private string mNewDeptText;
        private string mNewDeptTag;

        #endregion

        #region Class Properties

        public string NewDeptName
        {
            get
            {
                return mNewDeptName;
            }
            set
            {
                mNewDeptName = value;
            }
        }

        public string NewDeptText
        {
            get
            {
                return mNewDeptText;
            }
            set
            {
                mNewDeptText = value;
            }
        }

        public string NewDeptTag
        {
            get
            {
                return mNewDeptTag;
            }
            set
            {
                mNewDeptTag = value;
            }
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtNewNodeName.Text != string.Empty)
            {
                NewDeptName = txtNewNodeName.Text;
            }
            else
            {
                MessageBox.Show("Name the node.");
                return;
            }

            if (txtNewNodeText.Text != string.Empty)
            {
                NewDeptText = txtNewNodeText.Text;
            }
            else
            {
                MessageBox.Show("Provide the new node's text");
                return;
            }

            if (txtTag.Text != string.Empty)
            {
                NewDeptTag = txtTag.Text;
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
