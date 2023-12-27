using MinimalCouponAPI.Models.DTO;

namespace MinimalCouponAPI.Repository.IRepository
{
    public interface IAuthRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO requestDTO);
    }
}
