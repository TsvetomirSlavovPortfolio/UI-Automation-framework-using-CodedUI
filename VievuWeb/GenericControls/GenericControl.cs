using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VievuWeb.GenericControls
{
    class GenericControl
    {
        private BrowserWindow browser;
        private HtmlControl genericControl;
        public GenericControl(BrowserWindow browser)
        {
            this.browser = browser;
        }

        public UITestControl FindControl<T>(String Propertytype, string propertyvalue) where T : HtmlControl
        {
            try
            {
                genericControl = (T)Activator.CreateInstance(typeof(T), browser);
                if (Propertytype == "Id")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.Id] = propertyvalue;
                else if (Propertytype == "Type")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.Type] = propertyvalue;
                else if (Propertytype == "ClassName")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.ClassName] = propertyvalue;
                else if (Propertytype == "FriendlyName")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.FriendlyName] = propertyvalue;
                else if (Propertytype == "InnerText")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.InnerText] = propertyvalue;
                else if (Propertytype == "Name")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.Name] = propertyvalue;
                else if (Propertytype == "TagName")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.TagName] = propertyvalue;
                else if (Propertytype == "ValueAttribute")
                    genericControl.SearchProperties[HtmlControl.PropertyNames.ValueAttribute] = propertyvalue;
                genericControl.WaitForControlEnabled();


                return genericControl;
            }
            catch (Exception)
            {
                return genericControl = null;
            }
        }


    }
}
