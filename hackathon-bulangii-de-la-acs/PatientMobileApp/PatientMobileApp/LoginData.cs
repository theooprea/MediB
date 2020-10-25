using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientMobileApp
{
    // clasa care retine datele pentru logare
    public class LoginData
    {
        [JsonProperty("Usercode")]
        public string Usercode { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }

    }
}
