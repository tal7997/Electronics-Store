namespace WinFormsApp1.NewFolder
{
    class Kettle:ElectricItems
    {
        private double liters;


        public Kettle(string color = "Black", int year = 2022 ,double liter = 1.7) : base((liter * 100) - 70, 3000 + (int)(liter * 100), 2000, color, year)
        {
            setLiter(liter);
            switch(color)
            {
                case "Black":
                    setId(3000 + (int)(liter * 100) + 1);
                    break;
                case "White":
                    setId(3000 + (int)(liter * 100) + 2);
                    break;
                case "Grey":
                    setId(3000 + (int)(liter * 100) + 3);
                    break;
                default:
                    break;
            }
        }

        public double getLiter()
        {
            return this.liters;
        }
        public void setLiter(double newLiter)
        {
            if(newLiter>=0)
                this.liters = newLiter;
        }
        public override string ToString()
        {
            return "Kettle" + " price: " + getPrice() + " id: " + getId() + " color: " + getColor() + " watts: " + getWatt() + " year: " + getYearsOfProduction() + " litter: " + getLiter();
        }
    }
}
