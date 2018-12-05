using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JustRipeFarm.ClassEntity;

namespace JustRipeFarm
{
    public partial class FormFarm : Form
    {
        public FormFarm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Farm farm = new Farm();
            farm.Description = descriptionText.Text;
            farm.Area = areaText.Text;
            farm.Utilize_area = utiliseAreaText.Text;

            InsertSQL farmHnd = new InsertSQL();
            int addrecord = farmHnd.addNewFarm(farm);
            MessageBox.Show(addrecord + "Your record is added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
