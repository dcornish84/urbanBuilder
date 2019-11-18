using System;

namespace Planner
{
    class Building
    {
        private string _designer = "David";

        private DateTime _dateConstructed;

        private string _address;

        private string _owner;

        public int Height { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * Stories;
            }
        }

        public Building(string address)
        {
            // address = "800 8th Street";
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public string Description
        {
            get
            {
                return $"Designed by {_designer} constructed on {_dateConstructed} {DateTime.Now} owned by {_owner}  {Volume} cubic meters of space";
            }
        }

    }

}