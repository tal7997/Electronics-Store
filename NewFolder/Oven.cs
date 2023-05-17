namespace WinFormsApp1.NewFolder
{
    class Oven:ElectricItems
    {
        private int liters;
        private int maxHigh;

        public Oven(string color = "Black", int year = 2022 , int liter = 60, int newMaxHigh = 200): 
            base((liter * 20) + newMaxHigh, 4000 + liter + newMaxHigh, 3000, color, year)
        {
            setMaxHigh(newMaxHigh);
            setLiter(liter);
            switch (color)
            {
                case "Black":
                    setId(4000 + liter + newMaxHigh + 1);
                    break;
                case "White":
                    setId(4000 + liter + newMaxHigh + 2);
                    break;
                case "Grey":
                    setId(4000 + liter + newMaxHigh + 3);
                    break;
                default:
                    break;
            }
        }

        public int getLiter()
        {
            return this.liters;
        }
        public void setLiter(int newLiter)
        {
            if(newLiter>0)
                this.liters = newLiter;
        }
        public int getMaxHigh()
        {
            return this.maxHigh;
        }
        public void setMaxHigh(int newMaxHigh)
        {
            if(newMaxHigh>0)
                this.maxHigh = newMaxHigh;
        }

        public override string ToString()
        {
            return "Oven" + " price: " + getPrice() + " id: " + getId() + " color: " + getColor() + " watts: " + getWatt() + " year: " + getYearsOfProduction() + " litter: " + getLiter() + " maxHigh: " + getMaxHigh();
        }

    }
}
