using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class clsTable
    {
        private string FldTableID;
        private int FldTableState;
        /// <summary>
        /// Initializes a new instance of the ClsTable class with the specified ID and state.
        /// </summary>
        /// <param name="prmTableID">The ID of the table.</param>
        /// <param name="prmTableState">The state of the table.</param>
        public clsTable(string prmTableID, int prmTableState)
        {
            FldTableID = prmTableID;
            FldTableState = prmTableState;
        }
        /// <summary>
        /// Returns the ID of the table.
        /// </summary>
        /// <param name="prmID">The ID of the table.</param>
        /// <returns>The ID of the table.</returns>
        public string GetTableID()
        {
            return FldTableID;
        }
        /// <summary>
        /// Returns the state of the table.
        /// </summary>
        /// <param name="prmState">The state of the table.</param>
        /// <returns>The state of the table.</returns>
        public int GetTableState()
        {
            // TODO: implement
            return FldTableState;
        }
        /// <summary>
        /// Sets the ID of the table.
        /// </summary>
        /// <param name="prmTableID">The ID to set.</param>
        /// <returns>True if the ID was set successfully, false otherwise.</returns>

        public bool SetTableID(string prmTableID)
        {
            FldTableID = prmTableID;
            if (FldTableID != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sets the state of the table.
        /// </summary>
        /// <param name="prmTableState">The state to set.</param>
        /// <returns>True if the state was set successfully, false otherwise.</returns>
        public bool SetTableState(int prmTableState)
        {
            FldTableState = prmTableState;
            if (FldTableState != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
