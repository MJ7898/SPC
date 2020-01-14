using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC.Components
{
   public abstract class Component
    {
        private string name;
        private string beschreibung;
        private string symbol;

        public Component()
        {

        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }
        public void setBeschreibung(String beschreibung)
        {
            this.beschreibung = beschreibung;
        }

        public String getBeschreibung()
        {
            return beschreibung;
        }

        public void setSymbol(String symbol)
        {
            this.symbol = symbol;
        }

        public String getSymbol()
        {
            return symbol;
        }
    }
}
