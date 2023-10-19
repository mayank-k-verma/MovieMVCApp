using Microsoft.AspNetCore.Mvc;
using RestSharp;
using Newtonsoft.Json;
using MovieApp.Models;
using System.Net;

public class MovieController : Controller
{
    private const string apiKey = "6ee6bcf4";
    private const string omdbApiBaseUrl = "http://www.omdbapi.com/";

    public IActionResult ShowMovie(){
        return View();
    }

    public IActionResult GetMovieDetails(string title, int year)
    {
        RestClient client = new RestClient(omdbApiBaseUrl);
        RestRequest request = new RestRequest();

        // Set query parameters for the API request
        request.AddQueryParameter("apikey", apiKey);
        request.AddQueryParameter("t", title);
        request.AddQueryParameter("y", year);

        // Execute the API request
        RestResponse response = client.Execute(request);

        //api request is successful
        if (response.IsSuccessful){
            //if the api response is null
            if(response.Content!.Contains("Error"))
                return View("NotFound");

            Movie? movie = JsonConvert.DeserializeObject<Movie>(response.Content!);

            //Getting the image
            RestClient imageClient = new RestClient(movie!.Poster);
            RestRequest imageRequest = new RestRequest();
            RestResponse imageResponse = imageClient.Execute(imageRequest);

            //image request is successful
            if (imageResponse.IsSuccessful){
                byte[] imageData = imageResponse.RawBytes!;

                // Passing both movie details and image data to the view
                var movieWithImage = new MovieWithImage
                {
                    MovieData = movie,
                    ImageData = imageData,
                };

                return View("GetMovieDetails", movieWithImage);
            }
            return Content("Image Error!");
        }
        //api request failed
        return View("Error");
    }
}