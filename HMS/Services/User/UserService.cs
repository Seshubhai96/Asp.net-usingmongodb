using HMS.Config;
using HMS.Helpers;
using HMS.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace HMS.Services.User
{
    public class UserService : Iuser
    {
        private readonly IMongoCollection<UserModel> _users;

        public UserService(IconfigHMS iconfig, IMongoClient mongoClient) {
          var database =  mongoClient.GetDatabase(iconfig.DatabaseName);
             _users = database.GetCollection<UserModel>(iconfig.CollectionName);

        }

        public ServiceResponse<UserModel> Create(UserModel id)
        {
            var response = new ServiceResponse<UserModel>();
            if(id != null)
            {
                _users.InsertOne(id);
                response.Data = id;
                response.Status = true;
                response.Message = "Created SucessFully";
                return response;
            }
            else
            {
                response.Data = null;
                response.Status = false;
                response.Message = "Something Went Wrong";
                return response;
            }
          
        }

        /*
public Task<ServiceResponse<UserModel>> Get(string id)
{
   throw new NotImplementedException();
}

public Task<ServiceResponse<>> GetAll()
{
   throw new NotImplementedException();
}

public Task<ServiceResponse<UserModel>> Update(string id)
{
   throw new NotImplementedException();
}
*/
    }
}
