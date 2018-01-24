using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Validation;
using System.Web.Mvc;
using WowForum.Models.APIReturnModels;
using WowForum.Models;

namespace WowForum.Controllers
{
    public class APIController : Controller
    {
        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri("https://us.api.battle.net");
            client.Authenticator = new SimpleAuthenticator("", "", "apikey", "2zfq64hb2s6hq76cbak7qgxdu3ad8eyp");

            var response = client.Execute<T>(request);

            return response.Data;
        }

        public CharacterInfoAPIModel GetCharacter(CharacterInformationModel info)
        {

            var request = new RestRequest(Method.GET);

            request.Resource = "/wow/character/{realm}/{name}?locale=en_US";
            request.AddParameter("name", info.name, ParameterType.UrlSegment);
            request.AddParameter("realm", info.realm, ParameterType.UrlSegment);


            return Execute<CharacterInfoAPIModel>(request);


        }

     
    }
}