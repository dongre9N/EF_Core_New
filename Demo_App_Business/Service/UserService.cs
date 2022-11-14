using Demo_App_Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo_App_Business.Service
{
    public class UserService
    {


        private readonly UserDataContext _objContext;

        public UserService(UserDataContext objContext)
        {
            _objContext = objContext;
        }


        public IEnumerable<UserModel> GetUser()
        {
            var result = _objContext.Users.ToList();
            return result;
        }

        public IEnumerable<UserModel> GetUserById(int ID)
        {
            var result = _objContext.Users.Where(x => x.Id == ID);
            return result;
        }

        public void AddUser(UserModel userModel)
        {
            DateTime today = DateTime.Today;
            userModel.CreatedDate = today;
            userModel.LastUpdatedDate = today;
            userModel.CreatedBy = userModel.Name;
            var result = _objContext.Users.Add(userModel);
            _objContext.SaveChanges();
        }

        public void DeleteUser(int ID)
        {
            var result = _objContext.Users.Find(ID);
            if (result != null)
            {

                _objContext.Users.Remove(result);
                _objContext.SaveChanges();
            }
        }

        public void UpdateUser( UserModel model)
        {
            var result = _objContext.Users.Where(x => x.Id == model.Id);
            //var result = _objContext.Users.Find(model.Id);
            model.LastUpdatedDate = DateTime.Today;
            model.CreatedBy = model.Name;
            if (result != null)
            {
                _objContext.Users.Update(model);
                _objContext.SaveChanges();
            }

        }

    }
}
