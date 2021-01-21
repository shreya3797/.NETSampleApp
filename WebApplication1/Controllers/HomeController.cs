using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CarRacedb"].ConnectionString.ToString();
        SQLiteConnection connection;
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Racing()
        {
            ViewBag.Message = "Racing Details";
            List<RacingModel> racing = new List<RacingModel>();
            
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM RacingDetails", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                RacingModel racingModel = new RacingModel();
                racingModel.RacingID = (int)reader["RacingID"];
                racingModel.City = reader["City"].ToString();
                racingModel.TrackName = reader["TrackName"].ToString();
                racingModel.TrackLength = (int)reader["TrackLength"];
                racingModel.Category = reader["Category"].ToString();
                racingModel.CarName = reader["CarName"].ToString();                 
                racingModel.DriverName = reader["DriverName"].ToString();
                racingModel.TopSpeedDriven = reader["TopSpeedDriven"].ToString();
                racingModel.CompletionTime = reader["CompletionTime"].ToString();
                racing.Add(racingModel);
            }
            connection.Close();
            return View(racing);
        }
        public ActionResult Driver()
        {
            ViewBag.Message = "Driver Details";
            List<DriverModel> driver = new List<DriverModel>();
            
            connection = new SQLiteConnection(connectionString);
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM DriverInfo", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DriverModel driverModel = new DriverModel();
                int index = 0;
                driverModel.DriverID = reader.GetInt32(index);
                driverModel.DriverName = reader["DriverName"].ToString();
                driverModel.RacesParticipated = (int)reader["RacesParticipated"];
                driverModel.RacesWon = (int)reader["RacesWon"];
                driverModel.RacesLost = (int)reader["RacesLost"];
                driver.Add(driverModel);
            }
            connection.Close();                
            return View(driver);
        }
    }
}