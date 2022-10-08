using BasicCrud.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BasicCrud.Controllers
{
    public class ComputationController : Controller
    {
        private readonly IComputation _icomput;
        public ComputationController(IComputation icomputr)
        {
            _icomput = icomputr; 
        }
        public async Task<double> AddNumbers(int A, int B)
        {
            double result = await _icomput.Addition(A,B);

            return result;
        }
    }
}
