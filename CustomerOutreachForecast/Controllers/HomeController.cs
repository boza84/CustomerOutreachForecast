using DAL.Models;
using Services.Interfaces;
using System;
using System.Web.Mvc;

namespace CustomerOutreachForecast.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOpenWeatherApiService _openWeatherApiService;
        private readonly IHomeControllerMapper _homeControllerMapper;

        public HomeController(IOpenWeatherApiService openWeatherApiService, IHomeControllerMapper homeControllerMapper)
        {
            _openWeatherApiService = openWeatherApiService;
            _homeControllerMapper = homeControllerMapper;
        }

        public ActionResult Index()
        {
            var viewModel = new CustomerForecastViewModel();

            try
            {
                var weatherData = _openWeatherApiService.GetWeatherData();
                if (weatherData.Code != 200)
                {
                    ViewBag.Message = "There was an error fetching error data, please try again later.";
                    return View(viewModel);
                }

                viewModel = _homeControllerMapper.MapWeatherDataToViewModel(weatherData);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            return View(viewModel);
        }
    }
}