﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webpage_Analyzation_WFA_V1
{
    class TimeCellHours
    {
        private int[] hours = new int[9];
        private int[] TTTPosition = new int[9];

        public TimeCellHours()
        {
            for (int i = 0; i < 9; i++)
            {
                Hours[i] = 0;
                TTTPosition1[i] = 0;
            }
        }

        public void TimeCellHoursMain()
        {
            
        }


        

        public int[] Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public int[] TTTPosition1
        {
            get
            {
                return TTTPosition;
            }

            set
            {
                TTTPosition = value;
            }
        }


        //private int nine;
        //private int ten;
        //private int eleven;
        //private int twelve;
        //private int one;
        //private int two;
        //private int three;
        //private int four;
        //private int five;

        //public TimeCellHours()
        //{
        //    nine = 0;
        //    ten = 0;
        //    eleven = 0;
        //    twelve = 0;
        //    one = 0;
        //    two = 0;
        //    three = 0;
        //    four = 0;
        //    five = 0;
        //}

        //public int Nine
        //{
        //    get
        //    {
        //        return nine;
        //    }

        //    set
        //    {
        //        nine = value;
        //    }
        //}

        //public int Ten
        //{
        //    get
        //    {
        //        return ten;
        //    }

        //    set
        //    {
        //        ten = value;
        //    }
        //}

        //public int Eleven
        //{
        //    get
        //    {
        //        return eleven;
        //    }

        //    set
        //    {
        //        eleven = value;
        //    }
        //}

        //public int Twelve
        //{
        //    get
        //    {
        //        return twelve;
        //    }

        //    set
        //    {
        //        twelve = value;
        //    }
        //}

        //public int One
        //{
        //    get
        //    {
        //        return one;
        //    }

        //    set
        //    {
        //        one = value;
        //    }
        //}

        //public int Two
        //{
        //    get
        //    {
        //        return two;
        //    }

        //    set
        //    {
        //        two = value;
        //    }
        //}

        //public int Three
        //{
        //    get
        //    {
        //        return three;
        //    }

        //    set
        //    {
        //        three = value;
        //    }
        //}

        //public int Four
        //{
        //    get
        //    {
        //        return four;
        //    }

        //    set
        //    {
        //        four = value;
        //    }
        //}

        //public int Five
        //{
        //    get
        //    {
        //        return five;
        //    }

        //    set
        //    {
        //        five = value;
        //    }
        //}
    }
}
