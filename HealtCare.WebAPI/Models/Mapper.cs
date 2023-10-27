using HealtCare.DAL.Data;
namespace HealtCare.WebAPI.Models

{
    public class Mapper
    {
        public UserModel MapperEntityToModel(User user)
        {
            UserModel model = new UserModel();

            model.Id = user.Id;
            model.Name = user.UserName;
            model.Surname = user.Surname;
            model.Email = user.Email;

            return model;
        }

    }
}
