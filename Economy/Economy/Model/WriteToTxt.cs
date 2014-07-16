using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

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
                        file.WriteLine("\t" + list[i].comment.PadRight(30) + "\t" + list[i].amount);


                    }
                    file.WriteLine("");
                    categoryIndex++;
                }
                file.WriteLine("\n--------------------------");
            }

            file.WriteLine("");

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
