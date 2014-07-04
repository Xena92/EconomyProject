using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economy.Model {
    class Person {
        public string name;

        private Dictionary<decimal, string> _indkomstDic;
        private Dictionary<decimal, string> _madDic;
        private Dictionary<decimal, string> _transportDic;
        private Dictionary<decimal, string> _diverseDic;
        private Dictionary<decimal, string> _regningerDic;
        private Dictionary<decimal, string> _fasteDic;


        public Person() {
            _indkomstDic = new Dictionary<decimal, string>();
            _madDic = new Dictionary<decimal, string>();
            _transportDic = new Dictionary<decimal, string>();
            _diverseDic = new Dictionary<decimal, string>();
            _regningerDic = new Dictionary<decimal, string>();
            _fasteDic = new Dictionary<decimal, string>();
        }


    }
}
