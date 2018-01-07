using QuanLyDiaOc.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuanLyDiaOc.GUI
{
    public partial class DialogCauHinh : Form
    {
        public DialogCauHinh()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[1].Value = txtChuoiKetNoi.Text.ToString().Trim();
                    xElement.LastChild.Attributes[1].Value = txtChuoiKetNoi.Text.ToString().Trim();
                    KetNoi.connectPath = txtChuoiKetNoi.Text.ToString().Trim();
                    MessageBox.Show("Cập nhật chuỗi kết nối thành công", "Thông báo");
                    //@"Data Source=DESKTOP-S2C4DB8\HOANGKIMTUAN;Initial Catalog=QUANLYDIAOC;Integrated Security=SSPI;"
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
