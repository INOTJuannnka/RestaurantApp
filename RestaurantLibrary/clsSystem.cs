using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    /// <summary>
    /// The clsSystem class represents the main system of the restaurant.
    /// It contains methods to manage the menu, tables, employers, and bills.
    /// </summary>
    public class clsSystem
    {
        /// <summary>
        /// The ClsMenu class represents a menu object, which is referenced by the MyMenu field.
        /// </summary>
        public clsMenu MyMenu;
        public List<clsTable> FldMyTable = new List<clsTable>();
        public List<clsEmployer> FldMyEmployer = new List<clsEmployer>();
        public List<clsBill> FldMyBill = new List<clsBill>();
        public clsMenu FldMenu;
        /// <summary>
        /// Creates a new menu with the given food names and prices.
        /// </summary>
        /// <param name="prmFoodName">The list of food names.</param>
        /// <param name="prmFoodPrice">The list of food prices.</param>
        public void createMenu(List<String> prmFoodName, List<double> prmFoorPrice)
        {
            FldMenu = new clsMenu(prmFoodName, prmFoorPrice);
        }
        /// <summary>
        /// Retrieves the list of food items in the menu.
        /// </summary>
        /// <returns>The list of food items.</returns>
        public List<String> getMenuFood()
        {
            return FldMenu.GetItemList();
        }
        /// <summary>
        /// Retrieves the list of food prices in the menu.
        /// </summary>
        /// <returns>The list of food prices.</returns>
        public List<Double> getMenuPrice()
        {
            return FldMenu.GetItemPrice();
        }
        /// <summary>
        /// Sets the state of a table with the given table number.
        /// </summary>
        /// <param name="prmTable">The table number.</param>
        /// <param name="prmState">The state to set for the table.</param>
        public void setTableState(int prmTable, int prmState)
        {
            FldMyTable[prmTable].SetTableState(prmState);
        }
        /// <summary>
        /// Retrieves the state of a table with the given table number.
        /// </summary>
        /// <param name="prmTable">The table number.</param>
        /// <returns>The state of the table.</returns>

        public int GetTableState(int prmTable)
        {
            return FldMyTable[prmTable].GetTableState();
        }
        /// <summary>
        /// Retrieves the ID of a table with the given table number.
        /// </summary>
        /// <param name="prmTable">The table number.</param>
        /// <returns>The ID of the table.</returns>

        public String GetFldTable(int prmTable)
        {
            return FldMyTable[prmTable].GetTableID();
        }
        /// <summary>
        /// Retrieves the ID of an employer with the given employer number.
        /// </summary>
        /// <param name="prmEmployer">The employer number.</param>
        /// <returns>The ID of the employer.</returns>
        public String GetFldEmployer(int prmEmployer)
        {
            try
            {
                return FldMyEmployer[prmEmployer].GetID();
            }
            catch (Exception)
            {

                return default(String);
            }

        }
        /// <summary>
        /// Creates a new table and adds it to the list of tables.
        /// </summary>
        /// <returns>True if the table creation is successful, false otherwise.</returns>

        public bool CreateTable()
        {
            Guid guid = Guid.NewGuid();
            clsTable table = new clsTable(guid.ToString(), 0);
            if (table != null)
            {
                FldMyTable.Add(table);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Creates a new table with the given table ID and state, and adds it to the list of tables.
        /// </summary>
        /// <param name="prmTableID">The ID of the table.</param>
        /// <param name="prmTableState">The state of the table.</param>

        public void CreateTable(String prmTableID, int prmTableState)
        {
            clsTable table = new clsTable(prmTableID, prmTableState);
            if (table != null)
            {
                FldMyTable.Add(table);
            }
        }
        /// <summary>
        /// Deletes the last table in the list of tables.
        /// </summary>
        /// <returns>True if the table deletion is successful, false otherwise.</returns>

        public bool DeleteTable()
        {
            FldMyTable.RemoveAt(FldMyTable.Count - 1);
            return true;
        }
        /// <summary>
        /// Upgrades the state of a table with the given table ID.
        /// </summary>
        /// <param name="ID">The ID of the table.</param>
        /// <param name="prmTableState">The new state to set for the table.</param>
        /// <returns>True if the table state upgrade is successful, false otherwise.</returns>

        public bool UpgradeTableState(string ID, int prmTableState)
        {
            Guid IDg = new Guid(ID);
            foreach (clsTable table in FldMyTable)
            {
                if (IDg.ToString().Equals(table.GetTableID().ToString()))
                {
                    table.SetTableState(prmTableState);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prmName"></param>
        /// <param name="prmLastname"></param>
        /// <returns></returns>
        public bool NewEmployer(string prmName, string prmLastname)
        {
            Guid guid = Guid.NewGuid();
            clsEmployer employer = new clsEmployer(guid.ToString(), prmName, prmLastname);
            if (employer != null)
            {
                FldMyEmployer.Add(employer);
                return true;
            }
            else
                return false;
        }
        public bool UpdateEmployer(string ID, string prmName, string prmLastName)
        {
            Guid IDg = new Guid(ID);
            foreach (clsEmployer employer in FldMyEmployer)
            {
                if (ID.ToString().Equals(employer.GetID().ToString()))
                {
                    employer.SetName(prmName);
                    employer.SetLastName(prmLastName);
                    return true;
                }
            }
            return false;
        }
        public bool DeleteEmployer(string ID)
        {
            Guid IDg = new Guid(ID);
            foreach (clsEmployer employer in FldMyEmployer)
            {
                if (IDg.ToString().Equals(employer.GetID().ToString()))
                {
                    FldMyEmployer.Remove(employer);
                    return true;
                }
            }
            return false;
        }

        public void GenerateBill(double prmBillAmount, List<string> prmBillItemList, List<double> prmBillPrice, string prmEmpID, string prmTableID)
        {
            Guid IDg = Guid.NewGuid();
            clsBill bill = new clsBill(IDg.ToString(), prmBillAmount, prmBillItemList, prmBillPrice, prmEmpID, prmTableID);
            if (bill != null)
            {
                FldMyBill.Add(bill);

            }
        }
        public void UpdateBill(int prmPos, double prmBillAmount, List<string> prmBillItemList, List<double> prmBillPrice,String prmEmpName)
        {
            Guid IDg = Guid.NewGuid();
            FldMyBill[prmPos].SetBillID(IDg.ToString());
            FldMyBill[prmPos].SetEmpID(prmEmpName);
            FldMyBill[prmPos].SetBillItemList(prmBillItemList);
            FldMyBill[prmPos].SetBillPrice(prmBillPrice);
            FldMyBill[prmPos].SetBillAmount(prmBillAmount);
        } 
        public clsBill GetFldMyBill(int prmPoss) { 
            return FldMyBill[prmPoss];
        }

        public List<clsBill> ShowBillHistory()
        {
            return FldMyBill;
        }

        public ArrayList clsTable;
        /// <summary>
        /// GetClsTable method 
        /// This method checks if the ArrayList is null, if it is, it creates a new instance of ArrayList object.
        /// </summary>
        /// <returns>returns an ArrayList of class ClsTable objects.</returns>
        public ArrayList GetClsTable()
        {
            if (clsTable == null)
                clsTable = new ArrayList();
            return clsTable;
        }
        /// <summary>
        /// SetClsTable method sets the ClsTable ArrayList object.
        /// An ArrayList object containing ClsTable elements
        /// </summary>
        /// <param name="newClsTable"></param>
        public void SetClsTable(ArrayList newClsTable)
        {
            RemoveAllClsTable();
            foreach (clsTable oClsTable in newClsTable)
                AddClsTable(oClsTable);
        }
        /// <summary>
        /// AddClsTable method adds a new ClsTable object to the clsTable ArrayList.
        /// A new ClsTable object to be added in clsTable ArrayList
        /// </summary>
        /// <param name="newClsTable"></param>
        public void AddClsTable(clsTable newClsTable)
        {
            if (newClsTable == null)
                return;
            if (clsTable == null)
                clsTable = new ArrayList();
            if (!clsTable.Contains(newClsTable))
                clsTable.Add(newClsTable);
        }
        /// <summary>
        /// AddClsTable method adds a new ClsTable object to the clsTable ArrayList.
        /// A new ClsTable object to be added in clsTable ArrayList
        /// </summary>
        /// <param name="oldClsTable"></param>
        public void RemoveClsTable(clsTable oldClsTable)
        {
            if (oldClsTable == null)
                return;
            if (clsTable != null)
                if (clsTable.Contains(oldClsTable))
                    clsTable.Remove(oldClsTable);
        }
        /// <summary>
        /// RemoveAllClsTable method removes all elements in the clsTable ArrayList.
        /// </summary>
        public void RemoveAllClsTable()
        {
            if (clsTable != null)
                clsTable.Clear();
        }
        public ArrayList employer;
        /// <summary>
        /// GetPersons method 
        /// This method checks if the ArrayList is null, if it is, it creates a new instance of ArrayList object.
        /// persons ArrayList object
        /// </summary>
        /// <returns>returns an ArrayList of class ClsEmployer objects.</returns>
        public ArrayList GetEmployer()
        {
            if (employer == null)
                employer = new ArrayList();
            return employer;
        }
        /// <summary>
        /// SetPersons method sets the Persons ArrayList object. 
        /// An ArrayList object containing ClsEmployer elements
        /// </summary>
        /// <param name="newPersons"></param>
        public void SetEmployer(ArrayList newPersons)
        {
            RemoveAllEmployer();
            foreach (clsEmployer oClsEmployer in newPersons)
                AddEmployer(oClsEmployer);
        }
        /// <summary>
        ///  AddPersons method adds a new ClsEmployer object to the persons ArrayList.
        /// A new ClsEmployer object to be added in persons ArrayList
        /// </summary>
        /// <param name="newClsEmployer"></param>
        public void AddEmployer(clsEmployer newClsEmployer)
        {
            if (newClsEmployer == null)
                return;
            if (employer == null)
                employer = new ArrayList();
            if (!employer.Contains(newClsEmployer))
                employer.Add(newClsEmployer);
        }
        /// <summary>
        /// RemovePersons method removes a specific ClsEmployer object from the persons ArrayList. 
        /// A ClsEmployer object to be removed from persons
        /// </summary>
        /// <param name="oldClsEmployer"></param>
        public void RemoveEmployer(clsEmployer oldClsEmployer)
        {
            if (oldClsEmployer == null)
                return;
            if (employer != null)
                if (employer.Contains(oldClsEmployer))
                    employer.Remove(oldClsEmployer);
        }
        /// <summary>
        /// The RemoveAllPersons() method removes all the persons from the list. If the persons list is null, the method does nothing.
        /// </summary>
        public void RemoveAllEmployer()
        {
            if (employer != null)
                employer.Clear();
        }

    }
}
