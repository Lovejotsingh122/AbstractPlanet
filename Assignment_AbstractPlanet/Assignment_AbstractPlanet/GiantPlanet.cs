using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /* Name: Lovejot Singh
 * Date: July 27, 2017
 * Description: This is the sub-class GiantPlanet of class Planet*/

namespace Assignment_AbstractPlanet
{

    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // private instant variables
        private string _type;
        //public properties
        public bool HasMoons()
        {
            if (MoonCount >0)
            {
                return true;
            }
            return false;
        }
        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //constructors
        public GiantPlanet(string name, double diameter, double mass, string type): base (name,diameter,mass)
        {
            this._type = type;
        }
    }
}
