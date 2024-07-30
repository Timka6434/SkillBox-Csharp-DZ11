using System.Collections.Generic;

namespace SkillBox_Csharp_DZ11.Models.Abstractions
{
    internal interface IManageClients
    {
        void CreateUser(AbstractClient client);
        void UpdateUser(int id, AbstractClient updatedClient);
        void DeleteUser(int id);
        void Show(int id);
        void ShowAll();
    }
}
