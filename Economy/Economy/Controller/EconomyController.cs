using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Economy.Model;

namespace Economy.Controller {
    class EconomyController {
        public string comment;
        public decimal amount;
        public WriteToTxt txt;
        public bool lockDate; 

        public EconomyController() {
            txt = new WriteToTxt();
            txt._personList.Add(new Person());
            lockDate = false;
        }

        public void AddPerson() {
            txt._personList.Add(new Person());

            lockDate = true;
        }

        public void AddToIndkomstList() {
            txt._personList.Last().indkomstList.Add(new Expense(comment, amount));
        }

        public void AddToMadList() {
            txt._personList.Last().madList.Add(new Expense(comment, amount));
        }

        public void AddToTransportList(){
            txt._personList.Last().transportList.Add(new Expense(comment, amount));
        }

        public void AddToDiverseList() {
            txt._personList.Last().diverseList.Add(new Expense(comment, amount));
        }

        public void AddToRegningerList() {
            txt._personList.Last().regningerList.Add(new Expense(comment, amount));
        }

        public void AddToFasteList() {
            txt._personList.Last().fasteList.Add(new Expense(comment, amount));
        }

        public void SetName(string userName) {
            txt._personList.Last().name = userName;
        }

        public void SetDate(string userDate) {
            txt.date = userDate;
        }

        public bool CheckNameAndDate(){
            if (string.IsNullOrEmpty(txt._personList.Last().name) || string.IsNullOrEmpty(txt.date))
                return false;
            else
                return true;
        }
    }
}
