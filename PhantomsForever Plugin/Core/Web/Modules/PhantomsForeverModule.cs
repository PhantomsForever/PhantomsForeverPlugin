using Nancy;
using Nancy.Json;
using PhantomsForever_Plugin.Core.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhantomsForever_Plugin.Core.Web.Modules
{
    public class PhantomsForeverModule : NancyModule
    {
        public PhantomsForeverModule() : base("/phantomsforever")
        {
            Get("/OnlineConfigService.svc/GetOnlineConfig", args =>
            {
                return "[{\"Name\":\"SandboxUrl\",\"Values\":[\"prudp:\\/ address = lb - pdc - 81.165.113.171; port = 22700\"]}]";
            });
            Get("/Version/PDC-Live_Packages.txt", args =>
            {
                return "";
            });
            Get("/updater/UtcNow", args =>
            {
                return DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'");
            });
            Get("/updater/GetValues/LauncherConfig@", args =>
            {
                var serializer = new JavaScriptSerializer();
                var config = new List<Configuration>();
                config.Add(new Configuration()
                {
                    Key = "UtcNow",
                    Value = DateTime.UtcNow.ToString("yyyy-MM-dd'T'HH:mm:ss")
                });
                config.Add(new Configuration()
                {
                    Key = "RequestStatus",
                    Value = "OK"
                });
                return serializer.Serialize(config);
            });
            Get("/updater/GetValues/LauncherConfig_DownloadType", args =>
            {
                return "";
            });
            Get("/updater/GetValues/eula_ubisoft", args =>
            {
                return "";
            });
            Get("/updater/GetValues/LauncherConfig_CanSeedInLobby", args =>
            {
                var serializer = new JavaScriptSerializer();
                var config = new List<Configuration>();
                config.Add(new Configuration()
                {
                    Key = "LauncherConfig_CanSeedInLobby",
                    Value = Convert.ToString(true)
                });
                config.Add(new Configuration()
                {
                    Key = "RequestStatus",
                    Value = "OK"
                });
                return serializer.Serialize(config);
            });
            Get("/LauncherWeb/main_*.html", args =>
            {
                return "";
            });
            Get("/redirect/uat.html", args =>
            {
                return "";
            });
            Post("loginservice/Login.svc/json/login", args =>
            {
                using (var sr = new StreamReader(this.Context.Request.Body))
                {
                    var serializer = new JavaScriptSerializer();
                    var response = new CredentialsResponse()//TODO implement authentication
                    {
                        Username = sr.ReadLine(),
                        Token = new List<int>() { 1, 1, 1, 1, 1, 1, 1}
                    };
                    return serializer.Serialize(response);
                }
            });
            Post("/grp-login/json/login", args =>
            {
                using (var sr = new StreamReader(this.Context.Request.Body))
                {
                    var serializer = new JavaScriptSerializer();
                    var response = new CredentialsResponse()//TODO implement authentication
                    {
                        Username = sr.ReadLine(),
                        Token = new List<int>() { 1, 1, 1, 1, 1, 1, 1 }
                    };
                    return serializer.Serialize(response);
                }
            });
        }
    }
}