using System;
namespace PrivateStudent
{
    public class Student
    {
        public string FullName;
        private string _groupNo;

        public string GroupNo {
            get { return this._groupNo; }
            set {
                if(!(string.IsNullOrWhiteSpace(value)) && value.Length == 5)
                {
                    bool check = false;
                    bool check1 = false;
                    foreach (var item in value)
                    {
                        if (char.IsLetter(item)) {
                            check = true;
                        }
                            

                        if (char.IsDigit(item)) {
                            check1 = true;
                        }
                            

                        if (check && check1) {
                            this._groupNo = value;
                        }
                            
                    }
                }
            }
        }
    }
}
