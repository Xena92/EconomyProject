using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Model {
    public class Person {
        public string name;

        public List<Expense> indkomstList;
        public List<Expense> madList;
        public List<Expense> transportList;
        public List<Expense> diverseList;
        public List<Expense> regningerList;
        public List<Expense> fasteList;
        public List<decimal> categoryExpensesList;


        public Person(string name) {
            this.name = name;

            indkomstList = new List<Expense>();
            madList = new List<Expense>();
            transportList = new List<Expense>();
            diverseList = new List<Expense>();
            regningerList = new List<Expense>();
            fasteList = new List<Expense>();
            categoryExpensesList = new List<decimal>();
        }


    }
}
