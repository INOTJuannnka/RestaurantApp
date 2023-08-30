    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantLibrary
{
    public class clsBill
    {
        /// <summary>
        /// Variables:
        /// ClsTable clsTableB
        /// Description: Represents a table object that is associated with this bill object.
        /// int FldBillID
        /// Description: Represents the bill ID.
        /// float FldBillAmount
        /// Description: Represents the bill amount.
        /// List FldBillItemList
        /// Description: Represents the bill items list.
        /// Table FldTable
        /// Description: Represents the associated table object.
        /// int FldEmpID
        /// Description: Represents the employee ID.
        /// </summary>
        protected string FldBillID;
        private double FldBillAmount;
        private List<string> FldBillItemList;
        private List<double> FldBillItemPrice;
        private string FldEmpID;
        private string FldTableID;
        /// <summary>
        /// ClsBill(int prmBillID, float prmBillAmount, List prmBillItemList, int prmEmpID)
        /// Description: Initializes a new instance of the ClsBill class with the specified bill ID, bill amount, bill items list, and employee ID. 
        /// Parameters:
        /// prmBillID: an integer representing the bill ID.
        /// prmBillAmount: a float representing the bill amount.
        /// prmBillItemList: a list of strings representing the bill items list.
        /// prmEmpID: an integer representing the employee ID.
        /// </summary>
        /// <param name="prmBillID"></param>
        /// <param name="prmBillAmount"></param>
        /// <param name="prmBillItemList"></param>
        /// <param name="prmEmpID"></param>
        /// <returns></returns>
        public clsBill(string prmBillID, double prmBillAmount, List<string> prmBillItemList,List<double> prmBillPrice, string prmEmpID, string prmTableID)
        {
            FldBillID = prmBillID;
            FldBillAmount = prmBillAmount;
            FldBillItemList = prmBillItemList;
            FldEmpID = prmEmpID;
            FldTableID = prmTableID;
            FldBillItemPrice = prmBillPrice;
        }
        /// <summary>
        /// int GetBillID()
        /// Description: Returns the bill ID.
        /// </summary>
        /// <returns>an integer representing the bill ID.</returns>
        public string GetBillID()
        {
            return FldBillID;
        }

        /// <summary>
        /// float GetBillAmount()
        /// Description: Returns the bill amount.
        /// </summary>
        /// <returns>a float representing the bill amount</returns>
        public double GetBillAmount()
        {
            return FldBillAmount;
        }
        /// <summary>
        /// List GetBillItemList()
        /// Description: Returns the bill items list.
        /// </summary>
        /// <returns>a list of strings representing the bill items list.</returns>
        public List<string> GetBillItemList()
        {
            return FldBillItemList;
        }
        public List<double> GetBillItemPrice()
        {
            return FldBillItemPrice;
        }

        /// <summary>
        /// int GetEmpID()
        /// Description: Returns the employee ID.
        /// </summary>
        /// <returns>an integer representing the employee ID.</returns>
        public string GetEmpID()
        {
            return FldEmpID;
        }
        /// <summary>
        /// bool SetBillID(int prmBillID)
        /// Description: Sets the bill ID with the specified value.
        /// Parameters:
        /// prmBillID: an integer representing the bill ID. 
        /// </summary>
        /// <param name="prmBillID"></param>
        /// <returns>a boolean indicating whether the operation was successful.</returns>
        public bool SetBillID(string prmBillID)
        {
            FldBillID = prmBillID;
            if (FldBillID != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// bool SetBillAmount(float prmBillAmount)
        /// Description: Sets the bill amount with the specified value.
        /// Parameters:
        /// prmBillAmount: a float representing the bill amount. 
        /// </summary>
        /// <param name="prmBillAmount"></param>
        /// <returns>a boolean indicating whether the operation was successful.</returns>
        public bool SetBillAmount(double prmBillAmount)
        {
            FldBillAmount = prmBillAmount;
            if (FldBillAmount != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// bool SetBillItemList(List prmBillItemList)
        /// Description: Sets the bill items list with the specified value.
        /// Parameters:
        /// prmBillItemList: a list of strings representing the bill items list. 
        /// </summary>
        /// <param name="prmBillItemList"></param>
        /// <returns>a boolean indicating whether the operation was successful.</returns>
        public bool SetBillItemList(List<string> prmBillItemList)
        {
            FldBillItemList = prmBillItemList;
            if (FldBillItemList != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetBillPrice(List<double> prmBillPrice)
        {
            FldBillItemPrice= prmBillPrice;
        }
        /// <summary>
        /// bool SetEmpID(int prmEmpID)
        /// Description: Sets the employee ID with the specified value.
        /// Parameters:
        /// prmEmpID: an integer representing the employee ID.
        /// </summary>
        /// <param name="prmEmpID"></param>
        /// <returns>a boolean indicating whether the operation was successful.</returns>
        public bool SetEmpID(string prmEmpID)
        {
            FldEmpID = prmEmpID;
            if (FldEmpID != null)
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
