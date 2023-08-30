using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class clsEmployer
    {
        /// <summary>
        /// Represents the assigned tasks of the employer.
        /// </summary>

        public ArrayList Assigned;
        private string FldID;
        private string FldName;
        private string FldLastName;
        /// <summary>
        /// Initializes a new instance of the ClsEmployer class.
        /// </summary>


        public clsEmployer()
        {
        }
        public clsEmployer(string fldID, string fldName, string fldLastName)
        {
            FldID = fldID;
            FldName = fldName;
            FldLastName = fldLastName;
        }

        /// <summary>
        /// Sets the ID of the employer.
        /// </summary>
        /// <param name="prmID">An integer representing the ID of the employer.</param>
        /// <returns>True if the ID was successfully set, false otherwise.</returns>
        public bool SetID(string prmID)
        {
            FldID = prmID;
            if (FldID != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sets the name of the employer.
        /// </summary>
        /// <param name="prmName">A string representing the name of the employer.</param>
        /// <returns>True if the name was successfully set, false otherwise.</returns>

        public bool SetName(string prmName)
        {
            FldName = prmName;
            if (FldName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Sets the last name of the employer.
        /// </summary>
        /// <param name="prmLastName">A string representing the last name of the employer.</param>
        /// <returns>True if the last name was successfully set, false otherwise.</returns>

        public bool SetLastName(string prmLastName)
        {
            FldLastName = prmLastName;
            if (FldLastName != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Returns the ID of the employer.
        /// </summary>
        /// <returns>An integer representing the ID of the employer.</returns>

        public string GetID()
        {
            return FldID;
        }
        /// <summary>
        /// Returns the name of the employer.
        /// </summary>
        /// <returns>A string representing the name of the employer.</returns>

        public string GetName()
        {
            return FldName;
        }
        /// <summary>
        /// Returns the last name of the employer.
        /// </summary>
        /// <returns>A string representing the last name of the employer.</returns>

        public string GetLastName()
        {
            return FldLastName;
        }
    }
}
