﻿using CoreNegocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoreSevices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "OpenServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione OpenServices.svc o OpenServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class OpenServices : IOpenServices
    {
        public bool ValidarUsuario(int user, string pass)
        {
            Login userLogin = new Login();
            userLogin.PERSONA_RUT = user;
            userLogin.PASSWORD = pass;
            Persona newPerson = userLogin.Read();

            if (newPerson != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ValidarLogin(string loginJson)
        {
            Login userLogin = new Login();
            userLogin = JsonConvert.DeserializeObject<Login>(loginJson);
            Persona newPerson = userLogin.Read();
            string userSerializado = JsonConvert.SerializeObject(newPerson);

            if (newPerson != null)
            {
                return userSerializado;
            }
            else
            {
                return null;
            }
        }
    }
}