using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class PanelItem
    {
        private string pnName;
        private string pnTitle;
        private string id;
        private string updateField;

        private string btnNew;
        private string btnUpdate;
        private string btnEdit;

        public string PnTitle { get => pnTitle; set => pnTitle = value; }
        public string Id { get => id; set => id = value; }
        public string UpdateField { get => updateField; set => updateField = value; }
        public string BtnNew { get => btnNew; set => btnNew = value; }
        public string BtnUpdate { get => btnUpdate; set => btnUpdate = value; }
        public string BtnEdit { get => btnEdit; set => btnEdit = value; }
        public string PnName { get => pnName; set => pnName = value; }

        public PanelItem(string btnName)
        {
            PnTitle = btnName;
            Id = btnName + " ID: ";
            BtnNew = "New " + btnName;
            BtnEdit = "Edit " + btnName;

        }
    }
}
