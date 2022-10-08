using System.Threading.Tasks;

namespace BasicCrud.Repository
{
    public interface IComputation
    {

        Task<double> Addition(int A, int B);
        Task<double> Subtraction(int A, int B);
        Task<double> Multiplication(int A, int B);
    }
}
