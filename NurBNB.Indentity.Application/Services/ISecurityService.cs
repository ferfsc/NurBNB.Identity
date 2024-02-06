
using NurBnb.Identity.Application.Dto;

namespace NurBnb.Identity.Application.Services;

public interface ISecurityService
{
    Task<Result<string>> Login(string username, string password);

    Task<Result> Register(RegisterAplicationUserModel model, bool isAdmin, bool emailConfirmationRequired);
}
