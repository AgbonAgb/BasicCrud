using BasicCrud.Repository;
using System.Threading.Tasks;

namespace BasicCrud.Services
{
    public class ComputationService : IComputation
    {
        public ComputationService()
        {

        }
        public async Task<double> Addition(int A, int B)
        {
            throw new System.NotImplementedException();
        }

        public async Task<double> Multiplication(int A, int B)
        {
            throw new System.NotImplementedException();
        }

        public async Task<double> Subtraction(int A, int B)
        {
            throw new System.NotImplementedException();
        }
    }
}
