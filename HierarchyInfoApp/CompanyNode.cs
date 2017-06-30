using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EasyTreeView
{
    public partial class CompanyNode : Form
    {
        public CompanyNode()
        {
            InitializeComponent();
        }

        #region Local Variables

        private string mNewCmpName;
        private string mNewCmpText;
        private string mNewCmpTag;

        #endregion

        #region Class Properties

        public string NewCmpName
        {
            get
            {
                return mNewCmpName;
            }
            set
            {
                mNewCmpName = value;
            }
        }

        public string NewCmpText
        {
            get
            {
                return mNewCmpText;
            }
            set
            {
                mNewCmpText = value;
            }
        }

        public string NewCmpTag
        {
            get
            {
                return mNewCmpTag;
            }
            set
            {
                mNewCmpTag = value;
            }
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtNewNodeName.Text != string.Empty)
            {
                NewCmpName = txtNewNodeName.Text;
            }
            else
            {
                MessageBox.Show("Name the node.");
                return;
            }

            if (txtNewNodeText.Text != string.Empty)
            {
                NewCmpText = txtNewNodeText.Text;
            }
            else
            {
                MessageBox.Show("Provide the new node's text");
                return;
            }

            if (txtTag.Text != string.Empty)
            {
                NewCmpTag = txtTag.Text;
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
