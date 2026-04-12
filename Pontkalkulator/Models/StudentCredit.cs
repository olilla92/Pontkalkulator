using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Pontkalkulator.Models
{
    public class StudentCredit
    {
        public string _studentName;
        private string _neptunCode;
        private int _creditNumber;

        public StudentCredit() { }
        public StudentCredit(string studentName, string neptunCode, int creditNumber)
        {
            _studentName = studentName;
            _neptunCode = neptunCode;
            _creditNumber = creditNumber;
        }

        public string StudentName
        {
            get => _studentName;
            set => _studentName = value;
        }
        public string NeptunCode
        {
            get => _neptunCode;
            set => _neptunCode = value;
        }
        public int CreditNumber
        {
            get => _creditNumber;
            set => _creditNumber = value;
        }

        public void SetName (string newName)
        {
            if (newName == _studentName)
                throw new ArgumentException("Már ez a neved.");
            else if (!newName.Contains(" "))
                throw new ArgumentException("Nem adtál meg teljes nevet.");
            else
                _studentName = newName;
        }

        public void SetNeptunCode (string newCode)
        {
            if (string.IsNullOrEmpty(newCode)) throw new ArgumentException("Neptun kód nem lehet üres.");
            else
                _neptunCode = newCode;
        }

        public bool IsFinished()
        {
            if (_creditNumber >= 44)
                return true;
            else
                return false;
        }

        public int LeftCredit()
        {
            if (_creditNumber < 44)
                return 44 - _creditNumber;
            else
                return _creditNumber;
        }

        public int IncreaseCredit(int coursePoint)
        {
            if (coursePoint <= 0)
                throw new ArgumentOutOfRangeException("A kredit csak pozitív értékkel növelhető.");
            else
                return _creditNumber += coursePoint;
        }

        public void StartOfSemester(bool isStart)
        {
            if (isStart == true)
                _creditNumber = 0;
        }

        public override string ToString()
        {
            return $"{_studentName} - {_neptunCode} (kredit: {_creditNumber})";
        }
    }
}
