using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

namespace SPC.Components
{
   public abstract class Component
    {
        private string componentName;
        private string componentDescription;
        private Image componentImage;

        public Component()
        {

        }

        public void setComponentName(String componentName)
        {
            this.componentName = componentName;
        }

        public String getComponentName()
        {
            return componentName;
        }
        public void setComponentDescription(String componentDescription)
        {
            this.componentDescription = componentDescription;
        }

        public String getComponentDescription()
        {
            return componentDescription;
        }

        public void setComponentImage(Image componentImage)
        {
            this.componentImage = componentImage;
        }

        public Image getComponentImage()
        {
            return componentImage;
        }
    }
}
