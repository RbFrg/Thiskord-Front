using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thiskord_Front.Models;

namespace Thiskord_Front.Services
{
    public class AuthService
    {
        // Simule un appel réseau
        public async Task<AuthModels> SimulateLoginAsync()
        {
            // Simulation d'attente réseau (1 seconde)
            await Task.Delay(1000);

            // Retourne une fausse réponse conforme au format attendu
            return new AuthModels
            {
                UserData = new Dictionary<string, string>
                {
                    { "user_name", "DevDiscord" },
                    { "user_mail", "dev@discord-clone.com" },
                    { "user_picture", "https://via.placeholder.com/150" }
                },
                ServerData = new Dictionary<string, int>
                {
                    { "fk_id_project", 42 }
                }
            };
        }
    }
}
