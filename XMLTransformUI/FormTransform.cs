using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace XMLTransformUI
{
    public partial class FormTransform : Form
    {
        public FormTransform()
        {
            InitializeComponent();
        }

        private void buttonBrowseI_Click(object sender, EventArgs e)
        {
            OpenFileDialog(0);
        }

        private void buttonBrowseT_Click(object sender, EventArgs e)
        {
            OpenFileDialog(1);
        }

        private void OpenFileDialog(int type)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (type == 0)
            {
                openFileDialog1.Title = "Choose XML file";
                openFileDialog1.Filter = "xml files (*.xml)|*.xml";
                openFileDialog1.FileName = textBoxI.Text;
            }
            else
            {
                openFileDialog1.Title = "Choose XSLT file";
                openFileDialog1.Filter = "xsl files (*.xsl)|*.xsl|xslt files (*.xslt)|*.xslt";
                openFileDialog1.FileName = textBoxT.Text;
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (type == 0)
                    textBoxI.Text = openFileDialog1.FileName;
                else
                    textBoxT.Text = openFileDialog1.FileName;
            }
        }


        private void SaveFileDialog(int type)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            //saveFileDialog1.Multiselect = false;

            if (type == 0)
            {
                saveFileDialog1.Title = "Choose output file";
                saveFileDialog1.Filter = "xml files (*.xml)|*.xml|html files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog1.FileName = textBoxO.Text;
            }
            else
            {
                saveFileDialog1.Title = "Choose output log file";
                saveFileDialog1.Filter = "|txt files (*.txt)|*.txt|log files (*.log)|*.log|All files (*.*)|*.*";
                saveFileDialog1.FileName = textBoxL.Text;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (type == 0)
                    textBoxO.Text = saveFileDialog1.FileName;
                else
                    textBoxL.Text = saveFileDialog1.FileName;
            }
        }

        private void OpenFolder(string fullFileName)
        {
            if (fullFileName.Trim() == "")
                return;

            string argument = "/select, \"" + fullFileName + "\"";
            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void buttonBrowseO_Click(object sender, EventArgs e)
        {
            SaveFileDialog(0);
        }

        private void buttonBrowseL_Click(object sender, EventArgs e)
        {
            SaveFileDialog(1);
        }

        private void buttonDirI_Click(object sender, EventArgs e)
        {
            OpenFolder(textBoxI.Text);
        }

        private void buttonDirT_Click(object sender, EventArgs e)
        {
            OpenFolder(textBoxT.Text);
        }

        private void buttonDirO_Click(object sender, EventArgs e)
        {
            OpenFolder(textBoxO.Text);
        }

        private void buttonDirL_Click(object sender, EventArgs e)
        {
            OpenFolder(textBoxL.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMsg.Text = "";
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelMsg.Text = "";
            textBoxI.Text = textBoxI.Text.Trim();
            textBoxT.Text = textBoxT.Text.Trim();
            textBoxO.Text = textBoxO.Text.Trim();
            textBoxL.Text = textBoxL.Text.Trim();

            if (textBoxI.Text == "")
                return;

            if (textBoxT.Text == "")
                return;

            if (textBoxO.Text == "")
                return;

            try
            {
                //load the Xml doc
                System.Xml.XPath.XPathDocument myXPathDoc = new System.Xml.XPath.XPathDocument(textBoxI.Text);

                //create XslTransform
                System.Xml.Xsl.XslCompiledTransform myXslTrans = new System.Xml.Xsl.XslCompiledTransform();

                //load the Xsl 
                myXslTrans.Load(textBoxT.Text);

                //run transformation 
                myXslTrans.Transform(textBoxI.Text, textBoxO.Text);

            }
            catch (Exception ex)
            {
                try
                {
                    if (textBoxL.Text.Length > 0)
                    {
                        System.IO.StreamWriter sw = new System.IO.StreamWriter(textBoxL.Text);
                        sw.WriteLine(ex.Message);
                        sw.Close();
                    }
                }
                catch
                {
                }

                labelMsg.Text = ex.Message;
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
