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
            if (state == "Edit")
            {
                updateFarm();
            }
            else
            {
                if (String.IsNullOrEmpty(descriptionText.Text))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(areaText.Text)))
                    {
                        if (String.IsNullOrEmpty(Convert.ToString(utiliseAreaText.Text)))
                        {
                            MessageBox.Show("Please fill up all the value");
                        }
                        MessageBox.Show("Please fill up all the value");
                    }
                    MessageBox.Show("Please fill up all the value");
                }
                else
                {
                    addFarm();
                }
            }
        }

        public void addFarm()
        {
            Farm f1 = new Farm();
            f1.Description = descriptionText.Text;
            f1.Area = Convert.ToInt32(areaText.Text);
            f1.Utilize_area = Convert.ToInt32(utiliseAreaText.Text);

            InsertSQL add = new InsertSQL();
            int addrecord = add.addNewFarm(f1);
            MessageBox.Show("Successful");
            this.Close();
        }

        public void updateFarm()
        {
            Farm f1 = new Farm();
            f1.Description = descriptionText.Text;
            f1.Area = Convert.ToInt32(areaText.Text);
            f1.Utilize_area = Convert.ToInt32(utiliseAreaText.Text);

            UpdateSQL add = new UpdateSQL();
            int editrecord = add.updateFarm(f1);
            MessageBox.Show("Successful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private bool checkInput()
        //{
            //int checkint;
            //if (!int.TryParse(areaText.Text, out checkint))
            //{
            //    return false;
            //}
            //if (!int.TryParse(utiliseAreaText.Text, out checkint))
            //{
            //    return false;
            //}
            //return true;
        //}

        private void FormFarm_Load(object sender, EventArgs e)
        {
            InsertSQL farm = new InsertSQL();

            if (state == "Edit")
            {
                descriptionText.Text = farmfarm.Description;
                areaText.Text = farmfarm.Area.ToString();
                utiliseAreaText.Text = farmfarm.Utilize_area.ToString();
            }
        }
    }
}
