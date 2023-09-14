using HMS.Helpers;
using HMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Services.User
{
    public interface Iuser
    {
      //  public Task<ActionResult<ServiceResponse>> GetAll();
       // public Task<ActionResult<ServiceResponse>> Get(string id);
        public ServiceResponse<UserModel> Create(UserModel userModel);
       // public Task<ActionResult<ServiceResponse>> Update(string id);
    }
}
