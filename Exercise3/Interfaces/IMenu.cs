using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Interfaces
{
    public interface IMenu
    {
        /// <summary>
        /// List the menu on the console
        /// </summary>
        void ShowMenu();

        /// <summary>
        /// Wait for, and capture, a menuItem
        /// </summary>
        void GetMenuItem();
    }
}
