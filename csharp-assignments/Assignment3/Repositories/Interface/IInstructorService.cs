using Assignment3.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Repositories.Interface
{
    public interface IInstructorService : IPersonService
    {
        decimal CalculateBonus();
    }
}
