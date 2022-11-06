using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSLibrary {
    public class JsAppException : Exception {
        public int ErrorNumber = -1;
        public string SQL = null;
        public JsAppException(string message) : base(message) { }
        public JsAppException(string message, int ErrorNumber) : base(message) {
            this.ErrorNumber = ErrorNumber;
        }
        public JsAppException(string message, int ErrorNumber, string SQL) : base(message) {
            this.ErrorNumber = ErrorNumber;
            this.SQL = SQL;
            //
            //
            //
        }
    }
}
