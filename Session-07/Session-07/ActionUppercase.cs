using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionUppercase : ActionRequest {
        public string[]? stringOfWords { get; set; }

        //CONSTRUCTORS
        public ActionUppercase(string input, ActionEnum action) : base(input, action) {

        }
        //METHODS
        public override bool isValid() {

            stringOfWords = Input.Split(' ', '\t');
            if (stringOfWords.Length > 1) {
                return true;
            } else
                return false;
        }

        public override string Convertion() {

            int length = 0;
            string maxWord = "";
            foreach (string word in stringOfWords) {

                if (word.Length > length) {
                    maxWord = word;
                    length = word.Length;
                }
            }
            return maxWord.ToUpper();
        }


    }
}
