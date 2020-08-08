using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dada.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.SearchRepositories;

namespace Dada.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchRepository _searchRepository;

        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }


        [HttpGet]
        public IActionResult Search()
        {
            string term = HttpContext.Request.Query["term"].ToString();

            var users = _searchRepository.GetMembers(term).Select(u => u.Username).ToList();
            var groups = _searchRepository.GetGroups(term).Select(g => g.Id + "*" + g.Name).ToList();
            var posts = _searchRepository.GetPostTitles(term).Select(p => p.Id + "*" + p.Title).ToList();

            Search search = new Search
            {
                Nicks = users,
                Clubs = groups,
                Titles = posts
            };


            return Ok(search);
        }
    }
}