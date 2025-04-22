using System.Collections.Generic;
using Tutorial4.Models;

namespace Tutorial4.Services
{
    public static class Database
    {
        public static List<Emp> GetEmps() => new List<Emp>
        {
            new Emp { EmpNo = 1, EName = "ALLEN", Job = "SALESMAN", DeptNo = 30, Sal = 1600, Comm = 300 },
            new Emp { EmpNo = 2, EName = "WARD", Job = "SALESMAN", DeptNo = 30, Sal = 1250, Comm = 500 },
            new Emp { EmpNo = 3, EName = "JONES", Job = "MANAGER", DeptNo = 20, Sal = 2975 },
            new Emp { EmpNo = 4, EName = "MARTIN", Job = "SALESMAN", DeptNo = 30, Sal = 1250, Comm = null }
        };

        public static List<Dept> GetDepts() => new List<Dept>
        {
            new Dept { DeptNo = 10, DName = "ACCOUNTING", Loc = "NEW YORK" },
            new Dept { DeptNo = 20, DName = "RESEARCH", Loc = "DALLAS" },
            new Dept { DeptNo = 30, DName = "SALES", Loc = "CHICAGO" }
        };

        public static List<Salgrade> GetSalgrades() => new List<Salgrade>
        {
            new Salgrade { Grade = 1, Losal = 700, Hisal = 1200 },
            new Salgrade { Grade = 2, Losal = 1201, Hisal = 1400 },
            new Salgrade { Grade = 3, Losal = 1401, Hisal = 2000 },
            new Salgrade { Grade = 4, Losal = 2001, Hisal = 3000 }
        };
    }
}
