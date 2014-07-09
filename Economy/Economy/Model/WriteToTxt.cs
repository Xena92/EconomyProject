using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Economy.Model {
    class WriteToTxt {
        public List<Person> _personList;
        public string date;

        public WriteToTxt() {
            _personList = new List<Person>();
        }


        public void WriteToFile() {
            string fileName = "C:\\Users\\bruger\\Documents\\Economy\\" + date + ".txt";
            int categoryIndex;
            List<List<Expense>> expensesList = new List<List<Expense>>();


            List<string> category = new List<string>{
                "Indkomst:", "Mad:", "Transport:", "Diverse:", "Regninger:", "Øvrige faste:"
            };

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileName);
            foreach (Person person in _personList) {
                file.WriteLine(person.name);
                CollectExpenses(expensesList, person);
                categoryIndex = 0;

                foreach (List<Expense> list in expensesList) {
                    file.WriteLine(category[categoryIndex]);
                    for (int i = 0; i < list.Count; i++) {
                        file.WriteLine(list[i].comment + "\t\t" + list[i].amount);


                    }
                    file.WriteLine("");
                    categoryIndex++;
                }
                file.WriteLine("");
            }

            file.WriteLine();

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
    }
}
