using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    
    public class TrainComposition
    {

        public static List<int> lstWagon = new List<int>();
        private LinkedList<int> Wagons = new LinkedList<int>();  // Faster then ordinarie list

        public void AttachWagonFromLeft(int wagonId)
        {
            Wagons.AddFirst(wagonId);
            lstWagon.Add(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            Wagons.AddLast(wagonId);
            lstWagon.Insert(0, wagonId);
        }

        public int DetachWagonFromLeft()
        {

            var wagon = Wagons.First.Value;
            Wagons.RemoveFirst();
            //return wagon;

            int r = lstWagon[lstWagon.Count - 1];
            lstWagon.RemoveAt(lstWagon.Count - 1);

            return r;
        }

        public int DetachWagonFromRight()
        {
            var wagon = Wagons.Last.Value;
            Wagons.RemoveLast();
            //return wagon;

            int r = lstWagon[0];

            lstWagon.RemoveAt(0);

            return r;
        }
    }


}