using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class clsMenu
    {
        private List<string> FldItemList;
        private List<double> FldItemPrice;
        /// <summary>
        /// Initializes a new instance of the ClsEmployer class.
        /// </summary>


        /// <summary>
        /// ClsMenu(List prmItemList)
        /// This method creates a new instance of the ClsMenu class that contains the list of items provided as input.
        /// </summary>
        /// <param name="prmItemList"></param>
        public clsMenu(List<string> prmItemList, List<double> fldItemPrice)
        {
            FldItemList = prmItemList;
            FldItemPrice = fldItemPrice;
        }
        /// <summary>
        /// GetItemList()
        /// </summary>
        /// <returns>This method returns the list of items stored in the ClsMenu object.</returns>
        public List<string> GetItemList()
        {
            return FldItemList;
        }
        public List<double> GetItemPrice() { return FldItemPrice; }
        /// <summary>
        /// SetItemList(List prmItemList)
        /// This method sets a new list of items for the ClsMenu object.
        /// </summary>
        /// <param name="prmItemList"></param>
        /// <returns>If the new list is not null, the method returns true. Otherwise, it returns false.</returns>
        public bool SetItemList(List<string> prmItemList)
        {
            FldItemList = prmItemList;
            if (FldItemList != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ArrayList clsBill;
        /// <summary>
        /// GetClsBill()
        /// This method returns the bill stored in the ClsMenu object as an ArrayList object.
        /// </summary>
        /// <returns></returns>
        public ArrayList GetClsBill()
        {
            if (clsBill == null)
                clsBill = new ArrayList();
            return clsBill;
        }
        /// <summary>
        /// SetClsBill(System.Collections.ArrayList newClsBill)
        /// This method sets a new bill for the ClsMenu object. 
        /// </summary>
        /// <param name="newClsBill"></param>
        public void SetClsBill(ArrayList newClsBill)
        {
            RemoveAllClsBill();
            foreach (clsBill oClsBill in newClsBill)
                AddClsBill(oClsBill);
        }
        /// <summary>
        /// AddClsBill(ClsBill newClsBill)
        /// This method adds a new ClsBill object to the bill stored in the ClsMenu object, if the object is not null and not already in the bill.
        /// </summary>
        /// <param name="newClsBill"></param>
        public void AddClsBill(clsBill newClsBill)
        {
            if (newClsBill == null)
                return;
            if (clsBill == null)
                clsBill = new ArrayList();
            if (!clsBill.Contains(newClsBill))
                clsBill.Add(newClsBill);
        }
        /// <summary>
        /// RemoveClsBill(ClsBill oldClsBill)
        /// This method removes a ClsBill object from the bill stored in the ClsMenu object, if the object is not null and exists in the bill.
        /// </summary>
        /// <param name="oldClsBill"></param>
        public void RemoveClsBill(clsBill oldClsBill)
        {
            if (oldClsBill == null)
                return;
            if (clsBill != null)
                if (clsBill.Contains(oldClsBill))
                    clsBill.Remove(oldClsBill);
        }
        /// <summary>
        /// RemoveAllClsBill()
        /// This method removes all the ClsBill objects from the bill stored in the ClsMenu object.
        /// </summary>
        public void RemoveAllClsBill()
        {
            if (clsBill != null)
                clsBill.Clear();
        }
    }
}
