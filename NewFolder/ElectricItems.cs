using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    abstract class ElectricItems:Item
    {
        private int watt;
        private string color;
        private int yearsOfProduction;

        protected ElectricItems(double price, int id, int watt, string color, int yearOfProduction) : base(price, id)
        {
            setWatt(watt);
            setColor(color);
            setYear(yearOfProduction);
        }
        protected ElectricItems(int watt = 0, string color = "Black", int year = 2022)
        {
            setWatt(watt);
            setColor(color);
            setYear(year);
        }
        public int getWatt()
        {
            return this.watt;
        }
        public string getColor()
        {
            return this.color;
        }
        public int getYearsOfProduction()
        {
            return this.yearsOfProduction;
        }
        public void setWatt(int newWatt)
        {
            if(newWatt>0)
                this.watt = newWatt;
        }
        public void setColor(string newColor)
        {
            if(!string.IsNullOrWhiteSpace(newColor))
                this.color = newColor;
        }
        public void setYear(int newYear)
        {
            if(newYear > 2015 && newYear < 2023)
                this.yearsOfProduction = newYear;
        }

        public override string ToString()
        {
            return "ElectricTiem";
        }

    }
}
