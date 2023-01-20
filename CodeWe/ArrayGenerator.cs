using System;
using System.Collections.Generic;

namespace BaseArray
{
    class ArrHelper
    {
        private List<List<int>> list;
        private Random random;

        public ArrHelper()
        {
            list = new List<List<int>>();
            random = new Random();
        }
        public List<List<int>> ArrayHelper
        {
            get { return this.list; }
        }

        public void createList(int x = 3, int y = 4, int min = 10, int max = 40)
        {
            for (int i = 0; i < x; i++)
            {
                list.Add(new List<int>());
                for (int j = 0; j < y; j++)
                {
                    list[i].Add(random.Next(min, max + 1));
                }
            }
        }

        public void printList()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                for (int j = 0; j < this.list[i].Count; j++)
                {
                    Console.Write(this.list[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void getSize()
        {
            Console.WriteLine("size: " + this.list.Count);
        }

        public void getMax()
        {
            int maxItem = this.list[0][0];
            for (int i = 0; i < this.list.Count; i++)
            {
                for (int j = 0; j < this.list[0].Count; j++)
                {
                    if (list[i][j] > maxItem)
                    {
                        maxItem = list[i][j];
                    }
                }
            }
            Console.WriteLine("max: " + maxItem);
        }

        public void getMin()
        {
            int minItem = this.list[0][0];
            for (int i = 0; i < this.list.Count; i++)
            {
                for (int j = 0; j < this.list[0].Count; j++)
                {
                    if (list[i][j] < minItem)
                    {
                        minItem = list[i][j];
                    }
                }
            }
            Console.WriteLine("min: " + minItem);
        }

        public void find(int number)
        {
            bool searchValue = false;
            for (int i = 0; i < this.list.Count; i++)
            {
                for (int j = 0; j < this.list[0].Count; j++)
                {
                    if (number == list[i][j])
                    {
                        searchValue = true;
                    }
                }
            }
            Console.WriteLine("Find: " + searchValue);
        }
    }

  }
