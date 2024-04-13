using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Shell_App.Models.ViewModels
{
    public partial class UserModelView : ObservableObject
    {
        private readonly UserRepository _repository;

        [ObservableProperty]
        private ObservableCollection<User> users;

        [ObservableProperty]
        private User currentUser = new();
        public UserModelView(UserRepository repository)
        {
            _repository = repository;
            Task.Run(async () => Users = new ObservableCollection<User>(await _repository.GetAllUsers()));
        }

        [RelayCommand]
        public async Task AddUser()
        {
            bool is_exist = false;
            foreach (var user in Users)
            {
                if(user.Id == CurrentUser.Id)
                {
                    is_exist = true;
                    Users.RemoveAt(CurrentUser.Id - 1);
                    Users.Insert(CurrentUser.Id - 1, CurrentUser);
                    await _repository.Update(new User
                    {
                        Id = CurrentUser.Id,
                        Name = CurrentUser.Name,
                    });
                    break;
                }
            }
            if (!is_exist)
            {
                await _repository.Create(CurrentUser);
                Users.Add(CurrentUser);
            }
            CurrentUser = new();
        }

        [RelayCommand]
        public async Task DeleteUser()
        {
            await _repository.Delete(CurrentUser);
            Users.RemoveAt(CurrentUser.Id - 1);
        }
    }
}
