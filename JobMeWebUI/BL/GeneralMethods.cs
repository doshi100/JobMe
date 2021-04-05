using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;


namespace BL
{
    public class GeneralMethods
    {
        /// <summary>
        /// sets the DBpath for the DB connection string
        /// </summary>
        static public void SetDBPath(string path)
        {
            Constants c = new Constants(path);
        }
    }
}
