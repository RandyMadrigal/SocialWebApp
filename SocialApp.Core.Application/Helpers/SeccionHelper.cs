using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialApp.Core.Application.Helpers
{
    public static class SeccionHelper
    {
        //Guardar la informacion en la seccion
        public static void Set<T>(this ISession seccion, string key, T value)
        {
            seccion.SetString(key, JsonConvert.SerializeObject(value));
        }

        //Conseguir la data guardada en la seccion
        public static T Get<T>(this ISession seccion, string key)
        {
            var value = seccion.GetString(key);
            return value == null ? default : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
