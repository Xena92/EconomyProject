using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Economy.Controller;

namespace Economy.Model {
    public class WriteToTxt {
        public List<Person> _personList;
        public string date;

        public WriteToTxt() {
            _personList = new List<Person>();
        }


        public void WriteToFile() {
            string fileName = "C:\\Economy\\" + date + ".txt";
            int categoryIndex;
            List<List<Expense>> expensesList = new List<List<Expense>>();


            List<string> categoryList = new List<string>{
                "Indkomst:", "Mad:", "Transport:", "Diverse:", "Regninger:", "Øvrige faste:"
            };

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            foreach (Person person in _personList) {
                file.WriteLine(person.name);
                CollectExpenses(expensesList, person);
                categoryIndex = 0;

                foreach (List<Expense> list in expensesList) {
                    file.WriteLine(categoryList[categoryIndex]);
                    decimal collected = 0;

                    for (int i = 0; i < list.Count; i++) {
                        file.WriteLine("\t" + list[i].comment.PadRight(30) + "\t" + list[i].amount);
                        collected += list[i].amount;

                    }

                    file.WriteLine("");
                    person.categoryExpensesList.Add(collected);
                    file.WriteLine("Total for {0} {1}", categoryList[categoryIndex], collected);
                    categoryIndex++;
                    file.WriteLine("");

                }
                
                file.WriteLine("\n--------------------------");
                
            }

            for (int i = 0; i < categoryList.Count; i++)
            {
                decimal personTotal = 0;
                foreach(Person person in _personList) {
                    personTotal += person.categoryExpensesList[i];
                }
                file.WriteLine("Total for {0} {1}", categoryList[i], personTotal);
            }


            file.WriteLine("");

            decimal totalIncome = 0, totalOutcome = 0;
            foreach (Person person in _personList)
            {
                for (int i = 0; i < person.categoryExpensesList.Count; i++ )
                {
                    if (i == 0)
                        totalIncome += person.categoryExpensesList[i];
                    else
                        totalOutcome += person.categoryExpensesList[i];
                }
            }

            file.WriteLine("Total indkomst: {0}",totalIncome);
            file.WriteLine("Total udgift: {0} ", totalOutcome);
            file.WriteLine("Forskel: {0}", totalIncome - totalOutcome);
            file.Close();
        }

        private void CollectExpenses(List<List<Expense>> expensesList, Person person) {
            expensesList.Clear();
                expensesList.Add(person.indkomstList);
                expensesList.Add(person.madList);
                expensesList.Add(person.transportList);
                expensesList.Add(person.diverseList);
                expensesList.Add(person.regningerList);
                expensesList.Add(person.fasteList);
        }

        private void CollectedResults(List<Expense> expensesList)
        {
            for (int i = 0; i < expensesList.Count; i++)
            {

            }
        }
    }
}
