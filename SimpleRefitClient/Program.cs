
using Microsoft.Extensions.Configuration;
using Refit;
using SimpleRefitClient;
using System;
using System.Linq;


IConfiguration config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

string urlBase = config.GetSection("API:UrlBase").Value;
Console.WriteLine($"Base URL: {urlBase}");

var JSONPlaceholder = RestService.For<IJSONPlaceholder>(urlBase);

var listPosts = await JSONPlaceholder.GetAllPosts();
Console.WriteLine($"Post id 1, title is from collection: {listPosts.FirstOrDefault(x=>x.id==1).title}");

var post = await JSONPlaceholder.GetPost(1);
Console.WriteLine($"Post id 1, title is:{post.title}");

