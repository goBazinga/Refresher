using System;
using System.Collections.Generic;


namespace RefresherConsole
{
   
    public class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < list.Count; i++)
            {
                var diff = sum - list[i];
                int j = -1;

                if (dict.TryGetValue(diff, out j))
                {
                    return Tuple.Create<int, int>(j, i);
                }

                dict[list[i]] = i;
            }

            /*
            for (int i=0;i<list.Count;i++)
            {

                for(int j = i + 1; j<list.Count;j++)
                {

                    if(list[i] + list[j] == sum)
                        return new Tuple<int, int>(i,j);

                }           


            }
            */

            return null;
        }

    }
}
