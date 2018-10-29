﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        static public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        static public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Level.low)
            {
                return 12.5;
            }
            else if (amulet.Quality == Level.high)
            {
                return 27.5;
            }
            else
            {
                return 20.0;
            }
        }

        static public double GetValueOfCourse(Course course)
        {
            double Nr = course.DurationInMinutes % 60;
            if (Nr >= 30)
            {
                return (course.DurationInMinutes / 60 + 1) * 875.00;
            }
            else
            {
                return (course.DurationInMinutes / 60) * 875.00;
            }
        }

    }
}