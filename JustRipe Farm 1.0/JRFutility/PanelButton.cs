using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRipeFarm
{
    public class PanelButton
    {
        string btnName;
        string panelName;
        bool isCommonPanel;
        //string title;

        public PanelButton(string bN, string pN, bool commonpanel)
        {
            this.btnName = bN;
            this.panelName = pN;
            this.isCommonPanel = commonpanel;
            //this.title = title;
        }

        public string BtnName { get => btnName; set => btnName = value; }
        public string PanelName { get => panelName; set => panelName = value; }
        public bool IsCommonPanel { get => isCommonPanel; set => isCommonPanel = value; }
        //public string Title { get => title; set => title = value; }
    }
}