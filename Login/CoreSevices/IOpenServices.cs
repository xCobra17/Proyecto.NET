﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CoreSevices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOpenServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOpenServices
    {
        [OperationContract]
        bool ValidarUsuario(string username, string password);

        [OperationContract]
        string ValidarLogin(string loginJson);
    }
}
