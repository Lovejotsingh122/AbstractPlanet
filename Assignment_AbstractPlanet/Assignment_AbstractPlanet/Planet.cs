using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Lovejot Singh
 * Date: july 27,2017
 * Description: Ths is the abstract Planet class
 * */
namespace Assignment_AbstractPlanet
{
    public abstract class Planet
    {
        //Private variables (fields)
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //Public properties
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }
        public double Mass
        {
            get
            {
                return _mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructors
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._mass = mass;
            this._diameter = diameter;
        }
        public override string ToString()
        {
            string PlanetInfo = "The planet" + this.Name + "has the diameter :" + this.Diameter + "Kilometer and has mass: " + this.Mass + " x 10^24 kilograms.";
            Console.WriteLine(PlanetInfo);
            return PlanetInfo;
        }
    }
}