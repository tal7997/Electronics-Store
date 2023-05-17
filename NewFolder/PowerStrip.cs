using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.NewFolder
{
    class PowerStrip:Item
    {
        private int socketWhitOutSwich ;
        private static int numOfPowerstrip = 0;

        public static int NumOfPowerstrip { get => numOfPowerstrip; }

        public PowerStrip(int newSocket=2)//constructor
        {
            setSocketWhitOutSwich(newSocket);
            setPrice(newSocket * 5);//10-40
            setId(1000 + newSocket);//1002-1008
            numOfPowerstrip++;
        }
        public int getSocketWhitOutSwich()
        {
            return this.socketWhitOutSwich;
        }
        public void setSocketWhitOutSwich(int newSocket)
        {
            if(newSocket>0)
                this.socketWhitOutSwich = newSocket;
        }
        public override string ToString()
        {
            return "PowerStrip" + " price: " + getPrice() + " id: " + getId() +" socket: "+ getSocketWhitOutSwich() ;
        }

        public void print()
        {
            Console.WriteLine("Details of PowerStrip whit"+socketWhitOutSwich+"shocket is:\n"); 
            Console.WriteLine("The price is:"+this.getPrice());
        }
        public void printId()
        {
            Console.WriteLine("Details of PowerStrip whit" + socketWhitOutSwich + "shocket is:\n");
            Console.WriteLine("The Id is:" + this.getId());
            Console.WriteLine("The price is:" + this.getPrice());
            
        }
    }
}
