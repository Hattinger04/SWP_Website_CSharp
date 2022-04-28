using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models.DB {
    
    // TODO: asynchrone Programmierung 
    // wichtig: es sollte immer gegen eine Schnittstelle (Interface, Basisklasse) programmiert werden
    //      => programm leichter wartbar, änderbar, testbar
    public interface IRepositoryUsers {
        Task ConnectAsync();
        Task DisconnectAsync();
        Task<bool> Insert(User user);
        Task<bool> Delete(int user_id);
        Task<bool> ChangeUserData(int userID, User newUserData);
        Task<List<User>> GetAllUsers();
        Task<User> Login(String username, String password);
        Task<bool> IsEmailExisting(String email);
        Task<User> GetUser(int id); 
        // weitere Methoden
    }
}
