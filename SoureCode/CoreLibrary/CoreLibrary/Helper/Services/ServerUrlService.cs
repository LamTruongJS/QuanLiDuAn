using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Helper.Services
{
    public class ServerUrlService
    {
        public string ThumbnailUrl(string name) => "/respo/thumbnail/" + name;
        public string BookPdfUrl(string name) => "/respo/pdf/" + name;
        public string AvatarUrl(string name) => "/assets/img/user/" + name;
    }
}
