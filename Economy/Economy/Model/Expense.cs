using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Model {
    class Expense {
        public string comment;
        public decimal amount;

        public Expense(string comment, decimal amount) {
            this.amount = amount;
            this.comment = comment;
        }
    }
}
