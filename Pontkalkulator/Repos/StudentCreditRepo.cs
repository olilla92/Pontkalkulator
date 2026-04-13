using Pontkalkulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pontkalkulator.Repos
{
    public class StudentCreditRepo
    {
        private List<StudentCredit> _record = new()
        {
            new StudentCredit("Kiss Anna", "1.", 46),
            new StudentCredit("Nagy Péter", "2.", 44),
            new StudentCredit("Tóth Eszter", "3.", 38),
            new StudentCredit("Varga Máté", "4.", 27),
            new StudentCredit("Szabó Lili", "5.", 41),
        };

        public IReadOnlyList<StudentCredit> GetAll()
        {
            return _record.ToList();
        }

        public int CountIsFinished => _record.Where(x => x.CreditNumber >= 44).Count();

        public IReadOnlyList<StudentCredit> CountIsNotFinished()
        {
            return _record.Where(x => x.CreditNumber < 44).ToList();
        }

        public List<string> LeftCreditsNameList()
        {
            return _record.Where(x => x.CreditNumber < 44).Select(x => x.StudentName).ToList();
        }

    }
}
