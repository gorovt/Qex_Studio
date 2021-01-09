/*   Qex Studio License
*******************************************************************************
*                                                                             *
*    Copyright (c) 2017-2021 Luciano Gorosito <lucianogorosito@hotmail.com>   *
*                                                                             *
*    This file is part of Qex Studio                                          *
*                                                                             *
*    Qex Studio is free software: you can redistribute it and/or modify       *
*    it under the terms of the GNU General Public License as published by     *
*    the Free Software Foundation, either version 3 of the License, or        *
*    (at your option) any later version.                                      *
*                                                                             *
*    Qex Studio is distributed in the hope that it will be useful,            *
*    but WITHOUT ANY WARRANTY; without even the implied warranty of           *
*    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the            *
*    GNU General Public License for more details.                             *
*                                                                             *
*    You should have received a copy of the GNU General Public License        *
*    along with this program.  If not, see <https://www.gnu.org/licenses/>.   *
*                                                                             *
*******************************************************************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Qex
{
    public static class GoroTimer
    {
        static System.Timers.Timer _timer;
        static ToolStripStatusLabel _label1;
        static ToolStripStatusLabel _label2;

        public static void Start(ToolStripStatusLabel label1, ToolStripStatusLabel label2)
        {
            _label1 = label1;
            _label2 = label2;
            _timer = new System.Timers.Timer(3000); // Set up the timer for 3 seconds
            _timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            _timer.Enabled = true; // Enable it
        }
        public static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _label1.Image = null;
            _label2.Text = "";
        }
    }
}
