using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;
using ZimmerArcitect.core.Repositories;
using ZimmerArcitect.core.Services;

namespace ZimmerArcitect.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository  _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _userRepository.GetListAsync();
        }
        public async Task<User> GetOneAsync(int id)
        {
           return await _userRepository.GetByidAsync(id);
        }
        public async Task<bool> AddAsync(User user)
        {
            await _userRepository.PostAsync(user);
            return true;
        }
        public bool update(int id,User value)
        {
            _userRepository.Put(id,value);
            return true;
        }
        public async Task<bool>RemoveAsync(int id)
        {
          return await _userRepository.DeleteAsync(id);
           
        }
    }
}
