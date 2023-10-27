using HealtCare.DAL.Data;
namespace HealtCare.WebAPI.Models

{
    public class Mapper
    {
        public UserModel MapEntityToModel(User user)
        {
            UserModel model = new UserModel();

            model.Id = user.Id;
            model.Name = user.UserName;
            model.Surname = user.Surname;
            model.Email = user.Email;

            return model;
        }


        public User MapModelToEntity(UserModel model)
        {
            User user = new User();

            user.UserName = model.Name;
            user.Surname= model.Surname;
            user.Email = model.Email;
            user.PasswordHash = model.Password.co;
        }

    }
}
