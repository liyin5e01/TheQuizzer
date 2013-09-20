/*
 * Copyright 2013 Gregory M Chen
   This file is part of TheQuizzer.

    TheQuizzer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    TheQuizzer is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with TheQuizzer.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheQuizzer
{
    public class Entry
    {
        private string[] elementOne;
        private string[] elementTwo;

        public Entry(string[] elementOne, string[] elementTwo)
        {
            this.elementOne = elementOne;
            this.elementTwo = elementTwo;
            
        }

        public string[] getElementOne()
        {
            return elementOne;
        }
        public string[] getElementTwo()
        {
            return elementTwo;
        }
    }
}
