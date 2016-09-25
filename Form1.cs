using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Collections;
using System.DirectoryServices;

namespace minfo
{
    public partial class minfo : Form
    {
        public minfo()
        {
            InitializeComponent();
        }

        private void Win32API_SelectedIndexChanged(object sender, EventArgs e)
        {
// Get Selected Win32 API from ComboBox
            Win32PropertiesDataGrid.DataSource = GetWin32Properties(Win32API.Text);
        }

        private void minfo_Load(object sender, EventArgs e)
        {
// Get Computers in network and load to combo box when form starts up
            DirectoryEntry root = new DirectoryEntry("WinNT:");
            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema")
                    {
                        this.ComputerComboBox.Items.Add(computer.Name);
                    }
                }
            }
        }

        private ArrayList GetWin32Properties(string sWin32)
        {

            ArrayList al = new ArrayList();
            ManagementObjectSearcher mos;

            try
            {
                mos = new ManagementObjectSearcher("SELECT * FROM " + sWin32);
                foreach (ManagementObject wmi_HD in mos.Get())
                {

                    PropertyDataCollection Win32Properties = wmi_HD.Properties;
                    foreach (PropertyData Win32Item in Win32Properties)
                    {
                        al.Add(Win32Item);
                    }
                }
            }
            catch ( Exception Ex )
            {
                MessageBox.Show(Ex.ToString(), "Error : " + sWin32);
            }
            return al;
        }

        private void ComputerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sComputer = "\\\\" + ComputerComboBox.Text + "\\root\\cimv2";
            try
            {
                ManagementScope scope = new ManagementScope(sComputer);
                scope.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error : " + sComputer);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Win32API_SelectedIndexChanged(sender, e);
        }
    }

}
