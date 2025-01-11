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
        public List<User> GetAll()
        {
            return _userRepository.GetList();
        }
        public User GetOne(int id)
        {
           return _userRepository.GetByid(id);
        }
        public bool Add(User user)
        {
            _userRepository.Post(user);
            return true;
        }
        public bool update(int id,User value)
        {
            _userRepository.Put(id,value);
            return true;
        }
        public void Remove(int id)
        {
            _userRepository.Delete(id);
           
        }
    }
}
