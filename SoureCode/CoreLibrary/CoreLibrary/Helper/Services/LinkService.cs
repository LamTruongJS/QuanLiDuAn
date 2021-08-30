using CoreLibrary.Areas.Reader.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreLibrary.Helper.Services
{
    public class LinkService
    {
        private readonly IConfiguration _configuration = null;
        private string domain;
        public LinkService(IConfiguration configuration)
        {
            _configuration = configuration;
            domain = _configuration.GetSection("Application:AppDomain").Value;
        }
        public string GetTokenUrl(string route, string token, string userId)
        {
            string tokenUrl = domain + route + "?" + "uid={0}&token={1}";
            token = token.Replace(' ', '+');
            string result = string.Format(tokenUrl, userId ?? "", token);
            return result;
        }
        public string GetTokenUrl<T>(string route, string token, T user, bool isGetId, bool isGetUserName)
        {
            return null;
        }
    }
}
