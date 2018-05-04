using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;// Instalar en paquetes Nuget
using Newtonsoft.Json;// Instalar en paquetes Nuget

namespace ParcialTaller
{
    class UserManager
    {
        const String URL = "http://pastoral.iucesmag.edu.co/practica/listar.php";
        //const String URL = "http://localhost/practica/listar.php";

        private HttpClient getCliente()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Connection", "close");

            return client;
        }

        public async Task<IEnumerable<User>> getUsuarios()
        {
            HttpClient client = getCliente();
            var res = await client.GetAsync(URL);

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<User>>(content);
            }

            return Enumerable.Empty<User>();
        }


    }
}