

namespace DVLD_Data
{
    public interface IValidatable
    {
        bool IsValid(out string ErrorMessage);
    }
}
