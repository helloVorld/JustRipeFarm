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
        public string state = "";
        public Farm farmfarm;
        public FormFarm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                if(state == "Edit")
                {
                    EditFarm();
                }
                else
                {
                    AddFarm();
                }
            }
            else
            {
                ErrorMsg.WrongIntInput();
            }
           
        }

        public void EditFarm()
        {
            Farm farm = new Farm();
            farm.Id = farmfarm.Id;
            farm.Description = descriptionText.Text;
            farm.Area = Int32.Parse(areaText.Text);
            farm.Utilize_area = Int32.Parse(utiliseAreaText.Text);

            UpdateSQL farmHnd = new UpdateSQL();
            int addrecord = farmHnd.updateFarm(farm);
            MessageBox.Show(addrecord + "Your record is added");
        }

        public void AddFarm()
        {
            Farm farm = new Farm();
            farm.Description = descriptionText.Text;
            farm.Area = Int32.Parse(areaText.Text);
            farm.Utilize_area = Int32.Parse(utiliseAreaText.Text);

            InsertSQL farmHnd = new InsertSQL();
            int addrecord = farmHnd.addNewFarm(farm);
            MessageBox.Show(addrecord + "Your record is added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkInput()
        {
            int checkint;
            if (!int.TryParse(areaText.Text, out checkint))
            {
                return false;
            }
            if (!int.TryParse(utiliseAreaText.Text, out checkint))
            {
                return false;
            }
            return true;
        }

        private void FormFarm_Load(object sender, EventArgs e)
        {
            if (state == "Edit")
            {
                descriptionText.Text = farmfarm.Description;
                areaText.Text = farmfarm.Area.ToString();
                utiliseAreaText.Text = farmfarm.Utilize_area.ToString();
                lblEditing.Show();
            }
            else
            {
                lblEditing.Hide();
            }
        }
    }
}
